namespace Patient_Monitoring_System
{
    partial class MainScreen
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
            this.centralStationbtn = new System.Windows.Forms.Button();
            this.patientButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // centralStationbtn
            // 
            this.centralStationbtn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centralStationbtn.Location = new System.Drawing.Point(100, 74);
            this.centralStationbtn.Name = "centralStationbtn";
            this.centralStationbtn.Size = new System.Drawing.Size(129, 73);
            this.centralStationbtn.TabIndex = 1;
            this.centralStationbtn.Text = "Central Station";
            this.centralStationbtn.UseVisualStyleBackColor = true;
            this.centralStationbtn.Click += new System.EventHandler(this.centralStationbtn_Click);
            // 
            // patientButton
            // 
            this.patientButton.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientButton.Location = new System.Drawing.Point(275, 74);
            this.patientButton.Name = "patientButton";
            this.patientButton.Size = new System.Drawing.Size(129, 73);
            this.patientButton.TabIndex = 2;
            this.patientButton.Text = "Patient";
            this.patientButton.UseVisualStyleBackColor = true;
            this.patientButton.Click += new System.EventHandler(this.patientButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(455, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 73);
            this.button1.TabIndex = 3;
            this.button1.Text = "Bedside";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 367);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.patientButton);
            this.Controls.Add(this.centralStationbtn);
            this.Name = "MainScreen";
            this.Text = "Patient Monitoring System";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button centralStationbtn;
        private System.Windows.Forms.Button patientButton;
        private System.Windows.Forms.Button button1;
    }
}

