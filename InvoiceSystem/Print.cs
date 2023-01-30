using System;
using System.Windows.Forms;
using InvoiceSystem.LINQ;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.BandedGrid;
using System.Data.SqlClient;
using System.Data;

namespace InvoiceSystem
{
    public partial class Print : Form
    {
        InvoiceDataContext dc = new InvoiceDataContext();
        public string invoice_id;
        public Print()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Print_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            GetItemRecord();
        }
        private void GetItemRecord()
        {
            invoice_id = txtInvoice_id.Text;
            List<ItemView> items_list = (from i in dc.ItemViews where i.Active == true && i.InvoiceId == invoice_id select i).ToList();
            gridControlItem.DataSource = items_list;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void Print_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C) {
                this.Hide();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
