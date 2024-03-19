using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLoggerTempAndVibrationDemo.View
{
    public partial class FrmDataLog : Form
    {
        private System.Windows.Forms.Timer delayTimer;
        public FrmDataLog()
        {
            InitializeComponent();
        }

        private void FrmDataLog_Load(object sender, EventArgs e)
        {
           
            delayTimer = new System.Windows.Forms.Timer();
            delayTimer.Interval = 100; 
            delayTimer.Tick += DataTimer_Tick;
            delayTimer.Start();
            

        }
        private void DataTimer_Tick(object sender, EventArgs e)
        {
            UpdateDataGridView(); 
        }
        private void UpdateDataGridView()
        {
            this.masterDatasTableAdapter.Fill(this.eFDBDataLogger01DataSet1.masterDatas);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
