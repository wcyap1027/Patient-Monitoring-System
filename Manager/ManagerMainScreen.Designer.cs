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
            this.label1 = new System.Windows.Forms.Label();
            this.staffScheduleBtn = new System.Windows.Forms.Button();
            this.readingBtn = new System.Windows.Forms.Button();
            this.patientInformationBtn = new System.Windows.Forms.Button();
            this.alarmReportBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.patientGridView = new System.Windows.Forms.DataGridView();
            this.patientIdLabel = new System.Windows.Forms.Label();
            this.patientIDTextBox = new System.Windows.Forms.TextBox();
            this.viewBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Monitoring System";
            // 
            // staffScheduleBtn
            // 
            this.staffScheduleBtn.Location = new System.Drawing.Point(186, 91);
            this.staffScheduleBtn.Name = "staffScheduleBtn";
            this.staffScheduleBtn.Size = new System.Drawing.Size(84, 62);
            this.staffScheduleBtn.TabIndex = 5;
            this.staffScheduleBtn.Text = "Staff Schedule";
            this.staffScheduleBtn.UseVisualStyleBackColor = true;
            this.staffScheduleBtn.Click += new System.EventHandler(this.staffScheduleBtn_Click);
            // 
            // readingBtn
            // 
            this.readingBtn.Location = new System.Drawing.Point(449, 91);
            this.readingBtn.Name = "readingBtn";
            this.readingBtn.Size = new System.Drawing.Size(84, 62);
            this.readingBtn.TabIndex = 6;
            this.readingBtn.Text = "Reading Report";
            this.readingBtn.UseVisualStyleBackColor = true;
            this.readingBtn.Click += new System.EventHandler(this.readingBtn_Click);
            // 
            // patientInformationBtn
            // 
            this.patientInformationBtn.Location = new System.Drawing.Point(319, 91);
            this.patientInformationBtn.Name = "patientInformationBtn";
            this.patientInformationBtn.Size = new System.Drawing.Size(84, 62);
            this.patientInformationBtn.TabIndex = 7;
            this.patientInformationBtn.Text = "Patient Information";
            this.patientInformationBtn.UseVisualStyleBackColor = true;
            this.patientInformationBtn.Click += new System.EventHandler(this.patientInformationBtn_Click);
            // 
            // alarmReportBtn
            // 
            this.alarmReportBtn.Location = new System.Drawing.Point(585, 91);
            this.alarmReportBtn.Name = "alarmReportBtn";
            this.alarmReportBtn.Size = new System.Drawing.Size(84, 62);
            this.alarmReportBtn.TabIndex = 9;
            this.alarmReportBtn.Text = "Alarm Report";
            this.alarmReportBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resetBtn);
            this.panel1.Controls.Add(this.viewBtn);
            this.panel1.Controls.Add(this.patientIDTextBox);
            this.panel1.Controls.Add(this.patientIdLabel);
            this.panel1.Controls.Add(this.patientGridView);
            this.panel1.Location = new System.Drawing.Point(185, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 201);
            this.panel1.TabIndex = 10;
            // 
            // patientGridView
            // 
            this.patientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientGridView.Location = new System.Drawing.Point(0, 69);
            this.patientGridView.Name = "patientGridView";
            this.patientGridView.Size = new System.Drawing.Size(475, 132);
            this.patientGridView.TabIndex = 0;
            this.patientGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // patientIdLabel
            // 
            this.patientIdLabel.AutoSize = true;
            this.patientIdLabel.Location = new System.Drawing.Point(73, 12);
            this.patientIdLabel.Name = "patientIdLabel";
            this.patientIdLabel.Size = new System.Drawing.Size(60, 13);
            this.patientIdLabel.TabIndex = 1;
            this.patientIdLabel.Text = "Patient ID :";
            // 
            // patientIDTextBox
            // 
            this.patientIDTextBox.Location = new System.Drawing.Point(139, 9);
            this.patientIDTextBox.Name = "patientIDTextBox";
            this.patientIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.patientIDTextBox.TabIndex = 2;
            this.patientIDTextBox.TextChanged += new System.EventHandler(this.patientIDTextBox_TextChanged);
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(96, 35);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(75, 23);
            this.viewBtn.TabIndex = 3;
            this.viewBtn.Text = "View";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(189, 35);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 4;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // ManagerMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 402);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.alarmReportBtn);
            this.Controls.Add(this.patientInformationBtn);
            this.Controls.Add(this.readingBtn);
            this.Controls.Add(this.staffScheduleBtn);
            this.Controls.Add(this.label1);
            this.Name = "ManagerMainScreen";
            this.Text = "Manager Main Screen";
            this.Load += new System.EventHandler(this.ManagerMainScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button staffScheduleBtn;
        private System.Windows.Forms.Button readingBtn;
        private System.Windows.Forms.Button patientInformationBtn;
        private System.Windows.Forms.Button alarmReportBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView patientGridView;
        private System.Windows.Forms.TextBox patientIDTextBox;
        private System.Windows.Forms.Label patientIdLabel;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button viewBtn;
    }
}