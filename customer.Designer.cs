namespace CRMS.Master
{
    partial class customer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCustomerAge = new System.Windows.Forms.TextBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cRMSDataSet1 = new CRMS.CRMSDataSet1();
            this.lblCustomerLicense = new System.Windows.Forms.Label();
            this.lblCustomerAge = new System.Windows.Forms.Label();
            this.lblCustomerGender = new System.Windows.Forms.Label();
            this.lblCustomerDocuments = new System.Windows.Forms.Label();
            this.customerTableAdapter = new CRMS.CRMSDataSet1TableAdapters.CustomerTableAdapter();
            this.txtCustomerLicense = new System.Windows.Forms.TextBox();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cRMSDataSet2 = new CRMS.CRMSDataSet2();
            this.lblCustomerMaster = new System.Windows.Forms.Label();
            this.txtCustomerNumber = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerNumber = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.txtCustomerid = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.lblCustomerid = new System.Windows.Forms.Label();
            this.customerTableAdapter1 = new CRMS.CRMSDataSet2TableAdapters.CustomerTableAdapter();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.txtCustomerDocuments = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.dgvCustomerMaster = new System.Windows.Forms.DataGridView();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerdocumentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeraddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customernumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customergenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerlicenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSelectColumn = new System.Windows.Forms.Label();
            this.cbSelectColumn = new System.Windows.Forms.ComboBox();
            this.lblSelectOperator = new System.Windows.Forms.Label();
            this.cbSelectOperator = new System.Windows.Forms.ComboBox();
            this.lblEnterValue = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtEntervalue = new System.Windows.Forms.TextBox();
            this.pbpictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerMaster)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustomerAge
            // 
            this.txtCustomerAge.BackColor = System.Drawing.Color.White;
            this.txtCustomerAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerAge.Location = new System.Drawing.Point(298, 205);
            this.txtCustomerAge.Name = "txtCustomerAge";
            this.txtCustomerAge.Size = new System.Drawing.Size(175, 27);
            this.txtCustomerAge.TabIndex = 46;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.cRMSDataSet1;
            // 
            // cRMSDataSet1
            // 
            this.cRMSDataSet1.DataSetName = "CRMSDataSet1";
            this.cRMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCustomerLicense
            // 
            this.lblCustomerLicense.AutoSize = true;
            this.lblCustomerLicense.BackColor = System.Drawing.SystemColors.Control;
            this.lblCustomerLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCustomerLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerLicense.Location = new System.Drawing.Point(559, 243);
            this.lblCustomerLicense.Name = "lblCustomerLicense";
            this.lblCustomerLicense.Size = new System.Drawing.Size(170, 25);
            this.lblCustomerLicense.TabIndex = 43;
            this.lblCustomerLicense.Text = "Customer License";
            // 
            // lblCustomerAge
            // 
            this.lblCustomerAge.AutoSize = true;
            this.lblCustomerAge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCustomerAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAge.Location = new System.Drawing.Point(72, 204);
            this.lblCustomerAge.Name = "lblCustomerAge";
            this.lblCustomerAge.Size = new System.Drawing.Size(138, 25);
            this.lblCustomerAge.TabIndex = 42;
            this.lblCustomerAge.Text = "Customer Age";
            // 
            // lblCustomerGender
            // 
            this.lblCustomerGender.AutoSize = true;
            this.lblCustomerGender.BackColor = System.Drawing.SystemColors.Control;
            this.lblCustomerGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCustomerGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerGender.Location = new System.Drawing.Point(559, 204);
            this.lblCustomerGender.Name = "lblCustomerGender";
            this.lblCustomerGender.Size = new System.Drawing.Size(167, 25);
            this.lblCustomerGender.TabIndex = 41;
            this.lblCustomerGender.Text = "Customer Gender";
            this.lblCustomerGender.Click += new System.EventHandler(this.lblCustomerGender_Click);
            // 
            // lblCustomerDocuments
            // 
            this.lblCustomerDocuments.AutoSize = true;
            this.lblCustomerDocuments.BackColor = System.Drawing.SystemColors.Control;
            this.lblCustomerDocuments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCustomerDocuments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerDocuments.Location = new System.Drawing.Point(73, 247);
            this.lblCustomerDocuments.Name = "lblCustomerDocuments";
            this.lblCustomerDocuments.Size = new System.Drawing.Size(201, 25);
            this.lblCustomerDocuments.TabIndex = 40;
            this.lblCustomerDocuments.Text = "Customer Documents";
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // txtCustomerLicense
            // 
            this.txtCustomerLicense.BackColor = System.Drawing.Color.White;
            this.txtCustomerLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerLicense.Location = new System.Drawing.Point(802, 244);
            this.txtCustomerLicense.Name = "txtCustomerLicense";
            this.txtCustomerLicense.Size = new System.Drawing.Size(175, 27);
            this.txtCustomerLicense.TabIndex = 47;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "Customer";
            this.customerBindingSource1.DataSource = this.cRMSDataSet2;
            // 
            // cRMSDataSet2
            // 
            this.cRMSDataSet2.DataSetName = "CRMSDataSet2";
            this.cRMSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCustomerMaster
            // 
            this.lblCustomerMaster.AutoSize = true;
            this.lblCustomerMaster.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCustomerMaster.Font = new System.Drawing.Font("Algerian", 28.2F, System.Drawing.FontStyle.Bold);
            this.lblCustomerMaster.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCustomerMaster.Location = new System.Drawing.Point(280, 23);
            this.lblCustomerMaster.Name = "lblCustomerMaster";
            this.lblCustomerMaster.Size = new System.Drawing.Size(473, 54);
            this.lblCustomerMaster.TabIndex = 37;
            this.lblCustomerMaster.Text = "Customer Master";
            // 
            // txtCustomerNumber
            // 
            this.txtCustomerNumber.BackColor = System.Drawing.Color.White;
            this.txtCustomerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerNumber.Location = new System.Drawing.Point(802, 166);
            this.txtCustomerNumber.Name = "txtCustomerNumber";
            this.txtCustomerNumber.Size = new System.Drawing.Size(175, 27);
            this.txtCustomerNumber.TabIndex = 36;
            this.txtCustomerNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerNumber_KeyPress);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.White;
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(802, 127);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(175, 27);
            this.txtCustomerName.TabIndex = 35;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            this.txtCustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerName_KeyPress);
            // 
            // lblCustomerNumber
            // 
            this.lblCustomerNumber.AutoSize = true;
            this.lblCustomerNumber.BackColor = System.Drawing.SystemColors.Control;
            this.lblCustomerNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCustomerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerNumber.Location = new System.Drawing.Point(559, 165);
            this.lblCustomerNumber.Name = "lblCustomerNumber";
            this.lblCustomerNumber.Size = new System.Drawing.Size(171, 25);
            this.lblCustomerNumber.TabIndex = 34;
            this.lblCustomerNumber.Text = "Customer Number";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.SystemColors.Control;
            this.lblCustomerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(559, 125);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(154, 25);
            this.lblCustomerName.TabIndex = 33;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.BackColor = System.Drawing.Color.White;
            this.txtCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerAddress.Location = new System.Drawing.Point(298, 162);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(175, 27);
            this.txtCustomerAddress.TabIndex = 32;
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.BackColor = System.Drawing.SystemColors.Control;
            this.lblCustomerAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAddress.Location = new System.Drawing.Point(71, 166);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(175, 25);
            this.lblCustomerAddress.TabIndex = 31;
            this.lblCustomerAddress.Text = "Customer Address";
            // 
            // txtCustomerid
            // 
            this.txtCustomerid.BackColor = System.Drawing.Color.White;
            this.txtCustomerid.Enabled = false;
            this.txtCustomerid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerid.Location = new System.Drawing.Point(298, 126);
            this.txtCustomerid.Name = "txtCustomerid";
            this.txtCustomerid.Size = new System.Drawing.Size(175, 27);
            this.txtCustomerid.TabIndex = 30;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(758, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 35);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(567, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 35);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(379, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 35);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(192, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 35);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddNew.Enabled = false;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAddNew.Location = new System.Drawing.Point(24, 13);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(139, 35);
            this.btnAddNew.TabIndex = 24;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // lblCustomerid
            // 
            this.lblCustomerid.AutoSize = true;
            this.lblCustomerid.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCustomerid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerid.Location = new System.Drawing.Point(72, 129);
            this.lblCustomerid.Name = "lblCustomerid";
            this.lblCustomerid.Size = new System.Drawing.Size(117, 25);
            this.lblCustomerid.TabIndex = 29;
            this.lblCustomerid.Text = "Customer id";
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.BackColor = System.Drawing.Color.White;
            this.rdMale.Location = new System.Drawing.Point(802, 201);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(59, 21);
            this.rdMale.TabIndex = 48;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = false;
            this.rdMale.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.BackColor = System.Drawing.Color.White;
            this.rdFemale.Location = new System.Drawing.Point(802, 219);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(75, 21);
            this.rdFemale.TabIndex = 49;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = false;
            // 
            // txtCustomerDocuments
            // 
            this.txtCustomerDocuments.BackColor = System.Drawing.Color.White;
            this.txtCustomerDocuments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerDocuments.Location = new System.Drawing.Point(298, 248);
            this.txtCustomerDocuments.Name = "txtCustomerDocuments";
            this.txtCustomerDocuments.Size = new System.Drawing.Size(100, 27);
            this.txtCustomerDocuments.TabIndex = 44;
            this.txtCustomerDocuments.TextChanged += new System.EventHandler(this.txtCustomerDocuments_TextChanged);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(398, 248);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 28);
            this.btnUpload.TabIndex = 50;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // dgvCustomerMaster
            // 
            this.dgvCustomerMaster.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomerMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customeridDataGridViewTextBoxColumn,
            this.customernameDataGridViewTextBoxColumn,
            this.customerdocumentsDataGridViewTextBoxColumn,
            this.customeraddressDataGridViewTextBoxColumn,
            this.customernumberDataGridViewTextBoxColumn,
            this.customergenderDataGridViewTextBoxColumn,
            this.customerageDataGridViewTextBoxColumn,
            this.customerlicenseDataGridViewTextBoxColumn});
            this.dgvCustomerMaster.DataSource = this.customerBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomerMaster.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomerMaster.Location = new System.Drawing.Point(89, 543);
            this.dgvCustomerMaster.Name = "dgvCustomerMaster";
            this.dgvCustomerMaster.RowTemplate.Height = 24;
            this.dgvCustomerMaster.Size = new System.Drawing.Size(900, 82);
            this.dgvCustomerMaster.TabIndex = 51;
            this.dgvCustomerMaster.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerMaster_CellContentClick_1);
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "Customerid";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "Customerid";
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            // 
            // customernameDataGridViewTextBoxColumn
            // 
            this.customernameDataGridViewTextBoxColumn.DataPropertyName = "Customername";
            this.customernameDataGridViewTextBoxColumn.HeaderText = "Customername";
            this.customernameDataGridViewTextBoxColumn.Name = "customernameDataGridViewTextBoxColumn";
            // 
            // customerdocumentsDataGridViewTextBoxColumn
            // 
            this.customerdocumentsDataGridViewTextBoxColumn.DataPropertyName = "Customerdocuments";
            this.customerdocumentsDataGridViewTextBoxColumn.HeaderText = "Customerdocuments";
            this.customerdocumentsDataGridViewTextBoxColumn.Name = "customerdocumentsDataGridViewTextBoxColumn";
            // 
            // customeraddressDataGridViewTextBoxColumn
            // 
            this.customeraddressDataGridViewTextBoxColumn.DataPropertyName = "Customeraddress";
            this.customeraddressDataGridViewTextBoxColumn.HeaderText = "Customeraddress";
            this.customeraddressDataGridViewTextBoxColumn.Name = "customeraddressDataGridViewTextBoxColumn";
            // 
            // customernumberDataGridViewTextBoxColumn
            // 
            this.customernumberDataGridViewTextBoxColumn.DataPropertyName = "Customernumber";
            this.customernumberDataGridViewTextBoxColumn.HeaderText = "Customernumber";
            this.customernumberDataGridViewTextBoxColumn.Name = "customernumberDataGridViewTextBoxColumn";
            // 
            // customergenderDataGridViewTextBoxColumn
            // 
            this.customergenderDataGridViewTextBoxColumn.DataPropertyName = "Customergender";
            this.customergenderDataGridViewTextBoxColumn.HeaderText = "Customergender";
            this.customergenderDataGridViewTextBoxColumn.Name = "customergenderDataGridViewTextBoxColumn";
            // 
            // customerageDataGridViewTextBoxColumn
            // 
            this.customerageDataGridViewTextBoxColumn.DataPropertyName = "Customerage";
            this.customerageDataGridViewTextBoxColumn.HeaderText = "Customerage";
            this.customerageDataGridViewTextBoxColumn.Name = "customerageDataGridViewTextBoxColumn";
            // 
            // customerlicenseDataGridViewTextBoxColumn
            // 
            this.customerlicenseDataGridViewTextBoxColumn.DataPropertyName = "Customerlicense";
            this.customerlicenseDataGridViewTextBoxColumn.HeaderText = "Customerlicense";
            this.customerlicenseDataGridViewTextBoxColumn.Name = "customerlicenseDataGridViewTextBoxColumn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblCustomerMaster);
            this.panel1.Location = new System.Drawing.Point(77, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 100);
            this.panel1.TabIndex = 53;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CRMS.Properties.Resources.IMG_20231008_1501151;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnAddNew);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Location = new System.Drawing.Point(83, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 59);
            this.panel2.TabIndex = 54;
            // 
            // lblSelectColumn
            // 
            this.lblSelectColumn.AutoSize = true;
            this.lblSelectColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectColumn.Location = new System.Drawing.Point(85, 471);
            this.lblSelectColumn.Name = "lblSelectColumn";
            this.lblSelectColumn.Size = new System.Drawing.Size(131, 20);
            this.lblSelectColumn.TabIndex = 55;
            this.lblSelectColumn.Text = "Select Column";
            // 
            // cbSelectColumn
            // 
            this.cbSelectColumn.FormattingEnabled = true;
            this.cbSelectColumn.Location = new System.Drawing.Point(89, 504);
            this.cbSelectColumn.Name = "cbSelectColumn";
            this.cbSelectColumn.Size = new System.Drawing.Size(121, 24);
            this.cbSelectColumn.TabIndex = 56;
            // 
            // lblSelectOperator
            // 
            this.lblSelectOperator.AutoSize = true;
            this.lblSelectOperator.BackColor = System.Drawing.Color.White;
            this.lblSelectOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectOperator.Location = new System.Drawing.Point(272, 471);
            this.lblSelectOperator.Name = "lblSelectOperator";
            this.lblSelectOperator.Size = new System.Drawing.Size(142, 20);
            this.lblSelectOperator.TabIndex = 57;
            this.lblSelectOperator.Text = "Select Operator";
            this.lblSelectOperator.Click += new System.EventHandler(this.lblSelectOperator_Click);
            // 
            // cbSelectOperator
            // 
            this.cbSelectOperator.BackColor = System.Drawing.Color.White;
            this.cbSelectOperator.FormattingEnabled = true;
            this.cbSelectOperator.Items.AddRange(new object[] {
            "=",
            "<",
            ">",
            "<=",
            ">=",
            "LIKE",
            "NOT LIKE",
            "MASTERDATA"});
            this.cbSelectOperator.Location = new System.Drawing.Point(277, 504);
            this.cbSelectOperator.Name = "cbSelectOperator";
            this.cbSelectOperator.Size = new System.Drawing.Size(121, 24);
            this.cbSelectOperator.TabIndex = 58;
            // 
            // lblEnterValue
            // 
            this.lblEnterValue.AutoSize = true;
            this.lblEnterValue.BackColor = System.Drawing.Color.White;
            this.lblEnterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterValue.Location = new System.Drawing.Point(470, 471);
            this.lblEnterValue.Name = "lblEnterValue";
            this.lblEnterValue.Size = new System.Drawing.Size(104, 20);
            this.lblEnterValue.TabIndex = 59;
            this.lblEnterValue.Text = "Enter value";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(682, 471);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(301, 59);
            this.btnSearch.TabIndex = 61;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseMnemonic = false;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtEntervalue
            // 
            this.txtEntervalue.BackColor = System.Drawing.Color.White;
            this.txtEntervalue.Location = new System.Drawing.Point(474, 506);
            this.txtEntervalue.Name = "txtEntervalue";
            this.txtEntervalue.Size = new System.Drawing.Size(123, 22);
            this.txtEntervalue.TabIndex = 62;
            // 
            // pbpictureBox
            // 
            this.pbpictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.pbpictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbpictureBox.ErrorImage = null;
            this.pbpictureBox.InitialImage = null;
            this.pbpictureBox.Location = new System.Drawing.Point(298, 288);
            this.pbpictureBox.Name = "pbpictureBox";
            this.pbpictureBox.Size = new System.Drawing.Size(175, 104);
            this.pbpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbpictureBox.TabIndex = 52;
            this.pbpictureBox.TabStop = false;
            // 
            // customer
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ColumnHeader;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1050, 625);
            this.ControlBox = false;
            this.Controls.Add(this.txtEntervalue);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblEnterValue);
            this.Controls.Add(this.cbSelectOperator);
            this.Controls.Add(this.lblSelectOperator);
            this.Controls.Add(this.cbSelectColumn);
            this.Controls.Add(this.lblSelectColumn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbpictureBox);
            this.Controls.Add(this.dgvCustomerMaster);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.rdFemale);
            this.Controls.Add(this.rdMale);
            this.Controls.Add(this.txtCustomerAge);
            this.Controls.Add(this.txtCustomerDocuments);
            this.Controls.Add(this.lblCustomerLicense);
            this.Controls.Add(this.lblCustomerAge);
            this.Controls.Add(this.lblCustomerGender);
            this.Controls.Add(this.lblCustomerDocuments);
            this.Controls.Add(this.txtCustomerLicense);
            this.Controls.Add(this.txtCustomerNumber);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomerNumber);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.txtCustomerAddress);
            this.Controls.Add(this.lblCustomerAddress);
            this.Controls.Add(this.txtCustomerid);
            this.Controls.Add(this.lblCustomerid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customer1";
            this.Load += new System.EventHandler(this.customer1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerMaster)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerAge;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private CRMSDataSet1 cRMSDataSet1;
        private System.Windows.Forms.Label lblCustomerLicense;
        private System.Windows.Forms.Label lblCustomerAge;
        private System.Windows.Forms.Label lblCustomerGender;
        private System.Windows.Forms.Label lblCustomerDocuments;
        private CRMSDataSet1TableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.TextBox txtCustomerLicense;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCustomerMaster;
        private System.Windows.Forms.TextBox txtCustomerNumber;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerNumber;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerid;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label lblCustomerid;
        private CRMSDataSet2 cRMSDataSet2;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private CRMSDataSet2TableAdapters.CustomerTableAdapter customerTableAdapter1;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.TextBox txtCustomerDocuments;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.DataGridView dgvCustomerMaster;
        private System.Windows.Forms.PictureBox pbpictureBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerdocumentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeraddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customernumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customergenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerlicenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSelectColumn;
        private System.Windows.Forms.ComboBox cbSelectColumn;
        private System.Windows.Forms.Label lblSelectOperator;
        private System.Windows.Forms.ComboBox cbSelectOperator;
        private System.Windows.Forms.Label lblEnterValue;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtEntervalue;
    }
}