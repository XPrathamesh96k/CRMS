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
    public partial class Returncar : Form
    {
        Connection con = new Connection();
        //int Driverid;
        public void Showgrid()
        {
            try
            {
                //con.cn.Close();
                con.cn.Open();
                con.dt.Clear();
                con.cmd.CommandText = "Select * from ReturnCar";
                con.cmd.Connection = con.cn;
                con.dt.Load(con.cmd.ExecuteReader());
                con.cn.Close();
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
        public void Bookingid()
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                con.dt5.Clear();
                con.cmd.CommandText = "Select * from Booking";
                con.cmd.Connection = con.cn;
                con.dt5.Load(con.cmd.ExecuteReader());
                cbBookingid.DataSource = con.dt5;
                cbBookingid.DisplayMember = "Bookingid";
                cbBookingid.ValueMember = "Bookingid";
                con.cn.Close();
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
        public void DriverId()
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                con.dt6.Clear();
                con.cmd.CommandText = "Select  DriverId from Car";
                con.cmd.Connection = con.cn;
                con.dt6.Load(con.cmd.ExecuteReader());
                
                //DataSource = con.dt6;
             //   string n = Convert.ToString(con.cmd.ExecuteScalar());
                
                con.cn.Close();
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
        public void Carid()
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                con.dt7.Clear();
                con.cmd.CommandText = "Select * from Car";
                con.cmd.Connection = con.cn;
                con.dt7.Load(con.cmd.ExecuteReader());
                cbBookingid.DataSource = con.dt7;
                cbBookingid.DisplayMember = "Carname";
                cbBookingid.ValueMember = "Carid";
                con.cn.Close();
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
        public Returncar()
        {
            InitializeComponent();
        }

        private void Returncar_Load(object sender, EventArgs e)
        {
            Showgrid();
            Bookingid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Open();
                con.cmd.CommandText = "Select count (Returncarid) from ReturnCar";
                con.cmd.Connection = con.cn;
                int n = Convert.ToInt32(con.cmd.ExecuteScalar());
                n++;
                txtReturncarid.Text = n.ToString();

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

        private void txtReturncarid_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbBookingid_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        

      private void cbCarid_SelectedIndexChanged(object sender,EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Close();
                ////con.cmd.CommandText = " Insert into ReturnCar values(" + txtReturncarid.Text + "," + lblCarid.Text + "," + cbBookingid.SelectedValue + ",'" + lblBookingdate.Text + "'," + lblDrivername.Text + ",'" + dtReturndate.Text + "')";
                //con.cmd.CommandText = "insert into ReturnCar values("+txtReturncarid.Text+","+lblCarid.Text+","+cbBookingid.SelectedIndex+",'"+ label2.Text+ "',"+ lblDrivername .Text+ ",'"+ dtReturndate.Text+ "')";
                //con.cmd.Connection = con.cn;
                //string n = Convert.ToDateTime(con.cmd.ExecuteScalar()).ToShortDateString();
                ////dtReturndate.Text = n.ToString();
                ////con.cmd.Parameters.AddWithValue("@p11", Convert.ToDateTime(dtReturndate.Text).ToShortDateString());
                //con.cmd.ExecuteNonQuery();
                //con.cn.Close();
                //MessageBox.Show("Data Saved");

                con.cn.Open();
                con.cmd.Parameters.Clear();
                con.cmd.CommandText = "insert into ReturnCar values(" + txtReturncarid.Text + "," + label1.Text + "," + cbBookingid.SelectedValue + ",'" + label2.Text + "','" + lblDrivername.Text + "','" + dtReturndate.Text + "')";

                con.cmd.Connection = con.cn;
                con.cmd.ExecuteNonQuery();
                //ShowGrid();
                //clear();
                con.cn.Close();
                MessageBox.Show("Data Saved");

                btnSave.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.cn.Close();
                
            }
            try
            {
                string sts = "Available";
                con.cn.Close();
                con.cmd.Parameters.Clear();
                con.cn.Open();
                con.cmd.CommandText = "Update Car set Carstatus='" + sts + "' where Carid=" + label1.Text + "";
                con.cmd.Connection = con.cn;
                con.cmd.ExecuteNonQuery();
                

                con.cn.Close();
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

        private void cbBookingid_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                con.cmd.CommandText = "Select Bookingdate from Booking where Bookingid =" + cbBookingid.Text + "";
                con.cmd.Connection = con.cn;
                string n = Convert.ToDateTime(con.cmd.ExecuteScalar()).ToShortDateString();
                label2.Text = n;
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
                con.cmd.CommandText = "Select Drivername from Booking where Bookingid=" + cbBookingid.Text + "";
                con.cmd.Connection = con.cn;
                string nm = Convert.ToString(con.cmd.ExecuteScalar());
                lblDrivername.Text = nm;
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
                con.cmd.CommandText = "Select Carid from Booking where Bookingid =" + cbBookingid.Text + "";
                con.cmd.Connection = con.cn;
                string n = Convert.ToString(con.cmd.ExecuteScalar());
                label1.Text = n;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblReturnCar_Click(object sender, EventArgs e)
        {

        }
    }
}
