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
            this.patientIDcomboBox = new System.Windows.Forms.ComboBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.patientIdLabel = new System.Windows.Forms.Label();
            this.patientGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.patientComboBox = new System.Windows.Forms.ComboBox();
            this.readingIDtb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AlarmGridView = new System.Windows.Forms.DataGridView();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.AlarmIDcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.option1ComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.patientIDcb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.readingGridView = new System.Windows.Forms.DataGridView();
            this.ResetB = new System.Windows.Forms.Button();
            this.ViewB = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmGridView)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readingGridView)).BeginInit();
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
            this.readingBtn.Location = new System.Drawing.Point(451, 91);
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
            this.panel1.Controls.Add(this.patientIDcomboBox);
            this.panel1.Controls.Add(this.resetBtn);
            this.panel1.Controls.Add(this.viewBtn);
            this.panel1.Controls.Add(this.patientIdLabel);
            this.panel1.Controls.Add(this.patientGridView);
            this.panel1.Location = new System.Drawing.Point(27, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 201);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // patientIDcomboBox
            // 
            this.patientIDcomboBox.FormattingEnabled = true;
            this.patientIDcomboBox.Location = new System.Drawing.Point(140, 9);
            this.patientIDcomboBox.Name = "patientIDcomboBox";
            this.patientIDcomboBox.Size = new System.Drawing.Size(121, 21);
            this.patientIDcomboBox.TabIndex = 5;
            this.patientIDcomboBox.SelectedIndexChanged += new System.EventHandler(this.patientIDcomboBox_SelectedIndexChanged);
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
            this.patientGridView.Size = new System.Drawing.Size(585, 132);
            this.patientGridView.TabIndex = 0;
            this.patientGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.patientComboBox);
            this.panel2.Controls.Add(this.readingIDtb);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.AlarmGridView);
            this.panel2.Controls.Add(this.ResetButton);
            this.panel2.Controls.Add(this.ViewButton);
            this.panel2.Controls.Add(this.AlarmIDcomboBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(533, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 276);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // patientComboBox
            // 
            this.patientComboBox.FormattingEnabled = true;
            this.patientComboBox.Location = new System.Drawing.Point(154, 8);
            this.patientComboBox.Name = "patientComboBox";
            this.patientComboBox.Size = new System.Drawing.Size(121, 21);
            this.patientComboBox.TabIndex = 14;
            // 
            // readingIDtb
            // 
            this.readingIDtb.Location = new System.Drawing.Point(154, 88);
            this.readingIDtb.Name = "readingIDtb";
            this.readingIDtb.Size = new System.Drawing.Size(100, 20);
            this.readingIDtb.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Reading ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Alarm Date and Time :";
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
            this.AlarmIDcomboBox.Location = new System.Drawing.Point(154, 61);
            this.AlarmIDcomboBox.Name = "AlarmIDcomboBox";
            this.AlarmIDcomboBox.Size = new System.Drawing.Size(121, 21);
            this.AlarmIDcomboBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Alarm ID :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.option1ComboBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.patientIDcb);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.readingGridView);
            this.panel3.Controls.Add(this.ResetB);
            this.panel3.Controls.Add(this.ViewB);
            this.panel3.Location = new System.Drawing.Point(186, 169);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 347);
            this.panel3.TabIndex = 12;
            // 
            // option1ComboBox
            // 
            this.option1ComboBox.FormattingEnabled = true;
            this.option1ComboBox.Items.AddRange(new object[] {
            "Blood Pressure",
            "Breathing Rate",
            "Pulse Rate ",
            "Temperature"});
            this.option1ComboBox.Location = new System.Drawing.Point(136, 44);
            this.option1ComboBox.Name = "option1ComboBox";
            this.option1ComboBox.Size = new System.Drawing.Size(121, 21);
            this.option1ComboBox.TabIndex = 12;
            this.option1ComboBox.SelectedIndexChanged += new System.EventHandler(this.option1ComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Optional :";
            // 
            // patientIDcb
            // 
            this.patientIDcb.FormattingEnabled = true;
            this.patientIDcb.Location = new System.Drawing.Point(136, 10);
            this.patientIDcb.Name = "patientIDcb";
            this.patientIDcb.Size = new System.Drawing.Size(121, 21);
            this.patientIDcb.TabIndex = 10;
            this.patientIDcb.SelectedIndexChanged += new System.EventHandler(this.patientIDcb_SelectedIndexChanged);
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
            // readingGridView
            // 
            this.readingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readingGridView.Location = new System.Drawing.Point(7, 132);
            this.readingGridView.Name = "readingGridView";
            this.readingGridView.Size = new System.Drawing.Size(475, 215);
            this.readingGridView.TabIndex = 5;
            this.readingGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.readingGridView_CellContentClick);
            // 
            // ResetB
            // 
            this.ResetB.Location = new System.Drawing.Point(182, 83);
            this.ResetB.Name = "ResetB";
            this.ResetB.Size = new System.Drawing.Size(75, 23);
            this.ResetB.TabIndex = 7;
            this.ResetB.Text = "Reset";
            this.ResetB.UseVisualStyleBackColor = true;
            this.ResetB.Click += new System.EventHandler(this.button2_Click);
            // 
            // ViewB
            // 
            this.ViewB.Location = new System.Drawing.Point(63, 83);
            this.ViewB.Name = "ViewB";
            this.ViewB.Size = new System.Drawing.Size(75, 23);
            this.ViewB.TabIndex = 5;
            this.ViewB.Text = "View";
            this.ViewB.UseVisualStyleBackColor = true;
            this.ViewB.Click += new System.EventHandler(this.ViewB_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(154, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // ManagerMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 402);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readingGridView)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView readingGridView;
        private System.Windows.Forms.Button ResetB;
        private System.Windows.Forms.Button ViewB;
        private System.Windows.Forms.TextBox readingIDtb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox patientIDcomboBox;
        private System.Windows.Forms.ComboBox patientComboBox;
        private System.Windows.Forms.ComboBox patientIDcb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox option1ComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}