namespace CRMS.Report2
{
    partial class Driverpayment
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.driverpaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cRMSDataSet20 = new CRMS.CRMSDataSet20();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.driverpaymentTableAdapter = new CRMS.CRMSDataSet20TableAdapters.DriverpaymentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.driverpaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMSDataSet20)).BeginInit();
            this.SuspendLayout();
            // 
            // driverpaymentBindingSource
            // 
            this.driverpaymentBindingSource.DataMember = "Driverpayment";
            this.driverpaymentBindingSource.DataSource = this.cRMSDataSet20;
            // 
            // cRMSDataSet20
            // 
            this.cRMSDataSet20.DataSetName = "CRMSDataSet20";
            this.cRMSDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.driverpaymentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CRMS.Report2.Driverpayment.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1164, 578);
            this.reportViewer1.TabIndex = 0;
            // 
            // driverpaymentTableAdapter
            // 
            this.driverpaymentTableAdapter.ClearBeforeFill = true;
            // 
            // Driverpayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 578);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Driverpayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Driverpayment";
            this.Load += new System.EventHandler(this.Driverpayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.driverpaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMSDataSet20)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CRMSDataSet20 cRMSDataSet20;
        private System.Windows.Forms.BindingSource driverpaymentBindingSource;
        private CRMSDataSet20TableAdapters.DriverpaymentTableAdapter driverpaymentTableAdapter;
    }
}