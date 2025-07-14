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
    public partial class CustomerPayment : Form

    {
        Connection con = new Connection();
        int id1;


        public void BookingId1()
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                con.dt3.Clear();
                con.dt3.Rows.Clear();
                con.cmd.CommandText = "Select * from Booking";
                con.cmd.Connection = con.cn;
                con.dt3.Load(con.cmd.ExecuteReader());
                cbBookingid.DataSource  = con.dt3;
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

        public void clear()
        {
            txtPaymentid.Text = "";
           // cbBookingid.Text = "";
            txtPayableAmount.Text = "";
           // txtGST.Text = "";
            txtTotalAmount.Text = "";
            txtAdvancePayment.Text = "";
            txtRemainingPayment.Text = "";

        }

        public CustomerPayment()
        {
            InitializeComponent();
        }

        private void CustomerPayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRMSDataSet14.Booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.cRMSDataSet14.Booking);
            //ShowGrid();
            BookingId1();
            // Bookingid();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void ShowGrid()
        {
            try
            {
                con.cn.Close();
                con.dt.Clear();
                con.cn.Open();
                con.cmd.CommandText = "Select * from CustomerPayment";
                con.cmd.Connection = con.cn;
                con.dt.Load(con.cmd.ExecuteReader());
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
        private void Bookingid()
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                con.dt5.Clear();
                con.dt5.Rows.Clear();
                con.cmd.CommandText = "Select * from Booking";
                con.cmd.Connection = con.cn;
                con.dt5.Load(con.cmd.ExecuteReader());
                cbBookingid.DataSource = con.dt5;
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
                

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Close();
                con.cmd.Parameters.Clear();
                con.cn.Open();
                con.cmd.CommandText = "insert into CustomerPayment values(" + txtPaymentid.Text + " ," +cbBookingid.Text+",@p11,'"+lblCname.Text+"',"+lblCid.Text+",'"+lblBdate.Text+"',' "+lblDname.Text+" '," + txtPayableAmount.Text + " , " + txtGST.Text+ "," + txtTotalAmount.Text+","+txtAdvancePayment.Text+","+txtRemainingPayment.Text+")";
                con.cmd.Connection = con.cn;
                con.cmd.Parameters.AddWithValue("@p11", Convert.ToDateTime(dtPaymentdate.Text).ToShortDateString());
                con.cmd.ExecuteNonQuery();
               // clear();
                
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

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                clear();
                con.cn.Open();
                con.cmd.CommandText = "select Max(Paymentid) from CustomerPayment";
                con.cmd.Connection = con.cn;
                string str;
                con.dr = con.cmd.ExecuteReader();
                if (con.dr.Read())
                {
                    str = con.dr[0].ToString();
                    if (str == "")
                    {
                        txtPaymentid.Text = "1";
                    }
                    else
                    {
                        int k = Convert.ToInt32(con.dr[0].ToString());
                        k = k + 1;
                        txtPaymentid.Text = k.ToString();
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
                txtPaymentid.Focus();
            }

        }

        private void txtGST_TextChanged(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtPayableAmount.Text);
            double b = Convert.ToDouble(txtGST.Text);
            double gst = b / 100;
            double c = Convert.ToDouble(a * gst);
            double d = a + c;
            txtTotalAmount.Text = d.ToString();
        }

        private void txtAdvancePayment_TextChanged(object sender, EventArgs e)
        {
            //      double = (txtAdvancePayment.Text - txtTotalAmount.Text);
           // double a = Convert.ToDouble(txtRemainingPayment.Text);
            double b = Convert.ToDouble(txtAdvancePayment.Text);
            double c = Convert.ToDouble(txtTotalAmount.Text);

            double a =  c - b;
            txtRemainingPayment.Text = a.ToString();

            //double RemainingPayment = AdvancePayment - txtTotalAmount;



        }

        private void cbBookingid_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void cbBookingid_SelectionChangeCommitted(object sender, EventArgs e)
        {

            try
            {

                lblCname.Text = "";
                con.cn.Close();
                con.cn.Open();
                con.cmd.CommandText = "Select Bookingid from Booking where Bookingid=" + cbBookingid.SelectedValue + "";
                con.cmd.Connection = con.cn;
                id1 = Convert.ToInt32(con.cmd.ExecuteScalar());
                //MessageBox.Show(id.ToString());
                //   lblCname.Text = nm.ToString();



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

                lblCname.Text = "";
                con.cn.Close();
                con.cn.Open();
                con.cmd.CommandText = "Select Carname from Booking where Bookingid=" + id1 + "";
                con.cmd.Connection = con.cn;
                string nm = Convert.ToString(con.cmd.ExecuteScalar());
                lblCname.Text = nm.ToString();



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
                lblCid.Text = " ";
                con.cn.Close();
                con.cn.Open();
                con.cmd.CommandText = "Select Carid from Booking where Bookingid=" + id1 + "";
                con.cmd.Connection = con.cn;
                int cid = Convert.ToInt32(con.cmd.ExecuteScalar());
                lblCid.Text = cid.ToString();

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
                lblBdate.Text = "";
                con.cn.Close();
                con.cn.Open();
                con.dt2.Clear();
                con.dt2.Rows.Clear();
                con.cmd.CommandText = "Select BookingDate from Booking where Bookingid=" + id1 + "";
                con.cmd.Connection = con.cn;
                string dt = Convert.ToDateTime(con.cmd.ExecuteScalar()).ToShortDateString();
                lblBdate.Text = dt;
                //lblBdate.Text = Convert.ToString(con.cmd.ExecuteScalar());


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
                lblDname.Text = "";
                con.cn.Close();
                con.cn.Open();
                con.dt.Clear();
                con.dt.Rows.Clear();
                con.cmd.CommandText = "Select DriverName from Booking where Bookingid=" + id1 + "";
                con.cmd.Connection = con.cn;
                string nm = Convert.ToString(con.cmd.ExecuteScalar());
                lblDname.Text = nm;
                //Convert.ToString(con.cmd.ExecuteScalar());

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
                con.cmd.CommandText = "Select Totalamount from Booking where Bookingid=" + id1 + "";
                con.cmd.Connection = con.cn;
                double pa = Convert.ToDouble(con.cmd.ExecuteScalar());
                txtPayableAmount.Text = pa.ToString();



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


               
                

                

               
                