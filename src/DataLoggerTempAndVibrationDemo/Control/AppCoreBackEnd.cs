using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt.Session;
using uPLibrary.Networking.M2Mqtt;
using System.Net.WebSockets;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt.Messages;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.Json;
using DataLoggerTempAndVibrationDemo.Model;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Remoting.Contexts;
using DataLoggerTempAndVibrationDemo.View;
using System.Runtime.InteropServices.ComTypes;
namespace DataLoggerTempAndVibrationDemo.Control
{

    public partial class AppCore
    {
        #region singleton
        private static AppCore _ins = new AppCore();
        public static AppCore Ins
        {
            get
            {
                return _ins == null ? _ins = new AppCore() : _ins;
            }
        }
        public AppCore()
        {
            var process = Process.GetProcessesByName($"{System.Reflection.Assembly.GetEntryAssembly().GetName().Name}");
            if (process.Length > 1)
            {
                process[1].Kill();
            }
        }
        #endregion

        #region main flow
        public async void Init()
        {
            ConnectMQTTSenSor();
            ReadDataMQTT();
            await CreateDatabase();
            StartShowUI();           
        }
        #endregion

        #region MQTT connect
        public MqttClient Client;
        public void ConnectMQTTSenSor()
        {
            try
            {
                Client = new MqttClient("dev.i-soft.com.vn");
                Client.Connect("sig200", "admin", "12345678");
                if (Client.IsConnected)
                {

                    
                    MessageBox.Show("Connect Successfull");                                        
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }

        }
        #endregion

        #region MQTTread data
        public void ReadDataMQTT()
        {
            try
            {
                if (Client != null && Client.IsConnected)
                {
                    Client.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;
                    string[] topics = new string[1];
                    topics[0] = "/sig200/data/port0";
                    byte[] msg = new byte[1];
                    msg[0] = MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE;
                    Client.Subscribe(topics, msg);
  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            try
            {
                string payload = System.Text.ASCIIEncoding.ASCII.GetString(e.Message);


                JsonDocument jsonDocument = JsonDocument.Parse(payload);
                JsonElement processDataIn = jsonDocument.RootElement.GetProperty("data").GetProperty("processDataIn");

                double value18 = processDataIn.GetProperty("18").GetDouble();
                double value19 = processDataIn.GetProperty("19").GetDouble();
                double value20 = processDataIn.GetProperty("20").GetDouble();
                double value21 = processDataIn.GetProperty("21").GetInt32();

                double x = value18;
                double y = value19;
                double z = value20;
                ////////////////////////
                double[] accX = { x };
                double[] accY = { y };
                double[] accZ = { z };
                ///////////////////////
                double vibrationEffectiveValue = VibrationShockCalculator.CalculateVibrationEffectiveValue(accX, accY, accZ);
                double shock = VibrationShockCalculator.CalculateShock(accX, accY, accZ);

                DeviceData deviceData = new DeviceData();
                {
                    deviceData.VibrValues = vibrationEffectiveValue;
                    deviceData.Shocks = shock;
                    deviceData.TempValues = value21;

                };
                UploadDataToDB(deviceData).Wait();

                Thread.Sleep(1000);
            }
            catch (JsonException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lost connection"+ex.Message);
                return;
            }
        }
        public class VibrationShockCalculator
        {
            public static double CalculateVibrationEffectiveValue(double[] accX, double[] accY, double[] accZ)
            {
                int n = accX.Length;
                double sum = 0.0;
                for (int i = 0; i < n; i++)
                {
                    double accMagnitude = Math.Sqrt(accX[i] * accX[i] + accY[i] * accY[i] + accZ[i] * accZ[i]);
                    sum += accMagnitude;
                }
                return sum / n;
            }

            public static double CalculateShock(double[] accX, double[] accY, double[] accZ)
            {
                double maxAcc = double.MinValue;
                int n = accX.Length;
                for (int i = 0; i < n; i++)
                {
                    double accMagnitude = Math.Sqrt(accX[i] * accX[i] + accY[i] * accY[i] + accZ[i] * accZ[i]);
                    if (accMagnitude > maxAcc)
                    {
                        maxAcc = accMagnitude;
                    }
                }
                return maxAcc;
            }
        }
        #endregion

        #region Create DataBase
        public static async Task CreateDatabase()
        {
            using (var dbcontext = new DataContext())
            {
                string databasename = dbcontext.Database.GetDbConnection().Database;// mydata

                MessageBox.Show("Tạo " + databasename);

                bool result = await dbcontext.Database.EnsureCreatedAsync();
                string resultstring = result ? "tạo  thành  công" : "đã có trước đó";
                MessageBox.Show($"CSDL {databasename} : {resultstring}");
            }
        }
        #endregion

        #region Find MinMaxData
        public static async Task FindMinMixData(string Positon) 
        {
            if (Positon == null)
            {
                using (var dbcontext = new DataContext())
                {
                    var MasterDatas = await (from p in dbcontext.masterDatas
                                             where (p.TempValue == double.MaxValue)
                                             select p).ToListAsync();
                }
            }
            else if(Positon == null) 
            {
                using (var dbcontext = new DataContext())
                {
                    var MasterDatas = await (from p in dbcontext.masterDatas
                                             where (p.TempValue == double.MinValue)
                                             select p).ToListAsync();
                }
            }
            else 
            {
                using (var dbcontext = new DataContext())
                {
                    var MasterDatas = await dbcontext.masterDatas.ToListAsync();
                }
            }
        }
        #endregion

        #region UploadtoDB
        public static async Task UploadDataToDB(DeviceData deviceData)
        {
            using (var dbcontext = new DataContext())
            {
                await dbcontext.masterDatas.AddAsync(new MasterData
                {
                    NameDevice = "Sig 200",
                    TempValue = deviceData.TempValues,
                    VibrValue = deviceData.VibrValues,
                    Updated = DateTime.Now,
                });
                int rows = await dbcontext.SaveChangesAsync();
            }
        }
        #endregion






























    }
}
