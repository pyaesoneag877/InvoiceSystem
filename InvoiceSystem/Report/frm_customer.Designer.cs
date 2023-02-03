
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.customerViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.customer = new InvoiceSystem.Report.customer();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CustomerViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CustomerViewTableAdapter = new InvoiceSystem.Report.customerTableAdapters.CustomerViewTableAdapter();
            this.label11 = new System.Windows.Forms.Label();
            this.linkLblCancel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.customerViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerViewBindingSource1
            // 
            this.customerViewBindingSource1.DataMember = "CustomerView";
            this.customerViewBindingSource1.DataSource = this.customerBindingSource2;
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
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DS_customer";
            reportDataSource2.Value = this.customerViewBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InvoiceSystem.Report.customer.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(40, 78);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(767, 246);
            this.reportViewer1.TabIndex = 0;
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(35, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 25);
            this.label11.TabIndex = 31;
            this.label11.Text = "Invoice System";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // linkLblCancel
            // 
            this.linkLblCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLblCancel.AutoSize = true;
            this.linkLblCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblCancel.LinkColor = System.Drawing.Color.Black;
            this.linkLblCancel.Location = new System.Drawing.Point(791, 350);
            this.linkLblCancel.Name = "linkLblCancel";
            this.linkLblCancel.Size = new System.Drawing.Size(50, 16);
            this.linkLblCancel.TabIndex = 32;
            this.linkLblCancel.TabStop = true;
            this.linkLblCancel.Text = "Cancel";
            this.linkLblCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblCancel_LinkClicked);
            // 
            // frm_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(853, 375);
            this.Controls.Add(this.linkLblCancel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_customer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CustomerViewBindingSource;
        private customer customer;
        private customerTableAdapters.CustomerViewTableAdapter CustomerViewTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource2;
        private System.Windows.Forms.BindingSource customerViewBindingSource1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel linkLblCancel;
    }
}