namespace AutomationUI.Forms.BankForms
{
    partial class BankTransactionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankTransactionsForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSave = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.btnUpdate = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.btnDelete = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.btnExit = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.txtAccountNumber = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.lblAccountNumber = new DevExpress.XtraEditors.LabelControl();
            this.txtAccountName = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.lblAccountName = new DevExpress.XtraEditors.LabelControl();
            this.txtDocumentNumber = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.lblDocumentNumber = new DevExpress.XtraEditors.LabelControl();
            this.txtTotal = new AutomationUI.UserControls.Controls.MyEmailTextEdit();
            this.memoDescription = new AutomationUI.UserControls.Controls.MyMemoEdit();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.lblDescription = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.lblExitTransaction = new DevExpress.XtraEditors.LabelControl();
            this.lblEnterTransaction = new DevExpress.XtraEditors.LabelControl();
            this.toggleSwitchEnterTransaction = new AutomationUI.UserControls.Controls.MyToggleSwitch();
            this.toggleSwitchExitTransaction = new AutomationUI.UserControls.Controls.MyToggleSwitch();
            this.deDate = new AutomationUI.UserControls.Controls.MyDateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumentNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchEnterTransaction.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchExitTransaction.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnExit);
            this.groupControl1.Controls.Add(this.txtAccountNumber);
            this.groupControl1.Controls.Add(this.lblAccountNumber);
            this.groupControl1.Controls.Add(this.txtAccountName);
            this.groupControl1.Controls.Add(this.lblAccountName);
            this.groupControl1.Controls.Add(this.txtDocumentNumber);
            this.groupControl1.Controls.Add(this.lblDocumentNumber);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(432, 182);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Basic Informations";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(318, 31);
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
            this.btnUpdate.Location = new System.Drawing.Point(318, 67);
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
            this.btnDelete.Location = new System.Drawing.Point(318, 105);
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
            this.btnExit.Location = new System.Drawing.Point(318, 143);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 33);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.EnterMoveNextControl = true;
            this.txtAccountNumber.Location = new System.Drawing.Point(109, 123);
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
            this.lblAccountNumber.Location = new System.Drawing.Point(18, 126);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(79, 13);
            this.lblAccountNumber.TabIndex = 12;
            this.lblAccountNumber.Text = "Account Number";
            // 
            // txtAccountName
            // 
            this.txtAccountName.EnterMoveNextControl = true;
            this.txtAccountName.Location = new System.Drawing.Point(109, 91);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtAccountName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAccountName.Properties.MaxLength = 50;
            this.txtAccountName.Size = new System.Drawing.Size(191, 20);
            this.txtAccountName.TabIndex = 13;
            // 
            // lblAccountName
            // 
            this.lblAccountName.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblAccountName.Appearance.Options.UseForeColor = true;
            this.lblAccountName.Location = new System.Drawing.Point(18, 94);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(69, 13);
            this.lblAccountName.TabIndex = 12;
            this.lblAccountName.Text = "Account Name";
            // 
            // txtDocumentNumber
            // 
            this.txtDocumentNumber.EnterMoveNextControl = true;
            this.txtDocumentNumber.Location = new System.Drawing.Point(109, 62);
            this.txtDocumentNumber.Name = "txtDocumentNumber";
            this.txtDocumentNumber.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtDocumentNumber.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtDocumentNumber.Properties.MaxLength = 50;
            this.txtDocumentNumber.Size = new System.Drawing.Size(191, 20);
            this.txtDocumentNumber.TabIndex = 13;
            // 
            // lblDocumentNumber
            // 
            this.lblDocumentNumber.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblDocumentNumber.Appearance.Options.UseForeColor = true;
            this.lblDocumentNumber.Location = new System.Drawing.Point(18, 65);
            this.lblDocumentNumber.Name = "lblDocumentNumber";
            this.lblDocumentNumber.Size = new System.Drawing.Size(53, 13);
            this.lblDocumentNumber.TabIndex = 12;
            this.lblDocumentNumber.Text = "Bank Name";
            // 
            // txtTotal
            // 
            this.txtTotal.EnterMoveNextControl = true;
            this.txtTotal.Location = new System.Drawing.Point(109, 65);
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
            // memoDescription
            // 
            this.memoDescription.EnterMoveNextControl = true;
            this.memoDescription.Location = new System.Drawing.Point(109, 99);
            this.memoDescription.Name = "memoDescription";
            this.memoDescription.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.memoDescription.Properties.Appearance.Options.UseBackColor = true;
            this.memoDescription.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.memoDescription.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.memoDescription.Properties.MaxLength = 500;
            this.memoDescription.Size = new System.Drawing.Size(313, 125);
            this.memoDescription.TabIndex = 22;
            // 
            // lblTotal
            // 
            this.lblTotal.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblTotal.Appearance.Options.UseForeColor = true;
            this.lblTotal.Location = new System.Drawing.Point(20, 68);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(24, 13);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total";
            // 
            // lblDate
            // 
            this.lblDate.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblDate.Appearance.Options.UseForeColor = true;
            this.lblDate.Location = new System.Drawing.Point(20, 39);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(23, 13);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Date";
            // 
            // lblDescription
            // 
            this.lblDescription.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblDescription.Appearance.Options.UseForeColor = true;
            this.lblDescription.Location = new System.Drawing.Point(20, 100);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(53, 13);
            this.lblDescription.TabIndex = 16;
            this.lblDescription.Text = "Description";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupControl3);
            this.groupControl2.Controls.Add(this.deDate);
            this.groupControl2.Controls.Add(this.memoDescription);
            this.groupControl2.Controls.Add(this.lblDescription);
            this.groupControl2.Controls.Add(this.txtTotal);
            this.groupControl2.Controls.Add(this.lblTotal);
            this.groupControl2.Controls.Add(this.lblDate);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 182);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(432, 232);
            this.groupControl2.TabIndex = 24;
            this.groupControl2.Text = "Transaction Information";
            // 
            // groupControl3
            // 
            this.groupControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl3.Controls.Add(this.lblExitTransaction);
            this.groupControl3.Controls.Add(this.lblEnterTransaction);
            this.groupControl3.Controls.Add(this.toggleSwitchEnterTransaction);
            this.groupControl3.Controls.Add(this.toggleSwitchExitTransaction);
            this.groupControl3.Location = new System.Drawing.Point(239, 26);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(196, 67);
            this.groupControl3.TabIndex = 27;
            this.groupControl3.Text = "groupControl3";
            // 
            // lblExitTransaction
            // 
            this.lblExitTransaction.Location = new System.Drawing.Point(98, 42);
            this.lblExitTransaction.Name = "lblExitTransaction";
            this.lblExitTransaction.Size = new System.Drawing.Size(77, 13);
            this.lblExitTransaction.TabIndex = 28;
            this.lblExitTransaction.Text = "Exit Transaction";
            // 
            // lblEnterTransaction
            // 
            this.lblEnterTransaction.Location = new System.Drawing.Point(98, 13);
            this.lblEnterTransaction.Name = "lblEnterTransaction";
            this.lblEnterTransaction.Size = new System.Drawing.Size(85, 13);
            this.lblEnterTransaction.TabIndex = 27;
            this.lblEnterTransaction.Text = "Enter Transaction";
            // 
            // toggleSwitchEnterTransaction
            // 
            this.toggleSwitchEnterTransaction.EnterMoveNextControl = true;
            this.toggleSwitchEnterTransaction.Location = new System.Drawing.Point(3, 12);
            this.toggleSwitchEnterTransaction.Name = "toggleSwitchEnterTransaction";
            this.toggleSwitchEnterTransaction.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.toggleSwitchEnterTransaction.Properties.Appearance.Options.UseForeColor = true;
            this.toggleSwitchEnterTransaction.Properties.AutoHeight = false;
            this.toggleSwitchEnterTransaction.Properties.AutoWidth = true;
            this.toggleSwitchEnterTransaction.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.toggleSwitchEnterTransaction.Properties.OffText = "Passive";
            this.toggleSwitchEnterTransaction.Properties.OnText = "Active";
            this.toggleSwitchEnterTransaction.Size = new System.Drawing.Size(89, 18);
            this.toggleSwitchEnterTransaction.TabIndex = 25;
            // 
            // toggleSwitchExitTransaction
            // 
            this.toggleSwitchExitTransaction.EnterMoveNextControl = true;
            this.toggleSwitchExitTransaction.Location = new System.Drawing.Point(5, 42);
            this.toggleSwitchExitTransaction.Name = "toggleSwitchExitTransaction";
            this.toggleSwitchExitTransaction.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.toggleSwitchExitTransaction.Properties.Appearance.Options.UseForeColor = true;
            this.toggleSwitchExitTransaction.Properties.AutoHeight = false;
            this.toggleSwitchExitTransaction.Properties.AutoWidth = true;
            this.toggleSwitchExitTransaction.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.toggleSwitchExitTransaction.Properties.OffText = "Passive";
            this.toggleSwitchExitTransaction.Properties.OnText = "Active";
            this.toggleSwitchExitTransaction.Size = new System.Drawing.Size(89, 18);
            this.toggleSwitchExitTransaction.TabIndex = 26;
            // 
            // deDate
            // 
            this.deDate.EditValue = null;
            this.deDate.EnterMoveNextControl = true;
            this.deDate.Location = new System.Drawing.Point(109, 36);
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
            this.deDate.Size = new System.Drawing.Size(123, 20);
            this.deDate.TabIndex = 24;
            // 
            // BankTransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 414);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BankTransactionsForm.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BankTransactionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bank Transections";
            this.Load += new System.EventHandler(this.BankTransactionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocumentNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchEnterTransaction.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchExitTransaction.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private UserControls.Controls.MySimpleButton btnSave;
        private UserControls.Controls.MySimpleButton btnUpdate;
        private UserControls.Controls.MySimpleButton btnDelete;
        private UserControls.Controls.MySimpleButton btnExit;
        private UserControls.Controls.MyTextEdit txtAccountNumber;
        private DevExpress.XtraEditors.LabelControl lblAccountNumber;
        private UserControls.Controls.MyTextEdit txtAccountName;
        private DevExpress.XtraEditors.LabelControl lblAccountName;
        private UserControls.Controls.MyTextEdit txtDocumentNumber;
        private DevExpress.XtraEditors.LabelControl lblDocumentNumber;
        private UserControls.Controls.MyEmailTextEdit txtTotal;
        private UserControls.Controls.MyMemoEdit memoDescription;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.LabelControl lblDescription;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private UserControls.Controls.MyDateEdit deDate;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl lblExitTransaction;
        private DevExpress.XtraEditors.LabelControl lblEnterTransaction;
        private UserControls.Controls.MyToggleSwitch toggleSwitchEnterTransaction;
        private UserControls.Controls.MyToggleSwitch toggleSwitchExitTransaction;
    }
}