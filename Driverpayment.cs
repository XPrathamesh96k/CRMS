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
    public partial class Driverpayment : Form
    {
        public Driverpayment()
        {
            InitializeComponent();
        }

        private void Driverpayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRMSDataSet20.Driverpayment' table. You can move, or remove it, as needed.
            this.driverpaymentTableAdapter.Fill(this.cRMSDataSet20.Driverpayment);

            this.reportViewer1.RefreshReport();
        }
    }
}
