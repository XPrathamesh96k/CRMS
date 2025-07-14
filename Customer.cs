using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMS.Report2
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRMSDataSet16.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.cRMSDataSet16.Customer);

            this.reportViewer1.RefreshReport();
        }
    }
}
