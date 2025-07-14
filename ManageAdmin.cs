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

namespace CRMS.Admin
{
    public partial class ManageAdmin : Form
    {
        public ManageAdmin()
        {
            InitializeComponent();
        }
        Connection con = new Connection();
        public void clear()
        {
            txtUserName.Text = " ";
            txtOldPassword.Text = " ";
            txtNewPassword.Text = " ";
            txtConfirmPassword.Text = " ";
        }
        public void ShowGrid()
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                con.dt.Clear();
                con.cmd.CommandText = "Select * from Admin";
                con.cmd.Connection = con.cn;
                con.dt.Load(con.cmd.ExecuteReader());
                dgvManageAdmin.DataSource = con.dt;
                con.cn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void lblManageAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRMSDataSet10.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.cRMSDataSet10.Admin);
            ShowGrid();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                if(txtNewPassword.Text==txtConfirmPassword.Text)
                {
                    con.cmd.CommandText = "insert into Admin values('" + txtUserName.Text + "','" + txtNewPassword.Text + "')";
                    con.cmd.Connection = con.cn;
                    con.cmd.ExecuteNonQuery();
                    clear();
                    ShowGrid();
                    con.cn.Close();
                    MessageBox.Show("Data Saved ...!");

                }
                else
                {
                    MessageBox.Show("Please check your password...!");
                }
                
              }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                if(txtNewPassword.Text == txtConfirmPassword.Text)
                {
                    con.cmd.ExecuteNonQuery();
                    clear();
                    ShowGrid();
                    con.cn.Close();
                    MessageBox.Show("Data Updated..!");
                }
                else
                {
                    MessageBox.Show("Please check your password..!");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if((MessageBox.Show("Do you want to delete?" ,"Confirmation" , MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)) == DialogResult.OK)
                {
                    con.cn.Open();
                    con.cmd.CommandText = "Delete from Login Where username=' " + txtUserName.Text + "'";
                    con.cmd.Connection = con.cn;
                    con.cmd.ExecuteNonQuery();
                    clear();
                    ShowGrid();
                    con.cn.Close();
                    MessageBox.Show("Data Deleted");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
