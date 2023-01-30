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
    public partial class Customer : Form
    {
        InvoiceDataContext dc = new InvoiceDataContext();
        public object customer_name;
        public object phone_number;
        public object address;
        public object discount_amount;
        public string customer_id;
        public Customer()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            GetCustomerRecord();
        }

        private void GetCustomerRecord()
        {
            List<CustomerView> customers_list = (from b in dc.CustomerViews where b.Active == true select b).ToList();
            gridControlCustomer.DataSource = customers_list;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                CustomerTb customer = new CustomerTb();
                customer.CustomerId = Guid.NewGuid().ToString();
                customer.CustomerName = txtCustomerName.Text;
                if (rgoMale.Checked == true)
                {
                    customer.Gender = "Male";
                }
                if (rgoFemale.Checked == true)
                {
                    customer.Gender = "Female";
                }
                if (chkIsMember.Checked == true)
                {
                    customer.IsMember = "True";
                }
                if (chkIsMember.Checked == false)
                {
                    customer.IsMember = "False";
                }
                customer.Phone = txtPhone.Text;
                customer.Address = rtxtAddress.Text;
                customer.DiscountAmount = Convert.ToInt32(txtDiscountAmount.Text);
                
                customer.Active = true;
                dc.CustomerTbs.InsertOnSubmit(customer);
                dc.SubmitChanges();
                MessageBox.Show("New Customer is created", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            GetCustomerRecord();
        }
        private bool IsValid()
        {
            if (txtCustomerName.Text == string.Empty)
            {
                MessageBox.Show("Customer Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtPhone.Text == string.Empty)
            {
                MessageBox.Show("Phone Number is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (rtxtAddress.Text == string.Empty)
            {
                MessageBox.Show("Address is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtDiscountAmount.Text == string.Empty)
            {
                MessageBox.Show("Discount Amount is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            return true;
        }

        private void gridViewCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            //CustomerView cellvalue;
            //cellvalue = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);

            //CustomerTb blog_record = (from c in dc.CustomerTbs where c.CustomerId == cellvalue.CustomerId select c).FirstOrDefault();

            //ColumnView view = (ColumnView)sender;
            //if (view.FocusedColumn.FieldName == "CustomerName")
            //{
            //    blog_record.CustomerName = customer_name.ToString();
            //}
            //else if (view.FocusedColumn.FieldName == "Phone")
            //{
            //    blog_record.Phone = phone_number.ToString();
            //}
            //else if (view.FocusedColumn.FieldName == "Address")
            //{
            //    blog_record.Address = address.ToString();
            //}
            //else if (view.FocusedColumn.FieldName == "DiscountAmount")
            //{
            //    blog_record.DiscountAmount = Convert.ToInt32(discount_amount.ToString());
            //}

            //dc.SubmitChanges();

            //MessageBox.Show("User is Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private CustomerView GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            //if (view.FocusedColumn.FieldName == "CustomerName")
            //{
            //    customer_name = view.ActiveEditor.EditValue;
            //}
            //else if (view.FocusedColumn.FieldName == "Phone")
            //{
            //    phone_number = view.ActiveEditor.EditValue;
            //}
            //else if (view.FocusedColumn.FieldName == "Address")
            //{
            //    address = view.ActiveEditor.EditValue;
            //}
            //else if (view.FocusedColumn.FieldName == "DiscountAmount")
            //{
            //    discount_amount = view.ActiveEditor.EditValue;
            //}
            return (CustomerView)view.GetRow(view.FocusedRowHandle);

        }

        private void ResetFormControl()
        {
            customer_id = "";
            txtCustomerName.Clear();
            rgoMale.Checked=false;
            rgoFemale.Checked = false;
            rtxtAddress.Clear();
            txtDiscountAmount.Clear();
            txtPhone.Clear();
            chkIsMember.Checked = false;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            CustomerTb customer_record = (from c in dc.CustomerTbs where c.CustomerId == customer_id select c).FirstOrDefault();
            customer_record.Active = false;
            dc.SubmitChanges();
            MessageBox.Show("customer is deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GetCustomerRecord();
            ResetFormControl();
        }

        private void gridViewCustomer_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            CustomerView cellvalue;
            cellvalue = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            txtCustomerId.Text = cellvalue.CustomerId;
            customer_id = txtCustomerId.Text;
            txtCustomerName.Text = cellvalue.CustomerName;
            rtxtAddress.Text = cellvalue.Address;
            txtDiscountAmount.Text = Convert.ToString(cellvalue.DiscountAmount);
            txtPhone.Text = cellvalue.Phone;

            if (cellvalue.Gender =="Male")
            {
                rgoMale.Checked=true;
            }
            if (cellvalue.Gender =="Female")
            {
                rgoFemale.Checked=true;
            }

            if (cellvalue.IsMember=="True")
            {
                chkIsMember.Checked = true;
            }
            if (cellvalue.IsMember == "False")
            {
                chkIsMember.Checked = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //CustomerView cellvalue;
            //cellvalue = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);

            CustomerTb customer = (from c in dc.CustomerTbs where c.CustomerId == customer_id select c).FirstOrDefault();
            
            customer.CustomerName = txtCustomerName.Text;
            if (rgoMale.Checked == true)
            {
                customer.Gender = "Male";
            }
            if (rgoFemale.Checked == true)
            {
                customer.Gender = "Female";
            }
            if (chkIsMember.Checked == true)
            {
                customer.IsMember = "True";
            }
            if (chkIsMember.Checked == false)
            {
                customer.IsMember = "False";
            }
            customer.Phone = txtPhone.Text;
            customer.Address = rtxtAddress.Text;
            customer.DiscountAmount = Convert.ToInt32(txtDiscountAmount.Text);

            dc.SubmitChanges();
            MessageBox.Show("Customer is Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GetCustomerRecord();
            ResetFormControl();
        }

        private void txtCustomerId_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkGotoCoffee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CoffeeForm coffee = new CoffeeForm();
            coffee.Show();
            this.Hide();
        }

        private void Customer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control==true && e.KeyCode == Keys.Enter)
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
        }
    }
}
