﻿using System;
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
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
        }

        private void MasterReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRMSDataSet15.Car' table. You can move, or remove it, as needed.
            this.carTableAdapter.Fill(this.cRMSDataSet15.Car);

            this.reportViewer1.RefreshReport();
        }
    }
}
