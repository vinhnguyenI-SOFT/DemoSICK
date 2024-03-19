namespace DataLoggerTempAndVibrationDemo.View
{
    partial class FrmDataLog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ButtonSendReport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eFDBDataLogger01DataSet1 = new DataLoggerTempAndVibrationDemo.EFDBDataLogger01DataSet1();
            this.masterDatasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDatasTableAdapter = new DataLoggerTempAndVibrationDemo.EFDBDataLogger01DataSet1TableAdapters.masterDatasTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDeviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vibrValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eFDBDataLogger01DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDatasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonSendReport
            // 
            this.ButtonSendReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSendReport.Location = new System.Drawing.Point(12, 12);
            this.ButtonSendReport.Name = "ButtonSendReport";
            this.ButtonSendReport.Size = new System.Drawing.Size(169, 36);
            this.ButtonSendReport.TabIndex = 1;
            this.ButtonSendReport.Text = "SEND REPORT";
            this.ButtonSendReport.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDeviceDataGridViewTextBoxColumn,
            this.tempValueDataGridViewTextBoxColumn,
            this.vibrValueDataGridViewTextBoxColumn,
            this.updatedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.masterDatasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1026, 472);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // eFDBDataLogger01DataSet1
            // 
            this.eFDBDataLogger01DataSet1.DataSetName = "EFDBDataLogger01DataSet1";
            this.eFDBDataLogger01DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masterDatasBindingSource
            // 
            this.masterDatasBindingSource.DataMember = "masterDatas";
            this.masterDatasBindingSource.DataSource = this.eFDBDataLogger01DataSet1;
            // 
            // masterDatasTableAdapter
            // 
            this.masterDatasTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDeviceDataGridViewTextBoxColumn
            // 
            this.nameDeviceDataGridViewTextBoxColumn.DataPropertyName = "NameDevice";
            this.nameDeviceDataGridViewTextBoxColumn.HeaderText = "NameDevice";
            this.nameDeviceDataGridViewTextBoxColumn.Name = "nameDeviceDataGridViewTextBoxColumn";
            // 
            // tempValueDataGridViewTextBoxColumn
            // 
            this.tempValueDataGridViewTextBoxColumn.DataPropertyName = "TempValue";
            this.tempValueDataGridViewTextBoxColumn.HeaderText = "TempValue";
            this.tempValueDataGridViewTextBoxColumn.Name = "tempValueDataGridViewTextBoxColumn";
            // 
            // vibrValueDataGridViewTextBoxColumn
            // 
            this.vibrValueDataGridViewTextBoxColumn.DataPropertyName = "VibrValue";
            this.vibrValueDataGridViewTextBoxColumn.HeaderText = "VibrValue";
            this.vibrValueDataGridViewTextBoxColumn.Name = "vibrValueDataGridViewTextBoxColumn";
            // 
            // updatedDataGridViewTextBoxColumn
            // 
            this.updatedDataGridViewTextBoxColumn.DataPropertyName = "Updated";
            this.updatedDataGridViewTextBoxColumn.HeaderText = "Updated";
            this.updatedDataGridViewTextBoxColumn.Name = "updatedDataGridViewTextBoxColumn";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(75, 23);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(74, 30);
            this.numericUpDown1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(81, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(346, 30);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(155, 23);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(74, 30);
            this.numericUpDown2.TabIndex = 6;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown3.Location = new System.Drawing.Point(235, 23);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(74, 30);
            this.numericUpDown3.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDown3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Location = new System.Drawing.Point(704, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 75);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "DATE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "TIME:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Location = new System.Drawing.Point(219, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 75);
            this.panel2.TabIndex = 10;
            // 
            // FrmDataLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 580);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonSendReport);
            this.Name = "FrmDataLog";
            this.Text = "FrmDataLog";
            this.Load += new System.EventHandler(this.FrmDataLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eFDBDataLogger01DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDatasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonSendReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EFDBDataLogger01DataSet1 eFDBDataLogger01DataSet1;
        private System.Windows.Forms.BindingSource masterDatasBindingSource;
        private EFDBDataLogger01DataSet1TableAdapters.masterDatasTableAdapter masterDatasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDeviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vibrValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
    }
}