namespace Patient_Monitoring_System
{
    partial class AlarmScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bPAlarmType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bPMin = new System.Windows.Forms.TextBox();
            this.bPMax = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tempMax = new System.Windows.Forms.TextBox();
            this.tempMin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tempAlarmType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pulseMax = new System.Windows.Forms.TextBox();
            this.pulseMin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pulseAlarmType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.breathMax = new System.Windows.Forms.TextBox();
            this.breathMin = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.breathAlarmType = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.confirmBtnAlarm = new System.Windows.Forms.Button();
            this.resetAlarmBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.bPMax);
            this.panel1.Controls.Add(this.bPMin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bPAlarmType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 184);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Blood Pressure";
            // 
            // bPAlarmType
            // 
            this.bPAlarmType.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPAlarmType.FormattingEnabled = true;
            this.bPAlarmType.Location = new System.Drawing.Point(168, 52);
            this.bPAlarmType.Name = "bPAlarmType";
            this.bPAlarmType.Size = new System.Drawing.Size(206, 28);
            this.bPAlarmType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alarm Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Min Value:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Max Value:";
            // 
            // bPMin
            // 
            this.bPMin.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPMin.Location = new System.Drawing.Point(168, 92);
            this.bPMin.Name = "bPMin";
            this.bPMin.Size = new System.Drawing.Size(205, 30);
            this.bPMin.TabIndex = 5;
            // 
            // bPMax
            // 
            this.bPMax.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPMax.Location = new System.Drawing.Point(168, 131);
            this.bPMax.Name = "bPMax";
            this.bPMax.Size = new System.Drawing.Size(205, 30);
            this.bPMax.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tempMax);
            this.panel2.Controls.Add(this.tempMin);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tempAlarmType);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(417, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 184);
            this.panel2.TabIndex = 1;
            // 
            // tempMax
            // 
            this.tempMax.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempMax.Location = new System.Drawing.Point(168, 131);
            this.tempMax.Name = "tempMax";
            this.tempMax.Size = new System.Drawing.Size(205, 30);
            this.tempMax.TabIndex = 6;
            // 
            // tempMin
            // 
            this.tempMin.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempMin.Location = new System.Drawing.Point(168, 92);
            this.tempMin.Name = "tempMin";
            this.tempMin.Size = new System.Drawing.Size(205, 30);
            this.tempMin.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Max Value:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Min Value:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Alarm Type:";
            // 
            // tempAlarmType
            // 
            this.tempAlarmType.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempAlarmType.FormattingEnabled = true;
            this.tempAlarmType.Location = new System.Drawing.Point(168, 52);
            this.tempAlarmType.Name = "tempAlarmType";
            this.tempAlarmType.Size = new System.Drawing.Size(206, 28);
            this.tempAlarmType.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "Temperature";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pulseMax);
            this.panel3.Controls.Add(this.pulseMin);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.pulseAlarmType);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(12, 202);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(399, 184);
            this.panel3.TabIndex = 2;
            // 
            // pulseMax
            // 
            this.pulseMax.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulseMax.Location = new System.Drawing.Point(168, 131);
            this.pulseMax.Name = "pulseMax";
            this.pulseMax.Size = new System.Drawing.Size(205, 30);
            this.pulseMax.TabIndex = 6;
            // 
            // pulseMin
            // 
            this.pulseMin.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulseMin.Location = new System.Drawing.Point(168, 92);
            this.pulseMin.Name = "pulseMin";
            this.pulseMin.Size = new System.Drawing.Size(205, 30);
            this.pulseMin.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 23);
            this.label9.TabIndex = 4;
            this.label9.Text = "Max Value:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 23);
            this.label10.TabIndex = 3;
            this.label10.Text = "Min Value:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 23);
            this.label11.TabIndex = 2;
            this.label11.Text = "Alarm Type:";
            // 
            // pulseAlarmType
            // 
            this.pulseAlarmType.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulseAlarmType.FormattingEnabled = true;
            this.pulseAlarmType.Location = new System.Drawing.Point(168, 52);
            this.pulseAlarmType.Name = "pulseAlarmType";
            this.pulseAlarmType.Size = new System.Drawing.Size(206, 28);
            this.pulseAlarmType.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 31);
            this.label12.TabIndex = 0;
            this.label12.Text = "Pulse";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.breathMax);
            this.panel4.Controls.Add(this.breathMin);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.breathAlarmType);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Location = new System.Drawing.Point(417, 202);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(399, 184);
            this.panel4.TabIndex = 3;
            // 
            // breathMax
            // 
            this.breathMax.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breathMax.Location = new System.Drawing.Point(168, 131);
            this.breathMax.Name = "breathMax";
            this.breathMax.Size = new System.Drawing.Size(205, 30);
            this.breathMax.TabIndex = 6;
            // 
            // breathMin
            // 
            this.breathMin.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breathMin.Location = new System.Drawing.Point(168, 92);
            this.breathMin.Name = "breathMin";
            this.breathMin.Size = new System.Drawing.Size(205, 30);
            this.breathMin.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(32, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 23);
            this.label13.TabIndex = 4;
            this.label13.Text = "Max Value:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(32, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 23);
            this.label14.TabIndex = 3;
            this.label14.Text = "Min Value:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(20, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 23);
            this.label15.TabIndex = 2;
            this.label15.Text = "Alarm Type:";
            // 
            // breathAlarmType
            // 
            this.breathAlarmType.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breathAlarmType.FormattingEnabled = true;
            this.breathAlarmType.Location = new System.Drawing.Point(168, 52);
            this.breathAlarmType.Name = "breathAlarmType";
            this.breathAlarmType.Size = new System.Drawing.Size(206, 28);
            this.breathAlarmType.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(15, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(167, 31);
            this.label16.TabIndex = 0;
            this.label16.Text = "Breathing";
            // 
            // confirmBtnAlarm
            // 
            this.confirmBtnAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.confirmBtnAlarm.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtnAlarm.ForeColor = System.Drawing.Color.White;
            this.confirmBtnAlarm.Location = new System.Drawing.Point(283, 398);
            this.confirmBtnAlarm.Name = "confirmBtnAlarm";
            this.confirmBtnAlarm.Size = new System.Drawing.Size(128, 40);
            this.confirmBtnAlarm.TabIndex = 7;
            this.confirmBtnAlarm.Text = "Confirm";
            this.confirmBtnAlarm.UseVisualStyleBackColor = false;
            // 
            // resetAlarmBtn
            // 
            this.resetAlarmBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.resetAlarmBtn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetAlarmBtn.ForeColor = System.Drawing.Color.White;
            this.resetAlarmBtn.Location = new System.Drawing.Point(417, 398);
            this.resetAlarmBtn.Name = "resetAlarmBtn";
            this.resetAlarmBtn.Size = new System.Drawing.Size(128, 40);
            this.resetAlarmBtn.TabIndex = 8;
            this.resetAlarmBtn.Text = "Reset";
            this.resetAlarmBtn.UseVisualStyleBackColor = false;
            // 
            // AlarmScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.Controls.Add(this.resetAlarmBtn);
            this.Controls.Add(this.confirmBtnAlarm);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AlarmScreen";
            this.Text = "AlarmScreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox bPMax;
        private System.Windows.Forms.TextBox bPMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox bPAlarmType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tempMax;
        private System.Windows.Forms.TextBox tempMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox tempAlarmType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox pulseMax;
        private System.Windows.Forms.TextBox pulseMin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox pulseAlarmType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox breathMax;
        private System.Windows.Forms.TextBox breathMin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox breathAlarmType;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button confirmBtnAlarm;
        private System.Windows.Forms.Button resetAlarmBtn;
    }
}