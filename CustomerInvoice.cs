using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace CRMS.Report2
{
    public partial class CustomerInvoice : Form
    {
        public CustomerInvoice()
        {
            InitializeComponent();
        }

        Connection con = new Connection();

        private void CustomerInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRMSDataSet34.CustomerInvoice' table. You can move, or remove it, as needed.
            //this.customerInvoiceTableAdapter.Fill(this.cRMSDataSet34.CustomerInvoice);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                con.da = new SqlDataAdapter("Select * From CustomerPayment where Paymentid=" + textBox1.Text + "", con.cn);
                con.da.Fill(con.dt);
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource source = new ReportDataSource("DataSet1", con.dt);
                reportViewer1.LocalReport.ReportPath = @"D:\CRMS\CRMS\Report2\CustomerInvoice.rdlc";
                reportViewer1.LocalReport.DataSources.Add(source);
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.cn.Close();
            }
        }
    }
}
