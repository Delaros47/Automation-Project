namespace AutomationUI.Forms.BankForms
{
    partial class BankCardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankCardForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSave = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.btnUpdate = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.txtEmailAddress = new AutomationUI.UserControls.Controls.MyEmailTextEdit();
            this.btnDelete = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.memoAddress = new AutomationUI.UserControls.Controls.MyMemoEdit();
            this.btnExit = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.txtPhoneNumber = new AutomationUI.UserControls.Controls.MyPhoneNumberTextEdit();
            this.txtIBAN = new AutomationUI.UserControls.Controls.MyIbanTextEdit();
            this.lblEmail = new DevExpress.XtraEditors.LabelControl();
            this.lblPhoneNumber = new DevExpress.XtraEditors.LabelControl();
            this.txtRepresentative = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.txtBankBranch = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.lblRepresentative = new DevExpress.XtraEditors.LabelControl();
            this.lblBankBranch = new DevExpress.XtraEditors.LabelControl();
            this.lblAddress = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtAccountNumber = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.lblAccountNumber = new DevExpress.XtraEditors.LabelControl();
            this.txtAccountName = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.lblAccountName = new DevExpress.XtraEditors.LabelControl();
            this.txtBankName = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlBanks = new AutomationUI.UserControls.Grids.MyGridControl();
            this.gridViewBanks = new AutomationUI.UserControls.Grids.MyGridView();
            this.colId = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colBankName = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colAccountName = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colBalance = new AutomationUI.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIBAN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepresentative.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBanks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBanks)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.txtEmailAddress);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.memoAddress);
            this.groupControl1.Controls.Add(this.btnExit);
            this.groupControl1.Controls.Add(this.txtPhoneNumber);
            this.groupControl1.Controls.Add(this.txtIBAN);
            this.groupControl1.Controls.Add(this.lblEmail);
            this.groupControl1.Controls.Add(this.lblPhoneNumber);
            this.groupControl1.Controls.Add(this.txtRepresentative);
            this.groupControl1.Controls.Add(this.txtBankBranch);
            this.groupControl1.Controls.Add(this.lblRepresentative);
            this.groupControl1.Controls.Add(this.lblBankBranch);
            this.groupControl1.Controls.Add(this.lblAddress);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtAccountNumber);
            this.groupControl1.Controls.Add(this.lblAccountNumber);
            this.groupControl1.Controls.Add(this.txtAccountName);
            this.groupControl1.Controls.Add(this.lblAccountName);
            this.groupControl1.Controls.Add(this.txtBankName);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(438, 378);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Bank Informations";
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
            // txtEmailAddress
            // 
            this.txtEmailAddress.EnterMoveNextControl = true;
            this.txtEmailAddress.Location = new System.Drawing.Point(109, 347);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtEmailAddress.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtEmailAddress.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtEmailAddress.Properties.MaskSettings.Set("allowBlankInput", true);
            this.txtEmailAddress.Properties.MaskSettings.Set("mask", "((([0-9a-zA-Z_%-])+[.])+|([0-9a-zA-Z_%-])+)+@((([0-9a-zA-Z_-])+[.])+|([0-9a-zA-Z_" +
        "-])+)+");
            this.txtEmailAddress.Properties.MaskSettings.Set("isAutoComplete", true);
            this.txtEmailAddress.Properties.MaskSettings.Set("isOptimistic", false);
            this.txtEmailAddress.Properties.MaxLength = 50;
            this.txtEmailAddress.Size = new System.Drawing.Size(191, 20);
            this.txtEmailAddress.TabIndex = 23;
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
            this.memoAddress.Location = new System.Drawing.Point(109, 191);
            this.memoAddress.Name = "memoAddress";
            this.memoAddress.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.memoAddress.Properties.Appearance.Options.UseBackColor = true;
            this.memoAddress.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.memoAddress.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.memoAddress.Properties.MaxLength = 500;
            this.memoAddress.Size = new System.Drawing.Size(191, 125);
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
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.EnterMoveNextControl = true;
            this.txtPhoneNumber.Location = new System.Drawing.Point(109, 164);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPhoneNumber.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPhoneNumber.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtPhoneNumber.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtPhoneNumber.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegularMaskManager));
            this.txtPhoneNumber.Properties.MaskSettings.Set("mask", "(0\\d?\\d?\\d?) \\d?\\d?\\d? \\d?\\d? \\d?\\d?");
            this.txtPhoneNumber.Properties.MaskSettings.Set("isAutoComplete", false);
            this.txtPhoneNumber.Properties.MaskSettings.Set("isOptimistic", false);
            this.txtPhoneNumber.Properties.MaxLength = 50;
            this.txtPhoneNumber.Size = new System.Drawing.Size(191, 20);
            this.txtPhoneNumber.TabIndex = 21;
            // 
            // txtIBAN
            // 
            this.txtIBAN.EnterMoveNextControl = true;
            this.txtIBAN.Location = new System.Drawing.Point(109, 113);
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtIBAN.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtIBAN.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegularMaskManager));
            this.txtIBAN.Properties.MaskSettings.Set("mask", "TR\\d?\\d? \\d?\\d?\\d?\\d? \\d?\\d?\\d?\\d? \\d?\\d?\\d?\\d? \\d?\\d?\\d?\\d? \\d?\\d?\\d?\\d? \\d?\\d?");
            this.txtIBAN.Properties.MaskSettings.Set("isAutoComplete", false);
            this.txtIBAN.Properties.MaskSettings.Set("isOptimistic", false);
            this.txtIBAN.Properties.MaxLength = 50;
            this.txtIBAN.Size = new System.Drawing.Size(191, 20);
            this.txtIBAN.TabIndex = 20;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(19, 350);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(66, 13);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email Address";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Location = new System.Drawing.Point(18, 167);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(70, 13);
            this.lblPhoneNumber.TabIndex = 14;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtRepresentative
            // 
            this.txtRepresentative.EnterMoveNextControl = true;
            this.txtRepresentative.Location = new System.Drawing.Point(109, 322);
            this.txtRepresentative.Name = "txtRepresentative";
            this.txtRepresentative.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtRepresentative.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtRepresentative.Properties.MaxLength = 50;
            this.txtRepresentative.Size = new System.Drawing.Size(191, 20);
            this.txtRepresentative.TabIndex = 18;
            // 
            // txtBankBranch
            // 
            this.txtBankBranch.EnterMoveNextControl = true;
            this.txtBankBranch.Location = new System.Drawing.Point(109, 139);
            this.txtBankBranch.Name = "txtBankBranch";
            this.txtBankBranch.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtBankBranch.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtBankBranch.Properties.MaxLength = 50;
            this.txtBankBranch.Size = new System.Drawing.Size(191, 20);
            this.txtBankBranch.TabIndex = 18;
            // 
            // lblRepresentative
            // 
            this.lblRepresentative.Location = new System.Drawing.Point(19, 325);
            this.lblRepresentative.Name = "lblRepresentative";
            this.lblRepresentative.Size = new System.Drawing.Size(74, 13);
            this.lblRepresentative.TabIndex = 15;
            this.lblRepresentative.Text = "Representative";
            // 
            // lblBankBranch
            // 
            this.lblBankBranch.Location = new System.Drawing.Point(18, 142);
            this.lblBankBranch.Name = "lblBankBranch";
            this.lblBankBranch.Size = new System.Drawing.Size(59, 13);
            this.lblBankBranch.TabIndex = 15;
            this.lblBankBranch.Text = "Bank Branch";
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(19, 192);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(39, 13);
            this.lblAddress.TabIndex = 16;
            this.lblAddress.Text = "Address";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(18, 116);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(24, 13);
            this.labelControl6.TabIndex = 16;
            this.labelControl6.Text = "IBAN";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.EnterMoveNextControl = true;
            this.txtAccountNumber.Location = new System.Drawing.Point(109, 87);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtAccountNumber.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAccountNumber.Properties.MaxLength = 50;
            this.txtAccountNumber.Size = new System.Drawing.Size(191, 20);
            this.txtAccountNumber.TabIndex = 13;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.Location = new System.Drawing.Point(18, 90);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(79, 13);
            this.lblAccountNumber.TabIndex = 12;
            this.lblAccountNumber.Text = "Account Number";
            // 
            // txtAccountName
            // 
            this.txtAccountName.EnterMoveNextControl = true;
            this.txtAccountName.Location = new System.Drawing.Point(109, 62);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtAccountName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAccountName.Properties.MaxLength = 50;
            this.txtAccountName.Size = new System.Drawing.Size(191, 20);
            this.txtAccountName.TabIndex = 13;
            // 
            // lblAccountName
            // 
            this.lblAccountName.Location = new System.Drawing.Point(18, 65);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(69, 13);
            this.lblAccountName.TabIndex = 12;
            this.lblAccountName.Text = "Account Name";
            // 
            // txtBankName
            // 
            this.txtBankName.EnterMoveNextControl = true;
            this.txtBankName.Location = new System.Drawing.Point(109, 36);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtBankName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtBankName.Properties.MaxLength = 50;
            this.txtBankName.Size = new System.Drawing.Size(191, 20);
            this.txtBankName.TabIndex = 13;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Bank Name";
            // 
            // groupControl2
            // 
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl2.Controls.Add(this.gridControlBanks);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 378);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(438, 239);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl2";
            // 
            // gridControlBanks
            // 
            this.gridControlBanks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlBanks.Location = new System.Drawing.Point(0, 0);
            this.gridControlBanks.MainView = this.gridViewBanks;
            this.gridControlBanks.Name = "gridControlBanks";
            this.gridControlBanks.Size = new System.Drawing.Size(438, 239);
            this.gridControlBanks.TabIndex = 0;
            this.gridControlBanks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBanks});
            // 
            // gridViewBanks
            // 
            this.gridViewBanks.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewBanks.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewBanks.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewBanks.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewBanks.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewBanks.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewBanks.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewBanks.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBanks.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewBanks.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewBanks.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colBankName,
            this.colAccountName,
            this.colBalance});
            this.gridViewBanks.GridControl = this.gridControlBanks;
            this.gridViewBanks.Name = "gridViewBanks";
            this.gridViewBanks.OptionsMenu.EnableColumnMenu = false;
            this.gridViewBanks.OptionsMenu.EnableFooterMenu = false;
            this.gridViewBanks.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewBanks.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewBanks.OptionsPrint.AutoWidth = false;
            this.gridViewBanks.OptionsPrint.PrintFooter = false;
            this.gridViewBanks.OptionsPrint.PrintGroupFooter = false;
            this.gridViewBanks.OptionsView.ColumnAutoWidth = false;
            this.gridViewBanks.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewBanks.OptionsView.RowAutoHeight = true;
            this.gridViewBanks.OptionsView.ShowAutoFilterRow = true;
            this.gridViewBanks.OptionsView.ShowGroupPanel = false;
            this.gridViewBanks.OptionsView.ShowViewCaption = true;
            this.gridViewBanks.ViewCaption = "Banks";
            // 
            // colId
            // 
            this.colId.Caption = "ID";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            // 
            // colBankName
            // 
            this.colBankName.Caption = "Bank";
            this.colBankName.FieldName = "BankName";
            this.colBankName.Name = "colBankName";
            this.colBankName.OptionsColumn.AllowEdit = false;
            this.colBankName.Visible = true;
            this.colBankName.VisibleIndex = 0;
            this.colBankName.Width = 150;
            // 
            // colAccountName
            // 
            this.colAccountName.Caption = "Account Name";
            this.colAccountName.FieldName = "AccountName";
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.OptionsColumn.AllowEdit = false;
            this.colAccountName.Visible = true;
            this.colAccountName.VisibleIndex = 1;
            this.colAccountName.Width = 125;
            // 
            // colBalance
            // 
            this.colBalance.Caption = "Balance";
            this.colBalance.FieldName = "Balance";
            this.colBalance.Name = "colBalance";
            this.colBalance.OptionsColumn.AllowEdit = false;
            this.colBalance.Visible = true;
            this.colBalance.VisibleIndex = 2;
            this.colBalance.Width = 125;
            // 
            // BankCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 617);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BankCardForm.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BankCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BankCardForm";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIBAN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepresentative.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBanks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBanks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private UserControls.Controls.MySimpleButton btnExit;
        private UserControls.Controls.MySimpleButton btnDelete;
        private UserControls.Controls.MySimpleButton btnUpdate;
        private UserControls.Controls.MySimpleButton btnSave;
        private UserControls.Controls.MyEmailTextEdit txtEmailAddress;
        private UserControls.Controls.MyMemoEdit memoAddress;
        private UserControls.Controls.MyPhoneNumberTextEdit txtPhoneNumber;
        private UserControls.Controls.MyIbanTextEdit txtIBAN;
        private DevExpress.XtraEditors.LabelControl lblEmail;
        private DevExpress.XtraEditors.LabelControl lblPhoneNumber;
        private UserControls.Controls.MyTextEdit txtRepresentative;
        private UserControls.Controls.MyTextEdit txtBankBranch;
        private DevExpress.XtraEditors.LabelControl lblRepresentative;
        private DevExpress.XtraEditors.LabelControl lblBankBranch;
        private DevExpress.XtraEditors.LabelControl lblAddress;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private UserControls.Controls.MyTextEdit txtAccountNumber;
        private DevExpress.XtraEditors.LabelControl lblAccountNumber;
        private UserControls.Controls.MyTextEdit txtAccountName;
        private DevExpress.XtraEditors.LabelControl lblAccountName;
        private UserControls.Controls.MyTextEdit txtBankName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private UserControls.Grids.MyGridControl gridControlBanks;
        private UserControls.Grids.MyGridView gridViewBanks;
        private UserControls.Grids.MyGridColumn colBankName;
        private UserControls.Grids.MyGridColumn colAccountName;
        private UserControls.Grids.MyGridColumn colBalance;
        private UserControls.Grids.MyGridColumn colId;
    }
}