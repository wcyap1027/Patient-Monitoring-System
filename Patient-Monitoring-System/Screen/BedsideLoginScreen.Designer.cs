namespace BedsideSystem
{
    partial class BedsideLoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BedsideLoginScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.proceedAssignBtn = new System.Windows.Forms.Button();
            this.patientIDAssignComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bedsideIdAssignComboBox = new System.Windows.Forms.ComboBox();
            this.assignPanel = new System.Windows.Forms.Panel();
            this.backAssignBtn = new System.Windows.Forms.Button();
            this.showMenuPanel = new System.Windows.Forms.Panel();
            this.assignBtn = new System.Windows.Forms.Button();
            this.existingBtn = new System.Windows.Forms.Button();
            this.existingPanel = new System.Windows.Forms.Panel();
            this.patientIdTextBox = new System.Windows.Forms.TextBox();
            this.backExistingBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.continueExistingBtn = new System.Windows.Forms.Button();
            this.bedsideIdExistingComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.assignPanel.SuspendLayout();
            this.showMenuPanel.SuspendLayout();
            this.existingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 275);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(423, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 55);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bedside Monitoring System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Patient ID:";
            // 
            // proceedAssignBtn
            // 
            this.proceedAssignBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.proceedAssignBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proceedAssignBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proceedAssignBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedAssignBtn.Location = new System.Drawing.Point(175, 112);
            this.proceedAssignBtn.Name = "proceedAssignBtn";
            this.proceedAssignBtn.Size = new System.Drawing.Size(118, 42);
            this.proceedAssignBtn.TabIndex = 6;
            this.proceedAssignBtn.Text = "Proceed";
            this.proceedAssignBtn.UseVisualStyleBackColor = false;
            this.proceedAssignBtn.Click += new System.EventHandler(this.proceedAssignBtn_Click);
            // 
            // patientIDAssignComboBox
            // 
            this.patientIDAssignComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDAssignComboBox.FormattingEnabled = true;
            this.patientIDAssignComboBox.Location = new System.Drawing.Point(104, 52);
            this.patientIDAssignComboBox.Name = "patientIDAssignComboBox";
            this.patientIDAssignComboBox.Size = new System.Drawing.Size(168, 29);
            this.patientIDAssignComboBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bedside ID:";
            // 
            // bedsideIdAssignComboBox
            // 
            this.bedsideIdAssignComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedsideIdAssignComboBox.FormattingEnabled = true;
            this.bedsideIdAssignComboBox.Location = new System.Drawing.Point(104, 13);
            this.bedsideIdAssignComboBox.Name = "bedsideIdAssignComboBox";
            this.bedsideIdAssignComboBox.Size = new System.Drawing.Size(168, 29);
            this.bedsideIdAssignComboBox.TabIndex = 9;
            // 
            // assignPanel
            // 
            this.assignPanel.Controls.Add(this.backAssignBtn);
            this.assignPanel.Controls.Add(this.label3);
            this.assignPanel.Controls.Add(this.proceedAssignBtn);
            this.assignPanel.Controls.Add(this.patientIDAssignComboBox);
            this.assignPanel.Controls.Add(this.bedsideIdAssignComboBox);
            this.assignPanel.Controls.Add(this.label2);
            this.assignPanel.Location = new System.Drawing.Point(774, 153);
            this.assignPanel.Name = "assignPanel";
            this.assignPanel.Size = new System.Drawing.Size(159, 174);
            this.assignPanel.TabIndex = 10;
            this.assignPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.assignPanel_Paint);
            // 
            // backAssignBtn
            // 
            this.backAssignBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.backAssignBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backAssignBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backAssignBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backAssignBtn.Location = new System.Drawing.Point(30, 112);
            this.backAssignBtn.Name = "backAssignBtn";
            this.backAssignBtn.Size = new System.Drawing.Size(118, 42);
            this.backAssignBtn.TabIndex = 10;
            this.backAssignBtn.Text = "Back";
            this.backAssignBtn.UseVisualStyleBackColor = false;
            this.backAssignBtn.Click += new System.EventHandler(this.backAssignBtn_Click);
            // 
            // showMenuPanel
            // 
            this.showMenuPanel.Controls.Add(this.assignBtn);
            this.showMenuPanel.Controls.Add(this.existingBtn);
            this.showMenuPanel.Location = new System.Drawing.Point(774, 76);
            this.showMenuPanel.Name = "showMenuPanel";
            this.showMenuPanel.Size = new System.Drawing.Size(61, 55);
            this.showMenuPanel.TabIndex = 11;
            // 
            // assignBtn
            // 
            this.assignBtn.AutoSize = true;
            this.assignBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.assignBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.assignBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assignBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignBtn.Image = ((System.Drawing.Image)(resources.GetObject("assignBtn.Image")));
            this.assignBtn.Location = new System.Drawing.Point(178, 39);
            this.assignBtn.Name = "assignBtn";
            this.assignBtn.Size = new System.Drawing.Size(118, 116);
            this.assignBtn.TabIndex = 12;
            this.assignBtn.Text = "Assign";
            this.assignBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.assignBtn.UseVisualStyleBackColor = false;
            this.assignBtn.Click += new System.EventHandler(this.assignBtn_Click);
            // 
            // existingBtn
            // 
            this.existingBtn.AutoSize = true;
            this.existingBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.existingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.existingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.existingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existingBtn.Image = ((System.Drawing.Image)(resources.GetObject("existingBtn.Image")));
            this.existingBtn.Location = new System.Drawing.Point(32, 39);
            this.existingBtn.Name = "existingBtn";
            this.existingBtn.Size = new System.Drawing.Size(118, 116);
            this.existingBtn.TabIndex = 11;
            this.existingBtn.Text = "Existing";
            this.existingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.existingBtn.UseVisualStyleBackColor = false;
            this.existingBtn.Click += new System.EventHandler(this.existingBtn_Click);
            // 
            // existingPanel
            // 
            this.existingPanel.Controls.Add(this.patientIdTextBox);
            this.existingPanel.Controls.Add(this.backExistingBtn);
            this.existingPanel.Controls.Add(this.label4);
            this.existingPanel.Controls.Add(this.continueExistingBtn);
            this.existingPanel.Controls.Add(this.bedsideIdExistingComboBox);
            this.existingPanel.Controls.Add(this.label5);
            this.existingPanel.Location = new System.Drawing.Point(423, 76);
            this.existingPanel.Name = "existingPanel";
            this.existingPanel.Size = new System.Drawing.Size(304, 178);
            this.existingPanel.TabIndex = 12;
            // 
            // patientIdTextBox
            // 
            this.patientIdTextBox.Enabled = false;
            this.patientIdTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIdTextBox.Location = new System.Drawing.Point(104, 55);
            this.patientIdTextBox.Name = "patientIdTextBox";
            this.patientIdTextBox.Size = new System.Drawing.Size(168, 29);
            this.patientIdTextBox.TabIndex = 11;
            // 
            // backExistingBtn
            // 
            this.backExistingBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.backExistingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backExistingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backExistingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backExistingBtn.Location = new System.Drawing.Point(30, 112);
            this.backExistingBtn.Name = "backExistingBtn";
            this.backExistingBtn.Size = new System.Drawing.Size(118, 42);
            this.backExistingBtn.TabIndex = 10;
            this.backExistingBtn.Text = "Back";
            this.backExistingBtn.UseVisualStyleBackColor = false;
            this.backExistingBtn.Click += new System.EventHandler(this.backExistingBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bedside ID:";
            // 
            // continueExistingBtn
            // 
            this.continueExistingBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.continueExistingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.continueExistingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueExistingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueExistingBtn.Location = new System.Drawing.Point(175, 112);
            this.continueExistingBtn.Name = "continueExistingBtn";
            this.continueExistingBtn.Size = new System.Drawing.Size(118, 42);
            this.continueExistingBtn.TabIndex = 6;
            this.continueExistingBtn.Text = "Continue";
            this.continueExistingBtn.UseVisualStyleBackColor = false;
            this.continueExistingBtn.Click += new System.EventHandler(this.continueExistingBtn_Click);
            // 
            // bedsideIdExistingComboBox
            // 
            this.bedsideIdExistingComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedsideIdExistingComboBox.FormattingEnabled = true;
            this.bedsideIdExistingComboBox.Location = new System.Drawing.Point(104, 13);
            this.bedsideIdExistingComboBox.Name = "bedsideIdExistingComboBox";
            this.bedsideIdExistingComboBox.Size = new System.Drawing.Size(168, 29);
            this.bedsideIdExistingComboBox.TabIndex = 9;
            this.bedsideIdExistingComboBox.SelectedIndexChanged += new System.EventHandler(this.bedsideIdExistingComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Patient ID:";
            // 
            // BedsideLoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(963, 352);
            this.Controls.Add(this.existingPanel);
            this.Controls.Add(this.showMenuPanel);
            this.Controls.Add(this.assignPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BedsideLoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bedside System";
            this.Load += new System.EventHandler(this.BedsideLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.assignPanel.ResumeLayout(false);
            this.assignPanel.PerformLayout();
            this.showMenuPanel.ResumeLayout(false);
            this.showMenuPanel.PerformLayout();
            this.existingPanel.ResumeLayout(false);
            this.existingPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button proceedAssignBtn;
        private System.Windows.Forms.ComboBox patientIDAssignComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox bedsideIdAssignComboBox;
        private System.Windows.Forms.Panel assignPanel;
        private System.Windows.Forms.Button backAssignBtn;
        private System.Windows.Forms.Panel showMenuPanel;
        private System.Windows.Forms.Button assignBtn;
        private System.Windows.Forms.Button existingBtn;
        private System.Windows.Forms.Panel existingPanel;
        private System.Windows.Forms.Button backExistingBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button continueExistingBtn;
        private System.Windows.Forms.ComboBox bedsideIdExistingComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox patientIdTextBox;
    }
}

