namespace DataLoggerTempAndVibrationDemo
{
    partial class MainUI
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
            this.buttonDataLog = new System.Windows.Forms.Button();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PauseSystem = new System.Windows.Forms.Button();
            this.AlarmTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ReStartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDataLog
            // 
            this.buttonDataLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDataLog.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDataLog.Location = new System.Drawing.Point(940, 560);
            this.buttonDataLog.Name = "buttonDataLog";
            this.buttonDataLog.Size = new System.Drawing.Size(437, 47);
            this.buttonDataLog.TabIndex = 0;
            this.buttonDataLog.Text = "Data Log";
            this.buttonDataLog.UseVisualStyleBackColor = true;
            this.buttonDataLog.Click += new System.EventHandler(this.buttonDataLog_Click);
            // 
            // buttonSetting
            // 
            this.buttonSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetting.Location = new System.Drawing.Point(457, 560);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(477, 47);
            this.buttonSetting.TabIndex = 1;
            this.buttonSetting.Text = "Setting Device";
            this.buttonSetting.UseVisualStyleBackColor = true;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUser.Location = new System.Drawing.Point(12, 560);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(439, 47);
            this.buttonUser.TabIndex = 2;
            this.buttonUser.Text = "User";
            this.buttonUser.UseVisualStyleBackColor = true;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tempurature";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Acceleration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(451, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vibration";
            // 
            // PauseSystem
            // 
            this.PauseSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PauseSystem.Location = new System.Drawing.Point(940, 507);
            this.PauseSystem.Name = "PauseSystem";
            this.PauseSystem.Size = new System.Drawing.Size(439, 47);
            this.PauseSystem.TabIndex = 9;
            this.PauseSystem.Text = "Pause System";
            this.PauseSystem.UseVisualStyleBackColor = true;
            this.PauseSystem.Click += new System.EventHandler(this.PauseSystem_Click);
            // 
            // AlarmTextBox
            // 
            this.AlarmTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.AlarmTextBox.Location = new System.Drawing.Point(12, 321);
            this.AlarmTextBox.Multiline = true;
            this.AlarmTextBox.Name = "AlarmTextBox";
            this.AlarmTextBox.Size = new System.Drawing.Size(328, 222);
            this.AlarmTextBox.TabIndex = 10;
            this.AlarmTextBox.TextChanged += new System.EventHandler(this.AlarmTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Alarm log:";
            // 
            // ReStartButton
            // 
            this.ReStartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReStartButton.Location = new System.Drawing.Point(456, 507);
            this.ReStartButton.Name = "ReStartButton";
            this.ReStartButton.Size = new System.Drawing.Size(478, 47);
            this.ReStartButton.TabIndex = 12;
            this.ReStartButton.Text = "Reconnect System";
            this.ReStartButton.UseVisualStyleBackColor = true;
            this.ReStartButton.Click += new System.EventHandler(this.ReStartButton_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1389, 619);
            this.Controls.Add(this.ReStartButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AlarmTextBox);
            this.Controls.Add(this.PauseSystem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUser);
            this.Controls.Add(this.buttonSetting);
            this.Controls.Add(this.buttonDataLog);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main UI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainUI_FormClosed);
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDataLog;
        private System.Windows.Forms.Button buttonSetting;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PauseSystem;
        private System.Windows.Forms.TextBox AlarmTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ReStartButton;
    }
}

