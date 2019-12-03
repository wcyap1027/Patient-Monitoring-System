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
            this.resetBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AlarmGridView = new System.Windows.Forms.DataGridView();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.AlarmIDcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.viewBtn = new System.Windows.Forms.Button();
            this.patientIDTextBox = new System.Windows.Forms.TextBox();
            this.patientIdLabel = new System.Windows.Forms.Label();
            this.patientGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.patientIDTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ResetB = new System.Windows.Forms.Button();
            this.ViewB = new System.Windows.Forms.Button();
            this.readingTypeTB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.patientidtextboxx = new System.Windows.Forms.TextBox();
            this.readingIDtb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientGridView)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.alarmReportBtn.Click += new System.EventHandler(this.alarmReportBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resetBtn);
            this.panel1.Controls.Add(this.viewBtn);
            this.panel1.Controls.Add(this.patientIDTextBox);
            this.panel1.Controls.Add(this.patientIdLabel);
            this.panel1.Controls.Add(this.patientGridView);
            this.panel1.Location = new System.Drawing.Point(26, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 201);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.readingIDtb);
            this.panel2.Controls.Add(this.patientidtextboxx);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.AlarmGridView);
            this.panel2.Controls.Add(this.ResetButton);
            this.panel2.Controls.Add(this.ViewButton);
            this.panel2.Controls.Add(this.AlarmIDcomboBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(81, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 276);
            this.panel2.TabIndex = 11;
            // 
            // AlarmGridView
            // 
            this.AlarmGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlarmGridView.Location = new System.Drawing.Point(11, 148);
            this.AlarmGridView.Name = "AlarmGridView";
            this.AlarmGridView.Size = new System.Drawing.Size(475, 132);
            this.AlarmGridView.TabIndex = 5;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(186, 119);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 7;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(50, 119);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(75, 23);
            this.ViewButton.TabIndex = 5;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            // 
            // AlarmIDcomboBox
            // 
            this.AlarmIDcomboBox.FormattingEnabled = true;
            this.AlarmIDcomboBox.Location = new System.Drawing.Point(154, 56);
            this.AlarmIDcomboBox.Name = "AlarmIDcomboBox";
            this.AlarmIDcomboBox.Size = new System.Drawing.Size(121, 21);
            this.AlarmIDcomboBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Alarm ID :";
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
            // patientIDTextBox
            // 
            this.patientIDTextBox.Location = new System.Drawing.Point(139, 9);
            this.patientIDTextBox.Name = "patientIDTextBox";
            this.patientIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.patientIDTextBox.TabIndex = 2;
            this.patientIDTextBox.TextChanged += new System.EventHandler(this.patientIDTextBox_TextChanged);
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
            // patientGridView
            // 
            this.patientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientGridView.Location = new System.Drawing.Point(0, 69);
            this.patientGridView.Name = "patientGridView";
            this.patientGridView.Size = new System.Drawing.Size(475, 132);
            this.patientGridView.TabIndex = 0;
            this.patientGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.patientIDTB);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.ResetB);
            this.panel3.Controls.Add(this.ViewB);
            this.panel3.Controls.Add(this.readingTypeTB);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(453, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 237);
            this.panel3.TabIndex = 12;
            // 
            // patientIDTB
            // 
            this.patientIDTB.Location = new System.Drawing.Point(136, 10);
            this.patientIDTB.Name = "patientIDTB";
            this.patientIDTB.Size = new System.Drawing.Size(100, 20);
            this.patientIDTB.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Patient ID :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(475, 132);
            this.dataGridView1.TabIndex = 5;
            // 
            // ResetB
            // 
            this.ResetB.Location = new System.Drawing.Point(182, 72);
            this.ResetB.Name = "ResetB";
            this.ResetB.Size = new System.Drawing.Size(75, 23);
            this.ResetB.TabIndex = 7;
            this.ResetB.Text = "Reset";
            this.ResetB.UseVisualStyleBackColor = true;
            this.ResetB.Click += new System.EventHandler(this.button2_Click);
            // 
            // ViewB
            // 
            this.ViewB.Location = new System.Drawing.Point(50, 72);
            this.ViewB.Name = "ViewB";
            this.ViewB.Size = new System.Drawing.Size(75, 23);
            this.ViewB.TabIndex = 5;
            this.ViewB.Text = "View";
            this.ViewB.UseVisualStyleBackColor = true;
            // 
            // readingTypeTB
            // 
            this.readingTypeTB.FormattingEnabled = true;
            this.readingTypeTB.Items.AddRange(new object[] {
            "Blood Pressure",
            "Breathing Rate",
            "Pulse Rate ",
            "Temperature"});
            this.readingTypeTB.Location = new System.Drawing.Point(136, 45);
            this.readingTypeTB.Name = "readingTypeTB";
            this.readingTypeTB.Size = new System.Drawing.Size(121, 21);
            this.readingTypeTB.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Reading Type :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Patient ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Alarm Date and Time :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Reading ID :";
            // 
            // patientidtextboxx
            // 
            this.patientidtextboxx.Location = new System.Drawing.Point(154, 11);
            this.patientidtextboxx.Name = "patientidtextboxx";
            this.patientidtextboxx.Size = new System.Drawing.Size(100, 20);
            this.patientidtextboxx.TabIndex = 10;
            // 
            // readingIDtb
            // 
            this.readingIDtb.Location = new System.Drawing.Point(154, 84);
            this.readingIDtb.Name = "readingIDtb";
            this.readingIDtb.Size = new System.Drawing.Size(100, 20);
            this.readingIDtb.TabIndex = 13;
            // 
            // ManagerMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 402);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView AlarmGridView;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.ComboBox AlarmIDcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox patientIDTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ResetB;
        private System.Windows.Forms.Button ViewB;
        private System.Windows.Forms.ComboBox readingTypeTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox readingIDtb;
        private System.Windows.Forms.TextBox patientidtextboxx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}