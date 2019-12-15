namespace Manager
{
    partial class ManagerMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerMainScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.staffScheduleBtn = new System.Windows.Forms.Button();
            this.readingBtn = new System.Windows.Forms.Button();
            this.patientInformationBtn = new System.Windows.Forms.Button();
            this.alarmReportBtn = new System.Windows.Forms.Button();
            this.panelInformationPanel = new System.Windows.Forms.Panel();
            this.patientIDcomboBox = new System.Windows.Forms.ComboBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.patientIdLabel = new System.Windows.Forms.Label();
            this.patientGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.optional1ComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.patientIDcb = new System.Windows.Forms.ComboBox();
            this.readingGridView = new System.Windows.Forms.DataGridView();
            this.ResetB = new System.Windows.Forms.Button();
            this.ViewB = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.patientComboBox = new System.Windows.Forms.ComboBox();
            this.AlarmGridView = new System.Windows.Forms.DataGridView();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelInformationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientGridView)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readingGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmGridView)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Monitoring System";
            // 
            // staffScheduleBtn
            // 
            this.staffScheduleBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffScheduleBtn.Location = new System.Drawing.Point(532, 106);
            this.staffScheduleBtn.Name = "staffScheduleBtn";
            this.staffScheduleBtn.Size = new System.Drawing.Size(105, 54);
            this.staffScheduleBtn.TabIndex = 5;
            this.staffScheduleBtn.Text = "Staff Schedule";
            this.staffScheduleBtn.UseVisualStyleBackColor = true;
            this.staffScheduleBtn.Click += new System.EventHandler(this.staffScheduleBtn_Click);
            // 
            // readingBtn
            // 
            this.readingBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readingBtn.Location = new System.Drawing.Point(123, 106);
            this.readingBtn.Name = "readingBtn";
            this.readingBtn.Size = new System.Drawing.Size(102, 54);
            this.readingBtn.TabIndex = 6;
            this.readingBtn.Text = "Reading Report";
            this.readingBtn.UseVisualStyleBackColor = true;
            this.readingBtn.Click += new System.EventHandler(this.readingBtn_Click);
            // 
            // patientInformationBtn
            // 
            this.patientInformationBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientInformationBtn.Location = new System.Drawing.Point(12, 106);
            this.patientInformationBtn.Name = "patientInformationBtn";
            this.patientInformationBtn.Size = new System.Drawing.Size(105, 54);
            this.patientInformationBtn.TabIndex = 7;
            this.patientInformationBtn.Text = "Patient Information";
            this.patientInformationBtn.UseVisualStyleBackColor = true;
            this.patientInformationBtn.Click += new System.EventHandler(this.patientInformationBtn_Click);
            // 
            // alarmReportBtn
            // 
            this.alarmReportBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmReportBtn.Location = new System.Drawing.Point(234, 106);
            this.alarmReportBtn.Name = "alarmReportBtn";
            this.alarmReportBtn.Size = new System.Drawing.Size(105, 54);
            this.alarmReportBtn.TabIndex = 9;
            this.alarmReportBtn.Text = "Alarm Report";
            this.alarmReportBtn.UseVisualStyleBackColor = true;
            this.alarmReportBtn.Click += new System.EventHandler(this.alarmReportBtn_Click);
            // 
            // panelInformationPanel
            // 
            this.panelInformationPanel.Controls.Add(this.patientIDcomboBox);
            this.panelInformationPanel.Controls.Add(this.resetBtn);
            this.panelInformationPanel.Controls.Add(this.viewBtn);
            this.panelInformationPanel.Controls.Add(this.patientIdLabel);
            this.panelInformationPanel.Controls.Add(this.patientGridView);
            this.panelInformationPanel.Location = new System.Drawing.Point(12, 171);
            this.panelInformationPanel.Name = "panelInformationPanel";
            this.panelInformationPanel.Size = new System.Drawing.Size(95, 77);
            this.panelInformationPanel.TabIndex = 10;
            // 
            // patientIDcomboBox
            // 
            this.patientIDcomboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDcomboBox.FormattingEnabled = true;
            this.patientIDcomboBox.Location = new System.Drawing.Point(111, 8);
            this.patientIDcomboBox.Name = "patientIDcomboBox";
            this.patientIDcomboBox.Size = new System.Drawing.Size(121, 29);
            this.patientIDcomboBox.TabIndex = 5;
            this.patientIDcomboBox.SelectedIndexChanged += new System.EventHandler(this.patientIDcomboBox_SelectedIndexChanged);
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(111, 43);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 34);
            this.resetBtn.TabIndex = 4;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // viewBtn
            // 
            this.viewBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.Location = new System.Drawing.Point(30, 43);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(75, 34);
            this.viewBtn.TabIndex = 3;
            this.viewBtn.Text = "View";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // patientIdLabel
            // 
            this.patientIdLabel.AutoSize = true;
            this.patientIdLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIdLabel.Location = new System.Drawing.Point(16, 11);
            this.patientIdLabel.Name = "patientIdLabel";
            this.patientIdLabel.Size = new System.Drawing.Size(89, 21);
            this.patientIdLabel.TabIndex = 1;
            this.patientIdLabel.Text = "Patient ID :";
            // 
            // patientGridView
            // 
            this.patientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientGridView.Location = new System.Drawing.Point(3, 83);
            this.patientGridView.Name = "patientGridView";
            this.patientGridView.Size = new System.Drawing.Size(621, 272);
            this.patientGridView.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.optional1ComboBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.patientIDcb);
            this.panel3.Controls.Add(this.readingGridView);
            this.panel3.Controls.Add(this.ResetB);
            this.panel3.Controls.Add(this.ViewB);
            this.panel3.Location = new System.Drawing.Point(155, 182);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(141, 147);
            this.panel3.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Patient ID :";
            // 
            // optional1ComboBox
            // 
            this.optional1ComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optional1ComboBox.FormattingEnabled = true;
            this.optional1ComboBox.Location = new System.Drawing.Point(119, 42);
            this.optional1ComboBox.Name = "optional1ComboBox";
            this.optional1ComboBox.Size = new System.Drawing.Size(121, 29);
            this.optional1ComboBox.TabIndex = 12;
            this.optional1ComboBox.SelectedIndexChanged += new System.EventHandler(this.option1ComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Reading :";
            // 
            // patientIDcb
            // 
            this.patientIDcb.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDcb.FormattingEnabled = true;
            this.patientIDcb.Location = new System.Drawing.Point(119, 7);
            this.patientIDcb.Name = "patientIDcb";
            this.patientIDcb.Size = new System.Drawing.Size(121, 29);
            this.patientIDcb.TabIndex = 10;
            this.patientIDcb.SelectedIndexChanged += new System.EventHandler(this.patientIDcb_SelectedIndexChanged);
            // 
            // readingGridView
            // 
            this.readingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readingGridView.Location = new System.Drawing.Point(3, 95);
            this.readingGridView.Name = "readingGridView";
            this.readingGridView.Size = new System.Drawing.Size(622, 2743);
            this.readingGridView.TabIndex = 5;
            this.readingGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.readingGridView_CellContentClick);
            // 
            // ResetB
            // 
            this.ResetB.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetB.Location = new System.Drawing.Point(336, 43);
            this.ResetB.Name = "ResetB";
            this.ResetB.Size = new System.Drawing.Size(75, 35);
            this.ResetB.TabIndex = 7;
            this.ResetB.Text = "Reset";
            this.ResetB.UseVisualStyleBackColor = true;
            this.ResetB.Click += new System.EventHandler(this.button2_Click);
            // 
            // ViewB
            // 
            this.ViewB.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewB.Location = new System.Drawing.Point(255, 42);
            this.ViewB.Name = "ViewB";
            this.ViewB.Size = new System.Drawing.Size(75, 36);
            this.ViewB.TabIndex = 5;
            this.ViewB.Text = "View";
            this.ViewB.UseVisualStyleBackColor = true;
            this.ViewB.Click += new System.EventHandler(this.ViewB_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.patientComboBox);
            this.panel2.Controls.Add(this.AlarmGridView);
            this.panel2.Controls.Add(this.ResetButton);
            this.panel2.Controls.Add(this.ViewButton);
            this.panel2.Location = new System.Drawing.Point(337, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 340);
            this.panel2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Patient ID :";
            // 
            // patientComboBox
            // 
            this.patientComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientComboBox.FormattingEnabled = true;
            this.patientComboBox.Location = new System.Drawing.Point(109, 8);
            this.patientComboBox.Name = "patientComboBox";
            this.patientComboBox.Size = new System.Drawing.Size(121, 29);
            this.patientComboBox.TabIndex = 14;
            this.patientComboBox.SelectedIndexChanged += new System.EventHandler(this.patientComboBox_SelectedIndexChanged);
            // 
            // AlarmGridView
            // 
            this.AlarmGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlarmGridView.Location = new System.Drawing.Point(3, 83);
            this.AlarmGridView.Name = "AlarmGridView";
            this.AlarmGridView.Size = new System.Drawing.Size(622, 275);
            this.AlarmGridView.TabIndex = 5;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(181, 96);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 7;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(66, 96);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(75, 23);
            this.ViewButton.TabIndex = 5;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(641, 100);
            this.panel4.TabIndex = 13;
            // 
            // ManagerMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 541);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelInformationPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.alarmReportBtn);
            this.Controls.Add(this.patientInformationBtn);
            this.Controls.Add(this.readingBtn);
            this.Controls.Add(this.staffScheduleBtn);
            this.Name = "ManagerMainScreen";
            this.Text = "Manager Main Screen";
            this.Load += new System.EventHandler(this.ManagerMainScreen_Load);
            this.panelInformationPanel.ResumeLayout(false);
            this.panelInformationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readingGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button staffScheduleBtn;
        private System.Windows.Forms.Button readingBtn;
        private System.Windows.Forms.Button patientInformationBtn;
        private System.Windows.Forms.Button alarmReportBtn;
        private System.Windows.Forms.Panel panelInformationPanel;
        private System.Windows.Forms.DataGridView patientGridView;
        private System.Windows.Forms.Label patientIdLabel;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView AlarmGridView;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView readingGridView;
        private System.Windows.Forms.Button ResetB;
        private System.Windows.Forms.Button ViewB;
        private System.Windows.Forms.ComboBox patientIDcomboBox;
        private System.Windows.Forms.ComboBox patientComboBox;
        private System.Windows.Forms.ComboBox patientIDcb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox optional1ComboBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}