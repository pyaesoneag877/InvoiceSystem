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
    public partial class InvoiceForm : Form
    {
        InvoiceDataContext dc = new InvoiceDataContext();
        public string invoice_id;
        public string item_id;

        public int item_qty = 1;
        public int item_totalAmount;
        public int item_discount;
        public int item_price;

        public int totalAmount;
        public int discount;
        public int balance;

        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            ResetFormControl();
            ResetItemFormControl();
            GetInvoiceRecord();

        }

        private void GetInvoiceRecord()
        {
            List<InvoiceView> invoices_list = (from b in dc.InvoiceViews where b.Active == true select b).ToList();
            gridControlInvoice.DataSource = invoices_list;           
        }
        private void GetItemRecord()
        {
            List<ItemView> items_list = (from i in dc.ItemViews where i.Active == true && i.InvoiceId == invoice_id select i).ToList();
            gridControlItem.DataSource = items_list;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var customer_name = cboCustomerName.Items[cboCustomerName.SelectedIndex].ToString();
            string customer_id = (from u in dc.CustomerTbs where u.CustomerName == customer_name select u.CustomerId).FirstOrDefault();

            if (IsValid())
            {
                Invoice invoice = new Invoice();
                invoice.InvoiceId = Guid.NewGuid().ToString();
                invoice.InvoiceNo = txtInvoiceNo.Text;

                //dropdown insert
                invoice.CustomerId = customer_id;
                invoice.CoffeeTypeId = null;
                invoice.InvoiceStatus = cboInvoiceStatus.Items[cboInvoiceStatus.SelectedIndex].ToString();
                //dropdown insert end

                invoice.Qty = 0;
                invoice.Price = 0;
                invoice.Discount = Convert.ToInt32(txtDiscount.Text);
                invoice.TotalAmount = Convert.ToInt32(txtTotalAmount.Text);
                invoice.Balance = Convert.ToInt32(txtBalance.Text); ;
                invoice.InvoiceDate = Convert.ToDateTime(dtpInvoiceDate.Text);
                invoice.Remark = rtxtRemark.Text;
                
                invoice.Active = true;
                dc.Invoices.InsertOnSubmit(invoice);
                dc.SubmitChanges();
                MessageBox.Show("New invoice is created", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            GetInvoiceRecord();
            ResetFormControl();
        }
        private bool IsValid()
        {
            if (txtInvoiceNo.Text == string.Empty)
            {
                MessageBox.Show("Invoice No. is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            if (cboInvoiceStatus.Text == string.Empty)
            {
                MessageBox.Show("Invoice Status is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void ResetFormControl()
        {
            invoice_id = "";
            txtInvoiceNo.Clear();
            txtBalance.Text = "0";
            txtTotalAmount.Text = "0";
            rtxtRemark.Clear();

            cboCustomerName.DataSource = (from u in dc.CustomerTbs where u.Active == true select u.CustomerName).ToList();
            PritLink.Hide();
        }
        private InvoiceView GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            return (InvoiceView)view.GetRow(view.FocusedRowHandle);
        }

        private void gridViewInvoice_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            InvoiceView cellvalue;
            cellvalue = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            txtInvoiceId.Text = cellvalue.InvoiceId;
            invoice_id= txtInvoiceId.Text;
            txtInvoiceNo.Text = cellvalue.InvoiceNo;

            GetItemRecord();

            //dropdown rowclick
            string customer_id = (from c in dc.Invoices where c.InvoiceId == invoice_id && c.Active == true select c.CustomerId).FirstOrDefault();
            string customer_name = (from c in dc.CustomerTbs where c.CustomerId == customer_id && c.Active == true select c.CustomerName).FirstOrDefault();
            cboCustomerName.Text = customer_name;

            cboInvoiceStatus.Text = cellvalue.InvoiceStatus;

            if (cellvalue.InvoiceStatus=="Completed" || cellvalue.InvoiceStatus=="Cancelled")
            {
                btnUpdate.Hide();
                btnDelete.Hide();
                PritLink.Show();

            }
            if (cellvalue.InvoiceStatus == "New")
            {
                btnUpdate.Show();
                btnDelete.Show();
                PritLink.Hide();
            }
            //end dropdown rowclick
            txtDiscount.Text = Convert.ToString(cellvalue.Discount);
            txtTotalAmount.Text = Convert.ToString(cellvalue.TotalAmount);
            txtBalance.Text = Convert.ToString(cellvalue.Balance);
            dtpInvoiceDate.Text = Convert.ToString(cellvalue.InvoiceDate);
            rtxtRemark.Text = cellvalue.Remark;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Invoice invoice = (from c in dc.Invoices where c.InvoiceId == invoice_id select c).FirstOrDefault();

            invoice.InvoiceNo = txtInvoiceNo.Text;

            //dropdown update
            var customer_name = cboCustomerName.Items[cboCustomerName.SelectedIndex].ToString();
            string customer_id = (from u in dc.CustomerTbs where u.CustomerName == customer_name select u.CustomerId).FirstOrDefault();

            invoice.CustomerId = customer_id;
            invoice.CoffeeTypeId = null;
            invoice.InvoiceStatus = cboInvoiceStatus.Items[cboInvoiceStatus.SelectedIndex].ToString();
            //dropdown update end

            invoice.Qty = 0;
            invoice.Price = 0;
            invoice.Discount = Convert.ToInt32(txtDiscount.Text);
            invoice.TotalAmount = Convert.ToInt32(txtTotalAmount.Text);
            invoice.Balance = Convert.ToInt32(txtBalance.Text);
            invoice.InvoiceDate = Convert.ToDateTime(dtpInvoiceDate.Text);
            invoice.Remark = rtxtRemark.Text;

            dc.SubmitChanges();
            MessageBox.Show("Invoice is Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GetInvoiceRecord();
            ResetFormControl();
        }

        private void linkLabelDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void lblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void lblGotoCoffee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CoffeeForm cf = new CoffeeForm();
            cf.Show();
            this.Hide();
        }

        private void lblCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Customer c = new Customer();
            c.Show();
            this.Hide();
        }

        private void txtQty_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void cboCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var customer_name = cboCustomerName.Items[cboCustomerName.SelectedIndex].ToString();
            int discount_amount = Convert.ToInt32((from c in dc.CustomerTbs where c.CustomerName == customer_name select c.DiscountAmount).FirstOrDefault());
            txtDiscount.Text = Convert.ToString(discount_amount);
        }

        private void cboCoffeeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void PritLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Print print = new Print();
            print.Show();

            print.lblInvoiceNo.Text = txtInvoiceNo.Text;
            print.txtInvoice_id.Text = invoice_id;

            List<ItemView> items_list = (from i in dc.ItemViews where i.Active == true && i.InvoiceId == invoice_id select i).ToList();
            print.gridControlItem.DataSource = items_list;

            //dropdown
            print.lblCustomerName.Text = cboCustomerName.Items[cboCustomerName.SelectedIndex].ToString();
            print.lblCoffeeName.Text = cboItemCoffeeName.Items[cboItemCoffeeName.SelectedIndex].ToString();
            print.lblInvoiceStatus.Text = cboInvoiceStatus.Items[cboInvoiceStatus.SelectedIndex].ToString();
            //end dropdown

            print.lblRemark.Text = rtxtRemark.Text;
            print.lblInvoiceDate.Text = dtpInvoiceDate.Text;
            print.lblTotalAmount.Text = txtTotalAmount.Text;
            print.lblDiscountTotal.Text = txtDiscount.Text;
            print.lblBalance.Text = txtBalance.Text;
  
        }

        private void InvoiceForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control == true && e.KeyCode == Keys.Enter)
            {
                btnCreate.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.U)
            {
                btnUpdate.PerformClick();
            }
            if (e.KeyCode == Keys.Delete)
            {
                btnDelete.PerformClick();
            }
            if(e.Control == true && e.KeyCode == Keys.P)
            {
                Print print = new Print();
                print.Show();

                print.lblInvoiceNo.Text = txtInvoiceNo.Text;
                //dropdown
                print.lblCustomerName.Text = cboCustomerName.Items[cboCustomerName.SelectedIndex].ToString();
                print.lblCoffeeName.Text = cboCoffeeName.Items[cboCoffeeName.SelectedIndex].ToString();
                try { print.lblInvoiceStatus.Text = cboInvoiceStatus.Items[cboInvoiceStatus.SelectedIndex].ToString(); }
                catch { MessageBox.Show("Choose Invoice Status", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                //end dropdown

                print.lblRemark.Text = rtxtRemark.Text;
                print.lblInvoiceDate.Text = dtpInvoiceDate.Text;
                print.lblTotalAmount.Text = txtTotalAmount.Text;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Invoice invoice_record = (from c in dc.Invoices where c.InvoiceId == invoice_id select c).FirstOrDefault();
            invoice_record.Active = false;
            dc.SubmitChanges();
            MessageBox.Show("customer is deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GetInvoiceRecord();
            ResetFormControl();
        }

        private void rtxtRemark_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var coffee_name = cboItemCoffeeName.Items[cboItemCoffeeName.SelectedIndex].ToString();
            string coffee_id = (from c in dc.Coffees where c.CoffeeTypeName == coffee_name select c.CoffeeTypeId).FirstOrDefault();

            if (IsValidItem())
            {
                ItemTb item = new ItemTb();
                item.ItemId = Guid.NewGuid().ToString();
                item.ItemName = txtItemName.Text;

                //dropdown insert
                item.CoffeeTypeId = coffee_id;
                //dropdown insert end

                item.InvoiceId = txtInvoiceId.Text;

                item.Qty = Convert.ToInt32(txtItemQty.Text);
                item.Price = Convert.ToInt32(txtItemPrice.Text);
                item.Discount = Convert.ToInt32(txtItemDiscount.Text);
                item.TotalAmount = Convert.ToInt32(txtItemTotalAmount.Text);

                item.Active = true;
                dc.ItemTbs.InsertOnSubmit(item);
                dc.SubmitChanges();
                MessageBox.Show("New Item is created", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetItemRecord();
                ResetItemFormControl();


                //Total Amount Calcuate
                Invoice invoice = (from c in dc.Invoices where c.InvoiceId == txtInvoiceId.Text select c).FirstOrDefault();
                invoice.TotalAmount = Convert.ToInt32((from i in dc.ItemTbs where i.Active == true && i.InvoiceId == invoice_id select i.TotalAmount).Sum().ToString());
                txtTotalAmount.Text = invoice.TotalAmount.ToString();

                try
                {
                    totalAmount = Convert.ToInt32(txtTotalAmount.Text);
                    discount = Convert.ToInt32(txtDiscount.Text);
                    balance = totalAmount - discount;
                    txtBalance.Text = Convert.ToString(balance);
                }
                catch
                {
                    MessageBox.Show("Balance Error", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                invoice.Balance = Convert.ToInt32(txtBalance.Text);
                dc.SubmitChanges();
                //end total amount calculate
                GetInvoiceRecord();
            }
            


        }
        private bool IsValidItem()
        {
            if (txtItemName.Text == string.Empty)
            {
                MessageBox.Show("Item Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtInvoiceNo.Text == string.Empty)
            {
                MessageBox.Show("Invoice No. is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void ResetItemFormControl()
        {
            item_id = "";
            txtItemName.Clear();
            txtItemQty.Text = "1";
            txtItemPrice.Text = "0";
            txtItemDiscount.Text = "0";
            txtItemTotalAmount.Text = "0";
            rtxtRemark.Clear();
            cboItemCoffeeName.DataSource = (from c in dc.Coffees where c.Active == true select c.CoffeeTypeName).ToList();
          
        }
        private ItemView GetItemSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            return (ItemView)view.GetRow(view.FocusedRowHandle);
        }

        private void gridViewItem_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            ItemView cellvalue;
            cellvalue = GetItemSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            txtItemId.Text = cellvalue.ItemId;
            item_id = txtItemId.Text;
            txtItemName.Text = cellvalue.ItemName;
            
            string invoice_name = (from c in dc.Invoices where c.InvoiceId == cellvalue.InvoiceId && c.Active == true select c.InvoiceNo).FirstOrDefault();
            txtInvoiceNo.Text = invoice_name;

            //dropdown rowclick
            string coffee_id = (from c in dc.ItemTbs where c.ItemId == item_id && c.Active == true select c.CoffeeTypeId).FirstOrDefault();
            string coffee_name = (from c in dc.Coffees where c.CoffeeTypeId == coffee_id && c.Active == true select c.CoffeeTypeName).FirstOrDefault();
            cboItemCoffeeName.Text = coffee_name;
            //dropdown rowclick end

            txtItemQty.Text = Convert.ToString(cellvalue.Qty);
            txtItemPrice.Text = Convert.ToString(cellvalue.Price);
            txtItemDiscount.Text = Convert.ToString(cellvalue.Discount);
            txtItemTotalAmount.Text = Convert.ToString(cellvalue.TotalAmount);
        }

        private void btnItemUpdate_Click(object sender, EventArgs e)
        {
            if (IsValidItem())
            {
                ItemTb item = (from c in dc.ItemTbs where c.ItemId == item_id select c).FirstOrDefault();
                item.ItemName = txtItemName.Text;
                //dropdown update
                var coffee_name = cboItemCoffeeName.Items[cboItemCoffeeName.SelectedIndex].ToString();
                string coffee_id = (from c in dc.Coffees where c.CoffeeTypeName == coffee_name select c.CoffeeTypeId).FirstOrDefault();
                item.CoffeeTypeId = coffee_id;
                //dropdown update end

                item.Qty = Convert.ToInt32(txtItemQty.Text);
                item.Price = Convert.ToInt32(txtItemPrice.Text);
                item.Discount = Convert.ToInt32(txtItemDiscount.Text);
                item.TotalAmount = Convert.ToInt32(txtItemTotalAmount.Text);
                
                dc.SubmitChanges();
                MessageBox.Show("Item is Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetItemRecord();
                ResetItemFormControl();
                //Total Amount Calcuate
                Invoice invoice = (from c in dc.Invoices where c.InvoiceId == txtInvoiceId.Text select c).FirstOrDefault();
                invoice.TotalAmount = Convert.ToInt32((from i in dc.ItemTbs where i.Active == true && i.InvoiceId == invoice_id select i.TotalAmount).Sum().ToString());
               
                txtTotalAmount.Text = invoice.TotalAmount.ToString();
                try
                {
                    totalAmount = Convert.ToInt32(txtTotalAmount.Text);
                    discount = Convert.ToInt32(txtDiscount.Text);
                    balance = totalAmount - discount;
                    txtBalance.Text = Convert.ToString(balance);
                }
                catch
                {
                    MessageBox.Show("Balance Error", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                invoice.Balance = Convert.ToInt32(txtBalance.Text);
                dc.SubmitChanges();
                //end total amount calculate
                GetInvoiceRecord();
            }
        }

        private void butItemDelete_Click(object sender, EventArgs e)
        {
            if (IsValidItem())
            {
                ItemTb item_record = (from c in dc.ItemTbs where c.ItemId == item_id select c).FirstOrDefault();
                item_record.Active = false;
                dc.SubmitChanges();
                MessageBox.Show("Item is deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetItemRecord();
                ResetItemFormControl();

                //Total Amount Calcuate
                Invoice invoice = (from c in dc.Invoices where c.InvoiceId == txtInvoiceId.Text select c).FirstOrDefault();
                invoice.TotalAmount = Convert.ToInt32((from i in dc.ItemTbs where i.Active == true && i.InvoiceId == invoice_id select i.TotalAmount).Sum().ToString());
                txtTotalAmount.Text = invoice.TotalAmount.ToString();
                try
                {
                    totalAmount = Convert.ToInt32(txtTotalAmount.Text);
                    discount = Convert.ToInt32(txtDiscount.Text);
                    balance = totalAmount - discount;
                    txtBalance.Text = Convert.ToString(balance);
                }
                catch
                {
                    MessageBox.Show("Balance Error", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                invoice.Balance = Convert.ToInt32(txtBalance.Text);
                dc.SubmitChanges();

                //end total amount calculate
                GetInvoiceRecord();
            }
        }

        private void txtItemQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtItemQty_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                item_qty = Convert.ToInt32(txtItemQty.Text);
                item_price = Convert.ToInt32(txtItemPrice.Text);
                item_discount = Convert.ToInt32(txtItemDiscount.Text);
                item_totalAmount = (item_qty * item_price) - item_discount;
                txtItemTotalAmount.Text = Convert.ToString(item_totalAmount);
            }
            catch
            {
                MessageBox.Show("Input Qty", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtItemDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                item_qty = Convert.ToInt32(txtItemQty.Text);
                item_price = Convert.ToInt32(txtItemPrice.Text);
                item_discount = Convert.ToInt32(txtItemDiscount.Text);
                item_totalAmount = (item_qty * item_price) - item_discount;
                txtItemTotalAmount.Text = Convert.ToString(item_totalAmount);
            }
            catch
            {
                MessageBox.Show("Input Discount", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtItemPrice_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                item_qty = Convert.ToInt32(txtItemQty.Text);
                item_price = Convert.ToInt32(txtItemPrice.Text);
                item_discount = Convert.ToInt32(txtItemDiscount.Text);
                item_totalAmount = (item_qty * item_price) - item_discount;
                txtItemTotalAmount.Text = Convert.ToString(item_totalAmount);
            }
            catch
            {
                MessageBox.Show("Input Price", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                totalAmount = Convert.ToInt32(txtTotalAmount.Text);
                discount = Convert.ToInt32(txtDiscount.Text);
                balance = totalAmount - discount;
                txtBalance.Text = Convert.ToString(balance);
            }
            catch
            {
                MessageBox.Show("Input Discount", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void txtTotalAmount_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                totalAmount = Convert.ToInt32(txtTotalAmount.Text);
                discount = Convert.ToInt32(txtDiscount.Text);
                balance = totalAmount - discount;
                txtBalance.Text = Convert.ToString(balance);
            }
            catch
            {
                MessageBox.Show("Input Total Amount", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBalance_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                totalAmount = Convert.ToInt32(txtTotalAmount.Text);
                discount = Convert.ToInt32(txtDiscount.Text);
                balance = totalAmount - discount;
                txtBalance.Text = Convert.ToString(balance);
            }
            catch
            {
                MessageBox.Show("Input Balance", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdd_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void btnItemUpdate_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                totalAmount = Convert.ToInt32(txtTotalAmount.Text);
                discount = Convert.ToInt32(txtDiscount.Text);
                balance = totalAmount - discount;
                txtBalance.Text = Convert.ToString(balance);
            }
            catch
            {
                MessageBox.Show("Balance Error", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void butItemDelete_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                totalAmount = Convert.ToInt32(txtTotalAmount.Text);
                discount = Convert.ToInt32(txtDiscount.Text);
                balance = totalAmount - discount;
                txtBalance.Text = Convert.ToString(balance);
            }
            catch
            {
                MessageBox.Show("Balance Error", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linkLblReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           Invoice_Detail frmInvoice = new Invoice_Detail();
            frmInvoice.Show();
        }
    }
}
