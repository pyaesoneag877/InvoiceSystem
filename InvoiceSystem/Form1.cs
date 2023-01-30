using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using InvoiceSystem.LINQ;
using System.Collections.Generic;
using System.Linq;

namespace InvoiceSystem
{
    public partial class Form1 : Form
    {
        InvoiceDataContext dc = new InvoiceDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsvalidUser(txtUserName.Text, txtPassword.Text))
            {
                MessageBox.Show("Login Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InvoiceForm invoice_form = new InvoiceForm();
                invoice_form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Fail", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Show();
            }

        }
        private bool IsvalidUser(string userName, string password)
        {
            InvoiceDataContext context = new InvoiceDataContext();
            var q = from p in context.UserTbs
                    where p.UserName == txtUserName.Text
                    && p.Password == txtPassword.Text
                    select p;
            if (q.Any())
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void btnLogin_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                btnLogin.PerformClick();
            }
            //e.Control == true &&
        }
    }
}
