namespace Patient_Monitoring_System
{
    partial class PatientProfileScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.bedsideIdLabel = new System.Windows.Forms.Label();
            this.patientIdLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.alarmDetailsLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.patientNRICLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.patientAGELabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bedside ID:";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bedsideIdLabel);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 98);
            this.panel1.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 30);
            this.label9.TabIndex = 10;
            this.label9.Text = "Bedside Information";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bedsideIdLabel
            // 
            this.bedsideIdLabel.AutoSize = true;
            this.bedsideIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.bedsideIdLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedsideIdLabel.Location = new System.Drawing.Point(166, 51);
            this.bedsideIdLabel.Name = "bedsideIdLabel";
            this.bedsideIdLabel.Size = new System.Drawing.Size(28, 25);
            this.bedsideIdLabel.TabIndex = 2;
            this.bedsideIdLabel.Text = "--";
            // 
            // patientIdLabel
            // 
            this.patientIdLabel.AutoSize = true;
            this.patientIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.patientIdLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIdLabel.Location = new System.Drawing.Point(166, 58);
            this.patientIdLabel.Name = "patientIdLabel";
            this.patientIdLabel.Size = new System.Drawing.Size(28, 25);
            this.patientIdLabel.TabIndex = 2;
            this.patientIdLabel.Text = "--";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 561);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.Snow;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.alarmDetailsLabel);
            this.panel4.Location = new System.Drawing.Point(3, 339);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(578, 186);
            this.panel4.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 30);
            this.label11.TabIndex = 2;
            this.label11.Text = "Alarm Trigger";
            // 
            // alarmDetailsLabel
            // 
            this.alarmDetailsLabel.AutoSize = true;
            this.alarmDetailsLabel.BackColor = System.Drawing.Color.Transparent;
            this.alarmDetailsLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmDetailsLabel.Location = new System.Drawing.Point(30, 54);
            this.alarmDetailsLabel.Name = "alarmDetailsLabel";
            this.alarmDetailsLabel.Size = new System.Drawing.Size(134, 30);
            this.alarmDetailsLabel.TabIndex = 0;
            this.alarmDetailsLabel.Text = "alarmDetails";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.Snow;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.patientIdLabel);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.patientNRICLabel);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.patientAGELabel);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.patientNameLabel);
            this.panel3.Location = new System.Drawing.Point(3, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(578, 229);
            this.panel3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "Patient Details";
            // 
            // patientNRICLabel
            // 
            this.patientNRICLabel.AutoSize = true;
            this.patientNRICLabel.BackColor = System.Drawing.Color.Transparent;
            this.patientNRICLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNRICLabel.Location = new System.Drawing.Point(166, 148);
            this.patientNRICLabel.Name = "patientNRICLabel";
            this.patientNRICLabel.Size = new System.Drawing.Size(28, 25);
            this.patientNRICLabel.TabIndex = 8;
            this.patientNRICLabel.Text = "--";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 30);
            this.label6.TabIndex = 3;
            this.label6.Text = "NAME:";
            // 
            // patientAGELabel
            // 
            this.patientAGELabel.AutoSize = true;
            this.patientAGELabel.BackColor = System.Drawing.Color.Transparent;
            this.patientAGELabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientAGELabel.Location = new System.Drawing.Point(166, 186);
            this.patientAGELabel.Name = "patientAGELabel";
            this.patientAGELabel.Size = new System.Drawing.Size(28, 25);
            this.patientAGELabel.TabIndex = 7;
            this.patientAGELabel.Text = "--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(86, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 30);
            this.label8.TabIndex = 5;
            this.label8.Text = "AGE:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(76, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 30);
            this.label7.TabIndex = 4;
            this.label7.Text = "NRIC:";
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.patientNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameLabel.Location = new System.Drawing.Point(166, 99);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(28, 25);
            this.patientNameLabel.TabIndex = 6;
            this.patientNameLabel.Text = "--";
            // 
            // PatientProfileScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.panel2);
            this.Name = "PatientProfileScreen";
            this.Text = "Patient Profile";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label patientIdLabel;
        private System.Windows.Forms.Label bedsideIdLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label alarmDetailsLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label patientNRICLabel;
        private System.Windows.Forms.Label patientAGELabel;
    }
}