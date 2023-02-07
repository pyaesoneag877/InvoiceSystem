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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;

namespace InvoiceSystem
{
    public partial class CoffeeForm : Form
    {
        InvoiceDataContext dc = new InvoiceDataContext();
        public object coffee_name, price;
        string record_id = "";
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
            save();
        }
        private void save()
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
            record_id = "";
        }

        private void gridViewCoffee_KeyDown(object sender, KeyEventArgs e)
        {
            //gridViewCoffee.AddNewRow();
            CoffeeView cellvalue;
            cellvalue = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
             
            Coffee coffee_record = (from c in dc.Coffees where c.CoffeeTypeId == cellvalue.CoffeeTypeId select c).FirstOrDefault();
            record_id = cellvalue.CoffeeTypeId;
            ColumnView view = (ColumnView)sender;
            if (view.FocusedColumn.FieldName == "CoffeeTypeName")
            {
               coffee_record.CoffeeTypeName = coffee_name.ToString();
            }
            else if (view.FocusedColumn.FieldName == "Price")
            {
               coffee_record.Price = Convert.ToInt32(price.ToString());
            }

            dc.SubmitChanges();

            MessageBox.Show("Coffee is Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetCoffeeRecord();
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
        }

        private void gridControlCoffee_Click(object sender, EventArgs e)
        {

        }

        private void gridViewCoffee_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns[0], 1);
            view.SetRowCellValue(e.RowHandle, view.Columns[1], 2);
            view.SetRowCellValue(e.RowHandle, view.Columns[2], 3);
        }

        private void gridViewCoffee_DoubleClick(object sender, EventArgs e)
        {
            Coffee coffee = new Coffee();
            coffee.CoffeeTypeId = Guid.NewGuid().ToString();
            coffee.CoffeeTypeName = "test";
            coffee.Price = 0;
            coffee.Active = true;
            dc.Coffees.InsertOnSubmit(coffee);
            dc.SubmitChanges();
            MessageBox.Show("New Coffee is created", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetCoffeeRecord();

        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            CoffeeView the_reslut = (CoffeeView)gridViewCoffee.GetRow(gridViewCoffee.GetSelectedRows().FirstOrDefault());

            Coffee coffee_record = (from c in dc.Coffees where c.CoffeeTypeId == the_reslut.CoffeeTypeId select c).FirstOrDefault();
            coffee_record.Active = false;
            dc.SubmitChanges();

            //MessageBox.Show("record is deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (XtraMessageBox.Show($"Are you sure want to delete! {(gridViewCoffee.GetFocusedRow() as CoffeeView).CoffeeTypeName}?",
                "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                XtraMessageBox.Show("Removing...");
            }

            GetCoffeeRecord();
            ResetFormControl();
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
