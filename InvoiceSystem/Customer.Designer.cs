
namespace InvoiceSystem
{
    partial class Customer
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.rtxtAddress = new System.Windows.Forms.RichTextBox();
            this.rgoMale = new System.Windows.Forms.RadioButton();
            this.rgoFemale = new System.Windows.Forms.RadioButton();
            this.gridControlCustomer = new DevExpress.XtraGrid.GridControl();
            this.gridViewCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IsMember = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiscountAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkIsMember = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.linkGotoCoffee = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.linklblReport = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(10, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(226, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Is Member ?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(226, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Discount Amount";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Black;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreate.Location = new System.Drawing.Point(255, 240);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(183, 27);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtCustomerName.ForeColor = System.Drawing.Color.White;
            this.txtCustomerName.Location = new System.Drawing.Point(100, 55);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(106, 20);
            this.txtCustomerName.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPhone.ForeColor = System.Drawing.SystemColors.Info;
            this.txtPhone.Location = new System.Drawing.Point(320, 95);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(118, 20);
            this.txtPhone.TabIndex = 10;
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtDiscountAmount.ForeColor = System.Drawing.SystemColors.Info;
            this.txtDiscountAmount.Location = new System.Drawing.Point(320, 55);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.Size = new System.Drawing.Size(118, 20);
            this.txtDiscountAmount.TabIndex = 11;
            // 
            // rtxtAddress
            // 
            this.rtxtAddress.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rtxtAddress.ForeColor = System.Drawing.SystemColors.Info;
            this.rtxtAddress.Location = new System.Drawing.Point(96, 121);
            this.rtxtAddress.Name = "rtxtAddress";
            this.rtxtAddress.Size = new System.Drawing.Size(342, 56);
            this.rtxtAddress.TabIndex = 12;
            this.rtxtAddress.Text = "";
            // 
            // rgoMale
            // 
            this.rgoMale.AutoSize = true;
            this.rgoMale.Checked = true;
            this.rgoMale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rgoMale.Location = new System.Drawing.Point(96, 93);
            this.rgoMale.Name = "rgoMale";
            this.rgoMale.Size = new System.Drawing.Size(48, 17);
            this.rgoMale.TabIndex = 13;
            this.rgoMale.TabStop = true;
            this.rgoMale.Text = "Male";
            this.rgoMale.UseVisualStyleBackColor = true;
            // 
            // rgoFemale
            // 
            this.rgoFemale.AutoSize = true;
            this.rgoFemale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rgoFemale.Location = new System.Drawing.Point(147, 93);
            this.rgoFemale.Name = "rgoFemale";
            this.rgoFemale.Size = new System.Drawing.Size(59, 17);
            this.rgoFemale.TabIndex = 14;
            this.rgoFemale.Text = "Female";
            this.rgoFemale.UseVisualStyleBackColor = true;
            // 
            // gridControlCustomer
            // 
            this.gridControlCustomer.Location = new System.Drawing.Point(15, 305);
            this.gridControlCustomer.MainView = this.gridViewCustomer;
            this.gridControlCustomer.Name = "gridControlCustomer";
            this.gridControlCustomer.Size = new System.Drawing.Size(430, 179);
            this.gridControlCustomer.TabIndex = 15;
            this.gridControlCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCustomer});
            // 
            // gridViewCustomer
            // 
            this.gridViewCustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CustomerId,
            this.CustomerName,
            this.Gender,
            this.Phone,
            this.Address,
            this.IsMember,
            this.DiscountAmount});
            this.gridViewCustomer.GridControl = this.gridControlCustomer;
            this.gridViewCustomer.Name = "gridViewCustomer";
            this.gridViewCustomer.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewCustomer_RowClick);
            this.gridViewCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewCustomer_KeyDown);
            // 
            // CustomerId
            // 
            this.CustomerId.Caption = "CustomerId";
            this.CustomerId.FieldName = "CustomerId";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "CustomerId", "{0}")});
            // 
            // CustomerName
            // 
            this.CustomerName.Caption = "CustomerName";
            this.CustomerName.FieldName = "CustomerName";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "CustomerName", "{0}")});
            this.CustomerName.Visible = true;
            this.CustomerName.VisibleIndex = 0;
            // 
            // Gender
            // 
            this.Gender.Caption = "Gender";
            this.Gender.FieldName = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.OptionsColumn.AllowEdit = false;
            this.Gender.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Gender", "{0}")});
            this.Gender.Visible = true;
            this.Gender.VisibleIndex = 1;
            // 
            // Phone
            // 
            this.Phone.Caption = "Phone";
            this.Phone.FieldName = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Phone", "{0}")});
            this.Phone.Visible = true;
            this.Phone.VisibleIndex = 2;
            // 
            // Address
            // 
            this.Address.Caption = "Address";
            this.Address.FieldName = "Address";
            this.Address.Name = "Address";
            this.Address.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Address", "{0}")});
            this.Address.Visible = true;
            this.Address.VisibleIndex = 3;
            // 
            // IsMember
            // 
            this.IsMember.Caption = "IsMember";
            this.IsMember.FieldName = "IsMember";
            this.IsMember.Name = "IsMember";
            this.IsMember.OptionsColumn.AllowEdit = false;
            this.IsMember.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IsMember", "{0}")});
            this.IsMember.Visible = true;
            this.IsMember.VisibleIndex = 4;
            // 
            // DiscountAmount
            // 
            this.DiscountAmount.Caption = "DiscountAmount";
            this.DiscountAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DiscountAmount.FieldName = "DiscountAmount";
            this.DiscountAmount.Name = "DiscountAmount";
            this.DiscountAmount.Visible = true;
            this.DiscountAmount.VisibleIndex = 5;
            // 
            // chkIsMember
            // 
            this.chkIsMember.AutoSize = true;
            this.chkIsMember.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkIsMember.Location = new System.Drawing.Point(96, 204);
            this.chkIsMember.Name = "chkIsMember";
            this.chkIsMember.Size = new System.Drawing.Size(15, 14);
            this.chkIsMember.TabIndex = 16;
            this.chkIsMember.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(15, 240);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 27);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Black;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(124, 240);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 27);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtCustomerId.ForeColor = System.Drawing.SystemColors.Info;
            this.txtCustomerId.Location = new System.Drawing.Point(338, 201);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerId.TabIndex = 19;
            this.txtCustomerId.Visible = false;
            this.txtCustomerId.TextChanged += new System.EventHandler(this.txtCustomerId_TextChanged);
            // 
            // linkGotoCoffee
            // 
            this.linkGotoCoffee.AutoSize = true;
            this.linkGotoCoffee.LinkColor = System.Drawing.Color.Black;
            this.linkGotoCoffee.Location = new System.Drawing.Point(400, 20);
            this.linkGotoCoffee.Name = "linkGotoCoffee";
            this.linkGotoCoffee.Size = new System.Drawing.Size(38, 13);
            this.linkGotoCoffee.TabIndex = 20;
            this.linkGotoCoffee.TabStop = true;
            this.linkGotoCoffee.Text = "Coffee";
            this.linkGotoCoffee.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGotoCoffee_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(8, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Invoice System";
            // 
            // linklblReport
            // 
            this.linklblReport.AutoSize = true;
            this.linklblReport.LinkColor = System.Drawing.Color.Black;
            this.linklblReport.Location = new System.Drawing.Point(406, 498);
            this.linklblReport.Name = "linklblReport";
            this.linklblReport.Size = new System.Drawing.Size(45, 13);
            this.linklblReport.TabIndex = 22;
            this.linklblReport.TabStop = true;
            this.linklblReport.Text = "Report?";
            this.linklblReport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblReport_LinkClicked);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(459, 518);
            this.Controls.Add(this.linklblReport);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linkGotoCoffee);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.chkIsMember);
            this.Controls.Add(this.gridControlCustomer);
            this.Controls.Add(this.rgoFemale);
            this.Controls.Add(this.rgoMale);
            this.Controls.Add(this.rtxtAddress);
            this.Controls.Add(this.txtDiscountAmount);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Customer_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomer)).EndInit();
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
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtDiscountAmount;
        private System.Windows.Forms.RichTextBox rtxtAddress;
        private System.Windows.Forms.RadioButton rgoMale;
        private System.Windows.Forms.RadioButton rgoFemale;
        private DevExpress.XtraGrid.GridControl gridControlCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerId;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn Gender;
        private DevExpress.XtraGrid.Columns.GridColumn Phone;
        private DevExpress.XtraGrid.Columns.GridColumn Address;
        private DevExpress.XtraGrid.Columns.GridColumn IsMember;
        private DevExpress.XtraGrid.Columns.GridColumn DiscountAmount;
        private System.Windows.Forms.CheckBox chkIsMember;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.LinkLabel linkGotoCoffee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linklblReport;
    }
}