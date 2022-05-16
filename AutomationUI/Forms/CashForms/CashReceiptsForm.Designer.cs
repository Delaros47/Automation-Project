﻿namespace AutomationUI.Forms.CashForms
{
    partial class CashReceiptsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashReceiptsForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSave = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.btnUpdate = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.btnDelete = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.memoAddress = new AutomationUI.UserControls.Controls.MyMemoEdit();
            this.btnExit = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.lblProcessType = new DevExpress.XtraEditors.LabelControl();
            this.txtCustomerName = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.lblCustomerName = new DevExpress.XtraEditors.LabelControl();
            this.lblAddress = new DevExpress.XtraEditors.LabelControl();
            this.lblCustomerCode = new DevExpress.XtraEditors.LabelControl();
            this.txtCashName = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.lblCashName = new DevExpress.XtraEditors.LabelControl();
            this.lblCashCode = new DevExpress.XtraEditors.LabelControl();
            this.txtDocumentNumber = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.lblDocumentNumber = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnCashCode = new AutomationUI.UserControls.Controls.MyButtonEdit();
            this.btnCustomerCode = new AutomationUI.UserControls.Controls.MyButtonEdit();
            this.deDate = new AutomationUI.UserControls.Controls.MyDateEdit();
            this.cbmProcessType = new AutomationUI.UserControls.Controls.MyComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCashName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumentNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCashCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomerCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbmProcessType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnCustomerCode);
            this.groupControl1.Controls.Add(this.btnCashCode);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnExit);
            this.groupControl1.Controls.Add(this.txtCustomerName);
            this.groupControl1.Controls.Add(this.lblCustomerName);
            this.groupControl1.Controls.Add(this.lblCustomerCode);
            this.groupControl1.Controls.Add(this.txtCashName);
            this.groupControl1.Controls.Add(this.lblCashName);
            this.groupControl1.Controls.Add(this.lblCashCode);
            this.groupControl1.Controls.Add(this.txtDocumentNumber);
            this.groupControl1.Controls.Add(this.lblDocumentNumber);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(428, 224);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Cash/Customer Informations";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(320, 37);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 41);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnUpdate.Appearance.Options.UseForeColor = true;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(320, 84);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 41);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnDelete.Appearance.Options.UseForeColor = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(320, 131);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 41);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            // 
            // memoAddress
            // 
            this.memoAddress.EnterMoveNextControl = true;
            this.memoAddress.Location = new System.Drawing.Point(113, 108);
            this.memoAddress.Name = "memoAddress";
            this.memoAddress.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.memoAddress.Properties.Appearance.Options.UseBackColor = true;
            this.memoAddress.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.memoAddress.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.memoAddress.Properties.MaxLength = 500;
            this.memoAddress.Size = new System.Drawing.Size(196, 125);
            this.memoAddress.TabIndex = 22;
            // 
            // btnExit
            // 
            this.btnExit.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnExit.Appearance.Options.UseForeColor = true;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(320, 178);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 41);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            // 
            // lblProcessType
            // 
            this.lblProcessType.Location = new System.Drawing.Point(18, 66);
            this.lblProcessType.Name = "lblProcessType";
            this.lblProcessType.Size = new System.Drawing.Size(64, 13);
            this.lblProcessType.TabIndex = 14;
            this.lblProcessType.Text = "Process Type";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.EnterMoveNextControl = true;
            this.txtCustomerName.Location = new System.Drawing.Point(113, 139);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtCustomerName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtCustomerName.Properties.MaxLength = 50;
            this.txtCustomerName.Size = new System.Drawing.Size(191, 20);
            this.txtCustomerName.TabIndex = 18;
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(18, 41);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(23, 13);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Date";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Location = new System.Drawing.Point(18, 142);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(76, 13);
            this.lblCustomerName.TabIndex = 15;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(23, 109);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(39, 13);
            this.lblAddress.TabIndex = 16;
            this.lblAddress.Text = "Address";
            // 
            // lblCustomerCode
            // 
            this.lblCustomerCode.Location = new System.Drawing.Point(18, 116);
            this.lblCustomerCode.Name = "lblCustomerCode";
            this.lblCustomerCode.Size = new System.Drawing.Size(74, 13);
            this.lblCustomerCode.TabIndex = 16;
            this.lblCustomerCode.Text = "Customer Code";
            // 
            // txtCashName
            // 
            this.txtCashName.EnterMoveNextControl = true;
            this.txtCashName.Location = new System.Drawing.Point(113, 87);
            this.txtCashName.Name = "txtCashName";
            this.txtCashName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtCashName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtCashName.Properties.MaxLength = 50;
            this.txtCashName.Size = new System.Drawing.Size(191, 20);
            this.txtCashName.TabIndex = 13;
            // 
            // lblCashName
            // 
            this.lblCashName.Location = new System.Drawing.Point(18, 90);
            this.lblCashName.Name = "lblCashName";
            this.lblCashName.Size = new System.Drawing.Size(54, 13);
            this.lblCashName.TabIndex = 12;
            this.lblCashName.Text = "Cash Name";
            // 
            // lblCashCode
            // 
            this.lblCashCode.Location = new System.Drawing.Point(18, 65);
            this.lblCashCode.Name = "lblCashCode";
            this.lblCashCode.Size = new System.Drawing.Size(52, 13);
            this.lblCashCode.TabIndex = 12;
            this.lblCashCode.Text = "Cash Code";
            // 
            // txtDocumentNumber
            // 
            this.txtDocumentNumber.EnterMoveNextControl = true;
            this.txtDocumentNumber.Location = new System.Drawing.Point(113, 36);
            this.txtDocumentNumber.Name = "txtDocumentNumber";
            this.txtDocumentNumber.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtDocumentNumber.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtDocumentNumber.Properties.MaxLength = 50;
            this.txtDocumentNumber.Size = new System.Drawing.Size(191, 20);
            this.txtDocumentNumber.TabIndex = 13;
            // 
            // lblDocumentNumber
            // 
            this.lblDocumentNumber.Location = new System.Drawing.Point(18, 39);
            this.lblDocumentNumber.Name = "lblDocumentNumber";
            this.lblDocumentNumber.Size = new System.Drawing.Size(88, 13);
            this.lblDocumentNumber.TabIndex = 12;
            this.lblDocumentNumber.Text = "Document Number";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.cbmProcessType);
            this.groupControl2.Controls.Add(this.deDate);
            this.groupControl2.Controls.Add(this.lblAddress);
            this.groupControl2.Controls.Add(this.lblProcessType);
            this.groupControl2.Controls.Add(this.memoAddress);
            this.groupControl2.Controls.Add(this.lblDate);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 224);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(428, 370);
            this.groupControl2.TabIndex = 24;
            this.groupControl2.Text = "groupControl2";
            // 
            // btnCashCode
            // 
            this.btnCashCode.EnterMoveNextControl = true;
            this.btnCashCode.Location = new System.Drawing.Point(113, 62);
            this.btnCashCode.Name = "btnCashCode";
            this.btnCashCode.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.btnCashCode.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.btnCashCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnCashCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.btnCashCode.Size = new System.Drawing.Size(191, 20);
            this.btnCashCode.TabIndex = 22;
            // 
            // btnCustomerCode
            // 
            this.btnCustomerCode.EnterMoveNextControl = true;
            this.btnCustomerCode.Location = new System.Drawing.Point(113, 113);
            this.btnCustomerCode.Name = "btnCustomerCode";
            this.btnCustomerCode.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.btnCustomerCode.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.btnCustomerCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnCustomerCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.btnCustomerCode.Size = new System.Drawing.Size(191, 20);
            this.btnCustomerCode.TabIndex = 23;
            // 
            // deDate
            // 
            this.deDate.EditValue = null;
            this.deDate.EnterMoveNextControl = true;
            this.deDate.Location = new System.Drawing.Point(113, 37);
            this.deDate.Name = "deDate";
            this.deDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.deDate.Properties.Appearance.Options.UseTextOptions = true;
            this.deDate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.deDate.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.deDate.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.deDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDate.Size = new System.Drawing.Size(111, 20);
            this.deDate.TabIndex = 24;
            // 
            // cbmProcessType
            // 
            this.cbmProcessType.EnterMoveNextControl = true;
            this.cbmProcessType.Location = new System.Drawing.Point(113, 63);
            this.cbmProcessType.Name = "cbmProcessType";
            this.cbmProcessType.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.cbmProcessType.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.cbmProcessType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbmProcessType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbmProcessType.Size = new System.Drawing.Size(111, 20);
            this.cbmProcessType.TabIndex = 25;
            // 
            // CashReceiptsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 594);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "CashReceiptsForm";
            this.Text = "CashReceipts";
            this.Load += new System.EventHandler(this.CashReceiptsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCashName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumentNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCashCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomerCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbmProcessType.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private UserControls.Controls.MyButtonEdit btnCustomerCode;
        private UserControls.Controls.MyButtonEdit btnCashCode;
        private UserControls.Controls.MySimpleButton btnSave;
        private UserControls.Controls.MySimpleButton btnUpdate;
        private UserControls.Controls.MySimpleButton btnDelete;
        private UserControls.Controls.MySimpleButton btnExit;
        private UserControls.Controls.MyTextEdit txtCustomerName;
        private DevExpress.XtraEditors.LabelControl lblCustomerName;
        private DevExpress.XtraEditors.LabelControl lblCustomerCode;
        private UserControls.Controls.MyTextEdit txtCashName;
        private DevExpress.XtraEditors.LabelControl lblCashName;
        private DevExpress.XtraEditors.LabelControl lblCashCode;
        private UserControls.Controls.MyTextEdit txtDocumentNumber;
        private DevExpress.XtraEditors.LabelControl lblDocumentNumber;
        private UserControls.Controls.MyMemoEdit memoAddress;
        private DevExpress.XtraEditors.LabelControl lblProcessType;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.LabelControl lblAddress;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private UserControls.Controls.MyComboBoxEdit cbmProcessType;
        private UserControls.Controls.MyDateEdit deDate;
    }
}