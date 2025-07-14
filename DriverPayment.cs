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

namespace CRMS.Transaction
{
    public partial class DriverPayment : Form
    {
        Connection con = new Connection();
        public void clear()
        {
            txtDriverPayid.Text = " ";
           cbDriverid.Text = " ";
            txtTotalPayment.Text = " ";
           // dtMonth.Text = " ";
            //txtAdvancepay.Text = " ";
            txtTotalamount.Text = " ";
          //  txtAdvancePay.Text = " ";
            //txtTotalAmount.Text = " ";
        }
        public DriverPayment()
        {
            InitializeComponent();
        }

        protected void Driverid()
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                con.dt6.Clear();
                con.dt6.Rows.Clear();
                con.cmd.CommandText = "Select * from Driver";
                con.cmd.Connection = con.cn;
                con.dt6.Load(con.cmd.ExecuteReader());
                cbDriverid.DataSource = con.dt6;
                cbDriverid.DisplayMember = "Drivername";
                cbDriverid.ValueMember = "Driverid";

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

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                //clear();
                con.cn.Open();
                con.cmd.CommandText = "Select Max(DriverPayid) from DriverPayment";
                con.cmd.Connection = con.cn;
                string str;
                con.dr = con.cmd.ExecuteReader();
                if (con.dr.Read())
                {
                    str = con.dr[0].ToString();
                    if (str == "")
                    {
                        txtDriverPayid.Text = "1";
                    }
                    else
                    {
                        int k = Convert.ToInt32(con.dr[0].ToString());
                        k = k + 1;
                        txtDriverPayid.Text = k.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.cn.Close();
                btnSave.Enabled = true;
                txtDriverPayid.Focus();
            }
        }

        private void DriverPayment_Load(object sender, EventArgs e)
        {
            Driverid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Close();
                con.cmd.Parameters.Clear();
                con.cn.Open();
                con.cmd.CommandText = "insert into DriverPayment values(" + txtDriverPayid.Text + "," + cbDriverid.SelectedValue + "," + txtTotalPayment.Text + ",'" + dtMonth.Text + "',"+txtAdvancepay.Text+ ","+txtTotalamount.Text+")";
                con.cmd.Connection = con.cn;
                con.cmd.Parameters.AddWithValue("@p11",Convert.ToDateTime(dtMonth.Text).ToShortDateString());
                con.cmd.ExecuteNonQuery();
                clear();
                ShowGrid();
                con.cn.Close();
                MessageBox.Show("Data Saved");
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ShowGrid()
        {
            try
            {
                con.cn.Close();
                con.dt.Clear();
                con.cn.Open();
                con.cmd.CommandText = "Select * from DriverPayment";
                con.cmd.Connection = con.cn;
                con.dt.Load(con.cmd.ExecuteReader());
             //   dataGridView1.DataSource = con.dt;
                con.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbDriverid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtAdvancepay_TextChanged(object sender, EventArgs e)
        {
            if (txtAdvancepay.Text == "")
            {
                MessageBox.Show("Please Enter Advance Payment Amount!!", "Alert!!");
            }
            else
            {
                int n = Convert.ToInt32(txtAdvancepay.Text);
                int n1 = Convert.ToInt32(txtTotalPayment.Text);

                int total = n + n1;
                txtTotalamount.Text = total.ToString();
            }
        }
    }
}
