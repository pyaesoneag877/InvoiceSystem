
namespace InvoiceSystem.Report
{
    partial class Form_Invoice
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.linkLblReport = new System.Windows.Forms.LinkLabel();
            this.InvoiceViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoice = new InvoiceSystem.Report.invoice();
            this.InvoiceViewTableAdapter = new InvoiceSystem.Report.invoiceTableAdapters.InvoiceViewTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoice)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource3.Name = "DS_invoice";
            reportDataSource3.Value = this.InvoiceViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InvoiceSystem.Report.invoice.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 82);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(765, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // linkLblReport
            // 
            this.linkLblReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLblReport.AutoSize = true;
            this.linkLblReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblReport.LinkColor = System.Drawing.Color.Black;
            this.linkLblReport.Location = new System.Drawing.Point(719, 395);
            this.linkLblReport.Name = "linkLblReport";
            this.linkLblReport.Size = new System.Drawing.Size(45, 15);
            this.linkLblReport.TabIndex = 61;
            this.linkLblReport.TabStop = true;
            this.linkLblReport.Text = "Cancel";
            this.linkLblReport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblReport_LinkClicked);
            // 
            // InvoiceViewBindingSource
            // 
            this.InvoiceViewBindingSource.DataMember = "InvoiceView";
            this.InvoiceViewBindingSource.DataSource = this.invoice;
            // 
            // invoice
            // 
            this.invoice.DataSetName = "invoice";
            this.invoice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // InvoiceViewTableAdapter
            // 
            this.InvoiceViewTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(12, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 25);
            this.label7.TabIndex = 62;
            this.label7.Text = "Invoice System";
            // 
            // Form_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linkLblReport);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form_Invoice";
            this.Text = "Form_Invoice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.LinkLabel linkLblReport;
        private System.Windows.Forms.BindingSource InvoiceViewBindingSource;
        private invoice invoice;
        private invoiceTableAdapters.InvoiceViewTableAdapter InvoiceViewTableAdapter;
        private System.Windows.Forms.Label label7;
    }
}