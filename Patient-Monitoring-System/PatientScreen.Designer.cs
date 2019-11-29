namespace Patient_Monitoring_System
{
    partial class PatientScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientScreen));
            this.patientGridView = new System.Windows.Forms.DataGridView();
            this.addRecordBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.updateRecordBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.viewRecordBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.viewControlPanel = new System.Windows.Forms.Panel();
            this.addRecordPanel = new System.Windows.Forms.Panel();
            this.resetPatientBtn = new System.Windows.Forms.Button();
            this.savePatientBtn = new System.Windows.Forms.Button();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.nricTextBox = new System.Windows.Forms.TextBox();
            this.patientIdTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.updateRecordPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.choosePatientComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.updatePatientButton = new System.Windows.Forms.Button();
            this.nricUpdateTextBox = new System.Windows.Forms.TextBox();
            this.fullNameUpdateTextBox = new System.Windows.Forms.TextBox();
            this.emailUpdateTextBox = new System.Windows.Forms.TextBox();
            this.ageUpdateTextBox = new System.Windows.Forms.TextBox();
            this.addressUpdateTextBox = new System.Windows.Forms.RichTextBox();
            this.bedsideIdUpdateTextBox = new System.Windows.Forms.TextBox();
            this.phoneUpdateTextBox = new System.Windows.Forms.TextBox();
            this.genderUpdatecomboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.patientGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.viewControlPanel.SuspendLayout();
            this.addRecordPanel.SuspendLayout();
            this.updateRecordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientGridView
            // 
            this.patientGridView.AllowUserToAddRows = false;
            this.patientGridView.AllowUserToDeleteRows = false;
            this.patientGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.patientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientGridView.Location = new System.Drawing.Point(4, 54);
            this.patientGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patientGridView.Name = "patientGridView";
            this.patientGridView.ReadOnly = true;
            this.patientGridView.RowHeadersWidth = 51;
            this.patientGridView.RowTemplate.Height = 24;
            this.patientGridView.Size = new System.Drawing.Size(864, 286);
            this.patientGridView.TabIndex = 32;
            // 
            // addRecordBtn
            // 
            this.addRecordBtn.AutoSize = true;
            this.addRecordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addRecordBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRecordBtn.Location = new System.Drawing.Point(129, 152);
            this.addRecordBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addRecordBtn.Name = "addRecordBtn";
            this.addRecordBtn.Size = new System.Drawing.Size(120, 39);
            this.addRecordBtn.TabIndex = 33;
            this.addRecordBtn.Text = "Add Record";
            this.addRecordBtn.UseVisualStyleBackColor = true;
            this.addRecordBtn.Click += new System.EventHandler(this.addRecordBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 21);
            this.label10.TabIndex = 37;
            this.label10.Text = "Search Patient Record:";
            // 
            // searchtextBox
            // 
            this.searchtextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtextBox.Location = new System.Drawing.Point(185, 13);
            this.searchtextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(184, 29);
            this.searchtextBox.TabIndex = 38;
            this.searchtextBox.TextChanged += new System.EventHandler(this.searchtextBox_TextChanged);
            // 
            // updateRecordBtn
            // 
            this.updateRecordBtn.AutoSize = true;
            this.updateRecordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateRecordBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateRecordBtn.Location = new System.Drawing.Point(251, 152);
            this.updateRecordBtn.Margin = new System.Windows.Forms.Padding(0);
            this.updateRecordBtn.Name = "updateRecordBtn";
            this.updateRecordBtn.Size = new System.Drawing.Size(131, 39);
            this.updateRecordBtn.TabIndex = 39;
            this.updateRecordBtn.Text = "Update Record";
            this.updateRecordBtn.UseVisualStyleBackColor = true;
            this.updateRecordBtn.Click += new System.EventHandler(this.updateRecordBtn_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(884, 148);
            this.label2.TabIndex = 40;
            this.label2.Text = "Patient Monitoring System";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 148);
            this.panel1.TabIndex = 41;
            // 
            // viewRecordBtn
            // 
            this.viewRecordBtn.AutoSize = true;
            this.viewRecordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewRecordBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.viewRecordBtn.Location = new System.Drawing.Point(5, 152);
            this.viewRecordBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewRecordBtn.Name = "viewRecordBtn";
            this.viewRecordBtn.Size = new System.Drawing.Size(120, 39);
            this.viewRecordBtn.TabIndex = 42;
            this.viewRecordBtn.Text = "View Record";
            this.viewRecordBtn.UseVisualStyleBackColor = true;
            this.viewRecordBtn.Click += new System.EventHandler(this.viewRecordBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.AutoSize = true;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(384, 152);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(125, 39);
            this.deleteBtn.TabIndex = 43;
            this.deleteBtn.Text = "Delete Record";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // viewControlPanel
            // 
            this.viewControlPanel.BackColor = System.Drawing.SystemColors.Control;
            this.viewControlPanel.Controls.Add(this.label10);
            this.viewControlPanel.Controls.Add(this.searchtextBox);
            this.viewControlPanel.Controls.Add(this.patientGridView);
            this.viewControlPanel.Location = new System.Drawing.Point(840, 167);
            this.viewControlPanel.Margin = new System.Windows.Forms.Padding(2);
            this.viewControlPanel.Name = "viewControlPanel";
            this.viewControlPanel.Size = new System.Drawing.Size(197, 110);
            this.viewControlPanel.TabIndex = 44;
            // 
            // addRecordPanel
            // 
            this.addRecordPanel.Controls.Add(this.resetPatientBtn);
            this.addRecordPanel.Controls.Add(this.savePatientBtn);
            this.addRecordPanel.Controls.Add(this.genderComboBox);
            this.addRecordPanel.Controls.Add(this.ageTextBox);
            this.addRecordPanel.Controls.Add(this.phoneTextBox);
            this.addRecordPanel.Controls.Add(this.emailTextBox);
            this.addRecordPanel.Controls.Add(this.addressTextBox);
            this.addRecordPanel.Controls.Add(this.fullNameTextBox);
            this.addRecordPanel.Controls.Add(this.nricTextBox);
            this.addRecordPanel.Controls.Add(this.patientIdTextBox);
            this.addRecordPanel.Controls.Add(this.label9);
            this.addRecordPanel.Controls.Add(this.label8);
            this.addRecordPanel.Controls.Add(this.label7);
            this.addRecordPanel.Controls.Add(this.label6);
            this.addRecordPanel.Controls.Add(this.label5);
            this.addRecordPanel.Controls.Add(this.label4);
            this.addRecordPanel.Controls.Add(this.label3);
            this.addRecordPanel.Controls.Add(this.label1);
            this.addRecordPanel.Location = new System.Drawing.Point(813, 337);
            this.addRecordPanel.Name = "addRecordPanel";
            this.addRecordPanel.Size = new System.Drawing.Size(86, 80);
            this.addRecordPanel.TabIndex = 45;
            // 
            // resetPatientBtn
            // 
            this.resetPatientBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.resetPatientBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPatientBtn.Location = new System.Drawing.Point(46, 269);
            this.resetPatientBtn.Margin = new System.Windows.Forms.Padding(2);
            this.resetPatientBtn.Name = "resetPatientBtn";
            this.resetPatientBtn.Size = new System.Drawing.Size(320, 38);
            this.resetPatientBtn.TabIndex = 67;
            this.resetPatientBtn.Text = "RESET";
            this.resetPatientBtn.UseVisualStyleBackColor = false;
            this.resetPatientBtn.Click += new System.EventHandler(this.resetPatientBtn_Click);
            // 
            // savePatientBtn
            // 
            this.savePatientBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.savePatientBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePatientBtn.Location = new System.Drawing.Point(392, 269);
            this.savePatientBtn.Margin = new System.Windows.Forms.Padding(2);
            this.savePatientBtn.Name = "savePatientBtn";
            this.savePatientBtn.Size = new System.Drawing.Size(320, 38);
            this.savePatientBtn.TabIndex = 66;
            this.savePatientBtn.Text = "SAVE";
            this.savePatientBtn.UseVisualStyleBackColor = false;
            this.savePatientBtn.Click += new System.EventHandler(this.savePatientBtn_Click);
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "--Select Gender--",
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(121, 138);
            this.genderComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(222, 38);
            this.genderComboBox.TabIndex = 65;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageTextBox.Location = new System.Drawing.Point(508, 141);
            this.ageTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(62, 35);
            this.ageTextBox.TabIndex = 64;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(508, 97);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(140, 35);
            this.phoneTextBox.TabIndex = 63;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(121, 97);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(140, 35);
            this.emailTextBox.TabIndex = 62;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(508, 54);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(246, 35);
            this.addressTextBox.TabIndex = 61;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameTextBox.Location = new System.Drawing.Point(121, 52);
            this.fullNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(140, 35);
            this.fullNameTextBox.TabIndex = 60;
            // 
            // nricTextBox
            // 
            this.nricTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nricTextBox.Location = new System.Drawing.Point(508, 10);
            this.nricTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nricTextBox.Name = "nricTextBox";
            this.nricTextBox.Size = new System.Drawing.Size(140, 35);
            this.nricTextBox.TabIndex = 59;
            // 
            // patientIdTextBox
            // 
            this.patientIdTextBox.Enabled = false;
            this.patientIdTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIdTextBox.Location = new System.Drawing.Point(121, 10);
            this.patientIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.patientIdTextBox.Name = "patientIdTextBox";
            this.patientIdTextBox.Size = new System.Drawing.Size(62, 35);
            this.patientIdTextBox.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(441, 141);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 30);
            this.label9.TabIndex = 57;
            this.label9.Text = "Age:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(420, 97);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 30);
            this.label8.TabIndex = 56;
            this.label8.Text = "Phone: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 138);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 30);
            this.label7.TabIndex = 55;
            this.label7.Text = "Gender: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 30);
            this.label6.TabIndex = 54;
            this.label6.Text = "Email: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(402, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 30);
            this.label5.TabIndex = 53;
            this.label5.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 30);
            this.label4.TabIndex = 52;
            this.label4.Text = "Full Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(432, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 30);
            this.label3.TabIndex = 51;
            this.label3.Text = "NRIC: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 30);
            this.label1.TabIndex = 50;
            this.label1.Text = "Patient ID:";
            // 
            // updateRecordPanel
            // 
            this.updateRecordPanel.Controls.Add(this.genderUpdatecomboBox);
            this.updateRecordPanel.Controls.Add(this.phoneUpdateTextBox);
            this.updateRecordPanel.Controls.Add(this.bedsideIdUpdateTextBox);
            this.updateRecordPanel.Controls.Add(this.addressUpdateTextBox);
            this.updateRecordPanel.Controls.Add(this.ageUpdateTextBox);
            this.updateRecordPanel.Controls.Add(this.emailUpdateTextBox);
            this.updateRecordPanel.Controls.Add(this.fullNameUpdateTextBox);
            this.updateRecordPanel.Controls.Add(this.nricUpdateTextBox);
            this.updateRecordPanel.Controls.Add(this.updatePatientButton);
            this.updateRecordPanel.Controls.Add(this.label19);
            this.updateRecordPanel.Controls.Add(this.label18);
            this.updateRecordPanel.Controls.Add(this.label17);
            this.updateRecordPanel.Controls.Add(this.label16);
            this.updateRecordPanel.Controls.Add(this.label15);
            this.updateRecordPanel.Controls.Add(this.label14);
            this.updateRecordPanel.Controls.Add(this.label13);
            this.updateRecordPanel.Controls.Add(this.label12);
            this.updateRecordPanel.Controls.Add(this.choosePatientComboBox);
            this.updateRecordPanel.Controls.Add(this.label11);
            this.updateRecordPanel.Location = new System.Drawing.Point(5, 196);
            this.updateRecordPanel.Name = "updateRecordPanel";
            this.updateRecordPanel.Size = new System.Drawing.Size(769, 361);
            this.updateRecordPanel.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "Choose Patient ID: ";
            // 
            // choosePatientComboBox
            // 
            this.choosePatientComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosePatientComboBox.FormattingEnabled = true;
            this.choosePatientComboBox.Location = new System.Drawing.Point(161, 6);
            this.choosePatientComboBox.Name = "choosePatientComboBox";
            this.choosePatientComboBox.Size = new System.Drawing.Size(183, 29);
            this.choosePatientComboBox.TabIndex = 1;
            this.choosePatientComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.choosePatientComboBox_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(54, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 30);
            this.label12.TabIndex = 2;
            this.label12.Text = "NRIC:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 30);
            this.label13.TabIndex = 3;
            this.label13.Text = "Full Name: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(54, 154);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 30);
            this.label14.TabIndex = 4;
            this.label14.Text = "Email:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(40, 200);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 30);
            this.label15.TabIndex = 5;
            this.label15.Text = "Gender:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(42, 243);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 30);
            this.label16.TabIndex = 6;
            this.label16.Text = "Phone: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(454, 141);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 30);
            this.label17.TabIndex = 7;
            this.label17.Text = "Age: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(392, 193);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(123, 30);
            this.label18.TabIndex = 8;
            this.label18.Text = "Bedside ID: ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(417, 51);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(98, 30);
            this.label19.TabIndex = 9;
            this.label19.Text = "Address: ";
            // 
            // updatePatientButton
            // 
            this.updatePatientButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.updatePatientButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePatientButton.Location = new System.Drawing.Point(217, 303);
            this.updatePatientButton.Margin = new System.Windows.Forms.Padding(2);
            this.updatePatientButton.Name = "updatePatientButton";
            this.updatePatientButton.Size = new System.Drawing.Size(320, 38);
            this.updatePatientButton.TabIndex = 68;
            this.updatePatientButton.Text = "UPDATE";
            this.updatePatientButton.UseVisualStyleBackColor = false;
            // 
            // nricUpdateTextBox
            // 
            this.nricUpdateTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nricUpdateTextBox.Location = new System.Drawing.Point(134, 48);
            this.nricUpdateTextBox.Name = "nricUpdateTextBox";
            this.nricUpdateTextBox.Size = new System.Drawing.Size(170, 33);
            this.nricUpdateTextBox.TabIndex = 69;
            // 
            // fullNameUpdateTextBox
            // 
            this.fullNameUpdateTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameUpdateTextBox.Location = new System.Drawing.Point(134, 98);
            this.fullNameUpdateTextBox.Name = "fullNameUpdateTextBox";
            this.fullNameUpdateTextBox.Size = new System.Drawing.Size(170, 33);
            this.fullNameUpdateTextBox.TabIndex = 70;
            // 
            // emailUpdateTextBox
            // 
            this.emailUpdateTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailUpdateTextBox.Location = new System.Drawing.Point(134, 151);
            this.emailUpdateTextBox.Name = "emailUpdateTextBox";
            this.emailUpdateTextBox.Size = new System.Drawing.Size(170, 33);
            this.emailUpdateTextBox.TabIndex = 71;
            // 
            // ageUpdateTextBox
            // 
            this.ageUpdateTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageUpdateTextBox.Location = new System.Drawing.Point(521, 141);
            this.ageUpdateTextBox.Name = "ageUpdateTextBox";
            this.ageUpdateTextBox.Size = new System.Drawing.Size(170, 33);
            this.ageUpdateTextBox.TabIndex = 72;
            // 
            // addressUpdateTextBox
            // 
            this.addressUpdateTextBox.Location = new System.Drawing.Point(521, 51);
            this.addressUpdateTextBox.Name = "addressUpdateTextBox";
            this.addressUpdateTextBox.Size = new System.Drawing.Size(234, 67);
            this.addressUpdateTextBox.TabIndex = 73;
            this.addressUpdateTextBox.Text = "";
            // 
            // bedsideIdUpdateTextBox
            // 
            this.bedsideIdUpdateTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedsideIdUpdateTextBox.Location = new System.Drawing.Point(521, 193);
            this.bedsideIdUpdateTextBox.Name = "bedsideIdUpdateTextBox";
            this.bedsideIdUpdateTextBox.Size = new System.Drawing.Size(170, 33);
            this.bedsideIdUpdateTextBox.TabIndex = 74;
            // 
            // phoneUpdateTextBox
            // 
            this.phoneUpdateTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneUpdateTextBox.Location = new System.Drawing.Point(131, 244);
            this.phoneUpdateTextBox.Name = "phoneUpdateTextBox";
            this.phoneUpdateTextBox.Size = new System.Drawing.Size(170, 33);
            this.phoneUpdateTextBox.TabIndex = 75;
            // 
            // genderUpdatecomboBox
            // 
            this.genderUpdatecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderUpdatecomboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderUpdatecomboBox.FormattingEnabled = true;
            this.genderUpdatecomboBox.Location = new System.Drawing.Point(131, 204);
            this.genderUpdatecomboBox.Name = "genderUpdatecomboBox";
            this.genderUpdatecomboBox.Size = new System.Drawing.Size(173, 29);
            this.genderUpdatecomboBox.TabIndex = 76;
            // 
            // PatientScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.updateRecordPanel);
            this.Controls.Add(this.addRecordPanel);
            this.Controls.Add(this.viewControlPanel);
            this.Controls.Add(this.viewRecordBtn);
            this.Controls.Add(this.addRecordBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateRecordBtn);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PatientScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientScreen";
            this.Load += new System.EventHandler(this.PatientScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.viewControlPanel.ResumeLayout(false);
            this.viewControlPanel.PerformLayout();
            this.addRecordPanel.ResumeLayout(false);
            this.addRecordPanel.PerformLayout();
            this.updateRecordPanel.ResumeLayout(false);
            this.updateRecordPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView patientGridView;
        private System.Windows.Forms.Button addRecordBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.Button updateRecordBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button viewRecordBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Panel viewControlPanel;
        private System.Windows.Forms.Panel addRecordPanel;
        private System.Windows.Forms.Button resetPatientBtn;
        private System.Windows.Forms.Button savePatientBtn;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox nricTextBox;
        private System.Windows.Forms.TextBox patientIdTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel updateRecordPanel;
        private System.Windows.Forms.Button updatePatientButton;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox choosePatientComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ageUpdateTextBox;
        private System.Windows.Forms.TextBox emailUpdateTextBox;
        private System.Windows.Forms.TextBox fullNameUpdateTextBox;
        private System.Windows.Forms.TextBox nricUpdateTextBox;
        private System.Windows.Forms.ComboBox genderUpdatecomboBox;
        private System.Windows.Forms.TextBox phoneUpdateTextBox;
        private System.Windows.Forms.TextBox bedsideIdUpdateTextBox;
        private System.Windows.Forms.RichTextBox addressUpdateTextBox;
    }
}