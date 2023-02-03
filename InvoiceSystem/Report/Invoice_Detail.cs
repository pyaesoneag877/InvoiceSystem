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
    public partial class Invoice_Detail : Form
    {
        public Invoice_Detail()
        {
            InitializeComponent();
        }

        private void Invoice_Detail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'invoice.Invoice_Detail' table. You can move, or remove it, as needed.
            load_list();
        }

    


        private void load_list()
        {
            this.invoice_DetailTableAdapter.Fill(this.invoice.Invoice_Detail, txtSearchName.Text,dtp_From.Value,dtp_To.Value);

            this.rpt_viewer.RefreshReport();
        }
        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            load_list();
        }

        private void dtp_From_ValueChanged(object sender, EventArgs e)
        {
            load_list();
        }

        private void dtp_To_ValueChanged(object sender, EventArgs e)
        {
            load_list();
        }

        private void rpt_viewer_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            load_list();
        }

        private void linklblReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }
    }
}
