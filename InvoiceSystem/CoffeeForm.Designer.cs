
namespace InvoiceSystem
{
    partial class CoffeeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCoffeeName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.gridControlCoffee = new DevExpress.XtraGrid.GridControl();
            this.gridViewCoffee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CoffeeTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CoffeeTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCoffee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCoffee)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(49, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coffee Type Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(49, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // txtCoffeeName
            // 
            this.txtCoffeeName.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtCoffeeName.ForeColor = System.Drawing.SystemColors.Info;
            this.txtCoffeeName.Location = new System.Drawing.Point(206, 72);
            this.txtCoffeeName.Name = "txtCoffeeName";
            this.txtCoffeeName.Size = new System.Drawing.Size(128, 20);
            this.txtCoffeeName.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtPrice.ForeColor = System.Drawing.SystemColors.Info;
            this.txtPrice.Location = new System.Drawing.Point(206, 113);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(128, 20);
            this.txtPrice.TabIndex = 3;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Black;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCreate.Location = new System.Drawing.Point(242, 151);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(92, 27);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // gridControlCoffee
            // 
            this.gridControlCoffee.Location = new System.Drawing.Point(24, 195);
            this.gridControlCoffee.MainView = this.gridViewCoffee;
            this.gridControlCoffee.Name = "gridControlCoffee";
            this.gridControlCoffee.Size = new System.Drawing.Size(349, 130);
            this.gridControlCoffee.TabIndex = 5;
            this.gridControlCoffee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCoffee});
            // 
            // gridViewCoffee
            // 
            this.gridViewCoffee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CoffeeTypeId,
            this.CoffeeTypeName,
            this.Price});
            this.gridViewCoffee.GridControl = this.gridControlCoffee;
            this.gridViewCoffee.Name = "gridViewCoffee";
            this.gridViewCoffee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewCoffee_KeyDown);
            // 
            // CoffeeTypeId
            // 
            this.CoffeeTypeId.Caption = "CoffeeTypeId";
            this.CoffeeTypeId.FieldName = "CoffeeTypeId";
            this.CoffeeTypeId.Name = "CoffeeTypeId";
            // 
            // CoffeeTypeName
            // 
            this.CoffeeTypeName.Caption = "CoffeeTypeName";
            this.CoffeeTypeName.FieldName = "CoffeeTypeName";
            this.CoffeeTypeName.Name = "CoffeeTypeName";
            this.CoffeeTypeName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "CoffeeTypeName", "{0}")});
            this.CoffeeTypeName.Visible = true;
            this.CoffeeTypeName.VisibleIndex = 0;
            // 
            // Price
            // 
            this.Price.Caption = "Price";
            this.Price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Price.FieldName = "Price";
            this.Price.Name = "Price";
            this.Price.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Price", "{0}")});
            this.Price.Visible = true;
            this.Price.VisibleIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(331, 30);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(42, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Invoice";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(15, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 25);
            this.label11.TabIndex = 29;
            this.label11.Text = "Invoice System";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(52, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CoffeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(399, 349);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.gridControlCoffee);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCoffeeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CoffeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee";
            this.Load += new System.EventHandler(this.Coffee_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CoffeeForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCoffee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCoffee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCoffeeName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnCreate;
        private DevExpress.XtraGrid.GridControl gridControlCoffee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCoffee;
        private DevExpress.XtraGrid.Columns.GridColumn CoffeeTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn CoffeeTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
    }
}