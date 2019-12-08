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
            this.bedsideBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logOutbtn = new System.Windows.Forms.Button();
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
            this.centralStationbtn.Location = new System.Drawing.Point(66, 156);
            this.centralStationbtn.Margin = new System.Windows.Forms.Padding(2);
            this.centralStationbtn.Name = "centralStationbtn";
            this.centralStationbtn.Size = new System.Drawing.Size(168, 108);
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
            this.patientButton.Location = new System.Drawing.Point(249, 156);
            this.patientButton.Margin = new System.Windows.Forms.Padding(2);
            this.patientButton.Name = "patientButton";
            this.patientButton.Size = new System.Drawing.Size(150, 108);
            this.patientButton.TabIndex = 2;
            this.patientButton.Text = "Patient";
            this.patientButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.patientButton.UseVisualStyleBackColor = false;
            this.patientButton.Click += new System.EventHandler(this.patientButton_Click);
            // 
            // bedsideBtn
            // 
            this.bedsideBtn.AutoSize = true;
            this.bedsideBtn.BackColor = System.Drawing.Color.Cyan;
            this.bedsideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bedsideBtn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedsideBtn.Image = ((System.Drawing.Image)(resources.GetObject("bedsideBtn.Image")));
            this.bedsideBtn.Location = new System.Drawing.Point(422, 156);
            this.bedsideBtn.Margin = new System.Windows.Forms.Padding(2);
            this.bedsideBtn.Name = "bedsideBtn";
            this.bedsideBtn.Size = new System.Drawing.Size(150, 108);
            this.bedsideBtn.TabIndex = 3;
            this.bedsideBtn.Text = "Bedside";
            this.bedsideBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bedsideBtn.UseVisualStyleBackColor = false;
            this.bedsideBtn.Click += new System.EventHandler(this.bedsideBtn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(632, 61);
            this.label1.TabIndex = 4;
            this.label1.Text = "Patient Monitoring System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logOutbtn
            // 
            this.logOutbtn.BackColor = System.Drawing.Color.Lime;
            this.logOutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logOutbtn.Image = ((System.Drawing.Image)(resources.GetObject("logOutbtn.Image")));
            this.logOutbtn.Location = new System.Drawing.Point(524, 308);
            this.logOutbtn.Name = "logOutbtn";
            this.logOutbtn.Size = new System.Drawing.Size(86, 48);
            this.logOutbtn.TabIndex = 5;
            this.logOutbtn.Text = "LogOut";
            this.logOutbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logOutbtn.UseVisualStyleBackColor = false;
            this.logOutbtn.Click += new System.EventHandler(this.logOutbtn_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 368);
            this.Controls.Add(this.logOutbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bedsideBtn);
            this.Controls.Add(this.patientButton);
            this.Controls.Add(this.centralStationbtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button centralStationbtn;
        private System.Windows.Forms.Button patientButton;
        private System.Windows.Forms.Button bedsideBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logOutbtn;
    }
}

