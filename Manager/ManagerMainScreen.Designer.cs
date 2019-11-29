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
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
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
            this.readingBtn.Click += new System.EventHandler(this.staffReportBtn_Click);
            // 
            // patientInformationBtn
            // 
            this.patientInformationBtn.Location = new System.Drawing.Point(319, 91);
            this.patientInformationBtn.Name = "patientInformationBtn";
            this.patientInformationBtn.Size = new System.Drawing.Size(84, 62);
            this.patientInformationBtn.TabIndex = 7;
            this.patientInformationBtn.Text = "Patient Information";
            this.patientInformationBtn.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(585, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 62);
            this.button3.TabIndex = 9;
            this.button3.Text = "Alarm Report";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(185, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 201);
            this.panel1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(475, 195);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ManagerMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 402);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.patientInformationBtn);
            this.Controls.Add(this.readingBtn);
            this.Controls.Add(this.staffScheduleBtn);
            this.Controls.Add(this.label1);
            this.Name = "ManagerMainScreen";
            this.Text = "Manager Main Screen";
            this.Load += new System.EventHandler(this.ManagerMainScreen_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button staffScheduleBtn;
        private System.Windows.Forms.Button readingBtn;
        private System.Windows.Forms.Button patientInformationBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}