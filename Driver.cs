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
    public partial class Driver : Form
    {
        public Driver()
        {
            InitializeComponent();
        }

        private void Driver_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRMSDataSet17.Driver' table. You can move, or remove it, as needed.
            this.driverTableAdapter.Fill(this.cRMSDataSet17.Driver);

            this.reportViewer1.RefreshReport();
        }
    }
}
