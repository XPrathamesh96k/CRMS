namespace CRMS.Transaction
{
    partial class Cancellation
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
            this.lblCancellation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCancellationid = new System.Windows.Forms.Label();
            this.txtCancellationid = new System.Windows.Forms.TextBox();
            this.lblBookingid = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCustomerid = new System.Windows.Forms.TextBox();
            this.lblCustomerid = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtBookingAdvanceAmount = new System.Windows.Forms.TextBox();
            this.lblBookingAdvanceAmount = new System.Windows.Forms.Label();
            this.dtBookingdate = new System.Windows.Forms.DateTimePicker();
            this.lblBookingdate = new System.Windows.Forms.Label();
            this.lblRefundAmount = new System.Windows.Forms.Label();
            this.txtRefundAmount = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbBookingid = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCancellation
            // 
            this.lblCancellation.AutoSize = true;
            this.lblCancellation.BackColor = System.Drawing.Color.Transparent;
            this.lblCancellation.Font = new System.Drawing.Font("Algerian", 28.2F, System.Drawing.FontStyle.Bold);
            this.lblCancellation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCancellation.Location = new System.Drawing.Point(350, 25);
            this.lblCancellation.Name = "lblCancellation";
            this.lblCancellation.Size = new System.Drawing.Size(376, 54);
            this.lblCancellation.TabIndex = 0;
            this.lblCancellation.Text = "Cancellation";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lblCancellation);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(5, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 2;
            // 
            // lblCancellationid
            // 
            this.lblCancellationid.AutoSize = true;
            this.lblCancellationid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancellationid.Location = new System.Drawing.Point(12, 141);
            this.lblCancellationid.Name = "lblCancellationid";
            this.lblCancellationid.Size = new System.Drawing.Size(140, 25);
            this.lblCancellationid.TabIndex = 3;
            this.lblCancellationid.Text = "Cancellation id";
            // 
            // txtCancellationid
            // 
            this.txtCancellationid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCancellationid.Location = new System.Drawing.Point(274, 145);
            this.txtCancellationid.Name = "txtCancellationid";
            this.txtCancellationid.Size = new System.Drawing.Size(214, 27);
            this.txtCancellationid.TabIndex = 4;
            this.txtCancellationid.TextChanged += new System.EventHandler(this.txtCancellationid_TextChanged);
            // 
            // lblBookingid
            // 
            this.lblBookingid.AutoSize = true;
            this.lblBookingid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingid.Location = new System.Drawing.Point(557, 145);
            this.lblBookingid.Name = "lblBookingid";
            this.lblBookingid.Size = new System.Drawing.Size(103, 25);
            this.lblBookingid.TabIndex = 5;
            this.lblBookingid.Text = "Booking id";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtCustomerid);
            this.panel2.Controls.Add(this.lblCustomerid);
            this.panel2.Controls.Add(this.txtTotalAmount);
            this.panel2.Controls.Add(this.lblTotalAmount);
            this.panel2.Controls.Add(this.txtCustomerName);
            this.panel2.Controls.Add(this.lblCustomerName);
            this.panel2.Controls.Add(this.txtBookingAdvanceAmount);
            this.panel2.Controls.Add(this.lblBookingAdvanceAmount);
            this.panel2.Controls.Add(this.dtBookingdate);
            this.panel2.Controls.Add(this.lblBookingdate);
            this.panel2.Location = new System.Drawing.Point(5, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(961, 152);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtCustomerid
            // 
            this.txtCustomerid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerid.Location = new System.Drawing.Point(765, 17);
            this.txtCustomerid.Name = "txtCustomerid";
            this.txtCustomerid.Size = new System.Drawing.Size(196, 27);
            this.txtCustomerid.TabIndex = 9;
            this.txtCustomerid.TextChanged += new System.EventHandler(this.txtCustomerid_TextChanged);
            // 
            // lblCustomerid
            // 
            this.lblCustomerid.AutoSize = true;
            this.lblCustomerid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerid.Location = new System.Drawing.Point(546, 19);
            this.lblCustomerid.Name = "lblCustomerid";
            this.lblCustomerid.Size = new System.Drawing.Size(117, 25);
            this.lblCustomerid.TabIndex = 8;
            this.lblCustomerid.Text = "Customer id";
            this.lblCustomerid.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(765, 119);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(196, 27);
            this.txtTotalAmount.TabIndex = 7;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(548, 118);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(129, 25);
            this.lblTotalAmount.TabIndex = 6;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(765, 69);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(196, 27);
            this.txtCustomerName.TabIndex = 5;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(546, 68);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(154, 25);
            this.lblCustomerName.TabIndex = 4;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // txtBookingAdvanceAmount
            // 
            this.txtBookingAdvanceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookingAdvanceAmount.Location = new System.Drawing.Point(269, 108);
            this.txtBookingAdvanceAmount.Name = "txtBookingAdvanceAmount";
            this.txtBookingAdvanceAmount.Size = new System.Drawing.Size(207, 27);
            this.txtBookingAdvanceAmount.TabIndex = 3;
            this.txtBookingAdvanceAmount.TextChanged += new System.EventHandler(this.txtBookingAdvanceAmount_TextChanged);
            // 
            // lblBookingAdvanceAmount
            // 
            this.lblBookingAdvanceAmount.AutoSize = true;
            this.lblBookingAdvanceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingAdvanceAmount.Location = new System.Drawing.Point(4, 107);
            this.lblBookingAdvanceAmount.Name = "lblBookingAdvanceAmount";
            this.lblBookingAdvanceAmount.Size = new System.Drawing.Size(239, 25);
            this.lblBookingAdvanceAmount.TabIndex = 2;
            this.lblBookingAdvanceAmount.Text = "Booking Advance Amount";
            // 
            // dtBookingdate
            // 
            this.dtBookingdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBookingdate.Location = new System.Drawing.Point(269, 29);
            this.dtBookingdate.Name = "dtBookingdate";
            this.dtBookingdate.Size = new System.Drawing.Size(200, 22);
            this.dtBookingdate.TabIndex = 1;
            // 
            // lblBookingdate
            // 
            this.lblBookingdate.AutoSize = true;
            this.lblBookingdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingdate.Location = new System.Drawing.Point(4, 26);
            this.lblBookingdate.Name = "lblBookingdate";
            this.lblBookingdate.Size = new System.Drawing.Size(129, 25);
            this.lblBookingdate.TabIndex = 0;
            this.lblBookingdate.Text = "Booking Date";
            // 
            // lblRefundAmount
            // 
            this.lblRefundAmount.AutoSize = true;
            this.lblRefundAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefundAmount.Location = new System.Drawing.Point(20, 378);
            this.lblRefundAmount.Name = "lblRefundAmount";
            this.lblRefundAmount.Size = new System.Drawing.Size(147, 25);
            this.lblRefundAmount.TabIndex = 8;
            this.lblRefundAmount.Text = "Refund Amount";
            // 
            // txtRefundAmount
            // 
            this.txtRefundAmount.Enabled = false;
            this.txtRefundAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefundAmount.Location = new System.Drawing.Point(274, 376);
            this.txtRefundAmount.Name = "txtRefundAmount";
            this.txtRefundAmount.Size = new System.Drawing.Size(219, 27);
            this.txtRefundAmount.TabIndex = 9;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(559, 381);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(109, 25);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(770, 382);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(196, 27);
            this.txtDescription.TabIndex = 11;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddNew.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(17, 429);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(427, 56);
            this.btnAddNew.TabIndex = 12;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSave.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(552, 429);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(429, 56);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbBookingid
            // 
            this.cbBookingid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBookingid.FormattingEnabled = true;
            this.cbBookingid.Location = new System.Drawing.Point(770, 145);
            this.cbBookingid.Name = "cbBookingid";
            this.cbBookingid.Size = new System.Drawing.Size(196, 28);
            this.cbBookingid.TabIndex = 10;
            this.cbBookingid.SelectedIndexChanged += new System.EventHandler(this.cbBookingid_SelectedIndexChanged);
            this.cbBookingid.SelectionChangeCommitted += new System.EventHandler(this.cbBookingid_SelectionChangeCommitted);
            // 
            // Cancellation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 489);
            this.ControlBox = false;
            this.Controls.Add(this.cbBookingid);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtRefundAmount);
            this.Controls.Add(this.lblRefundAmount);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblBookingid);
            this.Controls.Add(this.txtCancellationid);
            this.Controls.Add(this.lblCancellationid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Cancellation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancellation";
            this.Load += new System.EventHandler(this.Cancellation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCancellation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCancellationid;
        private System.Windows.Forms.TextBox txtCancellationid;
        private System.Windows.Forms.Label lblBookingid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBookingAdvanceAmount;
        private System.Windows.Forms.Label lblBookingAdvanceAmount;
        private System.Windows.Forms.DateTimePicker dtBookingdate;
        private System.Windows.Forms.Label lblBookingdate;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblRefundAmount;
        private System.Windows.Forms.TextBox txtRefundAmount;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCustomerid;
        private System.Windows.Forms.TextBox txtCustomerid;
        private System.Windows.Forms.ComboBox cbBookingid;
    }
}