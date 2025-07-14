using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CRMS.Master
{
    public partial class customer : Form
    {
        Connection con = new Connection();
        //SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CRMS\CRMS\CRMS.mdf;Integrated Security=True");
        //SqlCommand cmd = new SqlCommand();
       // DataTable dt = new DataTable();
        //private object pbCustomerMaster;

        public void clear()
        {
      
                txtCustomerid.Text = " ";
                txtCustomerName.Text = " ";
                txtCustomerAddress.Text = " ";
                txtCustomerNumber.Text = " ";
                txtCustomerDocuments.Text = " ";
                rdMale.Checked = false;
                rdFemale.Checked = false;
                txtCustomerAge.Text = "";
                txtCustomerLicense.Text = " ";
            }
            
        public customer()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            { 
                string str;
                con.cn.Close();
                con.cn.Open();
                con.cmd.CommandText = "Select Max(Customerid) from customer";
                con.cmd.Connection = con.cn;
                con.dr = con.cmd.ExecuteReader();
                if (con.dr.Read())
                {
                    str = con.dr[0].ToString();
                    if (str == "")
                        txtCustomerid.Text = "1";
                    else
                    {
                        int k = Convert.ToInt32(con.dr[0].ToString());
                        k = k + 1;
                        txtCustomerid.Text = k.ToString();
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
            }

            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                con.cmd.CommandText = "insert into Customer values(" + txtCustomerid.Text + ", ' " + txtCustomerName.Text + " ',' " + txtCustomerDocuments.Text + " ','" + txtCustomerAddress.Text + " ', " + txtCustomerNumber.Text + " ,@P1," + txtCustomerAge.Text  +" ,'"+ txtCustomerLicense.Text +" ')";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.cn.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Close();
                con.cmd.Parameters.Clear();
                con.cn.Open();
                con.cmd.CommandText = "update customer set  Customername= ' "+txtCustomerName.Text+ "',Customerdocuments ='" + txtCustomerDocuments.Text + "', Customeraddress = ' " + txtCustomerAddress.Text + " ' , Customernumber = " + txtCustomerNumber.Text + ",Customergender=@p1,Customerage="+txtCustomerAge.Text+",Customerlicense='"+txtCustomerLicense.Text+ "' Where Customerid = " + txtCustomerid.Text + "";
                if (rdMale.Checked == true)
                    con.cmd.Parameters.AddWithValue("@p1", rdMale.Text);
                else
                    con.cmd.Parameters.AddWithValue("@p1", rdFemale.Text);
                con.cmd.Connection = con.cn;
                con.cmd.ExecuteNonQuery();
                ShowGrid();
                clear();                
                MessageBox.Show("Data Updated");
                //ShowGrid();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                con.cmd.CommandText = "delete from Customer where Customerid =" + txtCustomerid.Text + "";
                con.cmd.Connection = con.cn;
                con.cmd.ExecuteNonQuery();
                con.cn.Close();
                clear();
                ShowGrid();
                MessageBox.Show("Data Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                con.dt.Rows.Clear();            
                con.cn.Open();
                con.cmd.CommandText = "Select * from Customer";
                con.cmd.Connection = con.cn;
                con.dt.Load(con.cmd.ExecuteReader());
                dgvCustomerMaster.DataSource = con.dt;
                con.cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void ShowField()
        { try
            {
                con.cn.Open();
                con.dt.Clear();
                con.cmd.CommandText = "Select * from customer";
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


            
            

           
        private void dgvCustomerMaster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCustomerid.Text = dgvCustomerMaster.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCustomerName.Text = dgvCustomerMaster.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCustomerDocuments.Text = dgvCustomerMaster.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtCustomerAddress.Text = dgvCustomerMaster.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtCustomerNumber.Text = dgvCustomerMaster.Rows[e.RowIndex].Cells[4].Value.ToString();
                rdMale.Text = dgvCustomerMaster.Rows[e.RowIndex].Cells[5].Value.ToString();
                rdFemale.Text = dgvCustomerMaster.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtCustomerAge.Text = dgvCustomerMaster.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtCustomerLicense.Text = dgvCustomerMaster.Rows[e.RowIndex].Cells[8].Value.ToString();

                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void customer1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRMSDataSet2.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter1.Fill(this.cRMSDataSet2.Customer);
            btnAddNew.Enabled = true;
            txtCustomerName.Focus();
            ShowGrid();
            ShowField();
        }

        private void txtCustomerDocuments_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "images only|*.jpeg; *.jpg;*.ping;*.Customer;";
                DialogResult result = dialog.ShowDialog();

                pbpictureBox.Image = Image.FromFile(dialog.FileName);
                txtCustomerDocuments.Text = dialog.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lblCustomerGender_Click(object sender, EventArgs e)
        {

        }

        private void dgvCustomerMaster_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                txtCustomerid.Text = dgvCustomerMaster.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCustomerName.Text = dgvCustomerMaster.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCustomerDocuments.Text = dgvCustomerMaster.Rows[e.RowIndex].Cells[2].Value.ToString();
                pbpictureBox.ImageLocation = txtCustomerDocuments.Text;

                txtCustomerAddress.Text = dgvCustomerMaster.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtCustomerNumber.Text = dgvCustomerMaster.Rows[e.RowIndex].Cells[4].Value.ToString();
                string gender = dgvCustomerMaster.Rows[e.RowIndex].Cells[5].Value.ToString();
                if (gender == "Male")
                    rdMale.Checked = true;
                else
                    rdFemale.Checked = true;
                txtCustomerAge.Text = dgvCustomerMaster.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtCustomerLicense.Text = dgvCustomerMaster.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtCustomerNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            con.digitonly(e);
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            con.charonly(e);
        }

        private void lblSelectOperator_Click(object sender, EventArgs e)
        {

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
                else if (txtEntervalue.Text == "")
                    MessageBox.Show("Please Enter Value", "Validation", MessageBoxButtons.OK);
                else
                {
                    if (cbSelectOperator.Text == "LIKE" || cbSelectOperator.Text == "NOT LIKE")
                    {
                        str = String.Format("{0} where {1} {2}'_{3}%'", " Select * from Customer", cbSelectColumn.Text, cbSelectOperator.Text, txtEntervalue.Text);
                        MessageBox.Show(str);
                    }
                    else if (cbSelectOperator.Text == "MASTERDATA")
                        str = String.Format("{0}", "Select * from Customer", cbSelectColumn.Text, cbSelectOperator.Text, txtEntervalue.Text);
                    else
                        str = String.Format("{0} where {1} {2} '{3}'", "Select * from Customer", cbSelectColumn.Text, cbSelectOperator.Text, txtEntervalue.Text);
                    con.cn.Close();
                    con.cn.Open();
                    con.dt.Clear();
                    con.dt.Rows.Clear();
                    con.cmd.CommandText = str;
                    con.cmd.Connection = con.cn;
                    con.dt.Load(con.cmd.ExecuteReader());
                    txtEntervalue.Clear();

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
}



