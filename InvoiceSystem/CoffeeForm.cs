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
using InvoiceSystem.Report;

namespace InvoiceSystem
{
    public partial class CoffeeForm : Form
    {
        InvoiceDataContext dc = new InvoiceDataContext();
        public object coffee_name, price;
        public CoffeeForm()
        {
            InitializeComponent();
        }

        private void Coffee_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            GetCoffeeRecord();
        }
        private void GetCoffeeRecord()
        {
            List<CoffeeView> coffees_list = (from b in dc.CoffeeViews where b.Active == true select b).ToList();
            gridControlCoffee.DataSource = coffees_list;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                Coffee coffee = new Coffee();
                coffee.CoffeeTypeId = Guid.NewGuid().ToString();
                coffee.CoffeeTypeName = txtCoffeeName.Text;
                coffee.Price = Convert.ToInt32(txtPrice.Text);
                coffee.Active = true;
                dc.Coffees.InsertOnSubmit(coffee);
                dc.SubmitChanges();
                MessageBox.Show("New Coffee is created", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            GetCoffeeRecord();
            ResetFormControl();
        }
        private bool IsValid()
        {
            if (txtCoffeeName.Text == string.Empty)
            {
                MessageBox.Show("Coffee Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtPrice.Text == string.Empty)
            {
                MessageBox.Show("Price is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void ResetFormControl()
        {
            txtCoffeeName.Clear();
            txtPrice.Clear();
        }

        private void gridViewCoffee_KeyDown(object sender, KeyEventArgs e)
        {
            CoffeeView cellvalue;
            cellvalue = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);

            Coffee coffee_record = (from c in dc.Coffees where c.CoffeeTypeId == cellvalue.CoffeeTypeId select c).FirstOrDefault();

            ColumnView view = (ColumnView)sender;
            if (view.FocusedColumn.FieldName == "CustomerName")
            {
                coffee_record.CoffeeTypeName = coffee_name.ToString();
            }
            else if (view.FocusedColumn.FieldName == "Phone")
            {
                coffee_record.Price = Convert.ToInt32(price.ToString());
            }

            dc.SubmitChanges();

            MessageBox.Show("Coffee is Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InvoiceForm invoiceform = new InvoiceForm();
            invoiceform.Show();
            this.Hide();
        }

        private void CoffeeForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control == true && e.KeyCode == Keys.Enter)
            {
                btnCreate.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_coffee from = new frm_coffee();
            from.Show();
            this.Hide();
        }

        private CoffeeView GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            if (view.FocusedColumn.FieldName == "CoffeeTypeName")
            {
                coffee_name = view.ActiveEditor.EditValue;
            }
            else if (view.FocusedColumn.FieldName == "Price")
            {
                price = view.ActiveEditor.EditValue;
            }
            return (CoffeeView)view.GetRow(view.FocusedRowHandle);
        }
    }
}
