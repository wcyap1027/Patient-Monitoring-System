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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.centralStationbtn = new System.Windows.Forms.Button();
            this.patientButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // centralStationbtn
            // 
            this.centralStationbtn.AutoSize = true;
            this.centralStationbtn.BackColor = System.Drawing.Color.Aquamarine;
            this.centralStationbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.centralStationbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.centralStationbtn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centralStationbtn.Image = ((System.Drawing.Image)(resources.GetObject("centralStationbtn.Image")));
            this.centralStationbtn.Location = new System.Drawing.Point(88, 192);
            this.centralStationbtn.Name = "centralStationbtn";
            this.centralStationbtn.Size = new System.Drawing.Size(200, 120);
            this.centralStationbtn.TabIndex = 1;
            this.centralStationbtn.Text = "Central Station";
            this.centralStationbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.centralStationbtn.UseVisualStyleBackColor = false;
            this.centralStationbtn.Click += new System.EventHandler(this.centralStationbtn_Click);
            // 
            // patientButton
            // 
            this.patientButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patientButton.AutoSize = true;
            this.patientButton.BackColor = System.Drawing.Color.Yellow;
            this.patientButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.patientButton.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientButton.Image = ((System.Drawing.Image)(resources.GetObject("patientButton.Image")));
            this.patientButton.Location = new System.Drawing.Point(332, 192);
            this.patientButton.Name = "patientButton";
            this.patientButton.Size = new System.Drawing.Size(200, 120);
            this.patientButton.TabIndex = 2;
            this.patientButton.Text = "Patient";
            this.patientButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.patientButton.UseVisualStyleBackColor = false;
            this.patientButton.Click += new System.EventHandler(this.patientButton_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(562, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 120);
            this.button1.TabIndex = 3;
            this.button1.Text = "Bedside";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(842, 75);
            this.label1.TabIndex = 4;
            this.label1.Text = "Patient Monitoring System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(842, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.patientButton);
            this.Controls.Add(this.centralStationbtn);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button centralStationbtn;
        private System.Windows.Forms.Button patientButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

