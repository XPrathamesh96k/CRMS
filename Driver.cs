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
using System.Text.RegularExpressions;

namespace CRMS.Master
{
    public partial class Driver : Form
    {
        Connection con = new Connection();
        //SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CRMS\CRMS\CRMS.mdf;Integrated Security=True");
        //SqlCommand cmd = new SqlCommand();
        //DataTable dt = new DataTable();
       

        public Driver()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Driver_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRMSDataSet6.Driver' table. You can move, or remove it, as needed.
            // this.driverTableAdapter.Fill(this.cRMSDataSet6.Driver);
            ShowGrid();
            ShowField();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDriverMaster_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtDriverId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtDriverName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDriverDocument.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                txtDriverLicence.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDriverExperience.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDriverPhoto.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                pbDriverMaster.ImageLocation = txtDriverPhoto.Text;

                txtDriverAge.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                dtDriverJoiningDate.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtDriverAdhaarCard.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                string gender = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                if (gender == "Male")
                    rdMale.Checked = true;
                else
                    rdFemale.Checked = true;
                txtDriverAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                txtDriverEmailId.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                txtDriverNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();

                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                string str;
                con.cn.Close();
                con.cn.Open();
                con.cmd.CommandText = "Select count (Driverid) from Driver";
                con.cmd.Connection = con.cn;
                con.dr = con.cmd.ExecuteReader();
                if(con.dr.Read())
                {
                    str = con.dr[0].ToString();
                    if (str == " ")
                        txtDriverId.Text = "1";
                    else
                    {
                        int k = Convert.ToInt32(con.dr[0].ToString());
                        k = k + 1;
                        txtDriverId.Text = k.ToString();
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
            }
            btnSave.Enabled = true;
         }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string email = txtDriverEmailId.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
           
