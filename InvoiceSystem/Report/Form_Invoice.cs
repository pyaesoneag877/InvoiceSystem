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
    public partial class Form_Invoice : Form
    {
        public Form_Invoice()
        {
            InitializeComponent();
        }

        private void Form_Invoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'invoice.InvoiceView' table. You can move, or remove it, as needed.
         
            this.InvoiceViewTableAdapter.Fill(this.invoice.InvoiceView);

            this.reportViewer1.RefreshReport();
        }

        private void linkLblReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }
    }
}
