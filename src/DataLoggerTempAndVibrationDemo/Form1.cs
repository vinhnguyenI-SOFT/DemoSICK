using DataLoggerTempAndVibrationDemo.Control;
using DataLoggerTempAndVibrationDemo.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Protocols.WSTrust;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using DataLoggerTempAndVibrationDemo.Model;

namespace DataLoggerTempAndVibrationDemo
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }
        #region Singleton parttern
        private static MainUI _Intance = null;
        public static MainUI Intance 
        {
            get 
            {
                if (_Intance == null) 
                {
                    _Intance = new MainUI();
                }
                return _Intance;
            }
        }
















        #endregion
        AppCore AppCore = new AppCore();
        private async void buttonDataLog_Click(object sender, EventArgs e)
        {
            FrmDataLog frmDataLog = new FrmDataLog();
            frmDataLog.ShowDialog();

        }

        private void MainUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private async void MainUI_Load(object sender, EventArgs e)
        {
 
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            FrmSetting frmSetting = new FrmSetting();
            frmSetting.ShowDialog();
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            FrmUser frmUser = new FrmUser();
            frmUser.ShowDialog();
        }

        private void solidGauge1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void AlarmTextBox_TextChanged(object sender, EventArgs e)
        {    

        }

        private void PauseSystem_Click(object sender, EventArgs e)
        {
        
        }

        private void ReStartButton_Click(object sender, EventArgs e)
        {
       
        }
    }
}
