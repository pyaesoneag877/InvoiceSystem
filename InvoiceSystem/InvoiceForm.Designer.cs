
namespace InvoiceSystem
{
    partial class InvoiceForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.cboCustomerName = new System.Windows.Forms.ComboBox();
            this.cboCoffeeName = new System.Windows.Forms.ComboBox();
            this.cboInvoiceStatus = new System.Windows.Forms.ComboBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.rtxtRemark = new System.Windows.Forms.RichTextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.linkLabelDelete = new System.Windows.Forms.LinkLabel();
            this.txtInvoiceId = new System.Windows.Forms.TextBox();
            this.gridControlInvoice = new DevExpress.XtraGrid.GridControl();
            this.gridViewInvoice = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.InvoiceId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InvoiceNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CoffeeTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CoffeeTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Discount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BalanceAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InvoiceDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InvoiceStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Remark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblGotoCoffee = new System.Windows.Forms.LinkLabel();
            this.lblCustomer = new System.Windows.Forms.LinkLabel();
            this.lblLogout = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.PritLink = new System.Windows.Forms.LinkLabel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemQty = new System.Windows.Forms.TextBox();
            this.txtItemPrice = new System.Windows.Forms.TextBox();
            this.txtItemDiscount = new System.Windows.Forms.TextBox();
            this.txtItemTotalAmount = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
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
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnItemUpdate = new System.Windows.Forms.Button();
            this.butItemDelete = new System.Windows.Forms.Button();
            this.cboItemCoffeeName = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.linkLblReport = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Invoice Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.SaddleBrown;
            this.label8.Location = new System.Drawing.Point(249, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(249, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Invoice Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Remark";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtInvoiceNo.ForeColor = System.Drawing.SystemColors.Info;
            this.txtInvoiceNo.Location = new System.Drawing.Point(110, 75);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(121, 20);
            this.txtInvoiceNo.TabIndex = 10;
            // 
            // cboCustomerName
            // 
            this.cboCustomerName.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cboCustomerName.ForeColor = System.Drawing.SystemColors.Info;
            this.cboCustomerName.FormattingEnabled = true;
            this.cboCustomerName.Location = new System.Drawing.Point(110, 111);
            this.cboCustomerName.Name = "cboCustomerName";
            this.cboCustomerName.Size = new System.Drawing.Size(121, 21);
            this.cboCustomerName.TabIndex = 11;
            this.cboCustomerName.SelectedIndexChanged += new System.EventHandler(this.cboCustomerName_SelectedIndexChanged);
            // 
            // cboCoffeeName
            // 
            this.cboCoffeeName.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cboCoffeeName.ForeColor = System.Drawing.SystemColors.Info;
            this.cboCoffeeName.FormattingEnabled = true;
            this.cboCoffeeName.Location = new System.Drawing.Point(499, 67);
            this.cboCoffeeName.Name = "cboCoffeeName";
            this.cboCoffeeName.Size = new System.Drawing.Size(10, 21);
            this.cboCoffeeName.TabIndex = 12;
            this.cboCoffeeName.Visible = false;
            this.cboCoffeeName.SelectedIndexChanged += new System.EventHandler(this.cboCoffeeName_SelectedIndexChanged);
            // 
            // cboInvoiceStatus
            // 
            this.cboInvoiceStatus.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cboInvoiceStatus.ForeColor = System.Drawing.SystemColors.Info;
            this.cboInvoiceStatus.FormattingEnabled = true;
            this.cboInvoiceStatus.Items.AddRange(new object[] {
            "New",
            "Completed",
            "Cancelled"});
            this.cboInvoiceStatus.Location = new System.Drawing.Point(110, 150);
            this.cboInvoiceStatus.Name = "cboInvoiceStatus";
            this.cboInvoiceStatus.Size = new System.Drawing.Size(121, 21);
            this.cboInvoiceStatus.TabIndex = 13;
            // 
            // txtQty
            // 
            this.txtQty.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtQty.ForeColor = System.Drawing.SystemColors.Info;
            this.txtQty.Location = new System.Drawing.Point(499, 167);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(10, 20);
            this.txtQty.TabIndex = 14;
            this.txtQty.Visible = false;
            this.txtQty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyUp);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPrice.ForeColor = System.Drawing.SystemColors.Info;
            this.txtPrice.Location = new System.Drawing.Point(499, 141);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(10, 20);
            this.txtPrice.TabIndex = 15;
            this.txtPrice.Visible = false;
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDiscount.ForeColor = System.Drawing.SystemColors.Info;
            this.txtDiscount.Location = new System.Drawing.Point(326, 111);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(121, 20);
            this.txtDiscount.TabIndex = 16;
            this.txtDiscount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDiscount_KeyUp);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTotalAmount.ForeColor = System.Drawing.SystemColors.Info;
            this.txtTotalAmount.Location = new System.Drawing.Point(326, 150);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(118, 20);
            this.txtTotalAmount.TabIndex = 17;
            this.txtTotalAmount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTotalAmount_KeyUp);
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpInvoiceDate.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(323, 75);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(121, 20);
            this.dtpInvoiceDate.TabIndex = 18;
            // 
            // rtxtRemark
            // 
            this.rtxtRemark.BackColor = System.Drawing.Color.Black;
            this.rtxtRemark.ForeColor = System.Drawing.SystemColors.Info;
            this.rtxtRemark.Location = new System.Drawing.Point(109, 188);
            this.rtxtRemark.Name = "rtxtRemark";
            this.rtxtRemark.Size = new System.Drawing.Size(122, 34);
            this.rtxtRemark.TabIndex = 19;
            this.rtxtRemark.Text = "";
            this.rtxtRemark.TextChanged += new System.EventHandler(this.rtxtRemark_TextChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.Location = new System.Drawing.Point(369, 246);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 20;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(110, 246);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // linkLabelDelete
            // 
            this.linkLabelDelete.AutoSize = true;
            this.linkLabelDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelDelete.LinkColor = System.Drawing.Color.Black;
            this.linkLabelDelete.Location = new System.Drawing.Point(348, 254);
            this.linkLabelDelete.Name = "linkLabelDelete";
            this.linkLabelDelete.Size = new System.Drawing.Size(0, 15);
            this.linkLabelDelete.TabIndex = 22;
            this.linkLabelDelete.Visible = false;
            this.linkLabelDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDelete_LinkClicked);
            // 
            // txtInvoiceId
            // 
            this.txtInvoiceId.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtInvoiceId.ForeColor = System.Drawing.SystemColors.Info;
            this.txtInvoiceId.Location = new System.Drawing.Point(499, 202);
            this.txtInvoiceId.Name = "txtInvoiceId";
            this.txtInvoiceId.Size = new System.Drawing.Size(10, 20);
            this.txtInvoiceId.TabIndex = 23;
            this.txtInvoiceId.Visible = false;
            // 
            // gridControlInvoice
            // 
            this.gridControlInvoice.Location = new System.Drawing.Point(12, 324);
            this.gridControlInvoice.MainView = this.gridViewInvoice;
            this.gridControlInvoice.Name = "gridControlInvoice";
            this.gridControlInvoice.Size = new System.Drawing.Size(435, 159);
            this.gridControlInvoice.TabIndex = 24;
            this.gridControlInvoice.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewInvoice});
            // 
            // gridViewInvoice
            // 
            this.gridViewInvoice.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.InvoiceId,
            this.InvoiceNo,
            this.CustomerId,
            this.CustomerName,
            this.CoffeeTypeId,
            this.CoffeeTypeName,
            this.Qty,
            this.Price,
            this.Discount,
            this.TotalAmount,
            this.BalanceAmount,
            this.InvoiceDate,
            this.InvoiceStatus,
            this.Remark});
            this.gridViewInvoice.GridControl = this.gridControlInvoice;
            this.gridViewInvoice.Name = "gridViewInvoice";
            this.gridViewInvoice.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewInvoice_RowClick);
            // 
            // InvoiceId
            // 
            this.InvoiceId.Caption = "InvoiceId";
            this.InvoiceId.FieldName = "InvoiceId";
            this.InvoiceId.Name = "InvoiceId";
            // 
            // InvoiceNo
            // 
            this.InvoiceNo.Caption = "InvoiceNo";
            this.InvoiceNo.FieldName = "InvoiceNo";
            this.InvoiceNo.Name = "InvoiceNo";
            this.InvoiceNo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "InvoiceNo", "{0}")});
            this.InvoiceNo.Visible = true;
            this.InvoiceNo.VisibleIndex = 0;
            // 
            // CustomerId
            // 
            this.CustomerId.Caption = "CustomerId";
            this.CustomerId.FieldName = "CustomerId";
            this.CustomerId.Name = "CustomerId";
            // 
            // CustomerName
            // 
            this.CustomerName.Caption = "CustomerName";
            this.CustomerName.FieldName = "CustomerName";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "CustomerName", "{0}")});
            this.CustomerName.Visible = true;
            this.CustomerName.VisibleIndex = 1;
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
            // 
            // Qty
            // 
            this.Qty.Caption = "Qty";
            this.Qty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Qty.FieldName = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Qty", "{0}")});
            // 
            // Price
            // 
            this.Price.Caption = "Price";
            this.Price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Price.FieldName = "Price";
            this.Price.Name = "Price";
            this.Price.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Price", "{0}")});
            // 
            // Discount
            // 
            this.Discount.Caption = "Discount";
            this.Discount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Discount.FieldName = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Discount", "{0}")});
            this.Discount.Visible = true;
            this.Discount.VisibleIndex = 6;
            // 
            // TotalAmount
            // 
            this.TotalAmount.Caption = "TotalAmount";
            this.TotalAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TotalAmount.FieldName = "TotalAmount";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "TotalAmount", "{0}")});
            this.TotalAmount.Visible = true;
            this.TotalAmount.VisibleIndex = 2;
            // 
            // BalanceAmount
            // 
            this.BalanceAmount.Caption = "BalanceAmount";
            this.BalanceAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.BalanceAmount.FieldName = "Balance";
            this.BalanceAmount.Name = "BalanceAmount";
            this.BalanceAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Balance", "{0}")});
            this.BalanceAmount.Visible = true;
            this.BalanceAmount.VisibleIndex = 7;
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.Caption = "InvoiceDate";
            this.InvoiceDate.DisplayFormat.FormatString = "d";
            this.InvoiceDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.InvoiceDate.FieldName = "InvoiceDate";
            this.InvoiceDate.Name = "InvoiceDate";
            this.InvoiceDate.Visible = true;
            this.InvoiceDate.VisibleIndex = 3;
            // 
            // InvoiceStatus
            // 
            this.InvoiceStatus.Caption = "InvoiceStatus";
            this.InvoiceStatus.FieldName = "InvoiceStatus";
            this.InvoiceStatus.Name = "InvoiceStatus";
            this.InvoiceStatus.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "InvoiceStatus", "{0}")});
            this.InvoiceStatus.Visible = true;
            this.InvoiceStatus.VisibleIndex = 4;
            // 
            // Remark
            // 
            this.Remark.Caption = "Remark";
            this.Remark.FieldName = "Remark";
            this.Remark.Name = "Remark";
            this.Remark.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Remark", "{0}")});
            this.Remark.Visible = true;
            this.Remark.VisibleIndex = 5;
            // 
            // lblGotoCoffee
            // 
            this.lblGotoCoffee.AutoSize = true;
            this.lblGotoCoffee.LinkColor = System.Drawing.Color.Black;
            this.lblGotoCoffee.Location = new System.Drawing.Point(320, 21);
            this.lblGotoCoffee.Name = "lblGotoCoffee";
            this.lblGotoCoffee.Size = new System.Drawing.Size(38, 13);
            this.lblGotoCoffee.TabIndex = 25;
            this.lblGotoCoffee.TabStop = true;
            this.lblGotoCoffee.Text = "Coffee";
            this.lblGotoCoffee.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGotoCoffee_LinkClicked);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.LinkColor = System.Drawing.Color.Black;
            this.lblCustomer.Location = new System.Drawing.Point(227, 21);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(51, 13);
            this.lblCustomer.TabIndex = 26;
            this.lblCustomer.TabStop = true;
            this.lblCustomer.Text = "Customer";
            this.lblCustomer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCustomer_LinkClicked);
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.LinkColor = System.Drawing.Color.Black;
            this.lblLogout.Location = new System.Drawing.Point(404, 21);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(40, 13);
            this.lblLogout.TabIndex = 27;
            this.lblLogout.TabStop = true;
            this.lblLogout.Text = "Logout";
            this.lblLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLogout_LinkClicked);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(7, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "Invoice System";
            // 
            // PritLink
            // 
            this.PritLink.AutoSize = true;
            this.PritLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PritLink.LinkColor = System.Drawing.Color.Black;
            this.PritLink.Location = new System.Drawing.Point(408, 303);
            this.PritLink.Name = "PritLink";
            this.PritLink.Size = new System.Drawing.Size(39, 15);
            this.PritLink.TabIndex = 29;
            this.PritLink.TabStop = true;
            this.PritLink.Text = "Print?";
            this.PritLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PritLink_LinkClicked);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(9, 246);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(581, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Item Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(581, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Qty";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(812, 117);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Price";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(581, 152);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Discount";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(813, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Total Amount";
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtItemName.ForeColor = System.Drawing.SystemColors.Info;
            this.txtItemName.Location = new System.Drawing.Point(662, 75);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(121, 20);
            this.txtItemName.TabIndex = 41;
            // 
            // txtItemQty
            // 
            this.txtItemQty.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtItemQty.ForeColor = System.Drawing.SystemColors.Info;
            this.txtItemQty.Location = new System.Drawing.Point(662, 114);
            this.txtItemQty.Name = "txtItemQty";
            this.txtItemQty.Size = new System.Drawing.Size(121, 20);
            this.txtItemQty.TabIndex = 42;
            this.txtItemQty.TextChanged += new System.EventHandler(this.txtItemQty_TextChanged);
            this.txtItemQty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtItemQty_KeyUp);
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtItemPrice.ForeColor = System.Drawing.SystemColors.Info;
            this.txtItemPrice.Location = new System.Drawing.Point(889, 114);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(121, 20);
            this.txtItemPrice.TabIndex = 43;
            this.txtItemPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtItemPrice_KeyUp);
            // 
            // txtItemDiscount
            // 
            this.txtItemDiscount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtItemDiscount.ForeColor = System.Drawing.SystemColors.Info;
            this.txtItemDiscount.Location = new System.Drawing.Point(662, 150);
            this.txtItemDiscount.Name = "txtItemDiscount";
            this.txtItemDiscount.Size = new System.Drawing.Size(121, 20);
            this.txtItemDiscount.TabIndex = 44;
            this.txtItemDiscount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtItemDiscount_KeyUp);
            // 
            // txtItemTotalAmount
            // 
            this.txtItemTotalAmount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtItemTotalAmount.ForeColor = System.Drawing.SystemColors.Info;
            this.txtItemTotalAmount.Location = new System.Drawing.Point(889, 149);
            this.txtItemTotalAmount.Name = "txtItemTotalAmount";
            this.txtItemTotalAmount.Size = new System.Drawing.Size(121, 20);
            this.txtItemTotalAmount.TabIndex = 45;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(935, 246);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 46;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnAdd_KeyUp);
            // 
            // txtItemId
            // 
            this.txtItemId.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtItemId.ForeColor = System.Drawing.SystemColors.Info;
            this.txtItemId.Location = new System.Drawing.Point(662, 191);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(121, 20);
            this.txtItemId.TabIndex = 47;
            this.txtItemId.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(812, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 13);
            this.label17.TabIndex = 48;
            this.label17.Text = "Coffee Name";
            // 
            // gridControlItem
            // 
            this.gridControlItem.Location = new System.Drawing.Point(584, 322);
            this.gridControlItem.MainView = this.gridViewItem;
            this.gridControlItem.Name = "gridControlItem";
            this.gridControlItem.Size = new System.Drawing.Size(426, 159);
            this.gridControlItem.TabIndex = 50;
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
            this.gridViewItem.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewItem_RowClick);
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
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(581, 303);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 16);
            this.label18.TabIndex = 51;
            this.label18.Text = "Item List";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(9, 306);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 16);
            this.label19.TabIndex = 52;
            this.label19.Text = "Invoice List";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(577, 40);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 16);
            this.label20.TabIndex = 53;
            this.label20.Text = "Add Item";
            // 
            // btnItemUpdate
            // 
            this.btnItemUpdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnItemUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItemUpdate.Location = new System.Drawing.Point(689, 246);
            this.btnItemUpdate.Name = "btnItemUpdate";
            this.btnItemUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnItemUpdate.TabIndex = 54;
            this.btnItemUpdate.Text = "Update";
            this.btnItemUpdate.UseVisualStyleBackColor = false;
            this.btnItemUpdate.Click += new System.EventHandler(this.btnItemUpdate_Click);
            this.btnItemUpdate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnItemUpdate_KeyUp);
            // 
            // butItemDelete
            // 
            this.butItemDelete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butItemDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butItemDelete.Location = new System.Drawing.Point(584, 246);
            this.butItemDelete.Name = "butItemDelete";
            this.butItemDelete.Size = new System.Drawing.Size(75, 23);
            this.butItemDelete.TabIndex = 55;
            this.butItemDelete.Text = "Delete";
            this.butItemDelete.UseVisualStyleBackColor = false;
            this.butItemDelete.Click += new System.EventHandler(this.butItemDelete_Click);
            this.butItemDelete.KeyUp += new System.Windows.Forms.KeyEventHandler(this.butItemDelete_KeyUp);
            // 
            // cboItemCoffeeName
            // 
            this.cboItemCoffeeName.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cboItemCoffeeName.ForeColor = System.Drawing.SystemColors.Info;
            this.cboItemCoffeeName.FormattingEnabled = true;
            this.cboItemCoffeeName.Location = new System.Drawing.Point(887, 75);
            this.cboItemCoffeeName.Name = "cboItemCoffeeName";
            this.cboItemCoffeeName.Size = new System.Drawing.Size(121, 21);
            this.cboItemCoffeeName.TabIndex = 56;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(249, 114);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 13);
            this.label21.TabIndex = 57;
            this.label21.Text = "Discount";
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBalance.ForeColor = System.Drawing.SystemColors.Info;
            this.txtBalance.Location = new System.Drawing.Point(326, 188);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(121, 20);
            this.txtBalance.TabIndex = 58;
            this.txtBalance.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBalance_KeyUp);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(249, 191);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(46, 13);
            this.label22.TabIndex = 59;
            this.label22.Text = "Balance";
            // 
            // linkLblReport
            // 
            this.linkLblReport.AutoSize = true;
            this.linkLblReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblReport.LinkColor = System.Drawing.Color.Black;
            this.linkLblReport.Location = new System.Drawing.Point(332, 303);
            this.linkLblReport.Name = "linkLblReport";
            this.linkLblReport.Size = new System.Drawing.Size(51, 15);
            this.linkLblReport.TabIndex = 60;
            this.linkLblReport.TabStop = true;
            this.linkLblReport.Text = "Report?";
            this.linkLblReport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblReport_LinkClicked);
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(1063, 511);
            this.Controls.Add(this.linkLblReport);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.cboItemCoffeeName);
            this.Controls.Add(this.butItemDelete);
            this.Controls.Add(this.btnItemUpdate);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.gridControlItem);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtItemId);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtItemTotalAmount);
            this.Controls.Add(this.txtItemDiscount);
            this.Controls.Add(this.txtItemPrice);
            this.Controls.Add(this.txtItemQty);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.PritLink);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblGotoCoffee);
            this.Controls.Add(this.gridControlInvoice);
            this.Controls.Add(this.txtInvoiceId);
            this.Controls.Add(this.linkLabelDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.rtxtRemark);
            this.Controls.Add(this.dtpInvoiceDate);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.cboInvoiceStatus);
            this.Controls.Add(this.cboCoffeeName);
            this.Controls.Add(this.cboCustomerName);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "InvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoiceForm";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InvoiceForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.ComboBox cboCustomerName;
        private System.Windows.Forms.ComboBox cboCoffeeName;
        private System.Windows.Forms.ComboBox cboInvoiceStatus;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.RichTextBox rtxtRemark;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.LinkLabel linkLabelDelete;
        private System.Windows.Forms.TextBox txtInvoiceId;
        private DevExpress.XtraGrid.GridControl gridControlInvoice;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewInvoice;
        private DevExpress.XtraGrid.Columns.GridColumn InvoiceId;
        private DevExpress.XtraGrid.Columns.GridColumn InvoiceNo;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerId;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn CoffeeTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn CoffeeTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn Qty;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraGrid.Columns.GridColumn Discount;
        private DevExpress.XtraGrid.Columns.GridColumn TotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn InvoiceDate;
        private DevExpress.XtraGrid.Columns.GridColumn InvoiceStatus;
        private DevExpress.XtraGrid.Columns.GridColumn Remark;
        private System.Windows.Forms.LinkLabel lblGotoCoffee;
        private System.Windows.Forms.LinkLabel lblCustomer;
        private System.Windows.Forms.LinkLabel lblLogout;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel PritLink;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemQty;
        private System.Windows.Forms.TextBox txtItemPrice;
        private System.Windows.Forms.TextBox txtItemDiscount;
        private System.Windows.Forms.TextBox txtItemTotalAmount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.Label label17;
        private DevExpress.XtraGrid.GridControl gridControlItem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewItem;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnItemUpdate;
        private System.Windows.Forms.Button butItemDelete;
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
        private System.Windows.Forms.ComboBox cboItemCoffeeName;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label22;
        private DevExpress.XtraGrid.Columns.GridColumn BalanceAmount;
        private System.Windows.Forms.LinkLabel linkLblReport;
    }
}