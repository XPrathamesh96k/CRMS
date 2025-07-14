namespace CRMS.Master
{
    partial class Car
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
            this.lblCarMaster = new System.Windows.Forms.Label();
            this.lblCarid = new System.Windows.Forms.Label();
            this.lblCarName = new System.Windows.Forms.Label();
            this.lblCarCompany = new System.Windows.Forms.Label();
            this.lblCarPlatenumber = new System.Windows.Forms.Label();
            this.lblCarFueltype = new System.Windows.Forms.Label();
            this.lblCarColor = new System.Windows.Forms.Label();
            this.lblCarType = new System.Windows.Forms.Label();
            this.lblCarSeater = new System.Windows.Forms.Label();
            this.lblCarAverage = new System.Windows.Forms.Label();
            this.lblCarEngine = new System.Windows.Forms.Label();
            this.lblCarImage = new System.Windows.Forms.Label();
            this.lblCarRent = new System.Windows.Forms.Label();
            this.CarStatus = new System.Windows.Forms.Label();
            this.txtCarPlatenumber = new System.Windows.Forms.TextBox();
            this.txtCarid = new System.Windows.Forms.TextBox();
            this.txtCarName = new System.Windows.Forms.TextBox();
            this.txtCarCompany = new System.Windows.Forms.TextBox();
            this.txtCarImage = new System.Windows.Forms.TextBox();
            this.txtCarEngine = new System.Windows.Forms.TextBox();
            this.txtCarRent = new System.Windows.Forms.TextBox();
            this.txtCarAverage = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cRMSDataSet7 = new CRMS.CRMSDataSet7();
            this.carTableAdapter = new CRMS.CRMSDataSet7TableAdapters.CarTableAdapter();
            this.txtCarfueltype = new System.Windows.Forms.ComboBox();
            this.txtCarcolor = new System.Windows.Forms.ComboBox();
            this.txtCarType = new System.Windows.Forms.ComboBox();
            this.txtCarSeater = new System.Windows.Forms.ComboBox();
            this.btnUpload = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            this.txtCarStatus = new System.Windows.Forms.ComboBox();
            this.dgvCarMaster = new System.Windows.Forms.DataGridView();
            this.carBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cRMSDataSet8 = new CRMS.CRMSDataSet8();
            this.carTableAdapter1 = new CRMS.CRMSDataSet8TableAdapters.CarTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSelectColumn = new System.Windows.Forms.Label();
            this.cbSelectColumn = new System.Windows.Forms.ComboBox();
            this.lblSelectOperator = new System.Windows.Forms.Label();
            this.cbSelectOperator = new System.Windows.Forms.ComboBox();
            this.lblEnterValue = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtEnterValue = new System.Windows.Forms.TextBox();
            this.caridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carcompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carplatenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carfueltypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carcolorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carseaterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caraverageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carengineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carimage = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMSDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMSDataSet8)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarMaster
            // 
            this.lblCarMaster.AutoSize = true;
            this.lblCarMaster.BackColor = System.Drawing.Color.Transparent;
            this.lblCarMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCarMaster.Font = new System.Drawing.Font("Algerian", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarMaster.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCarMaster.Location = new System.Drawing.Point(371, 9);
            this.lblCarMaster.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarMaster.Name = "lblCarMaster";
            this.lblCarMaster.Size = new System.Drawing.Size(325, 54);
            this.lblCarMaster.TabIndex = 0;
            this.lblCarMaster.Text = "Car Master";
            // 
            // lblCarid
            // 
            this.lblCarid.AutoSize = true;
            this.lblCarid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCarid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCarid.Location = new System.Drawing.Point(29, 83);
            this.lblCarid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarid.Name = "lblCarid";
            this.lblCarid.Size = new System.Drawing.Size(64, 25);
            this.lblCarid.TabIndex = 1;
            this.lblCarid.Text = "Car id";
            // 
            // lblCarName
            // 
            this.lblCarName.AutoSize = true;
            this.lblCarName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarName.Location = new System.Drawing.Point(29, 121);
            this.lblCarName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarName.Name = "lblCarName";
            this.lblCarName.Size = new System.Drawing.Size(101, 25);
            this.lblCarName.TabIndex = 2;
            this.lblCarName.Text = "Car Name";
            // 
            // lblCarCompany
            // 
            this.lblCarCompany.AutoSize = true;
            this.lblCarCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCarCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarCompany.Location = new System.Drawing.Point(29, 162);
            this.lblCarCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarCompany.Name = "lblCarCompany";
            this.lblCarCompany.Size = new System.Drawing.Size(134, 25);
            this.lblCarCompany.TabIndex = 3;
            this.lblCarCompany.Text = "Car Company";
            // 
            // lblCarPlatenumber
            // 
            this.lblCarPlatenumber.AutoSize = true;
            this.lblCarPlatenumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCarPlatenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarPlatenumber.Location = new System.Drawing.Point(29, 203);
            this.lblCarPlatenumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarPlatenumber.Name = "lblCarPlatenumber";
            this.lblCarPlatenumber.Size = new System.Drawing.Size(159, 25);
            this.lblCarPlatenumber.TabIndex = 4;
            this.lblCarPlatenumber.Text = "Car Platenumber";
            // 
            // lblCarFueltype
            // 
            this.lblCarFueltype.AutoSize = true;
            this.lblCarFueltype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCarFueltype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarFueltype.Location = new System.Drawing.Point(29, 247);
            this.lblCarFueltype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarFueltype.Name = "lblCarFueltype";
            this.lblCarFueltype.Size = new System.Drawing.Size(124, 25);
            this.lblCarFueltype.TabIndex = 5;
            this.lblCarFueltype.Text = "Car Fueltype";
            // 
            // lblCarColor
            // 
            this.lblCarColor.AutoSize = true;
            this.lblCarColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCarColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarColor.Location = new System.Drawing.Point(33, 292);
            this.lblCarColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarColor.Name = "lblCarColor";
            this.lblCarColor.Size = new System.Drawing.Size(96, 25);
            this.lblCarColor.TabIndex = 6;
            this.lblCarColor.Text = "Car Color";
            // 
            // lblCarType
            // 
            this.lblCarType.AutoSize = true;
            this.lblCarType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCarType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarType.Location = new System.Drawing.Point(422, 86);
            this.lblCarType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(94, 25);
            this.lblCarType.TabIndex = 7;
            this.lblCarType.Text = "Car Type";
            this.lblCarType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCarSeater
            // 
            this.lblCarSeater.AutoSize = true;
            this.lblCarSeater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCarSeater.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarSeater.Location = new System.Drawing.Point(422, 126);
            this.lblCarSeater.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarSeater.Name = "lblCarSeater";
            this.lblCarSeater.Size = new System.Drawing.Size(107, 25);
            this.lblCarSeater.TabIndex = 8;
            this.lblCarSeater.Text = "Car Seater";
            // 
            // lblCarAverage
            // 
            this.lblCarAverage.AutoSize = true;
            this.lblCarAverage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCarAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarAverage.Location = new System.Drawing.Point(34, 339);
            this.lblCarAverage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarAverage.Name = "lblCarAverage";
            this.lblCarAverage.Size = new System.Drawing.Size(123, 25);
            this.lblCarAverage.TabIndex = 9;
            this.lblCarAverage.Text = "Car Average";
            // 
            // lblCarEngine
            // 
            this.lblCarEngine.AutoSize = true;
            this.lblCarEngine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCarEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarEngine.Location = new System.Drawing.Point(422, 165);
            this.lblCarEngine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarEngine.Name = "lblCarEngine";
            this.lblCarEngine.Size = new System.Drawing.Size(110, 25);
            this.lblCarEngine.TabIndex = 10;
            this.lblCarEngine.Text = "Car Engine";
            // 
            // lblCarImage
            // 
            this.lblCarImage.AutoSize = true;
            this.lblCarImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarImage.Location = new System.Drawing.Point(422, 206);
            this.lblCarImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarImage.Name = "lblCarImage";
            this.lblCarImage.Size = new System.Drawing.Size(103, 25);
            this.lblCarImage.TabIndex = 11;
            this.lblCarImage.Text = "Car Image";
            // 
            // lblCarRent
            // 
            this.lblCarRent.AutoSize = true;
            this.lblCarRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarRent.Location = new System.Drawing.Point(422, 251);
            this.lblCarRent.Name = "lblCarRent";
            this.lblCarRent.Size = new System.Drawing.Size(125, 25);
            this.lblCarRent.TabIndex = 12;
            this.lblCarRent.Text = "Car Rent/Km";
            // 
            // CarStatus
            // 
            this.CarStatus.AutoSize = true;
            this.CarStatus.BackColor = System.Drawing.Color.Transparent;
            this.CarStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarStatus.Location = new System.Drawing.Point(422, 296);
            this.CarStatus.Name = "CarStatus";
            this.CarStatus.Size = new System.Drawing.Size(105, 25);
            this.CarStatus.TabIndex = 13;
            this.CarStatus.Text = "Car Status";
            // 
            // txtCarPlatenumber
            // 
            this.txtCarPlatenumber.BackColor = System.Drawing.Color.White;
            this.txtCarPlatenumber.Location = new System.Drawing.Point(223, 204);
            this.txtCarPlatenumber.Name = "txtCarPlatenumber";
            this.txtCarPlatenumber.Size = new System.Drawing.Size(171, 27);
            this.txtCarPlatenumber.TabIndex = 14;
            // 
            // txtCarid
            // 
            this.txtCarid.BackColor = System.Drawing.Color.White;
            this.txtCarid.Enabled = false;
            this.txtCarid.Location = new System.Drawing.Point(223, 84);
            this.txtCarid.Name = "txtCarid";
            this.txtCarid.ReadOnly = true;
            this.txtCarid.Size = new System.Drawing.Size(171, 27);
            this.txtCarid.TabIndex = 15;
            // 
            // txtCarName
            // 
            this.txtCarName.BackColor = System.Drawing.Color.White;
            this.txtCarName.Location = new System.Drawing.Point(223, 123);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.Size = new System.Drawing.Size(171, 27);
            this.txtCarName.TabIndex = 16;
            // 
            // txtCarCompany
            // 
            this.txtCarCompany.BackColor = System.Drawing.Color.White;
            this.txtCarCompany.Location = new System.Drawing.Point(223, 163);
            this.txtCarCompany.Name = "txtCarCompany";
            this.txtCarCompany.Size = new System.Drawing.Size(171, 27);
            this.txtCarCompany.TabIndex = 17;
            // 
            // txtCarImage
            // 
            this.txtCarImage.BackColor = System.Drawing.Color.White;
            this.txtCarImage.Enabled = false;
            this.txtCarImage.Location = new System.Drawing.Point(563, 207);
            this.txtCarImage.Name = "txtCarImage";
            this.txtCarImage.Size = new System.Drawing.Size(169, 27);
            this.txtCarImage.TabIndex = 22;
            // 
            // txtCarEngine
            // 
            this.txtCarEngine.BackColor = System.Drawing.Color.White;
            this.txtCarEngine.Location = new System.Drawing.Point(566, 166);
            this.txtCarEngine.Name = "txtCarEngine";
            this.txtCarEngine.Size = new System.Drawing.Size(166, 27);
            this.txtCarEngine.TabIndex = 23;
            // 
            // txtCarRent
            // 
            this.txtCarRent.BackColor = System.Drawing.Color.White;
            this.txtCarRent.Location = new System.Drawing.Point(566, 247);
            this.txtCarRent.Name = "txtCarRent";
            this.txtCarRent.Size = new System.Drawing.Size(166, 27);
            this.txtCarRent.TabIndex = 24;
            // 
            // txtCarAverage
            // 
            this.txtCarAverage.BackColor = System.Drawing.Color.White;
            this.txtCarAverage.Location = new System.Drawing.Point(223, 338);
            this.txtCarAverage.Name = "txtCarAverage";
            this.txtCarAverage.Size = new System.Drawing.Size(171, 27);
            this.txtCarAverage.TabIndex = 26;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdate.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btnUpdate.Location = new System.Drawing.Point(445, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 42);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btnDelete.Location = new System.Drawing.Point(646, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 43);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSave.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btnSave.Location = new System.Drawing.Point(236, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 43);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddNew.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btnAddNew.Location = new System.Drawing.Point(32, 3);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(137, 42);
            this.btnAddNew.TabIndex = 29;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btnExit.Location = new System.Drawing.Point(843, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 42);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnAddNew);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Location = new System.Drawing.Point(34, 382);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 50);
            this.panel1.TabIndex = 28;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.cRMSDataSet7;
            // 
            // cRMSDataSet7
            // 
            this.cRMSDataSet7.DataSetName = "CRMSDataSet7";
            this.cRMSDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // txtCarfueltype
            // 
            this.txtCarfueltype.BackColor = System.Drawing.Color.White;
            this.txtCarfueltype.FormattingEnabled = true;
            this.txtCarfueltype.Items.AddRange(new object[] {
            "Petrol",
            "Diesel"});
            this.txtCarfueltype.Location = new System.Drawing.Point(223, 248);
            this.txtCarfueltype.Name = "txtCarfueltype";
            this.txtCarfueltype.Size = new System.Drawing.Size(171, 28);
            this.txtCarfueltype.TabIndex = 31;
            // 
            // txtCarcolor
            // 
            this.txtCarcolor.BackColor = System.Drawing.Color.White;
            this.txtCarcolor.FormattingEnabled = true;
            this.txtCarcolor.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Green",
            "Orange",
            "Red",
            "White",
            "Yellow"});
            this.txtCarcolor.Location = new System.Drawing.Point(223, 293);
            this.txtCarcolor.Name = "txtCarcolor";
            this.txtCarcolor.Size = new System.Drawing.Size(171, 28);
            this.txtCarcolor.TabIndex = 32;
            this.txtCarcolor.SelectedIndexChanged += new System.EventHandler(this.txtCarcolor_SelectedIndexChanged);
            // 
            // txtCarType
            // 
            this.txtCarType.BackColor = System.Drawing.Color.White;
            this.txtCarType.FormattingEnabled = true;
            this.txtCarType.Items.AddRange(new object[] {
            "Hatchback",
            "Suv",
            "Luxury"});
            this.txtCarType.Location = new System.Drawing.Point(564, 87);
            this.txtCarType.Name = "txtCarType";
            this.txtCarType.Size = new System.Drawing.Size(168, 28);
            this.txtCarType.TabIndex = 33;
            // 
            // txtCarSeater
            // 
            this.txtCarSeater.BackColor = System.Drawing.Color.White;
            this.txtCarSeater.FormattingEnabled = true;
            this.txtCarSeater.Items.AddRange(new object[] {
            "4",
            "5",
            "7"});
            this.txtCarSeater.Location = new System.Drawing.Point(564, 127);
            this.txtCarSeater.Name = "txtCarSeater";
            this.txtCarSeater.Size = new System.Drawing.Size(168, 28);
            this.txtCarSeater.TabIndex = 34;
            // 
            // btnUpload
            // 
            this.btnUpload.AutoSize = true;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(655, 342);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(80, 25);
            this.btnUpload.TabIndex = 35;
            this.btnUpload.Text = "Upload";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileSystemWatcher2
            // 
            this.fileSystemWatcher2.EnableRaisingEvents = true;
            this.fileSystemWatcher2.SynchronizingObject = this;
            // 
            // txtCarStatus
            // 
            this.txtCarStatus.BackColor = System.Drawing.Color.White;
            this.txtCarStatus.FormattingEnabled = true;
            this.txtCarStatus.Items.AddRange(new object[] {
            "Available",
            "UnAvailable"});
            this.txtCarStatus.Location = new System.Drawing.Point(566, 297);
            this.txtCarStatus.Name = "txtCarStatus";
            this.txtCarStatus.Size = new System.Drawing.Size(166, 28);
            this.txtCarStatus.TabIndex = 37;
            this.txtCarStatus.Tag = "";
            this.txtCarStatus.SelectedIndexChanged += new System.EventHandler(this.txtCarStatus_SelectedIndexChanged);
            // 
            // dgvCarMaster
            // 
            this.dgvCarMaster.AutoGenerateColumns = false;
            this.dgvCarMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.caridDataGridViewTextBoxColumn,
            this.carnameDataGridViewTextBoxColumn,
            this.carcompanyDataGridViewTextBoxColumn,
            this.carplatenumberDataGridViewTextBoxColumn,
            this.carfueltypeDataGridViewTextBoxColumn,
            this.carcolorDataGridViewTextBoxColumn,
            this.cartypeDataGridViewTextBoxColumn,
            this.carseaterDataGridViewTextBoxColumn,
            this.caraverageDataGridViewTextBoxColumn,
            this.carengineDataGridViewTextBoxColumn,
            this.carrentDataGridViewTextBoxColumn,
            this.carstatusDataGridViewTextBoxColumn,
            this.Carimage});
            this.dgvCarMaster.DataSource = this.carBindingSource1;
            this.dgvCarMaster.Location = new System.Drawing.Point(34, 532);
            this.dgvCarMaster.Name = "dgvCarMaster";
            this.dgvCarMaster.RowTemplate.Height = 24;
            this.dgvCarMaster.Size = new System.Drawing.Size(1031, 91);
            this.dgvCarMaster.TabIndex = 38;
            this.dgvCarMaster.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarMaster_CellContentClick_1);
            // 
            // carBindingSource1
            // 
            this.carBindingSource1.DataMember = "Car";
            this.carBindingSource1.DataSource = this.cRMSDataSet8;
            // 
            // cRMSDataSet8
            // 
            this.cRMSDataSet8.DataSetName = "CRMSDataSet8";
            this.cRMSDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carTableAdapter1
            // 
            this.carTableAdapter1.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.lblCarMaster);
            this.panel2.Location = new System.Drawing.Point(34, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1031, 73);
            this.panel2.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(741, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 276);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // lblSelectColumn
            // 
            this.lblSelectColumn.AutoSize = true;
            this.lblSelectColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectColumn.Location = new System.Drawing.Point(49, 454);
            this.lblSelectColumn.Name = "lblSelectColumn";
            this.lblSelectColumn.Size = new System.Drawing.Size(131, 20);
            this.lblSelectColumn.TabIndex = 41;
            this.lblSelectColumn.Text = "Select Column";
            // 
            // cbSelectColumn
            // 
            this.cbSelectColumn.BackColor = System.Drawing.Color.White;
            this.cbSelectColumn.FormattingEnabled = true;
            this.cbSelectColumn.Location = new System.Drawing.Point(53, 489);
            this.cbSelectColumn.Name = "cbSelectColumn";
            this.cbSelectColumn.Size = new System.Drawing.Size(121, 28);
            this.cbSelectColumn.TabIndex = 42;
            // 
            // lblSelectOperator
            // 
            this.lblSelectOperator.AutoSize = true;
            this.lblSelectOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectOperator.Location = new System.Drawing.Point(252, 454);
            this.lblSelectOperator.Name = "lblSelectOperator";
            this.lblSelectOperator.Size = new System.Drawing.Size(142, 20);
            this.lblSelectOperator.TabIndex = 43;
            this.lblSelectOperator.Text = "Select Operator";
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
            this.cbSelectOperator.Location = new System.Drawing.Point(256, 490);
            this.cbSelectOperator.Name = "cbSelectOperator";
            this.cbSelectOperator.Size = new System.Drawing.Size(121, 28);
            this.cbSelectOperator.TabIndex = 44;
            // 
            // lblEnterValue
            // 
            this.lblEnterValue.AutoSize = true;
            this.lblEnterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterValue.Location = new System.Drawing.Point(475, 454);
            this.lblEnterValue.Name = "lblEnterValue";
            this.lblEnterValue.Size = new System.Drawing.Size(107, 20);
            this.lblEnterValue.TabIndex = 45;
            this.lblEnterValue.Text = "Enter Value";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(695, 451);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(370, 66);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtEnterValue
            // 
            this.txtEnterValue.BackColor = System.Drawing.Color.White;
            this.txtEnterValue.Location = new System.Drawing.Point(479, 490);
            this.txtEnterValue.Name = "txtEnterValue";
            this.txtEnterValue.Size = new System.Drawing.Size(123, 27);
            this.txtEnterValue.TabIndex = 48;
            // 
            // caridDataGridViewTextBoxColumn
            // 
            this.caridDataGridViewTextBoxColumn.DataPropertyName = "Carid";
            this.caridDataGridViewTextBoxColumn.HeaderText = "Carid";
            this.caridDataGridViewTextBoxColumn.Name = "caridDataGridViewTextBoxColumn";
            // 
            // carnameDataGridViewTextBoxColumn
            // 
            this.carnameDataGridViewTextBoxColumn.DataPropertyName = "Carname";
            this.carnameDataGridViewTextBoxColumn.HeaderText = "Carname";
            this.carnameDataGridViewTextBoxColumn.Name = "carnameDataGridViewTextBoxColumn";
            // 
            // carcompanyDataGridViewTextBoxColumn
            // 
            this.carcompanyDataGridViewTextBoxColumn.DataPropertyName = "Carcompany";
            this.carcompanyDataGridViewTextBoxColumn.HeaderText = "Carcompany";
            this.carcompanyDataGridViewTextBoxColumn.Name = "carcompanyDataGridViewTextBoxColumn";
            // 
            // carplatenumberDataGridViewTextBoxColumn
            // 
            this.carplatenumberDataGridViewTextBoxColumn.DataPropertyName = "Carplatenumber";
            this.carplatenumberDataGridViewTextBoxColumn.HeaderText = "Carplatenumber";
            this.carplatenumberDataGridViewTextBoxColumn.Name = "carplatenumberDataGridViewTextBoxColumn";
            // 
            // carfueltypeDataGridViewTextBoxColumn
            // 
            this.carfueltypeDataGridViewTextBoxColumn.DataPropertyName = "Carfueltype";
            this.carfueltypeDataGridViewTextBoxColumn.HeaderText = "Carfueltype";
            this.carfueltypeDataGridViewTextBoxColumn.Name = "carfueltypeDataGridViewTextBoxColumn";
            // 
            // carcolorDataGridViewTextBoxColumn
            // 
            this.carcolorDataGridViewTextBoxColumn.DataPropertyName = "Carcolor";
            this.carcolorDataGridViewTextBoxColumn.HeaderText = "Carcolor";
            this.carcolorDataGridViewTextBoxColumn.Name = "carcolorDataGridViewTextBoxColumn";
            // 
            // cartypeDataGridViewTextBoxColumn
            // 
            this.cartypeDataGridViewTextBoxColumn.DataPropertyName = "Cartype";
            this.cartypeDataGridViewTextBoxColumn.HeaderText = "Cartype";
            this.cartypeDataGridViewTextBoxColumn.Name = "cartypeDataGridViewTextBoxColumn";
            // 
            // carseaterDataGridViewTextBoxColumn
            // 
            this.carseaterDataGridViewTextBoxColumn.DataPropertyName = "Carseater";
            this.carseaterDataGridViewTextBoxColumn.HeaderText = "Carseater";
            this.carseaterDataGridViewTextBoxColumn.Name = "carseaterDataGridViewTextBoxColumn";
            // 
            // caraverageDataGridViewTextBoxColumn
            // 
            this.caraverageDataGridViewTextBoxColumn.DataPropertyName = "Caraverage";
            this.caraverageDataGridViewTextBoxColumn.HeaderText = "Caraverage";
            this.caraverageDataGridViewTextBoxColumn.Name = "caraverageDataGridViewTextBoxColumn";
            // 
            // carengineDataGridViewTextBoxColumn
            // 
            this.carengineDataGridViewTextBoxColumn.DataPropertyName = "Carengine";
            this.carengineDataGridViewTextBoxColumn.HeaderText = "Carengine";
            this.carengineDataGridViewTextBoxColumn.Name = "carengineDataGridViewTextBoxColumn";
            // 
            // carrentDataGridViewTextBoxColumn
            // 
            this.carrentDataGridViewTextBoxColumn.DataPropertyName = "Carrent";
            this.carrentDataGridViewTextBoxColumn.HeaderText = "Carrent";
            this.carrentDataGridViewTextBoxColumn.Name = "carrentDataGridViewTextBoxColumn";
            // 
            // carstatusDataGridViewTextBoxColumn
            // 
            this.carstatusDataGridViewTextBoxColumn.DataPropertyName = "Carstatus";
            this.carstatusDataGridViewTextBoxColumn.HeaderText = "Carstatus";
            this.carstatusDataGridViewTextBoxColumn.Name = "carstatusDataGridViewTextBoxColumn";
            // 
            // Carimage
            // 
            this.Carimage.DataPropertyName = "Carimage";
            this.Carimage.HeaderText = "Carimage";
            this.Carimage.Name = "Carimage";
            // 
            // Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1092, 628);
            this.ControlBox = false;
            this.Controls.Add(this.txtEnterValue);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblEnterValue);
            this.Controls.Add(this.cbSelectOperator);
            this.Controls.Add(this.lblSelectOperator);
            this.Controls.Add(this.cbSelectColumn);
            this.Controls.Add(this.lblSelectColumn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvCarMaster);
            this.Controls.Add(this.txtCarStatus);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.txtCarSeater);
            this.Controls.Add(this.txtCarType);
            this.Controls.Add(this.txtCarcolor);
            this.Controls.Add(this.txtCarfueltype);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCarAverage);
            this.Controls.Add(this.txtCarRent);
            this.Controls.Add(this.txtCarEngine);
            this.Controls.Add(this.txtCarImage);
            this.Controls.Add(this.txtCarCompany);
            this.Controls.Add(this.txtCarName);
            this.Controls.Add(this.txtCarid);
            this.Controls.Add(this.txtCarPlatenumber);
            this.Controls.Add(this.CarStatus);
            this.Controls.Add(this.lblCarRent);
            this.Controls.Add(this.lblCarImage);
            this.Controls.Add(this.lblCarEngine);
            this.Controls.Add(this.lblCarAverage);
            this.Controls.Add(this.lblCarSeater);
            this.Controls.Add(this.lblCarType);
            this.Controls.Add(this.lblCarColor);
            this.Controls.Add(this.lblCarFueltype);
            this.Controls.Add(this.lblCarPlatenumber);
            this.Controls.Add(this.lblCarCompany);
            this.Controls.Add(this.lblCarName);
            this.Controls.Add(this.lblCarid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Car";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Car_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMSDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMSDataSet8)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarMaster;
        private System.Windows.Forms.Label lblCarid;
        private System.Windows.Forms.Label lblCarName;
        private System.Windows.Forms.Label lblCarCompany;
        private System.Windows.Forms.Label lblCarPlatenumber;
        private System.Windows.Forms.Label lblCarFueltype;
        private System.Windows.Forms.Label lblCarColor;
        private System.Windows.Forms.Label lblCarType;
        private System.Windows.Forms.Label lblCarSeater;
        private System.Windows.Forms.Label lblCarAverage;
        private System.Windows.Forms.Label lblCarEngine;
        private System.Windows.Forms.Label lblCarImage;
        private System.Windows.Forms.Label lblCarRent;
        private System.Windows.Forms.Label CarStatus;
        private System.Windows.Forms.TextBox txtCarPlatenumber;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.TextBox txtCarCompany;
        private System.Windows.Forms.TextBox txtCarImage;
        private System.Windows.Forms.TextBox txtCarEngine;
        private System.Windows.Forms.TextBox txtCarRent;
        private System.Windows.Forms.TextBox txtCarAverage;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        //private System.Windows.Forms.PictureBox pbCarMaster;
        private CRMSDataSet7 cRMSDataSet7;
        private System.Windows.Forms.BindingSource carBindingSource;
        private CRMSDataSet7TableAdapters.CarTableAdapter carTableAdapter;
        private System.Windows.Forms.ComboBox txtCarfueltype;
        private System.Windows.Forms.ComboBox txtCarcolor;
        private System.Windows.Forms.ComboBox txtCarType;
        private System.Windows.Forms.ComboBox txtCarSeater;
        private System.Windows.Forms.Label btnUpload;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.IO.FileSystemWatcher fileSystemWatcher2;
        private System.Windows.Forms.ComboBox txtCarStatus;
        private System.Windows.Forms.DataGridView dgvCarMaster;
        private CRMSDataSet8 cRMSDataSet8;
        private System.Windows.Forms.BindingSource carBindingSource1;
        private CRMSDataSet8TableAdapters.CarTableAdapter carTableAdapter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSelectColumn;
        private System.Windows.Forms.ComboBox cbSelectColumn;
        private System.Windows.Forms.Label lblSelectOperator;
        private System.Windows.Forms.ComboBox cbSelectOperator;
        private System.Windows.Forms.Label lblEnterValue;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtEnterValue;
        private System.Windows.Forms.TextBox txtCarid;
        private System.Windows.Forms.DataGridViewTextBoxColumn caridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carcompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carplatenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carfueltypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carcolorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carseaterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caraverageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carengineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carrentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Carimage;
    }
}