            {

                try
                {
                    if (txtDriverName.Text == "")
                        MessageBox.Show("Please Enter Driver Name", "Alert");

                    else if (txtDriverAddress.Text == "")
                        MessageBox.Show("Please Enter Driver Address", "Alert");

                    else if (txtDriverEmailId.Text == "")
                        MessageBox.Show("Please Enter Driver Email Id", "Alert");

                    else if (txtDriverDocument.Text == "")
                        MessageBox.Show("Please Enter Driver Document Id", "Alert");

                    else if (txtDriverLicence.Text == "")
                        MessageBox.Show("Please Enter Driver Licence Id", "Alert");

                    else if (txtDriverExperience.Text == "")
                        MessageBox.Show("Please Enter Driver Expirience Id", "Alert");

                    else if (dtDriverJoiningDate.Text == "")
                        MessageBox.Show("Please Enter Driver joining Date Id", "Alert");

                    else if (txtDriverAge.Text == "")
                        MessageBox.Show("Please Enter gender", "Alert");

                    else if (rdMale.Checked == false && rdFemale.Checked == false)
                        MessageBox.Show("Please Enter gender", "Alert");


                    else if (txtDriverAdhaarCard.Text == "")
                        MessageBox.Show("Please Enter Driver Adhaar card", "Alert");

                    else if (txtDriverEmailId.Text == "")
                        MessageBox.Show("Please Enter Driver Email Id", "Alert");

                    else if (txtDriverNumber.Text == "")
                        MessageBox.Show("Please Enter Driver Number", "Alert");

                    else if (txtDriverPhoto.Text == "")
                        MessageBox.Show("Please Enter Driver photo", "Alert");




                    else if (match.Success)
                    {




                        con.cn.Open();
                        con.cmd.Parameters.Clear();
                        con.cmd.CommandText = "insert into Driver values(" + txtDriverId.Text + ",'" + txtDriverName.Text + "', '" + txtDriverDocument.Text + "','" + txtDriverLicence.Text + "', '" + txtDriverExperience.Text + "','" + txtDriverPhoto.Text + "', " + txtDriverAge.Text + ",'" + dtDriverJoiningDate.Text + "', " + txtDriverAdhaarCard.Text + ", @p1 ,'" + txtDriverAddress.Text + "','" + txtDriverEmailId.Text + "'," + txtDriverNumber.Text + ")";
                        if (rdMale.Checked == true)
                            con.cmd.Parameters.AddWithValue("@P1", rdMale.Text);
                        else
                            con.cmd.Parameters.AddWithValue("@P1", rdFemale.Text);
                        con.cmd.Connection = con.cn;
                        con.cmd.ExecuteNonQuery();
                        ShowGrid();
                        clear();
                        con.cn.Close();
                        MessageBox.Show("Data Saved");
                    }
                    else
                    {
                        MessageBox.Show("Envalid Email Address .. ", "Alert");
                    }
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
        private void ShowGrid()
        {
            try
            {
                con.cn.Close();
                con.dt.Clear();
                con.cn.Open();
                con.cmd.CommandText = "Select * from Driver";
                con.cmd.Connection = con.cn;
                con.dt.Load(con.cmd.ExecuteReader());
                dataGridView1.DataSource = con.dt;
                con.cn.Close();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void ShowField()
        {
            try
            {
                con.cn.Open();
                con.dt.Clear();
                con.cmd.CommandText = "Select * from Driver";
                con.cmd.Connection = con.cn;
                con.dt.Load(con.cmd.ExecuteReader());
                foreach (DataColumn dc in con.dt.Columns)
                {
                    cbSelectColumn.Items.Add(dc.ColumnName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void clear()
        {
            txtDriverId.Text = "";
            txtDriverName.Text = "";
            txtDriverDocument.Text = "";
            
            txtDriverLicence.Text = "";
            txtDriverExperience.Text = "";
            txtDriverPhoto.Text = "";
            txtDriverAge.Text = "";
            dtDriverJoiningDate.Text = "";
            txtDriverAdhaarCard.Text = "";
            rdMale.Checked = false;
            rdFemale.Checked = false;
            txtDriverAddress.Text = "";
            txtDriverEmailId.Text = "";
            txtDriverNumber.Text = "";
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Open();
                con.cmd.Parameters.Clear();
                con.cmd.CommandText = "update Driver set DriverName= '" + txtDriverName.Text + "', DriverDocument='" + txtDriverDocument.Text + "',DriverLicense='" + txtDriverLicence.Text + "',Driverexperience='" + txtDriverExperience.Text + "',Driverphoto='" + txtDriverPhoto.Text + "',Driverage=" + txtDriverAge.Text + ",Driverjoiningdate='" + dtDriverJoiningDate.Text + "',Driveradhaarcard='" + txtDriverAdhaarCard.Text + "',Drivergender=@p1,Driveraddress='" + txtDriverAddress.Text + "',Driveremailid='" + txtDriverEmailId.Text + "',Drivernumber=" + txtDriverNumber.Text + " Where Driverid=" + txtDriverId.Text + "";
                if (rdMale.Checked == true)
                    con.cmd.Parameters.AddWithValue("@p1", rdMale.Text);
                else
                    con.cmd.Parameters.AddWithValue("@p1", rdFemale.Text);
                con.cmd.Connection = con.cn;
                con.cmd.ExecuteNonQuery(); 
                clear();
                MessageBox.Show("Data Updated");
                ShowGrid();

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Open();
                con.cmd.CommandText = "Delete from Driver where Driverid=" + txtDriverId.Text + "";
                con.cmd.Connection = con.cn;
                con.cmd.ExecuteNonQuery();
                con.cn.Close();
                clear();
                ShowGrid();
                MessageBox.Show("Data Deleted");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
     
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "images only |*.jpeg; *.jpg; *.ping; *.Driver;";
                DialogResult result = dialog.ShowDialog();
                pbDriverMaster.Image = Image.FromFile(dialog.FileName);
                txtDriverPhoto.Text = dialog.FileName;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnUploadDocument_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "images only |*.jpeg; *.jpg; *.ping; *.Driver;";
                DialogResult result = dialog.ShowDialog();

                txtDriverDocument.Text = dialog.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string str;
            try
            {
                if (cbSelectColumn.Text == "")
                    MessageBox.Show("Please Select Column", "Validation", MessageBoxButtons.OK);
                else if (cbSelectOperator.Text == "")
                    MessageBox.Show("Please Select", "Validation", MessageBoxButtons.OK);
                else if (txtEnterValue.Text == "")
                    MessageBox.Show("Please Enter Value", "Validation", MessageBoxButtons.OK);
                else
                {
                    if (cbSelectOperator.Text == "LIKE" || cbSelectOperator.Text == "NOT LIKE")
                    {
                        str = String.Format("{0} where {1} {2} '{3}%'", " Select * from Driver", cbSelectColumn.Text, cbSelectOperator.Text, txtEnterValue.Text);
                    }
                    else if (cbSelectOperator.Text == "MASTERDATA")
                        str = String.Format("{0}", "Select * from Driver", cbSelectColumn.Text, cbSelectOperator.Text, txtEnterValue.Text);
                    else
                        str = String.Format("{0} where {1}{2} '{3}'", "Select * from Driver", cbSelectColumn.Text, cbSelectOperator.Text, txtEnterValue.Text);
                    con.cn.Close();
                    con.cn.Open();
                    con.dt.Clear();
                    con.dt.Rows.Clear();
                    con.cmd.CommandText = str;
                    con.cmd.Connection = con.cn;
                    con.dt.Load(con.cmd.ExecuteReader());
                    txtEnterValue.Clear();

                    

                }
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

        private void lblSelectColumn_Click(object sender, EventArgs e)
        {

        }

        private void lblEnterValue_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtDriverEmailId_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
    

