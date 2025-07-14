using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMS.Admin
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }      


       
    

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //lblTime.Left = lblTime.Left - 6;
           // if (lblTime.Left < 0 - lblTime.Width)
               // lblTime.Left = panel4.Width;
            time();
        }

        private void carToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Master.Car c = new Master.Car();
            c.Show();
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Master.customer c = new Master.customer();
            c.Show();
        }

        private void driverToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Master.Driver d = new Master.Driver();
            d.Show();
        }

        private void bookingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Transaction.Booking b = new Transaction.Booking();
            b.Show();
        }

        private void cancellationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Transaction.Cancellation C = new Transaction.Cancellation();
            C.Show();
        }

        private void customerPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transaction.CustomerPayment b = new Transaction.CustomerPayment();
            b.Show();
        }

        private void driverPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transaction.DriverPayment c = new Transaction.DriverPayment();
            c.Show();
        }

        private void adminLoginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Admin.AdminLogin b = new Admin.AdminLogin();
            b.Show();
        }

        private void manageAdminToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Admin.ManageAdmin b = new Admin.ManageAdmin();
            b.Show();
        }

        private void calenderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Admin.Calender c = new Admin.Calender();
            c.Show();
        }

        private void notepadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\System32\\notepad.exe");
        }

        private void calculatorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\System32/calc.exe");
        }

        private void masterReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Report.MasterReport C = new Report.MasterReport();
            C.Show();
        }

        private void transactionReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Report.TransactionReport C = new Report.TransactionReport();
            C.Show();
        }
      public void time()
        {
           // lblDate.Text = System.DateTime.Now.ToShortDateString();
           // lblTime.Text = System.DateTime.Now.ToShortTimeString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            pictureBox3.Left = pictureBox3.Left - 8;
            if (pictureBox3.Left < 0 - pictureBox3.Width)
                pictureBox3.Left = panel4.Width;

        }

        private void carmodulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Master.Car cr = new Master.Car();
            cr.Show();
        }

        private void returnCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transaction.Returncar c = new Transaction.Returncar();
            c.Show();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Master.customer c = new Master.customer();
            c.Show();
        }

        private void driverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Master.Driver cr = new Master.Driver();
            cr.Show();
        }

        private void paymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void bookingToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Transaction.Booking cr = new Transaction.Booking();
            cr.Show();
        }

        private void cancellationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transaction.Cancellation cr = new Transaction.Cancellation();
            cr.Show();
        }

        private void driverPaymentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void driverPaymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Transaction.DriverPayment cr = new Transaction.DriverPayment();
            cr.Show();
        }

        private void paymentToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Transaction.CustomerPayment cr = new Transaction.CustomerPayment();
            cr.Show();
        }

        private void calenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin.Calender c = new Admin.Calender();
            c.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void carReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report2.Car c = new Report2.Car();
            c.Show();
        }

        private void driverReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report2.Driver c = new Report2.Driver();
            c.Show();
        }

        private void customerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report2.Customer c = new Report2.Customer();
            c.Show();
        }

        private void bookingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report2.Booking c = new Report2.Booking();
            c.Show();
        }

        private void cancellationReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report2.Cancellation c = new Report2.Cancellation();
            c.Show();
        }

        private void customerPaymentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Report2.CustomerPayment c = new Report2.CustomerPayment();
            c.Show();
        }

        private void driverPaymentToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Report2.Driverpayment c = new Report2.Driverpayment();
            c.Show();
        }

        private void returncarPaymnetToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Report2.Returncar c = new Report2.Returncar();
           c.Show();
        }

     
        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\System32\\notepad.exe");
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\System32/calc.exe");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin.Help c = new Admin.Help();
            c.Show();
        }
    }
}
    

