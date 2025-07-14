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

namespace CRMS.Master
{
    public partial class Car : Form
    {
        Connection con = new Connection();
       // SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CRMS\CRMS\CRMS.mdf;Integrated Security=True");
        //SqlCommand cmd = new SqlCommand();
        //DataTable dt = new DataTable();
        //private object pbCarMaster;
        public Car()
        {
            InitializeComponent();
        }

        private void lblCarPlatenumber_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                string str;
                con.cn.Close();
                
                con.cn.Open();
                con.cmd.CommandText = "Select count(Carid) from Car";
                con.cmd.Connection = con.cn;
                con.dr = con.cmd.ExecuteReader();
                if(con.dr.Read())
                {
                    str = con.dr[0].ToString();
                    if (str == " ")
                        txtCarid.Text = "1";
                    else
                    {
                        int k = Convert.ToInt32(con.dr[0].ToString());
                        k = k + 1;
                        txtCarid.Text = k.ToString();
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
            try
            {
                con.cn.Open();
                con.cmd.CommandText = "insert into Car values(" + txtCarid.Text + ", ' " + txtCarName.Text + " ',' " + txtCarCompany.Text + " ','" + txtCarPlatenumber.Text + " ', '" + txtCarfueltype.Text + "' ,' " + txtCarcolor.Text + " ','" + txtCarType.Text + "' ,'" + txtCarSeater.Text + " ','" + txtCarAverage.Text + "','" + txtCarEngine.Text + "','" + txtCarImage.Text + "'," + txtCarRent.Text + ",'" + txtCarStatus.Text + "')";
                con.cmd.Connection = con.cn;
                con.cmd.ExecuteNonQuery();
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

        private void ShowGrid()
        {
            try
            {
                con.cn.Close();
                con.dt.Clear();
                con.cn.Open();
                con.cmd.CommandText = "select * from Car";
                con.cmd.Connection = con.cn;
                con.dt.Load(con.cmd.ExecuteReader());
                dgvCarMaster.DataSource = con.dt;
                con.cn.Close();
            }
            catch (Exception ex)
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
                con.cmd.CommandText = "Select * from Car";
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
       
                txtCarid.Text = "";
                txtCarName.Text = "";
                txtCarCompany.Text = "";
                txtCarPlatenumber.Text = "";
                txtCarfueltype.Text = "";
                txtCarcolor.Text = "";
                txtCarType.Text = "";
                txtCarSeater.Text = "";
                txtCarAverage.Text = "";
                txtCarEngine.Text = "";
                txtCarImage.Text = "";
                txtCarRent.Text = "";
                txtCarStatus.Text = "";
        }
    

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                con.cmd.CommandText = "update Car set Carname= '" + txtCarName.Text + "', Carcompany = '" + txtCarCompany.Text + " ',Carplatenumber='" + txtCarPlatenumber.Text + "', Carfueltype='" + txtCarfueltype.Text + " ',Carcolor='" + txtCarcolor.Text + "',Cartype='" + txtCarType.Text + "',Carseater='" + txtCarSeater.Text + "',Caraverage='" + txtCarAverage.Text + "',Carengine='" + txtCarEngine.Text + "' ,Carimage='" + txtCarImage.Text + "',Carrent='" + txtCarRent.Text + "',Carstatus='" + txtCarStatus.Text + "' Where Carid='" + txtCarid.Text + "'";
                con.cmd.Connection = con.cn;
                con.cmd.ExecuteNonQuery();
                clear();
                MessageBox.Show("Data Updated");
                ShowGrid();
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



        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.cn.Close();
            con.cn.Open();
            con.cmd.CommandText="Delete from Car where Carid= "+txtCarid.Text+"";
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

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Car_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRMSDataSet8.Car' table. You can move, or remove it, as needed.
            //this.carTableAdapter1.Fill(cRMSDataSet8.Car);
            // TODO: This line of code loads data into the 'cRMSDataSet7.Car' table. You can move, or remove it, as needed.
            //this.carTableAdapter.Fill(this.cRMSDataSet7.Car);
            ShowGrid();
            ShowField();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image only|*.jpeg; *.jpg;*.png;*.gif;";
                DialogResult result = dialog.ShowDialog();

                pictureBox1.Image  = Image.FromFile(dialog.FileName);
                txtCarImage.Text = dialog.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvCarMaster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
         }

        private void txtCarcolor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvCarMaster_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCarid.Text = dgvCarMaster.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCarName.Text = dgvCarMaster.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCarCompany.Text = dgvCarMaster.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtCarPlatenumber.Text = dgvCarMaster.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtCarfueltype.Text = dgvCarMaster.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtCarcolor.Text = dgvCarMaster.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtCarType.Text = dgvCarMaster.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtCarSeater.Text = dgvCarMaster.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtCarAverage.Text = dgvCarMaster.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtCarEngine.Text = dgvCarMaster.Rows[e.RowIndex].Cells[9].Value.ToString();

                txtCarImage.Text = dgvCarMaster.Rows[e.RowIndex].Cells[10].Value.ToString();
                pictureBox1.ImageLocation = txtCarImage.Text;

                txtCarRent.Text = dgvCarMaster.Rows[e.RowIndex].Cells[11].Value.ToString();
                txtCarStatus.Text = dgvCarMaster.Rows[e.RowIndex].Cells[12].Value.ToString();
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
                con.cn.Close();
                
                if (cbSelectColumn.Text == "")
                    MessageBox.Show("Please Select Column", "Validation", MessageBoxButtons.OK);
                else if (cbSelectOperator.Text == "")
                    MessageBox.Show("Please Select ", "Validation", MessageBoxButtons.OK);
                else if (txtEnterValue.Text == "")
                    MessageBox.Show("Please Enter Value ", "Validation", MessageBoxButtons.OK);
                else
                {
                    if (cbSelectOperator.Text == "LIKE" || cbSelectOperator.Text == "NOT LIKE")
                    {
                        str = String.Format("{0} where {1} {2} '_{3}%'", "Select * from Car", cbSelectColumn.Text, cbSelectOperator.Text, txtEnterValue.Text);
                        //MessageBox.Show(str);
                    }
                    else if (cbSelectOperator.Text == "MASTERDATA")
                        str = String.Format("{0}", "Select * from Car", cbSelectColumn.Text, cbSelectOperator.Text, txtEnterValue.Text);
                    else
                        str = String.Format("{0} where {1}{2}'{3}'", "Select * from Car", cbSelectColumn.Text, cbSelectOperator.Text, txtEnterValue.Text);
                    con.cn.Open();                    
                    con.dt.Clear();
                    con.dt.Rows.Clear();
                    con.cmd.CommandText = str;
                    con.cmd.Connection = con.cn;
                    con.dt.Load(con.cmd.ExecuteReader());
                    txtEnterValue.Clear();

                    dgvCarMaster.DataSource = con.dt;
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

        private void txtCarStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}











































































































































































































































































































































































































































































































































































































































    

