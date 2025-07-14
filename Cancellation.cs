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

    public partial class Cancellation : Form
    {
        Connection con = new Connection();
        public Cancellation()
        {
            InitializeComponent();
        }
        public void clear()
        {
            txtCancellationid.Text = "";
            cbBookingid.Text = "";
            txtCustomerName.Text = "";
          //  txtBookingAdvanceAmount.Text = "";
            txtTotalAmount.Text = "";
            txtRefundAmount.Text = "";
            txtDescription.Text = "";

        }
        private void Cancellation_Load(object sender, EventArgs e)
        {
            Bookingid();
        }
        private void Bookingid()
        {

            try
            {
                con.cn.Close();
                con.cn.Open();
                con.dt1.Clear();
                con.dt1.Rows.Clear();
                con.cmd.CommandText = "Select Bookingid,Customername from booking";
                con.cmd.Connection = con.cn;
                con.dt1.Load(con.cmd.ExecuteReader());
                cbBookingid.DataSource = con.dt1;
                cbBookingid.DisplayMember = "Bookingid";
                cbBookingid.ValueMember = "Bookingid";
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

        private void txtBookingid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                con.dt.Clear();
                con.dt.Rows.Clear();
                con.cmd.CommandText = "Select Bookingid from Booking";
                con.cmd.Connection = con.cn;
                txtCustomerName.Text = Convert.ToString(con.cmd.ExecuteScalar());


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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Close();
                con.cmd.Parameters.Clear();
                con.cn.Open();
                con.cmd.CommandText = "insert into Cancellation values("+ txtCancellationid.Text +","+ cbBookingid.SelectedValue +",'"+ dtBookingdate.Text +"',"+ txtCustomerid.Text+ ",'"+ txtCustomerName.Text +"'," + txtBookingAdvanceAmount.Text +","+ txtTotalAmount.Text +","+ txtRefundAmount.Text +",'"+ txtDescription.Text +"')";
                con.cmd.Connection = con.cn;
                con.cmd.Parameters.AddWithValue("@p11", Convert.ToDateTime(dtBookingdate.Text).ToShortDateString());
                con.cmd.ExecuteNonQuery();
                clear();
                
                con.cn.Close();
                MessageBox.Show("Data Saved");
            }
            catch(Exception ex)
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
                con.cn.Open();
                con.cmd.CommandText = "select Max(Cancellationid) from Cancellation";
                con.cmd.Connection = con.cn;
                string str;
                con.dr = con.cmd.ExecuteReader();
                if (con.dr.Read())
                {
                    str = con.dr[0].ToString();
                    if(str == "")
                    {
                        txtCancellationid.Text = "1";
                    }
                    else
                    {
                        int k = Convert.ToInt32(con.dr[0].ToString());
                        k = k + 1;
                        txtCancellationid.Text = k.ToString();
                    }

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.cn.Close();
              
            }
        }

        private void txtCancellationid_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbBookingid_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtCustomerid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBookingAdvanceAmount_TextChanged(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(txtBookingAdvanceAmount.Text);
            b = a * 20 / 100;
            txtRefundAmount.Text = b.ToString();
        }

        private void cbBookingid_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                con.cmd.CommandText = " Select Customername from Booking where Bookingid=" + cbBookingid.Text + "";
                con.cmd.Connection = con.cn;
                int n = Convert.ToInt32(con.cmd.ExecuteScalar());
                txtCustomerid.Text = n.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.cn.Close();
            }
            try
            {
                con.cn.Close();
                con.cn.Open();
                con.cmd.CommandText = " Select customername  from customer where Customerid=" + txtCustomerid.Text + "";
                con.cmd.Connection = con.cn;
                string n = Convert.ToString(con.cmd.ExecuteScalar());
                txtCustomerName.Text = n.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.cn.Close();
            }
            try
            {
                con.cn.Close();
                con.cn.Open();
                con.cmd.CommandText = " Select Advanceamount from Booking where Bookingid=" + cbBookingid.Text + "";
                con.cmd.Connection = con.cn;
                double n = Convert.ToDouble(con.cmd.ExecuteScalar());
                txtBookingAdvanceAmount.Text = n.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.cn.Close();
            }
            try
            {
                con.cn.Close();
                con.cn.Open();
                con.cmd.CommandText = " Select Totalamount from Booking where Bookingid=" + cbBookingid.Text + "";
                con.cmd.Connection = con.cn;
                double n = Convert.ToDouble(con.cmd.ExecuteScalar());
                txtTotalAmount.Text = n.ToString();
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
