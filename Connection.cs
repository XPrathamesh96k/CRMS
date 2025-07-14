using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace CRMS
{
    public class Connection
    {
        public ReportDocument crpt = new ReportDocument();
        public SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CRMS\CRMS\CRMS.mdf;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        public DataTable dt = new DataTable();
        public DataTable dt1 = new DataTable();
        public DataTable dt2 = new DataTable();
        public DataTable dt3 = new DataTable();
        public DataTable dt4 = new DataTable();
        public DataTable dt5 = new DataTable();
        public DataTable dt6 = new DataTable();
        public DataTable dt7 = new DataTable();

        public SqlDataReader dr;
        public SqlDataAdapter da = new SqlDataAdapter();
        public DataSet ds = new DataSet();

        public void digitonly(KeyPressEventArgs e)
        {
            try
            {
                if(!(char.IsDigit(e.KeyChar))|| char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Enter digit only", "Alert");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void charonly(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Enter char only", "Alert");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
