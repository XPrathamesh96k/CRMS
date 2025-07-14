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
    public partial class Login_New : Form
    {
        string strusername, strpassword;
        Connection con = new Connection();
        public Login_New()
        {
            InitializeComponent(); 
        }
    

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Left = pictureBox2.Left - 8;
            if (pictureBox2.Left < 0 - pictureBox2.Width)
                pictureBox2.Left = panel4.Width;

        }

        private void Login_New_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Close();
                con.cn.Open();
                con.cmd.CommandText = "Select * from Admin Where Adminname='" + txtname.Text + "'";
                con.cmd.Connection = con.cn;
                con.dr = con.cmd.ExecuteReader();
                if (con.dr.HasRows)
                {
                    while (con.dr.Read())
                    {
                        strusername = con.dr.GetString(0);
                        strpassword = con.dr.GetString(1);
                    }
                }
                con.cn.Close();
                if (strusername == txtname.Text && strpassword == txtpassword.Text)
                {
                   // MessageBox.Show("Login Successfully");
                  //  this.Hide();
                    Admin.MDI md = new Admin.MDI();
                    md.Show();
                }
                else
                {
                    MessageBox.Show("Confirm your username or password", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

       
    
