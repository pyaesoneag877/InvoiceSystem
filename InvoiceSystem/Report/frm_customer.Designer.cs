
namespace InvoiceSystem.Report
{
    partial class frm_customer
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
            this.customerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.customer = new InvoiceSystem.Report.customer();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CustomerViewTableAdapter = new InvoiceSystem.Report.customerTableAdapters.CustomerViewTableAdapter();
            this.customerViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerViewBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerBindingSource2
            // 
            this.customerBindingSource2.DataSource = this.customer;
            this.customerBindingSource2.Position = 0;
            // 
            // customer
            // 
            this.customer.DataSetName = "customer";
            this.customer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DS_customer";
            reportDataSource1.Value = this.customerViewBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InvoiceSystem.Report.customer.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(40, 78);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(625, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer List";
            // 
            // CustomerViewBindingSource
            // 
            this.CustomerViewBindingSource.DataMember = "CustomerView";
            this.CustomerViewBindingSource.DataSource = this.customer;
            // 
            // CustomerViewTableAdapter
            // 
            this.CustomerViewTableAdapter.ClearBeforeFill = true;
            // 
            // customerViewBindingSource1
            // 
            this.customerViewBindingSource1.DataMember = "CustomerView";
            this.customerViewBindingSource1.DataSource = this.customerBindingSource2;
            // 
            // frm_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 346);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_customer";
            this.Load += new System.EventHandler(this.frm_customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerViewBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource CustomerViewBindingSource;
        private customer customer;
        private customerTableAdapters.CustomerViewTableAdapter CustomerViewTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource2;
        private System.Windows.Forms.BindingSource customerViewBindingSource1;
    }
}