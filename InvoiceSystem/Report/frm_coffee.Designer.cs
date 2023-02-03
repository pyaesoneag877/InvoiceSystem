
namespace InvoiceSystem.Report
{
    partial class frm_coffee
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label11 = new System.Windows.Forms.Label();
            this.linkLblCancel = new System.Windows.Forms.LinkLabel();
            this.coffeeViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coffee = new InvoiceSystem.Report.coffee();
            this.CoffeeViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CoffeeViewTableAdapter = new InvoiceSystem.Report.coffeeTableAdapters.CoffeeViewTableAdapter();
            this.sumDiscountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sumDiscountTableAdapter = new InvoiceSystem.Report.coffeeTableAdapters.SumDiscountTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoffeeViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumDiscountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DS_coffee";
            reportDataSource1.Value = this.coffeeViewBindingSource1;
            reportDataSource2.Name = "DS_Disc";
            reportDataSource2.Value = this.sumDiscountBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InvoiceSystem.Report.coffee.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(26, 58);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(548, 258);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(12, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 25);
            this.label11.TabIndex = 32;
            this.label11.Text = "Invoice System";
            // 
            // linkLblCancel
            // 
            this.linkLblCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLblCancel.AutoSize = true;
            this.linkLblCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblCancel.LinkColor = System.Drawing.Color.Black;
            this.linkLblCancel.Location = new System.Drawing.Point(541, 335);
            this.linkLblCancel.Name = "linkLblCancel";
            this.linkLblCancel.Size = new System.Drawing.Size(50, 16);
            this.linkLblCancel.TabIndex = 33;
            this.linkLblCancel.TabStop = true;
            this.linkLblCancel.Text = "Cancel";
            this.linkLblCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblCancel_LinkClicked);
            // 
            // coffeeViewBindingSource1
            // 
            this.coffeeViewBindingSource1.DataMember = "CoffeeView";
            this.coffeeViewBindingSource1.DataSource = this.coffee;
            // 
            // coffee
            // 
            this.coffee.DataSetName = "coffee";
            this.coffee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CoffeeViewBindingSource
            // 
            this.CoffeeViewBindingSource.DataMember = "CoffeeView";
            this.CoffeeViewBindingSource.DataSource = this.coffee;
            // 
            // CoffeeViewTableAdapter
            // 
            this.CoffeeViewTableAdapter.ClearBeforeFill = true;
            // 
            // sumDiscountBindingSource
            // 
            this.sumDiscountBindingSource.DataMember = "SumDiscount";
            this.sumDiscountBindingSource.DataSource = this.coffee;
            // 
            // sumDiscountTableAdapter
            // 
            this.sumDiscountTableAdapter.ClearBeforeFill = true;
            // 
            // frm_coffee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(603, 372);
            this.Controls.Add(this.linkLblCancel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_coffee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coffeeViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoffeeViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumDiscountBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CoffeeViewBindingSource;
        private coffee coffee;
        private coffeeTableAdapters.CoffeeViewTableAdapter CoffeeViewTableAdapter;
        private System.Windows.Forms.BindingSource coffeeViewBindingSource1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel linkLblCancel;
        private System.Windows.Forms.BindingSource sumDiscountBindingSource;
        private coffeeTableAdapters.SumDiscountTableAdapter sumDiscountTableAdapter;
    }
}