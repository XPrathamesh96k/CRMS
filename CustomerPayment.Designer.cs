namespace CRMS.Transaction
{
    partial class CustomerPayment
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
            this.lblCustomerPayment = new System.Windows.Forms.Label();
            this.lblPaymentid = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPaymentid = new System.Windows.Forms.TextBox();
            this.lblBookingid = new System.Windows.Forms.Label();
            this.cbBookingid = new System.Windows.Forms.ComboBox();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cRMSDataSet14 = new CRMS.CRMSDataSet14();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDname = new System.Windows.Forms.Label();
            this.lblDriverName = new System.Windows.Forms.Label();
            this.lblBdate = new System.Windows.Forms.Label();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.lblCid = new System.Windows.Forms.Label();
            this.lblCname = new System.Windows.Forms.Label();
            this.lblCarid = new System.Windows.Forms.Label();
            this.lblCarName = new System.Windows.Forms.Label();
            this.lblCarDetails = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.lblPayableAmount = new System.Windows.Forms.Label();
            this.txtPayableAmount = new System.Windows.Forms.TextBox();
            this.lblGST = new System.Windows.Forms.Label();
            this.txtGST = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblAdvancePayment = new System.Windows.Forms.Label();
            this.txtAdvancePayment = new System.Windows.Forms.TextBox();
            this.lblRemainingPayment = new System.Windows.Forms.Label();
            this.txtRemainingPayment = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.dtPaymentdate = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bookingTableAdapter = new CRMS.CRMSDataSet14TableAdapters.BookingTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMSDataSet14)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustomerPayment
            // 
            this.lblCustomerPayment.AutoSize = true;
            this.lblCustomerPayment.Font = new System.Drawing.Font("Algerian", 28.2F, System.Drawing.FontStyle.Bold);
            this.lblCustomerPayment.Location = new System.Drawing.Point(120, 8);
            this.lblCustomerPayment.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCustomerPayment.Name = "lblCustomerPayment";
            this.lblCustomerPayment.Size = new System.Drawing.Size(505, 54);
            this.lblCustomerPayment.TabIndex = 0;
            this.lblCustomerPayment.Text = "Customer Payment";
            // 
            // lblPaymentid
            // 
            this.lblPaymentid.AutoSize = true;
            this.lblPaymentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentid.Location = new System.Drawing.Point(18, 15);
            this.lblPaymentid.Name = "lblPaymentid";
            this.lblPaymentid.Size = new System.Drawing.Size(109, 25);
            this.lblPaymentid.TabIndex = 1;
            this.lblPaymentid.Text = "Payment id";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lblCustomerPayment);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(30, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 68);
            this.panel1.TabIndex = 2;
            // 
            // txtPaymentid
            // 
            this.txtPaymentid.Enabled = false;
            this.txtPaymentid.Location = new System.Drawing.Point(140, 10);
            this.txtPaymentid.Name = "txtPaymentid";
            this.txtPaymentid.Size = new System.Drawing.Size(176, 30);
            this.txtPaymentid.TabIndex = 3;
            // 
            // lblBookingid
            // 
            this.lblBookingid.AutoSize = true;
            this.lblBookingid.Location = new System.Drawing.Point(18, 57);
            this.lblBookingid.Name = "lblBookingid";
            this.lblBookingid.Size = new System.Drawing.Size(103, 25);
            this.lblBookingid.TabIndex = 4;
            this.lblBookingid.Text = "Booking id";
            // 
            // cbBookingid
            // 
            this.cbBookingid.FormattingEnabled = true;
            this.cbBookingid.Location = new System.Drawing.Point(139, 53);
            this.cbBookingid.Name = "cbBookingid";
            this.cbBookingid.Size = new System.Drawing.Size(176, 33);
            this.cbBookingid.TabIndex = 5;
            this.cbBookingid.SelectedIndexChanged += new System.EventHandler(this.cbBookingid_SelectedIndexChanged);
            this.cbBookingid.SelectionChangeCommitted += new System.EventHandler(this.cbBookingid_SelectionChangeCommitted);
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.cRMSDataSet14;
            // 
            // cRMSDataSet14
            // 
            this.cRMSDataSet14.DataSetName = "CRMSDataSet14";
            this.cRMSDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Location = new System.Drawing.Point(386, 15);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(135, 25);
            this.lblPaymentDate.TabIndex = 6;
            this.lblPaymentDate.Text = "Payment Date";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblDname);
            this.panel2.Controls.Add(this.lblDriverName);
            this.panel2.Controls.Add(this.lblBdate);
            this.panel2.Controls.Add(this.lblBookingDate);
            this.panel2.Controls.Add(this.lblCid);
            this.panel2.Controls.Add(this.lblCname);
            this.panel2.Controls.Add(this.lblCarid);
            this.panel2.Controls.Add(this.lblCarName);
            this.panel2.Controls.Add(this.lblCarDetails);
            this.panel2.Location = new System.Drawing.Point(0, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(698, 122);
            this.panel2.TabIndex = 8;
            // 
            // lblDname
            // 
            this.lblDname.AutoSize = true;
            this.lblDname.Location = new System.Drawing.Point(611, 83);
            this.lblDname.Name = "lblDname";
            this.lblDname.Size = new System.Drawing.Size(64, 25);
            this.lblDname.TabIndex = 9;
            this.lblDname.Text = "label4";
            // 
            // lblDriverName
            // 
            this.lblDriverName.AutoSize = true;
            this.lblDriverName.Location = new System.Drawing.Point(408, 83);
            this.lblDriverName.Name = "lblDriverName";
            this.lblDriverName.Size = new System.Drawing.Size(120, 25);
            this.lblDriverName.TabIndex = 8;
            this.lblDriverName.Text = "Driver Name";
            // 
            // lblBdate
            // 
            this.lblBdate.AutoSize = true;
            this.lblBdate.Location = new System.Drawing.Point(611, 41);
            this.lblBdate.Name = "lblBdate";
            this.lblBdate.Size = new System.Drawing.Size(64, 25);
            this.lblBdate.TabIndex = 7;
            this.lblBdate.Text = "label3";
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.Location = new System.Drawing.Point(406, 41);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(129, 25);
            this.lblBookingDate.TabIndex = 6;
            this.lblBookingDate.Text = "Booking Date";
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.Location = new System.Drawing.Point(173, 85);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(64, 25);
            this.lblCid.TabIndex = 4;
            this.lblCid.Text = "label2";
            // 
            // lblCname
            // 
            this.lblCname.AutoSize = true;
            this.lblCname.Location = new System.Drawing.Point(173, 45);
            this.lblCname.Name = "lblCname";
            this.lblCname.Size = new System.Drawing.Size(64, 25);
            this.lblCname.TabIndex = 3;
            this.lblCname.Text = "label1";
            // 
            // lblCarid
            // 
            this.lblCarid.AutoSize = true;
            this.lblCarid.Location = new System.Drawing.Point(5, 85);
            this.lblCarid.Name = "lblCarid";
            this.lblCarid.Size = new System.Drawing.Size(64, 25);
            this.lblCarid.TabIndex = 2;
            this.lblCarid.Text = "Car id";
            // 
            // lblCarName
            // 
            this.lblCarName.AutoSize = true;
            this.lblCarName.Location = new System.Drawing.Point(3, 45);
            this.lblCarName.Name = "lblCarName";
            this.lblCarName.Size = new System.Drawing.Size(101, 25);
            this.lblCarName.TabIndex = 1;
            this.lblCarName.Text = "Car Name";
            // 
            // lblCarDetails
            // 
            this.lblCarDetails.AutoSize = true;
            this.lblCarDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarDetails.Location = new System.Drawing.Point(4, 10);
            this.lblCarDetails.Name = "lblCarDetails";
            this.lblCarDetails.Size = new System.Drawing.Size(140, 25);
            this.lblCarDetails.TabIndex = 0;
            this.lblCarDetails.Text = "Car Details :-";
            // 
            // lblPayableAmount
            // 
            this.lblPayableAmount.AutoSize = true;
            this.lblPayableAmount.Location = new System.Drawing.Point(18, 226);
            this.lblPayableAmount.Name = "lblPayableAmount";
            this.lblPayableAmount.Size = new System.Drawing.Size(156, 25);
            this.lblPayableAmount.TabIndex = 9;
            this.lblPayableAmount.Text = "Payable Amount";
            // 
            // txtPayableAmount
            // 
            this.txtPayableAmount.Enabled = false;
            this.txtPayableAmount.Location = new System.Drawing.Point(180, 226);
            this.txtPayableAmount.Name = "txtPayableAmount";
            this.txtPayableAmount.Size = new System.Drawing.Size(148, 30);
            this.txtPayableAmount.TabIndex = 10;
            // 
            // lblGST
            // 
            this.lblGST.AutoSize = true;
            this.lblGST.Location = new System.Drawing.Point(406, 229);
            this.lblGST.Name = "lblGST";
            this.lblGST.Size = new System.Drawing.Size(91, 25);
            this.lblGST.TabIndex = 11;
            this.lblGST.Text = "GST (%)";
            // 
            // txtGST
            // 
            this.txtGST.Location = new System.Drawing.Point(510, 226);
            this.txtGST.Name = "txtGST";
            this.txtGST.Size = new System.Drawing.Size(148, 30);
            this.txtGST.TabIndex = 12;
            this.txtGST.TextChanged += new System.EventHandler(this.txtGST_TextChanged);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(18, 273);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(129, 25);
            this.lblTotalAmount.TabIndex = 13;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.Location = new System.Drawing.Point(180, 273);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(148, 30);
            this.txtTotalAmount.TabIndex = 14;
            // 
            // lblAdvancePayment
            // 
            this.lblAdvancePayment.AutoSize = true;
            this.lblAdvancePayment.Location = new System.Drawing.Point(29, 413);
            this.lblAdvancePayment.Name = "lblAdvancePayment";
            this.lblAdvancePayment.Size = new System.Drawing.Size(172, 25);
            this.lblAdvancePayment.TabIndex = 15;
            this.lblAdvancePayment.Text = "Advance Payment";
            // 
            // txtAdvancePayment
            // 
            this.txtAdvancePayment.Location = new System.Drawing.Point(210, 411);
            this.txtAdvancePayment.Name = "txtAdvancePayment";
            this.txtAdvancePayment.Size = new System.Drawing.Size(148, 30);
            this.txtAdvancePayment.TabIndex = 17;
            this.txtAdvancePayment.TextChanged += new System.EventHandler(this.txtAdvancePayment_TextChanged);
            // 
            // lblRemainingPayment
            // 
            this.lblRemainingPayment.AutoSize = true;
            this.lblRemainingPayment.Location = new System.Drawing.Point(379, 413);
            this.lblRemainingPayment.Name = "lblRemainingPayment";
            this.lblRemainingPayment.Size = new System.Drawing.Size(186, 25);
            this.lblRemainingPayment.TabIndex = 18;
            this.lblRemainingPayment.Text = "Remaining Payment";
            // 
            // txtRemainingPayment
            // 
            this.txtRemainingPayment.Enabled = false;
            this.txtRemainingPayment.Location = new System.Drawing.Point(561, 410);
            this.txtRemainingPayment.Name = "txtRemainingPayment";
            this.txtRemainingPayment.Size = new System.Drawing.Size(167, 30);
            this.txtRemainingPayment.TabIndex = 21;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddNew.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btnAddNew.Location = new System.Drawing.Point(17, 23);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(187, 45);
            this.btnAddNew.TabIndex = 22;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSave.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btnSave.Location = new System.Drawing.Point(256, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 45);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.btnAddNew);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Location = new System.Drawing.Point(30, 464);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(702, 89);
            this.panel3.TabIndex = 10;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btnExit.Location = new System.Drawing.Point(505, 23);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(193, 45);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // dtPaymentdate
            // 
            this.dtPaymentdate.Location = new System.Drawing.Point(544, 13);
            this.dtPaymentdate.Name = "dtPaymentdate";
            this.dtPaymentdate.Size = new System.Drawing.Size(154, 30);
            this.dtPaymentdate.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.lblPaymentid);
            this.panel4.Controls.Add(this.dtPaymentdate);
            this.panel4.Controls.Add(this.txtPaymentid);
            this.panel4.Controls.Add(this.lblBookingid);
            this.panel4.Controls.Add(this.lblTotalAmount);
            this.panel4.Controls.Add(this.txtTotalAmount);
            this.panel4.Controls.Add(this.cbBookingid);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.lblPaymentDate);
            this.panel4.Controls.Add(this.lblPayableAmount);
            this.panel4.Controls.Add(this.txtPayableAmount);
            this.panel4.Controls.Add(this.txtGST);
            this.panel4.Controls.Add(this.lblGST);
            this.panel4.Location = new System.Drawing.Point(30, 84);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(702, 315);
            this.panel4.TabIndex = 23;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 565);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtRemainingPayment);
            this.Controls.Add(this.lblRemainingPayment);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAdvancePayment);
            this.Controls.Add(this.txtAdvancePayment);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CustomerPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerPayment";
            this.Load += new System.EventHandler(this.CustomerPayment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMSDataSet14)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerPayment;
        private System.Windows.Forms.Label lblPaymentid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPaymentid;
        private System.Windows.Forms.Label lblBookingid;
        private System.Windows.Forms.ComboBox cbBookingid;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCarid;
        private System.Windows.Forms.Label lblCarName;
        private System.Windows.Forms.Label lblCarDetails;
        private System.Windows.Forms.Label lblDname;
        private System.Windows.Forms.Label lblDriverName;
        private System.Windows.Forms.Label lblBdate;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.Label lblCid;
        private System.Windows.Forms.Label lblCname;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label lblPayableAmount;
        private System.Windows.Forms.TextBox txtPayableAmount;
        private System.Windows.Forms.Label lblGST;
        private System.Windows.Forms.TextBox txtGST;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblAdvancePayment;
        private System.Windows.Forms.TextBox txtAdvancePayment;
        private System.Windows.Forms.Label lblRemainingPayment;
        private System.Windows.Forms.TextBox txtRemainingPayment;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtPaymentdate;
        private System.Windows.Forms.Panel panel4;
        private CRMSDataSet14 cRMSDataSet14;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private CRMSDataSet14TableAdapters.BookingTableAdapter bookingTableAdapter;
        private System.Windows.Forms.Button btnExit;
    }
}