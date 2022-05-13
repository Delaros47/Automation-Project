namespace AutomationUI.Forms.BankForms
{
    partial class BankMovementsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankMovementsForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblAccountName = new DevExpress.XtraEditors.LabelControl();
            this.btnAccountName = new DevExpress.XtraEditors.ButtonEdit();
            this.lblAccountNumber = new DevExpress.XtraEditors.LabelControl();
            this.txtAccountNumber = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtEnter = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.lblExit = new DevExpress.XtraEditors.LabelControl();
            this.txtExit = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.myTextEdit1 = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.lblBalance = new DevExpress.XtraEditors.LabelControl();
            this.gridControlBankMovements = new AutomationUI.UserControls.Grids.MyGridControl();
            this.gridViewBankMovements = new AutomationUI.UserControls.Grids.MyGridView();
            this.colId = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colDocumentNumber = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.coldPapersType = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colPapersId = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colEnter = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colExit = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colDescription = new AutomationUI.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccountName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBankMovements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBankMovements)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.myTextEdit1);
            this.groupControl1.Controls.Add(this.lblBalance);
            this.groupControl1.Controls.Add(this.txtExit);
            this.groupControl1.Controls.Add(this.txtEnter);
            this.groupControl1.Controls.Add(this.lblExit);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtAccountNumber);
            this.groupControl1.Controls.Add(this.lblAccountNumber);
            this.groupControl1.Controls.Add(this.btnAccountName);
            this.groupControl1.Controls.Add(this.lblAccountName);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(848, 130);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Bank Informations";
            // 
            // lblAccountName
            // 
            this.lblAccountName.Location = new System.Drawing.Point(17, 39);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(69, 13);
            this.lblAccountName.TabIndex = 0;
            this.lblAccountName.Text = "Account Name";
            // 
            // btnAccountName
            // 
            this.btnAccountName.Location = new System.Drawing.Point(103, 37);
            this.btnAccountName.Name = "btnAccountName";
            this.btnAccountName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnAccountName.Size = new System.Drawing.Size(324, 20);
            this.btnAccountName.TabIndex = 1;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.Location = new System.Drawing.Point(17, 67);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(79, 13);
            this.lblAccountNumber.TabIndex = 2;
            this.lblAccountNumber.Text = "Account Number";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.EnterMoveNextControl = true;
            this.txtAccountNumber.Location = new System.Drawing.Point(103, 63);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtAccountNumber.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAccountNumber.Properties.MaxLength = 50;
            this.txtAccountNumber.Size = new System.Drawing.Size(324, 20);
            this.txtAccountNumber.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 95);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Enter";
            // 
            // txtEnter
            // 
            this.txtEnter.EnterMoveNextControl = true;
            this.txtEnter.Location = new System.Drawing.Point(103, 88);
            this.txtEnter.Name = "txtEnter";
            this.txtEnter.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtEnter.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtEnter.Properties.MaxLength = 50;
            this.txtEnter.Size = new System.Drawing.Size(69, 20);
            this.txtEnter.TabIndex = 5;
            // 
            // lblExit
            // 
            this.lblExit.Location = new System.Drawing.Point(183, 91);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(18, 13);
            this.lblExit.TabIndex = 4;
            this.lblExit.Text = "Exit";
            // 
            // txtExit
            // 
            this.txtExit.EnterMoveNextControl = true;
            this.txtExit.Location = new System.Drawing.Point(222, 88);
            this.txtExit.Name = "txtExit";
            this.txtExit.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtExit.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtExit.Properties.MaxLength = 50;
            this.txtExit.Size = new System.Drawing.Size(69, 20);
            this.txtExit.TabIndex = 5;
            // 
            // myTextEdit1
            // 
            this.myTextEdit1.EnterMoveNextControl = true;
            this.myTextEdit1.Location = new System.Drawing.Point(358, 88);
            this.myTextEdit1.Name = "myTextEdit1";
            this.myTextEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.myTextEdit1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.myTextEdit1.Properties.MaxLength = 50;
            this.myTextEdit1.Size = new System.Drawing.Size(69, 20);
            this.myTextEdit1.TabIndex = 7;
            // 
            // lblBalance
            // 
            this.lblBalance.Location = new System.Drawing.Point(308, 91);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(37, 13);
            this.lblBalance.TabIndex = 6;
            this.lblBalance.Text = "Balance";
            // 
            // gridControlBankMovements
            // 
            this.gridControlBankMovements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlBankMovements.Location = new System.Drawing.Point(0, 130);
            this.gridControlBankMovements.MainView = this.gridViewBankMovements;
            this.gridControlBankMovements.Name = "gridControlBankMovements";
            this.gridControlBankMovements.Size = new System.Drawing.Size(848, 413);
            this.gridControlBankMovements.TabIndex = 1;
            this.gridControlBankMovements.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBankMovements});
            // 
            // gridViewBankMovements
            // 
            this.gridViewBankMovements.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewBankMovements.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewBankMovements.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewBankMovements.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewBankMovements.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewBankMovements.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewBankMovements.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewBankMovements.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBankMovements.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewBankMovements.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewBankMovements.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDocumentNumber,
            this.coldPapersType,
            this.colPapersId,
            this.colEnter,
            this.colExit,
            this.colDescription});
            this.gridViewBankMovements.GridControl = this.gridControlBankMovements;
            this.gridViewBankMovements.Name = "gridViewBankMovements";
            this.gridViewBankMovements.OptionsMenu.EnableColumnMenu = false;
            this.gridViewBankMovements.OptionsMenu.EnableFooterMenu = false;
            this.gridViewBankMovements.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewBankMovements.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewBankMovements.OptionsPrint.AutoWidth = false;
            this.gridViewBankMovements.OptionsPrint.PrintFooter = false;
            this.gridViewBankMovements.OptionsPrint.PrintGroupFooter = false;
            this.gridViewBankMovements.OptionsView.ColumnAutoWidth = false;
            this.gridViewBankMovements.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewBankMovements.OptionsView.RowAutoHeight = true;
            this.gridViewBankMovements.OptionsView.ShowAutoFilterRow = true;
            this.gridViewBankMovements.OptionsView.ShowGroupPanel = false;
            this.gridViewBankMovements.OptionsView.ShowViewCaption = true;
            this.gridViewBankMovements.ViewCaption = "Bank Movements";
            // 
            // colId
            // 
            this.colId.Caption = "ID";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            // 
            // colDocumentNumber
            // 
            this.colDocumentNumber.Caption = "Document Number";
            this.colDocumentNumber.FieldName = "DocumentNumber";
            this.colDocumentNumber.Name = "colDocumentNumber";
            this.colDocumentNumber.OptionsColumn.AllowEdit = false;
            this.colDocumentNumber.Visible = true;
            this.colDocumentNumber.VisibleIndex = 0;
            this.colDocumentNumber.Width = 150;
            // 
            // coldPapersType
            // 
            this.coldPapersType.Caption = "Papers Type";
            this.coldPapersType.FieldName = "PapersType";
            this.coldPapersType.Name = "coldPapersType";
            this.coldPapersType.OptionsColumn.AllowEdit = false;
            this.coldPapersType.Visible = true;
            this.coldPapersType.VisibleIndex = 1;
            this.coldPapersType.Width = 150;
            // 
            // colPapersId
            // 
            this.colPapersId.Caption = "Papers ID";
            this.colPapersId.FieldName = "PapersId";
            this.colPapersId.Name = "colPapersId";
            this.colPapersId.OptionsColumn.AllowEdit = false;
            // 
            // colEnter
            // 
            this.colEnter.Caption = "Enter";
            this.colEnter.FieldName = "Enter";
            this.colEnter.Name = "colEnter";
            this.colEnter.OptionsColumn.AllowEdit = false;
            this.colEnter.Visible = true;
            this.colEnter.VisibleIndex = 2;
            // 
            // colExit
            // 
            this.colExit.Caption = "Exit";
            this.colExit.FieldName = "Exit";
            this.colExit.Name = "colExit";
            this.colExit.OptionsColumn.AllowEdit = false;
            this.colExit.Visible = true;
            this.colExit.VisibleIndex = 3;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowEdit = false;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
            this.colDescription.Width = 350;
            // 
            // BankMovementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 543);
            this.Controls.Add(this.gridControlBankMovements);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BankMovementsForm.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BankMovementsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bank Movements";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccountName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBankMovements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBankMovements)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private UserControls.Controls.MyTextEdit myTextEdit1;
        private DevExpress.XtraEditors.LabelControl lblBalance;
        private UserControls.Controls.MyTextEdit txtExit;
        private UserControls.Controls.MyTextEdit txtEnter;
        private DevExpress.XtraEditors.LabelControl lblExit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private UserControls.Controls.MyTextEdit txtAccountNumber;
        private DevExpress.XtraEditors.LabelControl lblAccountNumber;
        private DevExpress.XtraEditors.ButtonEdit btnAccountName;
        private DevExpress.XtraEditors.LabelControl lblAccountName;
        private UserControls.Grids.MyGridControl gridControlBankMovements;
        private UserControls.Grids.MyGridView gridViewBankMovements;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colDocumentNumber;
        private UserControls.Grids.MyGridColumn coldPapersType;
        private UserControls.Grids.MyGridColumn colPapersId;
        private UserControls.Grids.MyGridColumn colEnter;
        private UserControls.Grids.MyGridColumn colExit;
        private UserControls.Grids.MyGridColumn colDescription;
    }
}