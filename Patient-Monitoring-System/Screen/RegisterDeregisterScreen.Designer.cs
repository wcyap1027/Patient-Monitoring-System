namespace Patient_Monitoring_System.Screen
{
    partial class RegisterDeregisterScreen
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
            this.registerTypecomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.registerDepartmentcomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userIdtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.registerbtn = new System.Windows.Forms.Button();
            this.deRegisterbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registerTypecomboBox
            // 
            this.registerTypecomboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerTypecomboBox.FormattingEnabled = true;
            this.registerTypecomboBox.Location = new System.Drawing.Point(158, 31);
            this.registerTypecomboBox.Name = "registerTypecomboBox";
            this.registerTypecomboBox.Size = new System.Drawing.Size(131, 29);
            this.registerTypecomboBox.TabIndex = 0;
            this.registerTypecomboBox.SelectedIndexChanged += new System.EventHandler(this.registerTypecomboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Department:";
            // 
            // registerDepartmentcomboBox
            // 
            this.registerDepartmentcomboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerDepartmentcomboBox.FormattingEnabled = true;
            this.registerDepartmentcomboBox.Location = new System.Drawing.Point(158, 93);
            this.registerDepartmentcomboBox.Name = "registerDepartmentcomboBox";
            this.registerDepartmentcomboBox.Size = new System.Drawing.Size(193, 29);
            this.registerDepartmentcomboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "User ID:";
            // 
            // userIdtextBox
            // 
            this.userIdtextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdtextBox.Location = new System.Drawing.Point(158, 155);
            this.userIdtextBox.Name = "userIdtextBox";
            this.userIdtextBox.Size = new System.Drawing.Size(193, 29);
            this.userIdtextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtextBox.Location = new System.Drawing.Point(158, 215);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.PasswordChar = '*';
            this.passwordtextBox.Size = new System.Drawing.Size(193, 29);
            this.passwordtextBox.TabIndex = 7;
            // 
            // registerbtn
            // 
            this.registerbtn.AutoSize = true;
            this.registerbtn.BackColor = System.Drawing.Color.SpringGreen;
            this.registerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerbtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerbtn.Location = new System.Drawing.Point(158, 284);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(103, 40);
            this.registerbtn.TabIndex = 8;
            this.registerbtn.Text = "Register";
            this.registerbtn.UseVisualStyleBackColor = false;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // deRegisterbtn
            // 
            this.deRegisterbtn.AutoSize = true;
            this.deRegisterbtn.BackColor = System.Drawing.Color.Red;
            this.deRegisterbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deRegisterbtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deRegisterbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deRegisterbtn.Location = new System.Drawing.Point(147, 284);
            this.deRegisterbtn.Name = "deRegisterbtn";
            this.deRegisterbtn.Size = new System.Drawing.Size(123, 40);
            this.deRegisterbtn.TabIndex = 9;
            this.deRegisterbtn.Text = "Deregister";
            this.deRegisterbtn.UseVisualStyleBackColor = false;
            this.deRegisterbtn.Click += new System.EventHandler(this.deRegisterbtn_Click);
            // 
            // RegisterDeregisterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.deRegisterbtn);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userIdtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.registerDepartmentcomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerTypecomboBox);
            this.Name = "RegisterDeregisterScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RegisterDeregisterScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox registerTypecomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox registerDepartmentcomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userIdtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.Button deRegisterbtn;
    }
}