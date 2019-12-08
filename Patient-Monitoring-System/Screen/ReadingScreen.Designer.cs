namespace Patient_Monitoring_System
{
    partial class ReadingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadingScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bPMax = new System.Windows.Forms.TextBox();
            this.bPMin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tempMax = new System.Windows.Forms.TextBox();
            this.tempMin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pulseMax = new System.Windows.Forms.TextBox();
            this.pulseMin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.breathMax = new System.Windows.Forms.TextBox();
            this.breathMin = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
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
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.bPMax);
            this.panel1.Controls.Add(this.bPMin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(51, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 150);
            this.panel1.TabIndex = 0;
            // 
            // bPMax
            // 
            this.bPMax.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPMax.Location = new System.Drawing.Point(125, 71);
            this.bPMax.Margin = new System.Windows.Forms.Padding(2);
            this.bPMax.Name = "bPMax";
            this.bPMax.Size = new System.Drawing.Size(145, 26);
            this.bPMax.TabIndex = 6;
            this.bPMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bPMax_KeyPress);
            // 
            // bPMin
            // 
            this.bPMin.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPMin.Location = new System.Drawing.Point(125, 41);
            this.bPMin.Margin = new System.Windows.Forms.Padding(2);
            this.bPMin.Name = "bPMin";
            this.bPMin.Size = new System.Drawing.Size(145, 26);
            this.bPMin.TabIndex = 5;
            this.bPMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bPMin_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Max Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Min Value:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Blood Pressure";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.tempMax);
            this.panel2.Controls.Add(this.tempMin);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(401, 29);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 150);
            this.panel2.TabIndex = 1;
            // 
            // tempMax
            // 
            this.tempMax.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempMax.Location = new System.Drawing.Point(125, 71);
            this.tempMax.Margin = new System.Windows.Forms.Padding(2);
            this.tempMax.Name = "tempMax";
            this.tempMax.Size = new System.Drawing.Size(144, 26);
            this.tempMax.TabIndex = 6;
            this.tempMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tempMax_KeyPress);
            // 
            // tempMin
            // 
            this.tempMin.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempMin.Location = new System.Drawing.Point(125, 41);
            this.tempMin.Margin = new System.Windows.Forms.Padding(2);
            this.tempMin.Name = "tempMin";
            this.tempMin.Size = new System.Drawing.Size(144, 26);
            this.tempMin.TabIndex = 5;
            this.tempMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tempMin_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Max Value:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 45);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Min Value:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Temperature";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pulseMax);
            this.panel3.Controls.Add(this.pulseMin);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(51, 196);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 150);
            this.panel3.TabIndex = 2;
            // 
            // pulseMax
            // 
            this.pulseMax.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulseMax.Location = new System.Drawing.Point(125, 71);
            this.pulseMax.Margin = new System.Windows.Forms.Padding(2);
            this.pulseMax.Name = "pulseMax";
            this.pulseMax.Size = new System.Drawing.Size(144, 26);
            this.pulseMax.TabIndex = 6;
            this.pulseMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pulseMax_KeyPress);
            // 
            // pulseMin
            // 
            this.pulseMin.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulseMin.Location = new System.Drawing.Point(125, 38);
            this.pulseMin.Margin = new System.Windows.Forms.Padding(2);
            this.pulseMin.Name = "pulseMin";
            this.pulseMin.Size = new System.Drawing.Size(144, 26);
            this.pulseMin.TabIndex = 5;
            this.pulseMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pulseMin_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "Max Value:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 42);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "Min Value:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Pulse";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.breathMax);
            this.panel4.Controls.Add(this.breathMin);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Location = new System.Drawing.Point(401, 196);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(299, 150);
            this.panel4.TabIndex = 3;
            // 
            // breathMax
            // 
            this.breathMax.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breathMax.Location = new System.Drawing.Point(124, 71);
            this.breathMax.Margin = new System.Windows.Forms.Padding(2);
            this.breathMax.Name = "breathMax";
            this.breathMax.Size = new System.Drawing.Size(145, 26);
            this.breathMax.TabIndex = 6;
            this.breathMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.breathMax_KeyPress);
            // 
            // breathMin
            // 
            this.breathMin.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breathMin.Location = new System.Drawing.Point(125, 38);
            this.breathMin.Margin = new System.Windows.Forms.Padding(2);
            this.breathMin.Name = "breathMin";
            this.breathMin.Size = new System.Drawing.Size(144, 26);
            this.breathMin.TabIndex = 5;
            this.breathMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.breathMin_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 75);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 18);
            this.label13.TabIndex = 4;
            this.label13.Text = "Max Value:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 42);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 18);
            this.label14.TabIndex = 3;
            this.label14.Text = "Min Value:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(11, 9);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(129, 25);
            this.label16.TabIndex = 0;
            this.label16.Text = "Breathing";
            // 
            // confirmBtnAlarm
            // 
            this.confirmBtnAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.confirmBtnAlarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmBtnAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmBtnAlarm.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtnAlarm.ForeColor = System.Drawing.Color.White;
            this.confirmBtnAlarm.Location = new System.Drawing.Point(284, 407);
            this.confirmBtnAlarm.Margin = new System.Windows.Forms.Padding(2);
            this.confirmBtnAlarm.Name = "confirmBtnAlarm";
            this.confirmBtnAlarm.Size = new System.Drawing.Size(96, 32);
            this.confirmBtnAlarm.TabIndex = 7;
            this.confirmBtnAlarm.Text = "Confirm";
            this.confirmBtnAlarm.UseVisualStyleBackColor = false;
            this.confirmBtnAlarm.Click += new System.EventHandler(this.confirmBtnAlarm_Click);
            // 
            // resetAlarmBtn
            // 
            this.resetAlarmBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.resetAlarmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetAlarmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetAlarmBtn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetAlarmBtn.ForeColor = System.Drawing.Color.White;
            this.resetAlarmBtn.Location = new System.Drawing.Point(425, 407);
            this.resetAlarmBtn.Margin = new System.Windows.Forms.Padding(2);
            this.resetAlarmBtn.Name = "resetAlarmBtn";
            this.resetAlarmBtn.Size = new System.Drawing.Size(96, 32);
            this.resetAlarmBtn.TabIndex = 8;
            this.resetAlarmBtn.Text = "Reset";
            this.resetAlarmBtn.UseVisualStyleBackColor = false;
            this.resetAlarmBtn.Click += new System.EventHandler(this.resetAlarmBtn_Click);
            // 
            // AlarmScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.resetAlarmBtn);
            this.Controls.Add(this.confirmBtnAlarm);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AlarmScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reading Screen";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tempMax;
        private System.Windows.Forms.TextBox tempMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox pulseMax;
        private System.Windows.Forms.TextBox pulseMin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox breathMax;
        private System.Windows.Forms.TextBox breathMin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button confirmBtnAlarm;
        private System.Windows.Forms.Button resetAlarmBtn;
    }
}