namespace CRMS.Report2
{
    partial class CustomerInvoice
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.customerInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cRMSDataSet34 = new CRMS.CRMSDataSet34();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.customerInvoiceTableAdapter = new CRMS.CRMSDataSet34TableAdapters.CustomerInvoiceTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerInvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMSDataSet34)).BeginInit();
            this.SuspendLayout();
            // 
            // customerInvoiceBindingSource
            // 
            this.customerInvoiceBindingSource.DataMember = "CustomerInvoice";
            this.customerInvoiceBindingSource.DataSource = this.cRMSDataSet34;
            // 
            // cRMSDataSet34
            // 
            this.cRMSDataSet34.DataSetName = "CRMSDataSet34";
            this.cRMSDataSet34.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.customerInvoiceBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CRMS.Report2.CustomerInvoice.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 87);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1093, 558);
            this.reportViewer1.TabIndex = 0;
            // 
            // customerInvoiceTableAdapter
            // 
            this.customerInvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(431, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 37);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Id";
            // 
            // CustomerInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 645);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "CustomerInvoice";
            this.Text = "CustomerInvoice";
            this.Load += new System.EventHandler(this.CustomerInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerInvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMSDataSet34)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CRMSDataSet34 cRMSDataSet34;
        private System.Windows.Forms.BindingSource customerInvoiceBindingSource;
        private CRMSDataSet34TableAdapters.CustomerInvoiceTableAdapter customerInvoiceTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}