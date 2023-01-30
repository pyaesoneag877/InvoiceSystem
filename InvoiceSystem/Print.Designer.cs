
namespace InvoiceSystem
{
    partial class Print
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCoffeeName = new System.Windows.Forms.Label();
            this.lblInvoiceStatus = new System.Windows.Forms.Label();
            this.lblRemark = new System.Windows.Forms.Label();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.gridControlItem = new DevExpress.XtraGrid.GridControl();
            this.gridViewItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ItemId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CoffeeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CoffeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id_Invoice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Invoice_Number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Item_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Item_Discount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Item_TotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtInvoice_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblDiscountTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice No : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Coffee Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(332, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Remark :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(409, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Invoice Date :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(155, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 15);
            this.label8.TabIndex = 7;
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(155, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 8;
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(395, 377);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Total Amount :";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 451);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(262, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Thank You for your purchase. Be Happy ";
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNo.Location = new System.Drawing.Point(105, 46);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(0, 16);
            this.lblInvoiceNo.TabIndex = 11;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(160, 85);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(0, 15);
            this.lblCustomerName.TabIndex = 12;
            // 
            // lblCoffeeName
            // 
            this.lblCoffeeName.AutoSize = true;
            this.lblCoffeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoffeeName.Location = new System.Drawing.Point(160, 124);
            this.lblCoffeeName.Name = "lblCoffeeName";
            this.lblCoffeeName.Size = new System.Drawing.Size(0, 15);
            this.lblCoffeeName.TabIndex = 13;
            // 
            // lblInvoiceStatus
            // 
            this.lblInvoiceStatus.AutoSize = true;
            this.lblInvoiceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceStatus.Location = new System.Drawing.Point(460, 85);
            this.lblInvoiceStatus.Name = "lblInvoiceStatus";
            this.lblInvoiceStatus.Size = new System.Drawing.Size(0, 15);
            this.lblInvoiceStatus.TabIndex = 14;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(409, 124);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(0, 13);
            this.lblRemark.TabIndex = 15;
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceDate.Location = new System.Drawing.Point(504, 46);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(0, 16);
            this.lblInvoiceDate.TabIndex = 16;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(216, 22);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(0, 15);
            this.lblQty.TabIndex = 17;
            this.lblQty.Visible = false;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(216, 37);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(0, 15);
            this.lblDiscount.TabIndex = 18;
            this.lblDiscount.Visible = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(216, 65);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 15);
            this.lblPrice.TabIndex = 19;
            this.lblPrice.Visible = false;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(519, 377);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(0, 18);
            this.lblTotalAmount.TabIndex = 20;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label22.Location = new System.Drawing.Point(234, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(171, 25);
            this.label22.TabIndex = 29;
            this.label22.Text = "Invoice System";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(602, 468);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 15);
            this.linkLabel1.TabIndex = 30;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cancel";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(265, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 15);
            this.label12.TabIndex = 31;
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(265, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 15);
            this.label13.TabIndex = 32;
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(606, 377);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 18);
            this.label14.TabIndex = 33;
            this.label14.Text = "MMK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(332, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Invoice Status :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(16, 151);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 16);
            this.label18.TabIndex = 53;
            this.label18.Text = "Item List";
            // 
            // gridControlItem
            // 
            this.gridControlItem.Location = new System.Drawing.Point(19, 170);
            this.gridControlItem.MainView = this.gridViewItem;
            this.gridControlItem.Name = "gridControlItem";
            this.gridControlItem.Size = new System.Drawing.Size(632, 194);
            this.gridControlItem.TabIndex = 52;
            this.gridControlItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewItem});
            // 
            // gridViewItem
            // 
            this.gridViewItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ItemId,
            this.ItemName,
            this.CoffeeId,
            this.CoffeeName,
            this.Id_Invoice,
            this.Invoice_Number,
            this.Quantity,
            this.Item_Price,
            this.Item_Discount,
            this.Item_TotalAmount});
            this.gridViewItem.GridControl = this.gridControlItem;
            this.gridViewItem.Name = "gridViewItem";
            // 
            // ItemId
            // 
            this.ItemId.Caption = "ItemId";
            this.ItemId.FieldName = "ItemId";
            this.ItemId.Name = "ItemId";
            // 
            // ItemName
            // 
            this.ItemName.Caption = "ItemName";
            this.ItemName.FieldName = "ItemName";
            this.ItemName.Name = "ItemName";
            this.ItemName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "ItemName", "{0}")});
            this.ItemName.Visible = true;
            this.ItemName.VisibleIndex = 0;
            // 
            // CoffeeId
            // 
            this.CoffeeId.Caption = "CoffeeId";
            this.CoffeeId.FieldName = "CoffeeTypeId";
            this.CoffeeId.Name = "CoffeeId";
            // 
            // CoffeeName
            // 
            this.CoffeeName.Caption = "CoffeeName";
            this.CoffeeName.FieldName = "CoffeeTypeName";
            this.CoffeeName.Name = "CoffeeName";
            this.CoffeeName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "CoffeeTypeName", "{0}")});
            this.CoffeeName.Visible = true;
            this.CoffeeName.VisibleIndex = 1;
            // 
            // Id_Invoice
            // 
            this.Id_Invoice.Caption = "Id_Invoice";
            this.Id_Invoice.FieldName = "InvoiceId";
            this.Id_Invoice.Name = "Id_Invoice";
            // 
            // Invoice_Number
            // 
            this.Invoice_Number.Caption = "Invoice_Number";
            this.Invoice_Number.FieldName = "InvoiceNo";
            this.Invoice_Number.Name = "Invoice_Number";
            this.Invoice_Number.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "InvoiceNo", "{0}")});
            this.Invoice_Number.Visible = true;
            this.Invoice_Number.VisibleIndex = 2;
            // 
            // Quantity
            // 
            this.Quantity.Caption = "Quantity";
            this.Quantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Quantity.FieldName = "Qty";
            this.Quantity.Name = "Quantity";
            this.Quantity.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Qty", "{0}")});
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 3;
            // 
            // Item_Price
            // 
            this.Item_Price.Caption = "Item_Price";
            this.Item_Price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Item_Price.FieldName = "Price";
            this.Item_Price.Name = "Item_Price";
            this.Item_Price.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Price", "{0}")});
            this.Item_Price.Visible = true;
            this.Item_Price.VisibleIndex = 4;
            // 
            // Item_Discount
            // 
            this.Item_Discount.Caption = "Item_Discount";
            this.Item_Discount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Item_Discount.FieldName = "Discount";
            this.Item_Discount.Name = "Item_Discount";
            this.Item_Discount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Discount", "{0}")});
            this.Item_Discount.Visible = true;
            this.Item_Discount.VisibleIndex = 5;
            // 
            // Item_TotalAmount
            // 
            this.Item_TotalAmount.Caption = "Item_TotalAmount";
            this.Item_TotalAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Item_TotalAmount.FieldName = "TotalAmount";
            this.Item_TotalAmount.Name = "Item_TotalAmount";
            this.Item_TotalAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "TotalAmount", "{0}")});
            this.Item_TotalAmount.Visible = true;
            this.Item_TotalAmount.VisibleIndex = 6;
            // 
            // txtInvoice_id
            // 
            this.txtInvoice_id.Location = new System.Drawing.Point(19, 9);
            this.txtInvoice_id.Name = "txtInvoice_id";
            this.txtInvoice_id.Size = new System.Drawing.Size(100, 20);
            this.txtInvoice_id.TabIndex = 54;
            this.txtInvoice_id.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(435, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 55;
            this.label7.Text = "Balance :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(606, 432);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 18);
            this.label15.TabIndex = 56;
            this.label15.Text = "MMK";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(519, 432);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 18);
            this.lblBalance.TabIndex = 57;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(428, 404);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 18);
            this.label16.TabIndex = 58;
            this.label16.Text = "Discount :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(606, 404);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 18);
            this.label17.TabIndex = 59;
            this.label17.Text = "MMK";
            // 
            // lblDiscountTotal
            // 
            this.lblDiscountTotal.AutoSize = true;
            this.lblDiscountTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountTotal.Location = new System.Drawing.Point(519, 404);
            this.lblDiscountTotal.Name = "lblDiscountTotal";
            this.lblDiscountTotal.Size = new System.Drawing.Size(0, 18);
            this.lblDiscountTotal.TabIndex = 60;
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 492);
            this.Controls.Add(this.lblDiscountTotal);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtInvoice_id);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.gridControlItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblInvoiceDate);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.lblInvoiceStatus);
            this.Controls.Add(this.lblCoffeeName);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblInvoiceNo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Print";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print";
            this.Load += new System.EventHandler(this.Print_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Print_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.Label lblInvoiceNo;
        public System.Windows.Forms.Label lblCustomerName;
        public System.Windows.Forms.Label lblCoffeeName;
        public System.Windows.Forms.Label lblInvoiceStatus;
        public System.Windows.Forms.Label lblRemark;
        public System.Windows.Forms.Label lblInvoiceDate;
        public System.Windows.Forms.Label lblQty;
        public System.Windows.Forms.Label lblDiscount;
        public System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label18;
        private DevExpress.XtraGrid.Columns.GridColumn ItemId;
        private DevExpress.XtraGrid.Columns.GridColumn ItemName;
        private DevExpress.XtraGrid.Columns.GridColumn CoffeeId;
        private DevExpress.XtraGrid.Columns.GridColumn CoffeeName;
        private DevExpress.XtraGrid.Columns.GridColumn Id_Invoice;
        private DevExpress.XtraGrid.Columns.GridColumn Invoice_Number;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn Item_Price;
        private DevExpress.XtraGrid.Columns.GridColumn Item_Discount;
        private DevExpress.XtraGrid.Columns.GridColumn Item_TotalAmount;
        public System.Windows.Forms.TextBox txtInvoice_id;
        public DevExpress.XtraGrid.GridControl gridControlItem;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label lblDiscountTotal;
    }
}