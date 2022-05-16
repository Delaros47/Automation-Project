namespace AutomationUI.Forms.InvoiceForms
{
    partial class SalesInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesInvoice));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblCustomerCode = new DevExpress.XtraEditors.LabelControl();
            this.txtCustomerCode = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.lblCustomerName = new DevExpress.XtraEditors.LabelControl();
            this.txtCustomerName = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.lblInvoiceType = new DevExpress.XtraEditors.LabelControl();
            this.txtInvoiceType = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.lblPaymentPlace = new DevExpress.XtraEditors.LabelControl();
            this.myTextEdit2 = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.lblInvoiceNumber = new DevExpress.XtraEditors.LabelControl();
            this.txtInvoiceNumber = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.lblDispatchNoteNumber = new DevExpress.XtraEditors.LabelControl();
            this.lblDispatchNoteDate = new DevExpress.XtraEditors.LabelControl();
            this.lblInvoiceDate = new DevExpress.XtraEditors.LabelControl();
            this.txtDispatchNoteNumber = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.deInvoiceDate = new AutomationUI.UserControls.Controls.MyDateEdit();
            this.deDispatchNoteDate = new AutomationUI.UserControls.Controls.MyDateEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlSalesInvoice = new AutomationUI.UserControls.Grids.MyGridControl();
            this.gridViewSalesInvoice = new AutomationUI.UserControls.Grids.MyGridView();
            this.btnSave = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.btnUpdate = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.btnDelete = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.btnExit = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.lblSubTotal = new DevExpress.XtraEditors.LabelControl();
            this.myTextEdit1 = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.txtSubTotal = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.txtVAT = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.lblDiscount = new DevExpress.XtraEditors.LabelControl();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.lblVAT = new DevExpress.XtraEditors.LabelControl();
            this.txtDiscount = new AutomationUI.UserControls.Controls.MyTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTextEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDispatchNoteNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInvoiceDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDispatchNoteDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDispatchNoteDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSalesInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSalesInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVAT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.panelControl2);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Controls.Add(this.btnExit);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1148, 159);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Invoice Informations";
            // 
            // lblCustomerCode
            // 
            this.lblCustomerCode.Location = new System.Drawing.Point(16, 14);
            this.lblCustomerCode.Name = "lblCustomerCode";
            this.lblCustomerCode.Size = new System.Drawing.Size(74, 13);
            this.lblCustomerCode.TabIndex = 0;
            this.lblCustomerCode.Text = "Customer Code";
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.EnterMoveNextControl = true;
            this.txtCustomerCode.Location = new System.Drawing.Point(105, 11);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtCustomerCode.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtCustomerCode.Properties.MaxLength = 50;
            this.txtCustomerCode.Size = new System.Drawing.Size(127, 20);
            this.txtCustomerCode.TabIndex = 1;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Location = new System.Drawing.Point(16, 40);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(76, 13);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.EnterMoveNextControl = true;
            this.txtCustomerName.Location = new System.Drawing.Point(105, 37);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtCustomerName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtCustomerName.Properties.MaxLength = 50;
            this.txtCustomerName.Size = new System.Drawing.Size(127, 20);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lblInvoiceType
            // 
            this.lblInvoiceType.Location = new System.Drawing.Point(16, 67);
            this.lblInvoiceType.Name = "lblInvoiceType";
            this.lblInvoiceType.Size = new System.Drawing.Size(62, 13);
            this.lblInvoiceType.TabIndex = 0;
            this.lblInvoiceType.Text = "Invoice Type";
            // 
            // txtInvoiceType
            // 
            this.txtInvoiceType.EnterMoveNextControl = true;
            this.txtInvoiceType.Location = new System.Drawing.Point(105, 64);
            this.txtInvoiceType.Name = "txtInvoiceType";
            this.txtInvoiceType.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtInvoiceType.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtInvoiceType.Properties.MaxLength = 50;
            this.txtInvoiceType.Size = new System.Drawing.Size(127, 20);
            this.txtInvoiceType.TabIndex = 1;
            // 
            // lblPaymentPlace
            // 
            this.lblPaymentPlace.Location = new System.Drawing.Point(16, 93);
            this.lblPaymentPlace.Name = "lblPaymentPlace";
            this.lblPaymentPlace.Size = new System.Drawing.Size(70, 13);
            this.lblPaymentPlace.TabIndex = 0;
            this.lblPaymentPlace.Text = "Payment Place";
            // 
            // myTextEdit2
            // 
            this.myTextEdit2.EnterMoveNextControl = true;
            this.myTextEdit2.Location = new System.Drawing.Point(105, 90);
            this.myTextEdit2.Name = "myTextEdit2";
            this.myTextEdit2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.myTextEdit2.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.myTextEdit2.Properties.MaxLength = 50;
            this.myTextEdit2.Size = new System.Drawing.Size(127, 20);
            this.myTextEdit2.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblCustomerCode);
            this.panelControl1.Controls.Add(this.myTextEdit2);
            this.panelControl1.Controls.Add(this.txtCustomerCode);
            this.panelControl1.Controls.Add(this.txtCustomerName);
            this.panelControl1.Controls.Add(this.lblInvoiceType);
            this.panelControl1.Controls.Add(this.lblPaymentPlace);
            this.panelControl1.Controls.Add(this.lblCustomerName);
            this.panelControl1.Controls.Add(this.txtInvoiceType);
            this.panelControl1.Location = new System.Drawing.Point(12, 26);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(253, 119);
            this.panelControl1.TabIndex = 2;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.deDispatchNoteDate);
            this.panelControl2.Controls.Add(this.deInvoiceDate);
            this.panelControl2.Controls.Add(this.lblInvoiceNumber);
            this.panelControl2.Controls.Add(this.txtInvoiceNumber);
            this.panelControl2.Controls.Add(this.lblDispatchNoteNumber);
            this.panelControl2.Controls.Add(this.lblDispatchNoteDate);
            this.panelControl2.Controls.Add(this.lblInvoiceDate);
            this.panelControl2.Controls.Add(this.txtDispatchNoteNumber);
            this.panelControl2.Location = new System.Drawing.Point(282, 27);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(281, 119);
            this.panelControl2.TabIndex = 3;
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.Location = new System.Drawing.Point(16, 14);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Size = new System.Drawing.Size(75, 13);
            this.lblInvoiceNumber.TabIndex = 0;
            this.lblInvoiceNumber.Text = "Invoice Number";
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.EnterMoveNextControl = true;
            this.txtInvoiceNumber.Location = new System.Drawing.Point(135, 11);
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtInvoiceNumber.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtInvoiceNumber.Properties.MaxLength = 50;
            this.txtInvoiceNumber.Size = new System.Drawing.Size(127, 20);
            this.txtInvoiceNumber.TabIndex = 1;
            // 
            // lblDispatchNoteNumber
            // 
            this.lblDispatchNoteNumber.Location = new System.Drawing.Point(16, 67);
            this.lblDispatchNoteNumber.Name = "lblDispatchNoteNumber";
            this.lblDispatchNoteNumber.Size = new System.Drawing.Size(107, 13);
            this.lblDispatchNoteNumber.TabIndex = 0;
            this.lblDispatchNoteNumber.Text = "Dispatch Note Number";
            // 
            // lblDispatchNoteDate
            // 
            this.lblDispatchNoteDate.Location = new System.Drawing.Point(16, 93);
            this.lblDispatchNoteDate.Name = "lblDispatchNoteDate";
            this.lblDispatchNoteDate.Size = new System.Drawing.Size(93, 13);
            this.lblDispatchNoteDate.TabIndex = 0;
            this.lblDispatchNoteDate.Text = "Dispatch Note Date";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.Location = new System.Drawing.Point(16, 40);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(61, 13);
            this.lblInvoiceDate.TabIndex = 0;
            this.lblInvoiceDate.Text = "Invoice Date";
            // 
            // txtDispatchNoteNumber
            // 
            this.txtDispatchNoteNumber.EnterMoveNextControl = true;
            this.txtDispatchNoteNumber.Location = new System.Drawing.Point(135, 64);
            this.txtDispatchNoteNumber.Name = "txtDispatchNoteNumber";
            this.txtDispatchNoteNumber.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtDispatchNoteNumber.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtDispatchNoteNumber.Properties.MaxLength = 50;
            this.txtDispatchNoteNumber.Size = new System.Drawing.Size(127, 20);
            this.txtDispatchNoteNumber.TabIndex = 1;
            // 
            // deInvoiceDate
            // 
            this.deInvoiceDate.EditValue = null;
            this.deInvoiceDate.EnterMoveNextControl = true;
            this.deInvoiceDate.Location = new System.Drawing.Point(135, 38);
            this.deInvoiceDate.Name = "deInvoiceDate";
            this.deInvoiceDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.deInvoiceDate.Properties.Appearance.Options.UseTextOptions = true;
            this.deInvoiceDate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.deInvoiceDate.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.deInvoiceDate.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.deInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deInvoiceDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deInvoiceDate.Size = new System.Drawing.Size(127, 20);
            this.deInvoiceDate.TabIndex = 2;
            // 
            // deDispatchNoteDate
            // 
            this.deDispatchNoteDate.EditValue = null;
            this.deDispatchNoteDate.EnterMoveNextControl = true;
            this.deDispatchNoteDate.Location = new System.Drawing.Point(135, 90);
            this.deDispatchNoteDate.Name = "deDispatchNoteDate";
            this.deDispatchNoteDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.deDispatchNoteDate.Properties.Appearance.Options.UseTextOptions = true;
            this.deDispatchNoteDate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.deDispatchNoteDate.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.deDispatchNoteDate.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.deDispatchNoteDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDispatchNoteDate.Size = new System.Drawing.Size(127, 20);
            this.deDispatchNoteDate.TabIndex = 3;
            // 
            // groupControl2
            // 
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl2.Controls.Add(this.gridControlSalesInvoice);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 159);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1148, 273);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl2";
            // 
            // gridControlSalesInvoice
            // 
            this.gridControlSalesInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSalesInvoice.Location = new System.Drawing.Point(0, 0);
            this.gridControlSalesInvoice.MainView = this.gridViewSalesInvoice;
            this.gridControlSalesInvoice.Name = "gridControlSalesInvoice";
            this.gridControlSalesInvoice.Size = new System.Drawing.Size(1148, 273);
            this.gridControlSalesInvoice.TabIndex = 0;
            this.gridControlSalesInvoice.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSalesInvoice});
            // 
            // gridViewSalesInvoice
            // 
            this.gridViewSalesInvoice.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewSalesInvoice.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewSalesInvoice.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewSalesInvoice.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewSalesInvoice.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewSalesInvoice.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewSalesInvoice.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewSalesInvoice.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewSalesInvoice.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewSalesInvoice.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewSalesInvoice.GridControl = this.gridControlSalesInvoice;
            this.gridViewSalesInvoice.Name = "gridViewSalesInvoice";
            this.gridViewSalesInvoice.OptionsMenu.EnableColumnMenu = false;
            this.gridViewSalesInvoice.OptionsMenu.EnableFooterMenu = false;
            this.gridViewSalesInvoice.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewSalesInvoice.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewSalesInvoice.OptionsPrint.AutoWidth = false;
            this.gridViewSalesInvoice.OptionsPrint.PrintFooter = false;
            this.gridViewSalesInvoice.OptionsPrint.PrintGroupFooter = false;
            this.gridViewSalesInvoice.OptionsView.ColumnAutoWidth = false;
            this.gridViewSalesInvoice.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewSalesInvoice.OptionsView.RowAutoHeight = true;
            this.gridViewSalesInvoice.OptionsView.ShowAutoFilterRow = true;
            this.gridViewSalesInvoice.OptionsView.ShowGroupPanel = false;
            this.gridViewSalesInvoice.OptionsView.ShowViewCaption = true;
            this.gridViewSalesInvoice.ViewCaption = "Sales Invoice";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(923, 39);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 41);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnUpdate.Appearance.Options.UseForeColor = true;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(923, 84);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 41);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnDelete.Appearance.Options.UseForeColor = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(1036, 39);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 41);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            // 
            // btnExit
            // 
            this.btnExit.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnExit.Appearance.Options.UseForeColor = true;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(1036, 86);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 41);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.lblSubTotal);
            this.panelControl3.Controls.Add(this.myTextEdit1);
            this.panelControl3.Controls.Add(this.txtSubTotal);
            this.panelControl3.Controls.Add(this.txtVAT);
            this.panelControl3.Controls.Add(this.lblDiscount);
            this.panelControl3.Controls.Add(this.lblTotal);
            this.panelControl3.Controls.Add(this.lblVAT);
            this.panelControl3.Controls.Add(this.txtDiscount);
            this.panelControl3.Location = new System.Drawing.Point(875, 448);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(253, 119);
            this.panelControl3.TabIndex = 3;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Location = new System.Drawing.Point(16, 14);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(45, 13);
            this.lblSubTotal.TabIndex = 0;
            this.lblSubTotal.Text = "Sub Total";
            // 
            // myTextEdit1
            // 
            this.myTextEdit1.EnterMoveNextControl = true;
            this.myTextEdit1.Location = new System.Drawing.Point(105, 90);
            this.myTextEdit1.Name = "myTextEdit1";
            this.myTextEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.myTextEdit1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.myTextEdit1.Properties.MaxLength = 50;
            this.myTextEdit1.Size = new System.Drawing.Size(127, 20);
            this.myTextEdit1.TabIndex = 1;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.EnterMoveNextControl = true;
            this.txtSubTotal.Location = new System.Drawing.Point(105, 11);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtSubTotal.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtSubTotal.Properties.MaxLength = 50;
            this.txtSubTotal.Size = new System.Drawing.Size(127, 20);
            this.txtSubTotal.TabIndex = 1;
            // 
            // txtVAT
            // 
            this.txtVAT.EnterMoveNextControl = true;
            this.txtVAT.Location = new System.Drawing.Point(105, 37);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtVAT.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtVAT.Properties.MaxLength = 50;
            this.txtVAT.Size = new System.Drawing.Size(127, 20);
            this.txtVAT.TabIndex = 1;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Location = new System.Drawing.Point(16, 67);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(41, 13);
            this.lblDiscount.TabIndex = 0;
            this.lblDiscount.Text = "Discount";
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(16, 93);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(24, 13);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total";
            // 
            // lblVAT
            // 
            this.lblVAT.Location = new System.Drawing.Point(16, 40);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(19, 13);
            this.lblVAT.TabIndex = 0;
            this.lblVAT.Text = "VAT";
            // 
            // txtDiscount
            // 
            this.txtDiscount.EnterMoveNextControl = true;
            this.txtDiscount.Location = new System.Drawing.Point(105, 64);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtDiscount.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtDiscount.Properties.MaxLength = 50;
            this.txtDiscount.Size = new System.Drawing.Size(127, 20);
            this.txtDiscount.TabIndex = 1;
            // 
            // SalesInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 580);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "SalesInvoice";
            this.Text = "Sales Invoice";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTextEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDispatchNoteNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInvoiceDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInvoiceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDispatchNoteDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDispatchNoteDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSalesInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSalesInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVAT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private UserControls.Controls.MyDateEdit deInvoiceDate;
        private DevExpress.XtraEditors.LabelControl lblInvoiceNumber;
        private UserControls.Controls.MyTextEdit txtInvoiceNumber;
        private DevExpress.XtraEditors.LabelControl lblDispatchNoteNumber;
        private DevExpress.XtraEditors.LabelControl lblDispatchNoteDate;
        private DevExpress.XtraEditors.LabelControl lblInvoiceDate;
        private UserControls.Controls.MyTextEdit txtDispatchNoteNumber;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblCustomerCode;
        private UserControls.Controls.MyTextEdit myTextEdit2;
        private UserControls.Controls.MyTextEdit txtCustomerCode;
        private UserControls.Controls.MyTextEdit txtCustomerName;
        private DevExpress.XtraEditors.LabelControl lblInvoiceType;
        private DevExpress.XtraEditors.LabelControl lblPaymentPlace;
        private DevExpress.XtraEditors.LabelControl lblCustomerName;
        private UserControls.Controls.MyTextEdit txtInvoiceType;
        private UserControls.Controls.MyDateEdit deDispatchNoteDate;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private UserControls.Grids.MyGridControl gridControlSalesInvoice;
        private UserControls.Grids.MyGridView gridViewSalesInvoice;
        private UserControls.Controls.MySimpleButton btnSave;
        private UserControls.Controls.MySimpleButton btnDelete;
        private UserControls.Controls.MySimpleButton btnExit;
        private UserControls.Controls.MySimpleButton btnUpdate;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl lblSubTotal;
        private UserControls.Controls.MyTextEdit myTextEdit1;
        private UserControls.Controls.MyTextEdit txtSubTotal;
        private UserControls.Controls.MyTextEdit txtVAT;
        private DevExpress.XtraEditors.LabelControl lblDiscount;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraEditors.LabelControl lblVAT;
        private UserControls.Controls.MyTextEdit txtDiscount;
    }
}