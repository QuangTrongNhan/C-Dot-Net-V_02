namespace EmployeeForm
{
    partial class Employee
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.dTPDOB = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNational = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbQualification = new System.Windows.Forms.ComboBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.clID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.National = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnNew = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnSavetoFile = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.cbNationalFilter = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pnSearchOptions = new System.Windows.Forms.Panel();
            this.BtnShowHide = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnLoadfromFile = new System.Windows.Forms.Button();
            this.dgEmployees = new System.Windows.Forms.DataGridView();
            this.clFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clgender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnational = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clqualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblID = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.pnSearchOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(112, 75);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(291, 22);
            this.txtFullName.TabIndex = 1;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // dTPDOB
            // 
            this.dTPDOB.CustomFormat = "MM/dd/yyyy";
            this.dTPDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPDOB.Location = new System.Drawing.Point(112, 114);
            this.dTPDOB.Margin = new System.Windows.Forms.Padding(4);
            this.dTPDOB.Name = "dTPDOB";
            this.dTPDOB.Size = new System.Drawing.Size(291, 22);
            this.dTPDOB.TabIndex = 2;
            this.dTPDOB.ValueChanged += new System.EventHandler(this.dTPDOB_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date of Birth:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gender:";
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(36, 12);
            this.radMale.Margin = new System.Windows.Forms.Padding(4);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(59, 21);
            this.radMale.TabIndex = 3;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(176, 12);
            this.radFemale.Margin = new System.Windows.Forms.Padding(4);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(75, 21);
            this.radFemale.TabIndex = 4;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radMale);
            this.groupBox1.Controls.Add(this.radFemale);
            this.groupBox1.Location = new System.Drawing.Point(112, 146);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(292, 44);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "National:";
            // 
            // cbNational
            // 
            this.cbNational.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNational.FormattingEnabled = true;
            this.cbNational.Items.AddRange(new object[] {
            "Vietnam",
            "Japan",
            "China",
            "Thailand",
            "Laos",
            "Indonesia",
            "Philipin"});
            this.cbNational.Location = new System.Drawing.Point(112, 202);
            this.cbNational.Margin = new System.Windows.Forms.Padding(4);
            this.cbNational.Name = "cbNational";
            this.cbNational.Size = new System.Drawing.Size(197, 24);
            this.cbNational.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Phone:";
            // 
            // mtxtPhone
            // 
            this.mtxtPhone.Location = new System.Drawing.Point(112, 235);
            this.mtxtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtPhone.Mask = "(+900)-0000-000-000";
            this.mtxtPhone.Name = "mtxtPhone";
            this.mtxtPhone.Size = new System.Drawing.Size(291, 22);
            this.mtxtPhone.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 272);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(112, 268);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(291, 80);
            this.txtAddress.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 367);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Qualification:";
            // 
            // cbQualification
            // 
            this.cbQualification.FormattingEnabled = true;
            this.cbQualification.Items.AddRange(new object[] {
            "College",
            "Software Engineer",
            "Economic Bachelor",
            "Master of Business Administration"});
            this.cbQualification.Location = new System.Drawing.Point(112, 363);
            this.cbQualification.Margin = new System.Windows.Forms.Padding(4);
            this.cbQualification.Name = "cbQualification";
            this.cbQualification.Size = new System.Drawing.Size(160, 24);
            this.cbQualification.TabIndex = 8;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(251, 460);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(128, 28);
            this.BtnAdd.TabIndex = 11;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // clID
            // 
            this.clID.HeaderText = "ID";
            this.clID.MinimumWidth = 6;
            this.clID.Name = "clID";
            this.clID.ReadOnly = true;
            this.clID.Width = 125;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Full Name";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 125;
            // 
            // DOB
            // 
            this.DOB.HeaderText = "Date of Birth";
            this.DOB.MinimumWidth = 6;
            this.DOB.Name = "DOB";
            this.DOB.ReadOnly = true;
            this.DOB.Width = 125;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 125;
            // 
            // National
            // 
            this.National.HeaderText = "National";
            this.National.MinimumWidth = 6;
            this.National.Name = "National";
            this.National.ReadOnly = true;
            this.National.Width = 125;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 125;
            // 
            // Qualification
            // 
            this.Qualification.HeaderText = "Qualification";
            this.Qualification.MinimumWidth = 6;
            this.Qualification.Name = "Qualification";
            this.Qualification.ReadOnly = true;
            this.Qualification.Width = 125;
            // 
            // Salary
            // 
            this.Salary.HeaderText = "Salary";
            this.Salary.MinimumWidth = 6;
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            this.Salary.Width = 125;
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(69, 460);
            this.BtnNew.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(128, 28);
            this.BtnNew.TabIndex = 10;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(112, 396);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(291, 22);
            this.txtSalary.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 400);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Salary:";
            // 
            // BtnSavetoFile
            // 
            this.BtnSavetoFile.Location = new System.Drawing.Point(69, 511);
            this.BtnSavetoFile.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSavetoFile.Name = "BtnSavetoFile";
            this.BtnSavetoFile.Size = new System.Drawing.Size(128, 28);
            this.BtnSavetoFile.TabIndex = 25;
            this.BtnSavetoFile.Text = "Save to File";
            this.BtnSavetoFile.UseVisualStyleBackColor = true;
            this.BtnSavetoFile.Click += new System.EventHandler(this.BtnSavetoFile_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(329, 25);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(100, 28);
            this.BtnSearch.TabIndex = 26;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnFilter);
            this.groupBox2.Controls.Add(this.cbNationalFilter);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.BtnSearch);
            this.groupBox2.Location = new System.Drawing.Point(19, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(448, 117);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // BtnFilter
            // 
            this.BtnFilter.Location = new System.Drawing.Point(197, 68);
            this.BtnFilter.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(100, 28);
            this.BtnFilter.TabIndex = 29;
            this.BtnFilter.Text = "Filter";
            this.BtnFilter.UseVisualStyleBackColor = true;
            this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // cbNationalFilter
            // 
            this.cbNationalFilter.FormattingEnabled = true;
            this.cbNationalFilter.Items.AddRange(new object[] {
            "Vietnam",
            "Singapore",
            "China",
            "Laos",
            "Campodia",
            "Thailand"});
            this.cbNationalFilter.Location = new System.Drawing.Point(9, 71);
            this.cbNationalFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cbNationalFilter.Name = "cbNationalFilter";
            this.cbNationalFilter.Size = new System.Drawing.Size(160, 24);
            this.cbNationalFilter.TabIndex = 28;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(8, 27);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(312, 22);
            this.txtName.TabIndex = 27;
            // 
            // pnSearchOptions
            // 
            this.pnSearchOptions.Controls.Add(this.groupBox2);
            this.pnSearchOptions.Location = new System.Drawing.Point(457, 75);
            this.pnSearchOptions.Margin = new System.Windows.Forms.Padding(4);
            this.pnSearchOptions.Name = "pnSearchOptions";
            this.pnSearchOptions.Size = new System.Drawing.Size(496, 142);
            this.pnSearchOptions.TabIndex = 28;
            // 
            // BtnShowHide
            // 
            this.BtnShowHide.Location = new System.Drawing.Point(457, 32);
            this.BtnShowHide.Margin = new System.Windows.Forms.Padding(4);
            this.BtnShowHide.Name = "BtnShowHide";
            this.BtnShowHide.Size = new System.Drawing.Size(189, 28);
            this.BtnShowHide.TabIndex = 29;
            this.BtnShowHide.Text = "Show Search options";
            this.BtnShowHide.UseVisualStyleBackColor = true;
            this.BtnShowHide.Click += new System.EventHandler(this.BtnShowHide_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 44);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "ID:";
            // 
            // BtnLoadfromFile
            // 
            this.BtnLoadfromFile.Location = new System.Drawing.Point(251, 511);
            this.BtnLoadfromFile.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLoadfromFile.Name = "BtnLoadfromFile";
            this.BtnLoadfromFile.Size = new System.Drawing.Size(128, 28);
            this.BtnLoadfromFile.TabIndex = 32;
            this.BtnLoadfromFile.Text = "Load from File";
            this.BtnLoadfromFile.UseVisualStyleBackColor = true;
            this.BtnLoadfromFile.Click += new System.EventHandler(this.BtnLoadfromFile_Click);
            // 
            // dgEmployees
            // 
            this.dgEmployees.AllowUserToAddRows = false;
            this.dgEmployees.AllowUserToDeleteRows = false;
            this.dgEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clFullName,
            this.clDoB,
            this.clgender,
            this.clnational,
            this.clphone,
            this.claddress,
            this.clqualification,
            this.clsalary});
            this.dgEmployees.Location = new System.Drawing.Point(444, 235);
            this.dgEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.dgEmployees.MultiSelect = false;
            this.dgEmployees.Name = "dgEmployees";
            this.dgEmployees.RowHeadersWidth = 51;
            this.dgEmployees.Size = new System.Drawing.Size(941, 334);
            this.dgEmployees.TabIndex = 33;
            this.dgEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmployees_CellClick);
            // 
            // clFullName
            // 
            this.clFullName.HeaderText = "Full Name";
            this.clFullName.MinimumWidth = 6;
            this.clFullName.Name = "clFullName";
            this.clFullName.Width = 125;
            // 
            // clDoB
            // 
            this.clDoB.HeaderText = "Date of Birth";
            this.clDoB.MinimumWidth = 6;
            this.clDoB.Name = "clDoB";
            this.clDoB.Width = 125;
            // 
            // clgender
            // 
            this.clgender.HeaderText = "Gender";
            this.clgender.MinimumWidth = 6;
            this.clgender.Name = "clgender";
            this.clgender.Width = 125;
            // 
            // clnational
            // 
            this.clnational.HeaderText = "National";
            this.clnational.MinimumWidth = 6;
            this.clnational.Name = "clnational";
            this.clnational.Width = 125;
            // 
            // clphone
            // 
            this.clphone.HeaderText = "Phone";
            this.clphone.MinimumWidth = 6;
            this.clphone.Name = "clphone";
            this.clphone.Width = 125;
            // 
            // claddress
            // 
            this.claddress.HeaderText = "Address";
            this.claddress.MinimumWidth = 6;
            this.claddress.Name = "claddress";
            this.claddress.Width = 125;
            // 
            // clqualification
            // 
            this.clqualification.HeaderText = "Qualification";
            this.clqualification.MinimumWidth = 6;
            this.clqualification.Name = "clqualification";
            this.clqualification.Width = 125;
            // 
            // clsalary
            // 
            this.clsalary.HeaderText = "Salary";
            this.clsalary.MinimumWidth = 6;
            this.clsalary.Name = "clsalary";
            this.clsalary.Width = 125;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(116, 44);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 30;
            this.lblID.Text = "ID";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Data files|*.dat";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(69, 558);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 27);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(251, 558);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 27);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 593);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgEmployees);
            this.Controls.Add(this.BtnLoadfromFile);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.BtnShowHide);
            this.Controls.Add(this.pnSearchOptions);
            this.Controls.Add(this.BtnSavetoFile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.cbQualification);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mtxtPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbNational);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dTPDOB);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmployee";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnSearchOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.DateTimePicker dTPDOB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNational;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbQualification;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button BtnSavetoFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnFilter;
        private System.Windows.Forms.ComboBox cbNationalFilter;
        private System.Windows.Forms.Panel pnSearchOptions;
        private System.Windows.Forms.Button BtnShowHide;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnLoadfromFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn clID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn National;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qualification;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridView dgEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clgender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnational;
        private System.Windows.Forms.DataGridViewTextBoxColumn clphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn claddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clqualification;
        private System.Windows.Forms.DataGridViewTextBoxColumn clsalary;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}