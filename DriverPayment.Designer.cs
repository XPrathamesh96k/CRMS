namespace CRMS.Transaction
{
    partial class DriverPayment
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDriverPayment = new System.Windows.Forms.Label();
            this.cRMSDataSet4 = new CRMS.CRMSDataSet4();
            this.driverpaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDriverPayid = new System.Windows.Forms.TextBox();
            this.txtTotalPayment = new System.Windows.Forms.TextBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.lblDriverid = new System.Windows.Forms.Label();
            this.lblDriverPayid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.driverpaymentTableAdapter = new CRMS.CRMSDataSet4TableAdapters.DriverpaymentTableAdapter();
            this.dtMonth = new System.Windows.Forms.DateTimePicker();
            this.cbDriverid = new System.Windows.Forms.ComboBox();
            this.lblAdvancepay = new System.Windows.Forms.Label();
            this.lblTotalamount = new System.Windows.Forms.Label();
            this.txtAdvancepay = new System.Windows.Forms.TextBox();
            this.txtTotalamount = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cRMSDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverpaymentBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.lblDriverPayment);
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 113);
            this.panel2.TabIndex = 37;
            // 
            // lblDriverPayment
            // 
            this.lblDriverPayment.AutoSize = true;
            this.lblDriverPayment.BackColor = System.Drawing.Color.Transparent;
            this.lblDriverPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDriverPayment.Font = new System.Drawing.Font("Algerian", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverPayment.ForeColor = System.Drawing.Color.Transparent;
            this.lblDriverPayment.Location = new System.Drawing.Point(102, 32);
            this.lblDriverPayment.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDriverPayment.Name = "lblDriverPayment";
            this.lblDriverPayment.Size = new System.Drawing.Size(387, 48);
            this.lblDriverPayment.TabIndex = 0;
            this.lblDriverPayment.Text = "Driver Payment";
            // 
            // cRMSDataSet4
            // 
            this.cRMSDataSet4.DataSetName = "CRMSDataSet4";
            this.cRMSDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // driverpaymentBindingSource
            // 
            this.driverpaymentBindingSource.DataMember = "Driverpayment";
            this.driverpaymentBindingSource.DataSource = this.cRMSDataSet4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnAddNew);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(363, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 213);
            this.panel1.TabIndex = 35;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddNew.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btnAddNew.Location = new System.Drawing.Point(33, 13);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(170, 46);
            this.btnAddNew.TabIndex = 17;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btnExit.Location = new System.Drawing.Point(33, 147);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(170, 45);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSave.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.btnSave.Location = new System.Drawing.Point(33, 82);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(170, 41);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDriverPayid
            // 
            this.txtDriverPayid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriverPayid.Location = new System.Drawing.Point(182, 162);
            this.txtDriverPayid.Margin = new System.Windows.Forms.Padding(5);
            this.txtDriverPayid.Name = "txtDriverPayid";
            this.txtDriverPayid.Size = new System.Drawing.Size(168, 30);
            this.txtDriverPayid.TabIndex = 34;
            // 
            // txtTotalPayment
            // 
            this.txtTotalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPayment.Location = new System.Drawing.Point(182, 281);
            this.txtTotalPayment.Margin = new System.Windows.Forms.Padding(5);
            this.txtTotalPayment.Name = "txtTotalPayment";
            this.txtTotalPayment.Size = new System.Drawing.Size(168, 30);
            this.txtTotalPayment.TabIndex = 32;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(9, 346);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(79, 29);
            this.lblMonth.TabIndex = 26;
            this.lblMonth.Text = "Month";
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.AutoSize = true;
            this.lblTotalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPayment.Location = new System.Drawing.Point(7, 282);
            this.lblTotalPayment.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(138, 25);
            this.lblTotalPayment.TabIndex = 25;
            this.lblTotalPayment.Text = "Total Payment";
            // 
            // lblDriverid
            // 
            this.lblDriverid.AutoSize = true;
            this.lblDriverid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverid.Location = new System.Drawing.Point(9, 221);
            this.lblDriverid.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDriverid.Name = "lblDriverid";
            this.lblDriverid.Size = new System.Drawing.Size(63, 25);
            this.lblDriverid.TabIndex = 24;
            this.lblDriverid.Text = "Driver";
            // 
            // lblDriverPayid
            // 
            this.lblDriverPayid.AutoSize = true;
            this.lblDriverPayid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverPayid.Location = new System.Drawing.Point(9, 163);
            this.lblDriverPayid.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDriverPayid.Name = "lblDriverPayid";
            this.lblDriverPayid.Size = new System.Drawing.Size(117, 25);
            this.lblDriverPayid.TabIndex = 23;
            this.lblDriverPayid.Text = "Driver Payid";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 263);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 22;
            // 
            // driverpaymentTableAdapter
            // 
            this.driverpaymentTableAdapter.ClearBeforeFill = true;
            // 
            // dtMonth
            // 
            this.dtMonth.Location = new System.Drawing.Point(182, 346);
            this.dtMonth.Name = "dtMonth";
            this.dtMonth.Size = new System.Drawing.Size(168, 22);
            this.dtMonth.TabIndex = 1;
            // 
            // cbDriverid
            // 
            this.cbDriverid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDriverid.FormattingEnabled = true;
            this.cbDriverid.Location = new System.Drawing.Point(182, 222);
            this.cbDriverid.Name = "cbDriverid";
            this.cbDriverid.Size = new System.Drawing.Size(168, 28);
            this.cbDriverid.TabIndex = 38;
            this.cbDriverid.SelectedIndexChanged += new System.EventHandler(this.cbDriverid_SelectedIndexChanged);
            // 
            // lblAdvancepay
            // 
            this.lblAdvancepay.AutoSize = true;
            this.lblAdvancepay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvancepay.Location = new System.Drawing.Point(11, 406);
            this.lblAdvancepay.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAdvancepay.Name = "lblAdvancepay";
            this.lblAdvancepay.Size = new System.Drawing.Size(129, 25);
            this.lblAdvancepay.TabIndex = 39;
            this.lblAdvancepay.Text = "Advance Pay";
            // 
            // lblTotalamount
            // 
            this.lblTotalamount.AutoSize = true;
            this.lblTotalamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalamount.Location = new System.Drawing.Point(12, 461);
            this.lblTotalamount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTotalamount.Name = "lblTotalamount";
            this.lblTotalamount.Size = new System.Drawing.Size(129, 25);
            this.lblTotalamount.TabIndex = 40;
            this.lblTotalamount.Text = "Total Amount";
            // 
            // txtAdvancepay
            // 
            this.txtAdvancepay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvancepay.Location = new System.Drawing.Point(182, 401);
            this.txtAdvancepay.Margin = new System.Windows.Forms.Padding(5);
            this.txtAdvancepay.Name = "txtAdvancepay";
            this.txtAdvancepay.Size = new System.Drawing.Size(168, 30);
            this.txtAdvancepay.TabIndex = 41;
            this.txtAdvancepay.TextChanged += new System.EventHandler(this.txtAdvancepay_TextChanged);
            // 
            // txtTotalamount
            // 
            this.txtTotalamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalamount.Location = new System.Drawing.Point(182, 459);
            this.txtTotalamount.Margin = new System.Windows.Forms.Padding(5);
            this.txtTotalamount.Name = "txtTotalamount";
            this.txtTotalamount.Size = new System.Drawing.Size(168, 30);
            this.txtTotalamount.TabIndex = 42;
            // 
            // DriverPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 504);
            this.ControlBox = false;
            this.Controls.Add(this.txtTotalamount);
            this.Controls.Add(this.txtAdvancepay);
            this.Controls.Add(this.lblTotalamount);
            this.Controls.Add(this.lblAdvancepay);
            this.Controls.Add(this.cbDriverid);
            this.Controls.Add(this.dtMonth);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDriverPayid);
            this.Controls.Add(this.txtTotalPayment);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblTotalPayment);
            this.Controls.Add(this.lblDriverid);
            this.Controls.Add(this.lblDriverPayid);
            this.Controls.Add(this.label1);
            this.Name = "DriverPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DriverPayment";
            this.Load += new System.EventHandler(this.DriverPayment_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cRMSDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverpaymentBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDriverPayment;
        private CRMSDataSet4 cRMSDataSet4;
        private System.Windows.Forms.BindingSource driverpaymentBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDriverPayid;
        private System.Windows.Forms.TextBox txtTotalPayment;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblTotalPayment;
        private System.Windows.Forms.Label lblDriverid;
        private System.Windows.Forms.Label lblDriverPayid;
        private System.Windows.Forms.Label label1;
        private CRMSDataSet4TableAdapters.DriverpaymentTableAdapter driverpaymentTableAdapter;
        private System.Windows.Forms.DateTimePicker dtMonth;
        private System.Windows.Forms.ComboBox cbDriverid;
        private System.Windows.Forms.Label lblAdvancepay;
        private System.Windows.Forms.Label lblTotalamount;
        private System.Windows.Forms.TextBox txtAdvancepay;
        private System.Windows.Forms.TextBox txtTotalamount;
    }
}