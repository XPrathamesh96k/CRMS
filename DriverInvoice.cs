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
    public partial class DriverInvoice : Form
    {
        public DriverInvoice()
        {
            InitializeComponent();
        }

        private void DriverInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRMSDataSet35.DriverInvoice' table. You can move, or remove it, as needed.
            //this.driverInvoiceTableAdapter.Fill(this.cRMSDataSet35.DriverInvoice);

            this.reportViewer1.RefreshReport();
        }

        Connection con = new Connection();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                con.da = new SqlDataAdapter("Select * From Driverpayment where Driverpayid=" + textBox1.Text + "", con.cn);
                con.da.Fill(con.dt);
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource source = new ReportDataSource("DataSet1", con.dt);
                reportViewer1.LocalReport.ReportPath = @"D:\CRMS\CRMS\Report2\DriverInvoice.rdlc";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
