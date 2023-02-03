
namespace InvoiceSystem.Report
{
    partial class Invoice_Detail
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpt_viewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_From = new System.Windows.Forms.DateTimePicker();
            this.dtp_To = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.linklblReport = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_Status = new System.Windows.Forms.ComboBox();
            this.invoice = new InvoiceSystem.Report.invoice();
            this.invoiceDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoice_DetailTableAdapter = new InvoiceSystem.Report.invoiceTableAdapters.Invoice_DetailTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.invoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpt_viewer
            // 
            this.rpt_viewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource6.Name = "Invoice_Detail";
            reportDataSource6.Value = this.invoiceDetailBindingSource;
            this.rpt_viewer.LocalReport.DataSources.Add(reportDataSource6);
            this.rpt_viewer.LocalReport.ReportEmbeddedResource = "InvoiceSystem.Report.Invoice_Detail.rdlc";
            this.rpt_viewer.Location = new System.Drawing.Point(13, 167);
            this.rpt_viewer.Name = "rpt_viewer";
            this.rpt_viewer.ServerReport.BearerToken = null;
            this.rpt_viewer.Size = new System.Drawing.Size(837, 212);
            this.rpt_viewer.TabIndex = 0;
            this.rpt_viewer.Load += new System.EventHandler(this.rpt_viewer_Load);
            // 
            // tb_search
            // 
            this.tb_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_search.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tb_search.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_search.Location = new System.Drawing.Point(415, 73);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(1, 20);
            this.tb_search.TabIndex = 1;
            this.tb_search.Visible = false;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(412, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search By Name";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(633, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search By Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(633, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "From";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(633, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "To";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dtp_From
            // 
            this.dtp_From.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_From.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dtp_From.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            this.dtp_From.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_From.Location = new System.Drawing.Point(669, 73);
            this.dtp_From.Name = "dtp_From";
            this.dtp_From.Size = new System.Drawing.Size(181, 20);
            this.dtp_From.TabIndex = 8;
            this.dtp_From.Value = new System.DateTime(2023, 1, 1, 14, 39, 0, 0);
            this.dtp_From.ValueChanged += new System.EventHandler(this.dtp_From_ValueChanged);
            // 
            // dtp_To
            // 
            this.dtp_To.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_To.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            this.dtp_To.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_To.Location = new System.Drawing.Point(669, 114);
            this.dtp_To.Name = "dtp_To";
            this.dtp_To.Size = new System.Drawing.Size(181, 20);
            this.dtp_To.TabIndex = 9;
            this.dtp_To.Value = new System.DateTime(2023, 2, 3, 8, 46, 50, 0);
            this.dtp_To.ValueChanged += new System.EventHandler(this.dtp_To_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(22, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Invoice System";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchName.Location = new System.Drawing.Point(415, 80);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(195, 20);
            this.txtSearchName.TabIndex = 23;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // linklblReport
            // 
            this.linklblReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linklblReport.AutoSize = true;
            this.linklblReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblReport.LinkColor = System.Drawing.Color.Black;
            this.linklblReport.Location = new System.Drawing.Point(799, 391);
            this.linklblReport.Name = "linklblReport";
            this.linklblReport.Size = new System.Drawing.Size(51, 17);
            this.linklblReport.TabIndex = 24;
            this.linklblReport.TabStop = true;
            this.linklblReport.Text = "Cancel";
            this.linklblReport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblReport_LinkClicked);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(201, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Search By Status";
            // 
            // cbo_Status
            // 
            this.cbo_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_Status.FormattingEnabled = true;
            this.cbo_Status.Location = new System.Drawing.Point(204, 80);
            this.cbo_Status.Name = "cbo_Status";
            this.cbo_Status.Size = new System.Drawing.Size(179, 21);
            this.cbo_Status.TabIndex = 26;
            this.cbo_Status.SelectedIndexChanged += new System.EventHandler(this.cbo_Status_SelectedIndexChanged);
            this.cbo_Status.TextChanged += new System.EventHandler(this.cbo_Status_TextChanged);
            // 
            // invoice
            // 
            this.invoice.DataSetName = "invoice";
            this.invoice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceDetailBindingSource
            // 
            this.invoiceDetailBindingSource.DataMember = "Invoice_Detail";
            this.invoiceDetailBindingSource.DataSource = this.invoice;
            // 
            // invoice_DetailTableAdapter
            // 
            this.invoice_DetailTableAdapter.ClearBeforeFill = true;
            // 
            // Invoice_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(861, 444);
            this.Controls.Add(this.cbo_Status);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linklblReport);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtp_To);
            this.Controls.Add(this.dtp_From);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.rpt_viewer);
            this.Name = "Invoice_Detail";
            this.Text = "Invoice_Detail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Invoice_Detail_Load);
            this.TextChanged += new System.EventHandler(this.Invoice_Detail_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.invoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpt_viewer;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_From;
        private System.Windows.Forms.DateTimePicker dtp_To;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.LinkLabel linklblReport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_Status;
        private System.Windows.Forms.BindingSource invoiceDetailBindingSource;
        private invoice invoice;
        private invoiceTableAdapters.Invoice_DetailTableAdapter invoice_DetailTableAdapter;
    }
}