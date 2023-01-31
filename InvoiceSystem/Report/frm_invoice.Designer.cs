
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.invoiceViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoice = new InvoiceSystem.Report.invoice();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.InvoiceViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InvoiceViewTableAdapter = new InvoiceSystem.Report.invoiceTableAdapters.InvoiceViewTableAdapter();
            this.label11 = new System.Windows.Forms.Label();
            this.linkLblCancel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceViewBindingSource1
            // 
            this.invoiceViewBindingSource1.DataMember = "InvoiceView";
            this.invoiceViewBindingSource1.DataSource = this.invoiceBindingSource;
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
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DS_invoice";
            reportDataSource2.Value = this.invoiceViewBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InvoiceSystem.Report.invoice.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(26, 65);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(797, 246);
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(21, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 25);
            this.label11.TabIndex = 30;
            this.label11.Text = "Invoice System";
            // 
            // linkLblCancel
            // 
            this.linkLblCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLblCancel.AutoSize = true;
            this.linkLblCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblCancel.LinkColor = System.Drawing.Color.Black;
            this.linkLblCancel.Location = new System.Drawing.Point(793, 328);
            this.linkLblCancel.Name = "linkLblCancel";
            this.linkLblCancel.Size = new System.Drawing.Size(50, 16);
            this.linkLblCancel.TabIndex = 31;
            this.linkLblCancel.TabStop = true;
            this.linkLblCancel.Text = "Cancel";
            this.linkLblCancel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkLblCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblCancel_LinkClicked);
            // 
            // frm_invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(855, 363);
            this.Controls.Add(this.linkLblCancel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_invoice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource InvoiceViewBindingSource;
        private invoice invoice;
        private invoiceTableAdapters.InvoiceViewTableAdapter InvoiceViewTableAdapter;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private System.Windows.Forms.BindingSource invoiceViewBindingSource1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel linkLblCancel;
    }
}