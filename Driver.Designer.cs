namespace CRMS.Master
{
    partial class Driver
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
            this.lblDriverId = new System.Windows.Forms.Label();
            this.lblDriverName = new System.Windows.Forms.Label();
            this.lblDriverDocument = new System.Windows.Forms.Label();
            this.lblDriverLicense = new System.Windows.Forms.Label();
            this.lblDriverExperience = new System.Windows.Forms.Label();
            this.lblDriverPhoto = new System.Windows.Forms.Label();
            this.lblDriverAge = new System.Windows.Forms.Label();
            this.lblDriverJoiningDate = new System.Windows.Forms.Label();
            this.lblDriverAdhaarCard = new System.Windows.Forms.Label();
            this.lblDriverGender = new System.Windows.Forms.Label();
            this.lblDriverAddress = new System.Windows.Forms.Label();
            this.lblDriverEmailId = new System.Windows.Forms.Label();
            this.lblDriverNumber = new System.Windows.Forms.Label();
            this.txtDriverId = new System.Windows.Forms.TextBox();
            this.txtDriverName = new System.Windows.Forms.TextBox();
            this.txtDriverDocument = new System.Windows.Forms.TextBox();
            this.txtDriverLicence = new System.Windows.Forms.TextBox();
            this.txtDriverExperience = new System.Windows.Forms.TextBox();
            this.txtDriverPhoto = new System.Windows.Forms.TextBox();
            this.txtDriverAge = new System.Windows.Forms.TextBox();
            this.txtDriverAdhaarCard = new System.Windows.Forms.TextBox();
            this.txtDriverAddress = new System.Windows.Forms.TextBox();
            this.txtDriverEmailId = new System.Windows.Forms.TextBox();
            this.txtDriverNumber = new System.Windows.Forms.TextBox();
            this.lblDriverMaster = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cRMSDataSet6 = new CRMS.CRMSDataSet6();
            this.driverTableAdapter = new CRMS.CRMSDataSet6TableAdapters.DriverTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtDriverJoiningDate = new System.Windows.Forms.DateTimePicker();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUploadPhoto = new System.Windows.Forms.Button();
            this.btnUploadDocument = new System.Windows.Forms.Button();
            this.pbDriverMaster = new System.Windows.Forms.PictureBox();
            this.lblSelectColumn = new System.Windows.Forms.Label();
            this.lblSelectOperator = new System.Windows.Forms.Label();
            this.lblEnterValue = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbSelectColumn = new System.Windows.Forms.ComboBox();
            this.cbSelectOperator = new System.Windows.Forms.ComboBox();
            this.txtEnterValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMSDataSet6)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDriverMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDriverId
            // 
            this.lblDriverId.AutoSize = true;
            this.lblDriverId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverId.Location = new System.Drawing.Point(30, 158);
            this.lblDriverId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriverId.Name = "lblDriverId";
            this.lblDriverId.Size = new System.Drawing.Size(84, 25);
            this.lblDriverId.TabIndex = 0;
            this.lblDriverId.Text = "Driver Id";
            // 
            // lblDriverName
            // 
            this.lblDriverName.AutoSize = true;
            this.lblDriverName.BackColor = System.Drawing.Color.Transparent;
            this.lblDriverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverName.Location = new System.Drawing.Point(418, 153);
            this.lblDriverName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriverName.Name = "lblDriverName";
            this.lblDriverName.Size = new System.Drawing.Size(120, 25);
            this.lblDriverName.TabIndex = 1;
            this.lblDriverName.Text = "Driver Name";
            // 
            // lblDriverDocument
            // 
            this.lblDriverDocument.AutoSize = true;
            this.lblDriverDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverDocument.Location = new System.Drawing.Point(30, 212);
            this.lblDriverDocument.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriverDocument.Name = "lblDriverDocument";
            this.lblDriverDocument.Size = new System.Drawing.Size(157, 25);
            this.lblDriverDocument.TabIndex = 2;
            this.lblDriverDocument.Text = "Driver Document";
            this.lblDriverDocument.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblDriverLicense
            // 
            this.lblDriverLicense.AutoSize = true;
            this.lblDriverLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverLicense.Location = new System.Drawing.Point(30, 263);
            this.lblDriverLicense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriverLicense.Name = "lblDriverLicense";
            this.lblDriverLicense.Size = new System.Drawing.Size(136, 25);
            this.lblDriverLicense.TabIndex = 4;
            this.lblDriverLicense.Text = "Driver License";
            this.lblDriverLicense.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblDriverExperience
            // 
            this.lblDriverExperience.AutoSize = true;
            this.lblDriverExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverExperience.Location = new System.Drawing.Point(418, 260);
            this.lblDriverExperience.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriverExperience.Name = "lblDriverExperience";
            this.lblDriverExperience.Size = new System.Drawing.Size(166, 25);
            this.lblDriverExperience.TabIndex = 5;
            this.lblDriverExperience.Text = "Driver Experience";
            this.lblDriverExperience.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblDriverPhoto
            // 
            this.lblDriverPhoto.AutoSize = true;
            this.lblDriverPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverPhoto.Location = new System.Drawing.Point(419, 482);
            this.lblDriverPhoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriverPhoto.Name = "lblDriverPhoto";
            this.lblDriverPhoto.Size = new System.Drawing.Size(119, 25);
            this.lblDriverPhoto.TabIndex = 6;
            this.lblDriverPhoto.Text = "Driver Photo";
            this.lblDriverPhoto.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblDriverAge
            // 
            this.lblDriverAge.AutoSize = true;
            this.lblDriverAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverAge.Location = new System.Drawing.Point(418, 318);
            this.lblDriverAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriverAge.Name = "lblDriverAge";
            this.lblDriverAge.Size = new System.Drawing.Size(104, 25);
            this.lblDriverAge.TabIndex = 7;
            this.lblDriverAge.Text = "Driver Age";
            this.lblDriverAge.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblDriverJoiningDate
            // 
            this.lblDriverJoiningDate.AutoSize = true;
            this.lblDriverJoiningDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverJoiningDate.Location = new System.Drawing.Point(30, 320);
            this.lblDriverJoiningDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriverJoiningDate.Name = "lblDriverJoiningDate";
            this.lblDriverJoiningDate.Size = new System.Drawing.Size(177, 25);
            this.lblDriverJoiningDate.TabIndex = 8;
            this.lblDriverJoiningDate.Text = "Driver Joining Date";
            this.lblDriverJoiningDate.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblDriverAdhaarCard
            // 
            this.lblDriverAdhaarCard.AutoSize = true;
            this.lblDriverAdhaarCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverAdhaarCard.Location = new System.Drawing.Point(417, 372);
            this.lblDriverAdhaarCard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriverAdhaarCard.Name = "lblDriverAdhaarCard";
            this.lblDriverAdhaarCard.Size = new System.Drawing.Size(175, 25);
            this.lblDriverAdhaarCard.TabIndex = 9;
            this.lblDriverAdhaarCard.Text = "Driver AdhaarCard";
            this.lblDriverAdhaarCard.Click += new System.EventHandler(this.label10_Click);
            // 
            // lblDriverGender
            // 
            this.lblDriverGender.AutoSize = true;
            this.lblDriverGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverGender.Location = new System.Drawing.Point(34, 374);
            this.lblDriverGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriverGender.Name = "lblDriverGender";
            this.lblDriverGender.Size = new System.Drawing.Size(133, 25);
            this.lblDriverGender.TabIndex = 10;
            this.lblDriverGender.Text = "Driver Gender";
            this.lblDriverGender.Click += new System.EventHandler(this.label11_Click);
            // 
            // lblDriverAddress
            // 
            this.lblDriverAddress.AutoSize = true;
            this.lblDriverAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverAddress.Location = new System.Drawing.Point(418, 206);
            this.lblDriverAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriverAddress.Name = "lblDriverAddress";
            this.lblDriverAddress.Size = new System.Drawing.Size(141, 25);
            this.lblDriverAddress.TabIndex = 11;
            this.lblDriverAddress.Text = "Driver Address";
            this.lblDriverAddress.Click += new System.EventHandler(this.label12_Click);
            // 
            // lblDriverEmailId
            // 
            this.lblDriverEmailId.AutoSize = true;
            this.lblDriverEmailId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverEmailId.Location = new System.Drawing.Point(34, 431);
            this.lblDriverEmailId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriverEmailId.Name = "lblDriverEmailId";
            this.lblDriverEmailId.Size = new System.Drawing.Size(132, 25);
            this.lblDriverEmailId.TabIndex = 12;
            this.lblDriverEmailId.Text = "Driver EmailId";
            this.lblDriverEmailId.Click += new System.EventHandler(this.label13_Click);
            // 
            // lblDriverNumber
            // 
            this.lblDriverNumber.AutoSize = true;
            this.lblDriverNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverNumber.Location = new System.Drawing.Point(419, 427);
            this.lblDriverNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriverNumber.Name = "lblDriverNumber";
            this.lblDriverNumber.Size = new System.Drawing.Size(137, 25);
            this.lblDriverNumber.TabIndex = 13;
            this.lblDriverNumber.Text = "Driver Number";
            this.lblDriverNumber.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtDriverId
            // 
            this.txtDriverId.Location = new System.Drawing.Point(222, 155);
            this.txtDriverId.Margin = new System.Windows.Forms.Padding(4);
            this.txtDriverId.Name = "txtDriverId";
            this.txtDriverId.Size = new System.Drawing.Size(160, 27);
            this.txtDriverId.TabIndex = 15;
            // 
            // txtDriverName
            // 
            this.txtDriverName.Location = new System.Drawing.Point(606, 153);
            this.txtDriverName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.Size = new System.Drawing.Size(160, 27);
            this.txtDriverName.TabIndex = 16;
            // 
            // txtDriverDocument
            // 
            this.txtDriverDocument.Location = new System.Drawing.Point(223, 207);
            this.txtDriverDocument.Margin = new System.Windows.Forms.Padding(4);
            this.txtDriverDocument.Name = "txtDriverDocument";
            this.txtDriverDocument.Size = new System.Drawing.Size(69, 27);
            this.txtDriverDocument.TabIndex = 17;
            // 
            // txtDriverLicence
            // 
            this.txtDriverLicence.Location = new System.Drawing.Point(222, 260);
            this.txtDriverLicence.Margin = new System.Windows.Forms.Padding(4);
            this.txtDriverLicence.Name = "txtDriverLicence";
            this.txtDriverLicence.Size = new System.Drawing.Size(160, 27);
            this.txtDriverLicence.TabIndex = 19;
            // 
            // txtDriverExperience
            // 
            this.txtDriverExperience.Location = new System.Drawing.Point(606, 258);
            this.txtDriverExperience.Margin = new System.Windows.Forms.Padding(4);
            this.txtDriverExperience.Name = "txtDriverExperience";
            this.txtDriverExperience.Size = new System.Drawing.Size(160, 27);
            this.txtDriverExperience.TabIndex = 20;
            this.txtDriverExperience.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtDriverPhoto
            // 
            this.txtDriverPhoto.Location = new System.Drawing.Point(606, 480);
            this.txtDriverPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.txtDriverPhoto.Name = "txtDriverPhoto";
            this.txtDriverPhoto.Size = new System.Drawing.Size(84, 27);
            this.txtDriverPhoto.TabIndex = 21;
            this.txtDriverPhoto.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtDriverAge
            // 
            this.txtDriverAge.Location = new System.Drawing.Point(606, 318);
            this.txtDriverAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtDriverAge.Name = "txtDriverAge";
            this.txtDriverAge.Size = new System.Drawing.Size(160, 27);
            this.txtDriverAge.TabIndex = 22;
            // 
            // txtDriverAdhaarCard
            // 
            this.txtDriverAdhaarCard.Location = new System.Drawing.Point(606, 372);
            this.txtDriverAdhaarCard.Margin = new System.Windows.Forms.Padding(4);
            this.txtDriverAdhaarCard.Name = "txtDriverAdhaarCard";
            this.txtDriverAdhaarCard.Size = new System.Drawing.Size(160, 27);
            this.txtDriverAdhaarCard.TabIndex = 24;
            // 
            // txtDriverAddress
            // 
            this.txtDriverAddress.Location = new System.Drawing.Point(606, 207);
            this.txtDriverAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtDriverAddress.Name = "txtDriverAddress";
            this.txtDriverAddress.Size = new System.Drawing.Size(160, 27);
            this.txtDriverAddress.TabIndex = 26;
            // 
            // txtDriverEmailId
            // 
            this.txtDriverEmailId.Location = new System.Drawing.Point(222, 431);
            this.txtDriverEmailId.Margin = new System.Windows.Forms.Padding(4);
            this.txtDriverEmailId.Name = "txtDriverEmailId";
            this.txtDriverEmailId.Size = new System.Drawing.Size(160, 27);
            this.txtDriverEmailId.TabIndex = 27;
            this.txtDriverEmailId.TextChanged += new System.EventHandler(this.txtDriverEmailId_TextChanged);
            // 
            // txtDriverNumber
            // 
            this.txtDriverNumber.Location = new System.Drawing.Point(606, 429);
            this.txtDriverNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtDriverNumber.Name = "txtDriverNumber";
            this.txtDriverNumber.Size = new System.Drawing.Size(160, 27);
            this.txtDriverNumber.TabIndex = 28;
            // 
            // lblDriverMaster
            // 
            this.lblDriverMaster.AutoSize = true;
            this.lblDriverMaster.BackColor = System.Drawing.Color.Transparent;
            this.lblDriverMaster.Font = new System.Drawing.Font("Algerian", 28.2F, System.Drawing.FontStyle.Bold);
            this.lblDriverMaster.ForeColor = System.Drawing.Color.White;
            this.lblDriverMaster.Location = new System.Drawing.Point(431, 33);
            this.lblDriverMaster.Name = "lblDriverMaster";
            this.lblDriverMaster.Size = new System.Drawing.Size(398, 54);
            this.lblDriverMaster.TabIndex = 29;
            this.lblDriverMaster.Text = "Driver Master";
            this.lblDriverMaster.Click += new System.EventHandler(this.lblDriverMaster_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 602);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1284, 119);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataMember = "Driver";
            this.driverBindingSource.DataSource = this.cRMSDataSet6;
            // 
            // cRMSDataSet6
            // 
            this.cRMSDataSet6.DataSetName = "CRMSDataSet6";
            this.cRMSDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // driverTableAdapter
            // 
            this.driverTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnAddNew);
            this.panel1.Location = new System.Drawing.Point(792, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 357);
            this.panel1.TabIndex = 31;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btnExit.Location = new System.Drawing.Point(31, 290);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(145, 42);
            this.btnExit.TabIndex = 32;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btnDelete.Location = new System.Drawing.Point(31, 229);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 42);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdate.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btnUpdate.Location = new System.Drawing.Point(31, 157);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(145, 42);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSave.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btnSave.Location = new System.Drawing.Point(31, 90);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 42);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddNew.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btnAddNew.Location = new System.Drawing.Point(31, 24);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(145, 42);
            this.btnAddNew.TabIndex = 36;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.lblDriverMaster);
            this.panel2.Location = new System.Drawing.Point(35, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1261, 115);
            this.panel2.TabIndex = 32;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dtDriverJoiningDate
            // 
            this.dtDriverJoiningDate.Location = new System.Drawing.Point(225, 320);
            this.dtDriverJoiningDate.Name = "dtDriverJoiningDate";
            this.dtDriverJoiningDate.Size = new System.Drawing.Size(160, 27);
            this.dtDriverJoiningDate.TabIndex = 33;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.BackColor = System.Drawing.Color.White;
            this.rdFemale.Location = new System.Drawing.Point(72, 0);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(85, 24);
            this.rdFemale.TabIndex = 34;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = false;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rdMale.Location = new System.Drawing.Point(3, 1);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(66, 24);
            this.rdMale.TabIndex = 35;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdFemale);
            this.panel3.Controls.Add(this.rdMale);
            this.panel3.Location = new System.Drawing.Point(225, 376);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 25);
            this.panel3.TabIndex = 36;
            // 
            // btnUploadPhoto
            // 
            this.btnUploadPhoto.Location = new System.Drawing.Point(693, 479);
            this.btnUploadPhoto.Name = "btnUploadPhoto";
            this.btnUploadPhoto.Size = new System.Drawing.Size(73, 29);
            this.btnUploadPhoto.TabIndex = 37;
            this.btnUploadPhoto.Text = "Upload";
            this.btnUploadPhoto.UseVisualStyleBackColor = true;
            this.btnUploadPhoto.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnUploadDocument
            // 
            this.btnUploadDocument.Location = new System.Drawing.Point(294, 206);
            this.btnUploadDocument.Name = "btnUploadDocument";
            this.btnUploadDocument.Size = new System.Drawing.Size(85, 27);
            this.btnUploadDocument.TabIndex = 38;
            this.btnUploadDocument.Text = "Upload";
            this.btnUploadDocument.UseVisualStyleBackColor = true;
            this.btnUploadDocument.Click += new System.EventHandler(this.btnUploadDocument_Click);
            // 
            // pbDriverMaster
            // 
            this.pbDriverMaster.BackColor = System.Drawing.SystemColors.Control;
            this.pbDriverMaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDriverMaster.ErrorImage = null;
            this.pbDriverMaster.InitialImage = null;
            this.pbDriverMaster.Location = new System.Drawing.Point(610, 514);
            this.pbDriverMaster.Name = "pbDriverMaster";
            this.pbDriverMaster.Size = new System.Drawing.Size(110, 82);
            this.pbDriverMaster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDriverMaster.TabIndex = 39;
            this.pbDriverMaster.TabStop = false;
            // 
            // lblSelectColumn
            // 
            this.lblSelectColumn.AutoSize = true;
            this.lblSelectColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectColumn.Location = new System.Drawing.Point(1027, 158);
            this.lblSelectColumn.Name = "lblSelectColumn";
            this.lblSelectColumn.Size = new System.Drawing.Size(131, 20);
            this.lblSelectColumn.TabIndex = 40;
            this.lblSelectColumn.Text = "Select Column";
            this.lblSelectColumn.Click += new System.EventHandler(this.lblSelectColumn_Click);
            // 
            // lblSelectOperator
            // 
            this.lblSelectOperator.AutoSize = true;
            this.lblSelectOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectOperator.Location = new System.Drawing.Point(1027, 244);
            this.lblSelectOperator.Name = "lblSelectOperator";
            this.lblSelectOperator.Size = new System.Drawing.Size(142, 20);
            this.lblSelectOperator.TabIndex = 41;
            this.lblSelectOperator.Text = "Select Operator";
            // 
            // lblEnterValue
            // 
            this.lblEnterValue.AutoSize = true;
            this.lblEnterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterValue.Location = new System.Drawing.Point(1027, 327);
            this.lblEnterValue.Name = "lblEnterValue";
            this.lblEnterValue.Size = new System.Drawing.Size(101, 20);
            this.lblEnterValue.TabIndex = 42;
            this.lblEnterValue.Text = "EnterValue";
            this.lblEnterValue.Click += new System.EventHandler(this.lblEnterValue_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1033, 383);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(265, 128);
            this.btnSearch.TabIndex = 43;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbSelectColumn
            // 
            this.cbSelectColumn.FormattingEnabled = true;
            this.cbSelectColumn.Location = new System.Drawing.Point(1175, 150);
            this.cbSelectColumn.Name = "cbSelectColumn";
            this.cbSelectColumn.Size = new System.Drawing.Size(121, 28);
            this.cbSelectColumn.TabIndex = 44;
            // 
            // cbSelectOperator
            // 
            this.cbSelectOperator.FormattingEnabled = true;
            this.cbSelectOperator.Items.AddRange(new object[] {
            "=",
            "<",
            ">",
            "<=",
            ">=",
            "LIKE",
            "NOTLIKE",
            "MASTERDATA"});
            this.cbSelectOperator.Location = new System.Drawing.Point(1175, 236);
            this.cbSelectOperator.Name = "cbSelectOperator";
            this.cbSelectOperator.Size = new System.Drawing.Size(121, 28);
            this.cbSelectOperator.TabIndex = 45;
            // 
            // txtEnterValue
            // 
            this.txtEnterValue.Location = new System.Drawing.Point(1175, 318);
            this.txtEnterValue.Name = "txtEnterValue";
            this.txtEnterValue.Size = new System.Drawing.Size(121, 27);
            this.txtEnterValue.TabIndex = 46;
            // 
            // Driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1311, 728);
            this.ControlBox = false;
            this.Controls.Add(this.txtEnterValue);
            this.Controls.Add(this.cbSelectOperator);
            this.Controls.Add(this.cbSelectColumn);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblEnterValue);
            this.Controls.Add(this.lblSelectOperator);
            this.Controls.Add(this.lblSelectColumn);
            this.Controls.Add(this.pbDriverMaster);
            this.Controls.Add(this.btnUploadDocument);
            this.Controls.Add(this.btnUploadPhoto);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dtDriverJoiningDate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDriverNumber);
            this.Controls.Add(this.txtDriverEmailId);
            this.Controls.Add(this.txtDriverAddress);
            this.Controls.Add(this.txtDriverAdhaarCard);
            this.Controls.Add(this.txtDriverAge);
            this.Controls.Add(this.txtDriverPhoto);
            this.Controls.Add(this.txtDriverExperience);
            this.Controls.Add(this.txtDriverLicence);
            this.Controls.Add(this.txtDriverDocument);
            this.Controls.Add(this.txtDriverName);
            this.Controls.Add(this.txtDriverId);
            this.Controls.Add(this.lblDriverNumber);
            this.Controls.Add(this.lblDriverEmailId);
            this.Controls.Add(this.lblDriverAddress);
            this.Controls.Add(this.lblDriverGender);
            this.Controls.Add(this.lblDriverAdhaarCard);
            this.Controls.Add(this.lblDriverJoiningDate);
            this.Controls.Add(this.lblDriverAge);
            this.Controls.Add(this.lblDriverPhoto);
            this.Controls.Add(this.lblDriverExperience);
            this.Controls.Add(this.lblDriverLicense);
            this.Controls.Add(this.lblDriverDocument);
            this.Controls.Add(this.lblDriverName);
            this.Controls.Add(this.lblDriverId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Driver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Driver";
            this.Load += new System.EventHandler(this.Driver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMSDataSet6)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDriverMaster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDriverId;
        private System.Windows.Forms.Label lblDriverName;
        private System.Windows.Forms.Label lblDriverDocument;
        private System.Windows.Forms.Label lblDriverLicense;
        private System.Windows.Forms.Label lblDriverExperience;
        private System.Windows.Forms.Label lblDriverPhoto;
        private System.Windows.Forms.Label lblDriverAge;
        private System.Windows.Forms.Label lblDriverJoiningDate;
        private System.Windows.Forms.Label lblDriverAdhaarCard;
        private System.Windows.Forms.Label lblDriverGender;
        private System.Windows.Forms.Label lblDriverAddress;
        private System.Windows.Forms.Label lblDriverEmailId;
        private System.Windows.Forms.Label lblDriverNumber;
        private System.Windows.Forms.TextBox txtDriverId;
        private System.Windows.Forms.TextBox txtDriverName;
        private System.Windows.Forms.TextBox txtDriverDocument;
        private System.Windows.Forms.TextBox txtDriverLicence;
        private System.Windows.Forms.TextBox txtDriverExperience;
        private System.Windows.Forms.TextBox txtDriverPhoto;
        private System.Windows.Forms.TextBox txtDriverAge;
        private System.Windows.Forms.TextBox txtDriverAdhaarCard;
        private System.Windows.Forms.TextBox txtDriverAddress;
        private System.Windows.Forms.TextBox txtDriverEmailId;
        private System.Windows.Forms.TextBox txtDriverNumber;
        private System.Windows.Forms.Label lblDriverMaster;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CRMSDataSet6 cRMSDataSet6;
        private System.Windows.Forms.BindingSource driverBindingSource;
        private CRMSDataSet6TableAdapters.DriverTableAdapter driverTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtDriverJoiningDate;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUploadPhoto;
        private System.Windows.Forms.Button btnUploadDocument;
        private System.Windows.Forms.PictureBox pbDriverMaster;
        private System.Windows.Forms.Label lblSelectColumn;
        private System.Windows.Forms.Label lblSelectOperator;
        private System.Windows.Forms.Label lblEnterValue;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbSelectColumn;
        private System.Windows.Forms.ComboBox cbSelectOperator;
        private System.Windows.Forms.TextBox txtEnterValue;
    }
}