namespace CRMS.Transaction
{
    partial class Returncar
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
            this.lblReturnCarid = new System.Windows.Forms.Label();
            this.lblCarid = new System.Windows.Forms.Label();
            this.lblBookingid = new System.Windows.Forms.Label();
            this.lblBookingdate = new System.Windows.Forms.Label();
            this.lblDriverid = new System.Windows.Forms.Label();
            this.lblReturndate = new System.Windows.Forms.Label();
            this.txtReturncarid = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblReturnCar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDrivername = new System.Windows.Forms.Label();
            this.cbBookingid = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtReturndate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReturnCarid
            // 
            this.lblReturnCarid.AutoSize = true;
            this.lblReturnCarid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnCarid.Location = new System.Drawing.Point(43, 149);
            this.lblReturnCarid.Name = "lblReturnCarid";
            this.lblReturnCarid.Size = new System.Drawing.Size(127, 25);
            this.lblReturnCarid.TabIndex = 0;
            this.lblReturnCarid.Text = "Return Car Id";
            // 
            // lblCarid
            // 
            this.lblCarid.AutoSize = true;
            this.lblCarid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarid.Location = new System.Drawing.Point(43, 256);
            this.lblCarid.Name = "lblCarid";
            this.lblCarid.Size = new System.Drawing.Size(65, 25);
            this.lblCarid.TabIndex = 1;
            this.lblCarid.Text = "Car Id";
            // 
            // lblBookingid
            // 
            this.lblBookingid.AutoSize = true;
            this.lblBookingid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingid.Location = new System.Drawing.Point(43, 208);
            this.lblBookingid.Name = "lblBookingid";
            this.lblBookingid.Size = new System.Drawing.Size(104, 25);
            this.lblBookingid.TabIndex = 2;
            this.lblBookingid.Text = "Booking Id";
            // 
            // lblBookingdate
            // 
            this.lblBookingdate.AutoSize = true;
            this.lblBookingdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingdate.Location = new System.Drawing.Point(43, 303);
            this.lblBookingdate.Name = "lblBookingdate";
            this.lblBookingdate.Size = new System.Drawing.Size(129, 25);
            this.lblBookingdate.TabIndex = 3;
            this.lblBookingdate.Text = "Booking Date";
            // 
            // lblDriverid
            // 
            this.lblDriverid.AutoSize = true;
            this.lblDriverid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverid.Location = new System.Drawing.Point(43, 351);
            this.lblDriverid.Name = "lblDriverid";
            this.lblDriverid.Size = new System.Drawing.Size(84, 25);
            this.lblDriverid.TabIndex = 4;
            this.lblDriverid.Text = "Driver Id";
            // 
            // lblReturndate
            // 
            this.lblReturndate.AutoSize = true;
            this.lblReturndate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturndate.Location = new System.Drawing.Point(43, 390);
            this.lblReturndate.Name = "lblReturndate";
            this.lblReturndate.Size = new System.Drawing.Size(115, 25);
            this.lblReturndate.TabIndex = 5;
            this.lblReturndate.Text = "Return Date";
            // 
            // txtReturncarid
            // 
            this.txtReturncarid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturncarid.Location = new System.Drawing.Point(317, 149);
            this.txtReturncarid.Name = "txtReturncarid";
            this.txtReturncarid.Size = new System.Drawing.Size(193, 27);
            this.txtReturncarid.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lblReturnCar);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 111);
            this.panel1.TabIndex = 7;
            // 
            // lblReturnCar
            // 
            this.lblReturnCar.AutoSize = true;
            this.lblReturnCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnCar.Location = new System.Drawing.Point(149, 34);
            this.lblReturnCar.Name = "lblReturnCar";
            this.lblReturnCar.Size = new System.Drawing.Size(224, 46);
            this.lblReturnCar.TabIndex = 0;
            this.lblReturnCar.Text = "Return Car";
            this.lblReturnCar.Click += new System.EventHandler(this.lblReturnCar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // lblDrivername
            // 
            this.lblDrivername.AutoSize = true;
            this.lblDrivername.Location = new System.Drawing.Point(321, 351);
            this.lblDrivername.Name = "lblDrivername";
            this.lblDrivername.Size = new System.Drawing.Size(46, 17);
            this.lblDrivername.TabIndex = 10;
            this.lblDrivername.Text = "label3";
            // 
            // cbBookingid
            // 
            this.cbBookingid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBookingid.FormattingEnabled = true;
            this.cbBookingid.Location = new System.Drawing.Point(317, 205);
            this.cbBookingid.Name = "cbBookingid";
            this.cbBookingid.Size = new System.Drawing.Size(193, 28);
            this.cbBookingid.TabIndex = 11;
            this.cbBookingid.SelectedIndexChanged += new System.EventHandler(this.cbBookingid_SelectedIndexChanged);
            this.cbBookingid.SelectionChangeCommitted += new System.EventHandler(this.cbBookingid_SelectionChangeCommitted);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(48, 454);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(199, 50);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(311, 454);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(199, 50);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtReturndate
            // 
            this.dtReturndate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtReturndate.Location = new System.Drawing.Point(324, 393);
            this.dtReturndate.Name = "dtReturndate";
            this.dtReturndate.Size = new System.Drawing.Size(167, 22);
            this.dtReturndate.TabIndex = 29;
            // 
            // Returncar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 529);
            this.Controls.Add(this.dtReturndate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbBookingid);
            this.Controls.Add(this.lblDrivername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtReturncarid);
            this.Controls.Add(this.lblReturndate);
            this.Controls.Add(this.lblDriverid);
            this.Controls.Add(this.lblBookingdate);
            this.Controls.Add(this.lblBookingid);
            this.Controls.Add(this.lblCarid);
            this.Controls.Add(this.lblReturnCarid);
            this.Name = "Returncar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Returncar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReturnCarid;
        private System.Windows.Forms.Label lblCarid;
        private System.Windows.Forms.Label lblBookingid;
        private System.Windows.Forms.Label lblBookingdate;
        private System.Windows.Forms.Label lblDriverid;
        private System.Windows.Forms.Label lblReturndate;
        private System.Windows.Forms.TextBox txtReturncarid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblReturnCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDrivername;
        private System.Windows.Forms.ComboBox cbBookingid;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtReturndate;
    }
}