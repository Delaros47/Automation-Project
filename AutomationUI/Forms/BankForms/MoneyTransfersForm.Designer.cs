namespace AutomationUI.Forms.BankForms
{
    partial class MoneyTransfersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoneyTransfersForm));
            this.deDate = new AutomationUI.UserControls.Controls.MyDateEdit();
            this.lblOutgoingRemittance = new DevExpress.XtraEditors.LabelControl();
            this.lblIncomingRemittance = new DevExpress.XtraEditors.LabelControl();
            this.toggleSwitchIncomingRemittance = new AutomationUI.UserControls.Controls.MyToggleSwitch();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.toggleSwitchOutgoingRemittance = new AutomationUI.UserControls.Controls.MyToggleSwitch();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lblTransferType = new DevExpress.XtraEditors.LabelControl();
            this.cmbTransferType = new AutomationUI.UserControls.Controls.MyComboBoxEdit();
            this.memoDescription = new AutomationUI.UserControls.Controls.MyMemoEdit();
            this.lblDescription = new DevExpress.XtraEditors.LabelControl();
            this.txtTotal = new AutomationUI.UserControls.Controls.MyEmailTextEdit();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.lblDocumentNumber = new DevExpress.XtraEditors.LabelControl();
            this.lblAccountName = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.btnUpdate = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.btnDelete = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.btnExit = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.txtAccountNumber = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.lblAccountNumber = new DevExpress.XtraEditors.LabelControl();
            this.txtDocumentNumber = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnCustomerCode = new AutomationUI.UserControls.Controls.MyButtonEdit();
            this.btnAccountName = new AutomationUI.UserControls.Controls.MyButtonEdit();
            this.txtCustomerName = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.lblCustomerName = new DevExpress.XtraEditors.LabelControl();
            this.lblCustomerCode = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchIncomingRemittance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchOutgoingRemittance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTransferType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumentNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomerCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccountName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // deDate
            // 
            this.deDate.EditValue = null;
            this.deDate.EnterMoveNextControl = true;
            this.deDate.Location = new System.Drawing.Point(119, 62);
            this.deDate.Name = "deDate";
            this.deDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.deDate.Properties.Appearance.Options.UseTextOptions = true;
            this.deDate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.deDate.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.deDate.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.deDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDate.Size = new System.Drawing.Size(123, 20);
            this.deDate.TabIndex = 24;
            // 
            // lblOutgoingRemittance
            // 
            this.lblOutgoingRemittance.Location = new System.Drawing.Point(98, 42);
            this.lblOutgoingRemittance.Name = "lblOutgoingRemittance";
            this.lblOutgoingRemittance.Size = new System.Drawing.Size(101, 13);
            this.lblOutgoingRemittance.TabIndex = 28;
            this.lblOutgoingRemittance.Text = "Outgoing Remittance";
            // 
            // lblIncomingRemittance
            // 
            this.lblIncomingRemittance.Location = new System.Drawing.Point(98, 13);
            this.lblIncomingRemittance.Name = "lblIncomingRemittance";
            this.lblIncomingRemittance.Size = new System.Drawing.Size(100, 13);
            this.lblIncomingRemittance.TabIndex = 27;
            this.lblIncomingRemittance.Text = "Incoming Remittance";
            // 
            // toggleSwitchIncomingRemittance
            // 
            this.toggleSwitchIncomingRemittance.EnterMoveNextControl = true;
            this.toggleSwitchIncomingRemittance.Location = new System.Drawing.Point(3, 12);
            this.toggleSwitchIncomingRemittance.Name = "toggleSwitchIncomingRemittance";
            this.toggleSwitchIncomingRemittance.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.toggleSwitchIncomingRemittance.Properties.Appearance.Options.UseForeColor = true;
            this.toggleSwitchIncomingRemittance.Properties.AutoHeight = false;
            this.toggleSwitchIncomingRemittance.Properties.AutoWidth = true;
            this.toggleSwitchIncomingRemittance.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.toggleSwitchIncomingRemittance.Properties.OffText = "Passive";
            this.toggleSwitchIncomingRemittance.Properties.OnText = "Active";
            this.toggleSwitchIncomingRemittance.Size = new System.Drawing.Size(89, 18);
            this.toggleSwitchIncomingRemittance.TabIndex = 25;
            // 
            // groupControl3
            // 
            this.groupControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl3.Controls.Add(this.lblOutgoingRemittance);
            this.groupControl3.Controls.Add(this.lblIncomingRemittance);
            this.groupControl3.Controls.Add(this.toggleSwitchIncomingRemittance);
            this.groupControl3.Controls.Add(this.toggleSwitchOutgoingRemittance);
            this.groupControl3.Location = new System.Drawing.Point(253, 40);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(208, 67);
            this.groupControl3.TabIndex = 27;
            this.groupControl3.Text = "groupControl3";
            // 
            // toggleSwitchOutgoingRemittance
            // 
            this.toggleSwitchOutgoingRemittance.EnterMoveNextControl = true;
            this.toggleSwitchOutgoingRemittance.Location = new System.Drawing.Point(5, 42);
            this.toggleSwitchOutgoingRemittance.Name = "toggleSwitchOutgoingRemittance";
            this.toggleSwitchOutgoingRemittance.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.toggleSwitchOutgoingRemittance.Properties.Appearance.Options.UseForeColor = true;
            this.toggleSwitchOutgoingRemittance.Properties.AutoHeight = false;
            this.toggleSwitchOutgoingRemittance.Properties.AutoWidth = true;
            this.toggleSwitchOutgoingRemittance.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.toggleSwitchOutgoingRemittance.Properties.OffText = "Passive";
            this.toggleSwitchOutgoingRemittance.Properties.OnText = "Active";
            this.toggleSwitchOutgoingRemittance.Size = new System.Drawing.Size(89, 18);
            this.toggleSwitchOutgoingRemittance.TabIndex = 26;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lblTransferType);
            this.groupControl2.Controls.Add(this.cmbTransferType);
            this.groupControl2.Controls.Add(this.groupControl3);
            this.groupControl2.Controls.Add(this.deDate);
            this.groupControl2.Controls.Add(this.memoDescription);
            this.groupControl2.Controls.Add(this.lblDescription);
            this.groupControl2.Controls.Add(this.txtTotal);
            this.groupControl2.Controls.Add(this.lblTotal);
            this.groupControl2.Controls.Add(this.lblDate);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 184);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(466, 259);
            this.groupControl2.TabIndex = 26;
            this.groupControl2.Text = "Transaction Information";
            // 
            // lblTransferType
            // 
            this.lblTransferType.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblTransferType.Appearance.Options.UseForeColor = true;
            this.lblTransferType.Location = new System.Drawing.Point(18, 39);
            this.lblTransferType.Name = "lblTransferType";
            this.lblTransferType.Size = new System.Drawing.Size(68, 13);
            this.lblTransferType.TabIndex = 29;
            this.lblTransferType.Text = "Transfer Type";
            // 
            // cmbTransferType
            // 
            this.cmbTransferType.EnterMoveNextControl = true;
            this.cmbTransferType.Location = new System.Drawing.Point(119, 36);
            this.cmbTransferType.Name = "cmbTransferType";
            this.cmbTransferType.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.cmbTransferType.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.cmbTransferType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTransferType.Properties.Items.AddRange(new object[] {
            "Bank Transfer",
            "Bank EFT"});
            this.cmbTransferType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbTransferType.Size = new System.Drawing.Size(123, 20);
            this.cmbTransferType.TabIndex = 28;
            // 
            // memoDescription
            // 
            this.memoDescription.EnterMoveNextControl = true;
            this.memoDescription.Location = new System.Drawing.Point(119, 121);
            this.memoDescription.Name = "memoDescription";
            this.memoDescription.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.memoDescription.Properties.Appearance.Options.UseBackColor = true;
            this.memoDescription.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.memoDescription.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.memoDescription.Properties.MaxLength = 500;
            this.memoDescription.Size = new System.Drawing.Size(328, 125);
            this.memoDescription.TabIndex = 22;
            // 
            // lblDescription
            // 
            this.lblDescription.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblDescription.Appearance.Options.UseForeColor = true;
            this.lblDescription.Location = new System.Drawing.Point(18, 122);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(53, 13);
            this.lblDescription.TabIndex = 16;
            this.lblDescription.Text = "Description";
            // 
            // txtTotal
            // 
            this.txtTotal.EnterMoveNextControl = true;
            this.txtTotal.Location = new System.Drawing.Point(119, 88);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtTotal.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtTotal.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Strong;
            this.txtTotal.Properties.Mask.EditMask = "((([0-9a-zA-Z_%-])+[.])+|([0-9a-zA-Z_%-])+)+@((([0-9a-zA-Z_-])+[.])+|([0-9a-zA-Z_" +
    "-])+)+";
            this.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtTotal.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtTotal.Properties.MaskSettings.Set("allowBlankInput", true);
            this.txtTotal.Properties.MaskSettings.Set("mask", "((([0-9a-zA-Z_%-])+[.])+|([0-9a-zA-Z_%-])+)+@((([0-9a-zA-Z_-])+[.])+|([0-9a-zA-Z_" +
        "-])+)+");
            this.txtTotal.Properties.MaskSettings.Set("isAutoComplete", true);
            this.txtTotal.Properties.MaskSettings.Set("isOptimistic", false);
            this.txtTotal.Properties.MaxLength = 50;
            this.txtTotal.Size = new System.Drawing.Size(123, 20);
            this.txtTotal.TabIndex = 23;
            // 
            // lblTotal
            // 
            this.lblTotal.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblTotal.Appearance.Options.UseForeColor = true;
            this.lblTotal.Location = new System.Drawing.Point(18, 91);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(24, 13);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total";
            // 
            // lblDate
            // 
            this.lblDate.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblDate.Appearance.Options.UseForeColor = true;
            this.lblDate.Location = new System.Drawing.Point(18, 65);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(23, 13);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Date";
            // 
            // lblDocumentNumber
            // 
            this.lblDocumentNumber.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblDocumentNumber.Appearance.Options.UseForeColor = true;
            this.lblDocumentNumber.Location = new System.Drawing.Point(18, 41);
            this.lblDocumentNumber.Name = "lblDocumentNumber";
            this.lblDocumentNumber.Size = new System.Drawing.Size(88, 13);
            this.lblDocumentNumber.TabIndex = 12;
            this.lblDocumentNumber.Text = "Document Number";
            // 
            // lblAccountName
            // 
            this.lblAccountName.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblAccountName.Appearance.Options.UseForeColor = true;
            this.lblAccountName.Location = new System.Drawing.Point(18, 67);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(69, 13);
            this.lblAccountName.TabIndex = 12;
            this.lblAccountName.Text = "Account Name";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(353, 33);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 33);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnUpdate.Appearance.Options.UseForeColor = true;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(353, 69);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 33);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnDelete.Appearance.Options.UseForeColor = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(353, 107);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 33);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            // 
            // btnExit
            // 
            this.btnExit.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnExit.Appearance.Options.UseForeColor = true;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(353, 145);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 33);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.EnterMoveNextControl = true;
            this.txtAccountNumber.Location = new System.Drawing.Point(119, 90);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtAccountNumber.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAccountNumber.Properties.MaxLength = 50;
            this.txtAccountNumber.Size = new System.Drawing.Size(191, 20);
            this.txtAccountNumber.TabIndex = 13;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblAccountNumber.Appearance.Options.UseForeColor = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(18, 93);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(79, 13);
            this.lblAccountNumber.TabIndex = 12;
            this.lblAccountNumber.Text = "Account Number";
            // 
            // txtDocumentNumber
            // 
            this.txtDocumentNumber.EnterMoveNextControl = true;
            this.txtDocumentNumber.Location = new System.Drawing.Point(119, 38);
            this.txtDocumentNumber.Name = "txtDocumentNumber";
            this.txtDocumentNumber.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtDocumentNumber.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtDocumentNumber.Properties.MaxLength = 50;
            this.txtDocumentNumber.Size = new System.Drawing.Size(191, 20);
            this.txtDocumentNumber.TabIndex = 13;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnCustomerCode);
            this.groupControl1.Controls.Add(this.btnAccountName);
            this.groupControl1.Controls.Add(this.txtCustomerName);
            this.groupControl1.Controls.Add(this.lblCustomerName);
            this.groupControl1.Controls.Add(this.lblCustomerCode);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnExit);
            this.groupControl1.Controls.Add(this.txtAccountNumber);
            this.groupControl1.Controls.Add(this.lblAccountNumber);
            this.groupControl1.Controls.Add(this.lblAccountName);
            this.groupControl1.Controls.Add(this.txtDocumentNumber);
            this.groupControl1.Controls.Add(this.lblDocumentNumber);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(466, 184);
            this.groupControl1.TabIndex = 25;
            this.groupControl1.Text = "Basic Informations";
            // 
            // btnCustomerCode
            // 
            this.btnCustomerCode.EnterMoveNextControl = true;
            this.btnCustomerCode.Location = new System.Drawing.Point(119, 116);
            this.btnCustomerCode.Name = "btnCustomerCode";
            this.btnCustomerCode.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.btnCustomerCode.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.btnCustomerCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnCustomerCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.btnCustomerCode.Size = new System.Drawing.Size(191, 20);
            this.btnCustomerCode.TabIndex = 19;
            // 
            // btnAccountName
            // 
            this.btnAccountName.EnterMoveNextControl = true;
            this.btnAccountName.Location = new System.Drawing.Point(119, 64);
            this.btnAccountName.Name = "btnAccountName";
            this.btnAccountName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.btnAccountName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.btnAccountName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnAccountName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.btnAccountName.Size = new System.Drawing.Size(191, 20);
            this.btnAccountName.TabIndex = 18;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.EnterMoveNextControl = true;
            this.txtCustomerName.Location = new System.Drawing.Point(119, 142);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtCustomerName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtCustomerName.Properties.MaxLength = 50;
            this.txtCustomerName.Size = new System.Drawing.Size(191, 20);
            this.txtCustomerName.TabIndex = 16;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblCustomerName.Appearance.Options.UseForeColor = true;
            this.lblCustomerName.Location = new System.Drawing.Point(18, 145);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(76, 13);
            this.lblCustomerName.TabIndex = 14;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblCustomerCode
            // 
            this.lblCustomerCode.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblCustomerCode.Appearance.Options.UseForeColor = true;
            this.lblCustomerCode.Location = new System.Drawing.Point(18, 119);
            this.lblCustomerCode.Name = "lblCustomerCode";
            this.lblCustomerCode.Size = new System.Drawing.Size(74, 13);
            this.lblCustomerCode.TabIndex = 15;
            this.lblCustomerCode.Text = "Customer Code";
            // 
            // MoneyTransfersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 443);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("MoneyTransfersForm.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MoneyTransfersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Money Transfers";
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchIncomingRemittance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchOutgoingRemittance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTransferType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumentNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomerCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccountName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.Controls.MyDateEdit deDate;
        private DevExpress.XtraEditors.LabelControl lblOutgoingRemittance;
        private DevExpress.XtraEditors.LabelControl lblIncomingRemittance;
        private UserControls.Controls.MyToggleSwitch toggleSwitchIncomingRemittance;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private UserControls.Controls.MyToggleSwitch toggleSwitchOutgoingRemittance;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private UserControls.Controls.MyMemoEdit memoDescription;
        private DevExpress.XtraEditors.LabelControl lblDescription;
        private UserControls.Controls.MyEmailTextEdit txtTotal;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.LabelControl lblDocumentNumber;
        private DevExpress.XtraEditors.LabelControl lblAccountName;
        private UserControls.Controls.MySimpleButton btnSave;
        private UserControls.Controls.MySimpleButton btnUpdate;
        private UserControls.Controls.MySimpleButton btnDelete;
        private UserControls.Controls.MySimpleButton btnExit;
        private UserControls.Controls.MyTextEdit txtAccountNumber;
        private DevExpress.XtraEditors.LabelControl lblAccountNumber;
        private UserControls.Controls.MyTextEdit txtDocumentNumber;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private UserControls.Controls.MyTextEdit txtCustomerName;
        private DevExpress.XtraEditors.LabelControl lblCustomerName;
        private DevExpress.XtraEditors.LabelControl lblCustomerCode;
        private UserControls.Controls.MyButtonEdit btnAccountName;
        private UserControls.Controls.MyButtonEdit btnCustomerCode;
        private DevExpress.XtraEditors.LabelControl lblTransferType;
        private UserControls.Controls.MyComboBoxEdit cmbTransferType;
    }
}