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
    public partial class Booking : Form
    {
        Connection con = new Connection();
        string status;
        public void clear()
        {




           // txtBookingId.Text = "";
           // txtCarType.Text = "";
           // txtBookingTime.Text = "";
           // txtCarName.Text = " ";
           // //cbCustomerName.Text = "";
           // txtNoOfPassenger.Text = "";
           //// cbDriverName.Text = "";
           // txtPickUpLocation.Text = "";
           // txtReturnLocation.Text = " ";


           // txtArrivalTime.Text = " ";
           // txtDepartureTime.Text = " ";
           // txtArrivalTimeAtDestination.Text = " ";
           // txtNumberOfkm.Text = " ";
           // txtChargesPerkm.Text = " ";
           // txtTotalAmount.Text = " ";
           //// cbCarId.Text = " ";
        }

        public Booking()
        {
            InitializeComponent();
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRMSDataSet13.Car' table. You can move, or remove it, as needed.
            this.carTableAdapter1.Fill(this.cRMSDataSet13.Car);
            // TODO: This line of code loads data into the 'cRMSDataSet12.Car' table. You can move, or remove it, as needed.
            this.carTableAdapter.Fill(this.cRMSDataSet12.Car);
            // TODO: This line of code loads data into the 'cRMSDataSet11.Booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter2.Fill(this.cRMSDataSet11.Booking);
            ShowGrid();
            DriverName();
            CustomerName();
            CarId();
            

            
            
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
           // clear();
            try
            {
                //
                con.cn.Open();
                con.cmd.CommandText = "select Max(Bookingid) from Booking";
                con.cmd.Connection = con.cn;
                string str;
                con.dr = con.cmd.ExecuteReader();
                if (con.dr.Read())
                {
                    str = con.dr[0].ToString();
                    if (str == "")
                    {
                        txtBookingId.Text = "1";
                    }
                    else
                    {
                        int k = Convert.ToInt32(con.dr[0].ToString());
                        k = k + 1;
                        txtBookingId.Text = k.ToString();
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
                txtBookingId.Focus();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Close();
                con.cmd.Parameters.Clear();
                con.cn.Open();
                con.cmd.CommandText = "insert into Booking values(" + txtBookingId.Text + ", '" + txtCarType.Text + "','" + dtBookingDate.Text + "','" + txtBookingTime.Text + "','" + txtCarName.Text + "'," + cbCustomerName.SelectedValue + ", " + txtNoOfPassenger.Text + ",'" + cbDriverName.Text + "','" + txtPickUpLocation.Text + "','" + txtReturnLocation.Text + "','" + dtPickUpDate.Text + "','" + dtReturnDate.Text + "','" + txtArrivalTime.Text + "' ,'" + txtDepartureTime.Text + "' ,'" + txtArrivalTimeAtDestination.Text + "',  " + txtNumberOfkm.Text + "  , " + txtChargesPerkm.Text + ",  " + txtTotalAmount.Text + ", " + cbCarId.SelectedValue + "," + txtAdvanceAmount.Text + ")";
                con.cmd.Connection = con.cn;
                con.cmd.Parameters.AddWithValue("@p11", Convert.ToDateTime(dtBookingDate.Text).ToShortDateString());
                con.cmd.Parameters.AddWithValue("@p12", Convert.ToDateTime(dtPickUpDate.Text).ToShortDateString());
                con.cmd.Parameters.AddWithValue("@p13", Convert.ToDateTime(dtReturnDate.Text).ToShortDateString());


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

          try
            {
                string sts = "UnAvailable";
                con.cn.Close();
                con.cmd.Parameters.Clear();
                con.cn.Open();
                con.cmd.CommandText="Update Car set Carstatus='"+ sts + "' where Carid="+cbCarId.SelectedValue+"";
                con.cmd.Connection = con.cn;
                con.cmd.ExecuteNonQuery();
                clear();
                ShowGrid();

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
                con.cmd.CommandText = "Select * from Booking";
                con.cmd.Connection = con.cn;
                con.dt.Load(con.cmd.ExecuteReader());
                dgvBookingMaster.DataSource = con.dt;
                con.cn.Close();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

   

        private void txtChargesPerkm_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCarId_Click(object sender, EventArgs e)
        {

        }

        private void CarId()
        {

            try
            {
                con.cn.Close();
                con.cn.Open();
                con.dt1.Clear();
                con.dt1.Rows.Clear();
                con.cmd.CommandText = "Select Carid,Carname from Car";
                con.cmd.Connection = con.cn;
                con.dt1.Load(con.cmd.ExecuteReader());
                cbCarId.DataSource = con.dt1;
                cbCarId.DisplayMember = "CarName";
                cbCarId.ValueMember = "CarId";

            


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


        
        
    

        private void txtNumberOfkm_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a, b, TotalAmount;
                a = Convert.ToInt32(txtNumberOfkm.Text);
                b = Convert.ToInt32(txtChargesPerkm.Text);
                TotalAmount = a * b;
                txtTotalAmount.Text = TotalAmount.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "images only|*.jpeg; *.jpg; *.ping; *.Booking;";
                DialogResult result = dialog.ShowDialog();

                pbpictureBox.ImageLocation = dialog.FileName;
                txtUploadDocument.Text = dialog.FileName;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        protected void CustomerName()
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                con.dt2.Clear();
                con.dt2.Rows.Clear();
                con.cmd.CommandText = "Select * from customer";
                con.cmd.Connection = con.cn;
                con.dt2.Load(con.cmd.ExecuteReader());
                cbCustomerName.DataSource = con.dt2;
                cbCustomerName.DisplayMember = "customerName";
                cbCustomerName.ValueMember = "customerid";

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

        protected void DriverName()
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                con.dt3.Clear();
                con.dt3.Rows.Clear();
                con.cmd.CommandText = "Select * from Driver";
                con.cmd.Connection = con.cn;
                con.dt3.Load(con.cmd.ExecuteReader());
                cbDriverName.DataSource = con.dt3;
                cbDriverName.DisplayMember = "DriverName";
                cbDriverName.ValueMember = "DriverId";

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

        private void cbCarId_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cbCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCarType_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbDriverName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtArrivalTimeAtDestination_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtArrivalTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDepartureTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtReturnDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtPickUpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblReturnDate_Click(object sender, EventArgs e)
        {

        }

        private void lblPickUpDate_Click(object sender, EventArgs e)
        {

        }

        private void txtReturnLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblReturnLocation_Click(object sender, EventArgs e)
        {

        }

        private void txtNoOfPassenger_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNoOfPassenger_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPickUpLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCarType_Click(object sender, EventArgs e)
        {

        }

        private void txtCarName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblArrivalTimeAtDestination_Click(object sender, EventArgs e)
        {

        }

        private void lblDriverName_Click(object sender, EventArgs e)
        {

        }

        private void lblBookingId_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBookingId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNumberOfkm_Click(object sender, EventArgs e)
        {

        }

        private void lblArrivalTime_Click(object sender, EventArgs e)
        {

        }

        private void lblDepartureTime_Click(object sender, EventArgs e)
        {

        }

        private void lblPickUpLocation_Click(object sender, EventArgs e)
        {

        }

        private void lblCarName_Click(object sender, EventArgs e)
        {

        }

        private void lblCustomerName_Click(object sender, EventArgs e)
        {

        }

        private void cbCarId_SelectionChangeCommitted(object sender, EventArgs e)
        {

            try
            {
                con.cn.Close();
                con.cn.Open(); ;
                con.cmd.CommandText = "Select Carstatus from Car where Carid = " + cbCarId.SelectedValue + "";
                con.cmd.Connection = con.cn;
                status = Convert.ToString(con.cmd.ExecuteScalar());


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.cn.Close();
            }

            if (status == "UnAvailable")
            {
                MessageBox.Show("Currently this car was UnAvailable");
            }
            else
            {

                try
                {
                    con.cn.Close();
                    con.cn.Open(); ;
                    con.cmd.CommandText = "Select Carrent from Car where Carid = " + cbCarId.SelectedValue + "";
                    con.cmd.Connection = con.cn;
                    txtChargesPerkm.Text = Convert.ToString(con.cmd.ExecuteScalar());


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
                    con.cn.Open(); ;
                    con.cmd.CommandText = "Select Carname from Car where Carid = " + cbCarId.SelectedValue + "";
                    con.cmd.Connection = con.cn;
                    txtCarName.Text = Convert.ToString(con.cmd.ExecuteScalar());


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
                    con.cn.Open(); ;
                    con.cmd.CommandText = "Select Cartype from Car where Carid = " + cbCarId.SelectedValue + "";
                    con.cmd.Connection = con.cn;
                    txtCarType.Text = Convert.ToString(con.cmd.ExecuteScalar());


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
}

