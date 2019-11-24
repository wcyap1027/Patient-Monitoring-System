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
            this.label2 = new System.Windows.Forms.Label();
            this.patientNRICT = new System.Windows.Forms.TextBox();
            this.csvReportBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient NRIC :";
            // 
            // patientNRICT
            // 
            this.patientNRICT.Location = new System.Drawing.Point(240, 99);
            this.patientNRICT.Name = "patientNRICT";
            this.patientNRICT.Size = new System.Drawing.Size(189, 20);
            this.patientNRICT.TabIndex = 2;
            this.patientNRICT.TextChanged += new System.EventHandler(this.patientNRICT_TextChanged);
            // 
            // csvReportBtn
            // 
            this.csvReportBtn.Location = new System.Drawing.Point(217, 173);
            this.csvReportBtn.Name = "csvReportBtn";
            this.csvReportBtn.Size = new System.Drawing.Size(114, 39);
            this.csvReportBtn.TabIndex = 3;
            this.csvReportBtn.Text = "Download CSV File";
            this.csvReportBtn.UseVisualStyleBackColor = true;
            this.csvReportBtn.Click += new System.EventHandler(this.csvReportBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(389, 173);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(114, 39);
            this.resetBtn.TabIndex = 4;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // ManagerMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 272);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.csvReportBtn);
            this.Controls.Add(this.patientNRICT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManagerMainScreen";
            this.Text = "Manager Main Screen";
            this.Load += new System.EventHandler(this.ManagerMainScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox patientNRICT;
        private System.Windows.Forms.Button csvReportBtn;
        private System.Windows.Forms.Button resetBtn;
    }
}