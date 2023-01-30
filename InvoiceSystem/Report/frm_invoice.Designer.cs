
namespace InvoiceSystem.Report
{
    partial class frm_invoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoice = new InvoiceSystem.Report.invoice();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.InvoiceViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InvoiceViewTableAdapter = new InvoiceSystem.Report.invoiceTableAdapters.InvoiceViewTableAdapter();
            this.invoiceViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceViewBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataSource = this.invoice;
            this.invoiceBindingSource.Position = 0;
            // 
            // invoice
            // 
            this.invoice.DataSetName = "invoice";
            this.invoice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DS_invoice";
            reportDataSource1.Value = this.invoiceViewBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InvoiceSystem.Report.invoice.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(72, 87);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(634, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // InvoiceViewBindingSource
            // 
            this.InvoiceViewBindingSource.DataMember = "InvoiceView";
            this.InvoiceViewBindingSource.DataSource = this.invoice;
            // 
            // InvoiceViewTableAdapter
            // 
            this.InvoiceViewTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceViewBindingSource1
            // 
            this.invoiceViewBindingSource1.DataMember = "InvoiceView";
            this.invoiceViewBindingSource1.DataSource = this.invoiceBindingSource;
            // 
            // frm_invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_invoice";
            this.Load += new System.EventHandler(this.frm_invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceViewBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource InvoiceViewBindingSource;
        private invoice invoice;
        private invoiceTableAdapters.InvoiceViewTableAdapter InvoiceViewTableAdapter;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private System.Windows.Forms.BindingSource invoiceViewBindingSource1;
    }
}