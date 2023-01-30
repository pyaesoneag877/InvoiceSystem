
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.coffee = new InvoiceSystem.Report.coffee();
            this.CoffeeViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CoffeeViewTableAdapter = new InvoiceSystem.Report.coffeeTableAdapters.CoffeeViewTableAdapter();
            this.coffeeViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coffee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoffeeViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeViewBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DS_coffee";
            reportDataSource1.Value = this.coffeeViewBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InvoiceSystem.Report.coffee.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(26, 58);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(399, 293);
            this.reportViewer1.TabIndex = 0;
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
            // coffeeViewBindingSource1
            // 
            this.coffeeViewBindingSource1.DataMember = "CoffeeView";
            this.coffeeViewBindingSource1.DataSource = this.coffee;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Coffee Report";
            // 
            // frm_coffee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 372);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_coffee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coffee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoffeeViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeViewBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CoffeeViewBindingSource;
        private coffee coffee;
        private coffeeTableAdapters.CoffeeViewTableAdapter CoffeeViewTableAdapter;
        private System.Windows.Forms.BindingSource coffeeViewBindingSource1;
        private System.Windows.Forms.Label label1;
    }
}