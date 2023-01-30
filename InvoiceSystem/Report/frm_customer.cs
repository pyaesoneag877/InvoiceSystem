using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceSystem.Report
{
    public partial class frm_customer : Form
    {
        public frm_customer()
        {
            InitializeComponent();
        }

        private void frm_customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customer.CustomerView' table. You can move, or remove it, as needed.
            this.CustomerViewTableAdapter.Fill(this.customer.CustomerView);

            this.reportViewer1.RefreshReport();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void linkLblCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }
    }
}
