namespace AutomationUI.Forms.CashForms
{
    partial class CashCardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashCardForm));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlCashs = new AutomationUI.UserControls.Grids.MyGridControl();
            this.gridViewCashs = new AutomationUI.UserControls.Grids.MyGridView();
            this.colId = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colCashCode = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colCashName = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colBalance = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colDescription = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.btnSave = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.btnUpdate = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.btnDelete = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.memoDescription = new AutomationUI.UserControls.Controls.MyMemoEdit();
            this.btnExit = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.lblDescription = new DevExpress.XtraEditors.LabelControl();
            this.lblCashName = new DevExpress.XtraEditors.LabelControl();
            this.txtCashCode = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.lblCashCode = new DevExpress.XtraEditors.LabelControl();
            this.txtCashName = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCashs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCashs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCashCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCashName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl2.Controls.Add(this.gridControlCashs);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 239);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(437, 261);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "groupControl2";
            // 
            // gridControlCashs
            // 
            this.gridControlCashs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCashs.Location = new System.Drawing.Point(0, 0);
            this.gridControlCashs.MainView = this.gridViewCashs;
            this.gridControlCashs.Name = "gridControlCashs";
            this.gridControlCashs.Size = new System.Drawing.Size(437, 261);
            this.gridControlCashs.TabIndex = 0;
            this.gridControlCashs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCashs});
            // 
            // gridViewCashs
            // 
            this.gridViewCashs.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewCashs.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewCashs.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewCashs.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewCashs.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewCashs.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewCashs.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewCashs.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCashs.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewCashs.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewCashs.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCashCode,
            this.colCashName,
            this.colBalance,
            this.colDescription});
            this.gridViewCashs.GridControl = this.gridControlCashs;
            this.gridViewCashs.Name = "gridViewCashs";
            this.gridViewCashs.OptionsMenu.EnableColumnMenu = false;
            this.gridViewCashs.OptionsMenu.EnableFooterMenu = false;
            this.gridViewCashs.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewCashs.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewCashs.OptionsPrint.AutoWidth = false;
            this.gridViewCashs.OptionsPrint.PrintFooter = false;
            this.gridViewCashs.OptionsPrint.PrintGroupFooter = false;
            this.gridViewCashs.OptionsView.ColumnAutoWidth = false;
            this.gridViewCashs.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewCashs.OptionsView.RowAutoHeight = true;
            this.gridViewCashs.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCashs.OptionsView.ShowGroupPanel = false;
            this.gridViewCashs.OptionsView.ShowViewCaption = true;
            this.gridViewCashs.ViewCaption = "Cashs";
            this.gridViewCashs.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewCashs_FocusedRowChanged);
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            // 
            // colCashCode
            // 
            this.colCashCode.Caption = "Cash Code";
            this.colCashCode.FieldName = "CashCode";
            this.colCashCode.Name = "colCashCode";
            this.colCashCode.OptionsColumn.AllowEdit = false;
            this.colCashCode.Visible = true;
            this.colCashCode.VisibleIndex = 0;
            // 
            // colCashName
            // 
            this.colCashName.Caption = "Cash Name";
            this.colCashName.FieldName = "CashName";
            this.colCashName.Name = "colCashName";
            this.colCashName.OptionsColumn.AllowEdit = false;
            this.colCashName.Visible = true;
            this.colCashName.VisibleIndex = 1;
            this.colCashName.Width = 100;
            // 
            // colBalance
            // 
            this.colBalance.Caption = "Balance";
            this.colBalance.FieldName = "Balance";
            this.colBalance.Name = "colBalance";
            this.colBalance.OptionsColumn.AllowEdit = false;
            this.colBalance.Visible = true;
            this.colBalance.VisibleIndex = 2;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowEdit = false;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
            this.colDescription.Width = 150;
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnUpdate.Appearance.Options.UseForeColor = true;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(320, 82);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 41);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnDelete.Appearance.Options.UseForeColor = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(320, 129);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 41);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // memoDescription
            // 
            this.memoDescription.EnterMoveNextControl = true;
            this.memoDescription.Location = new System.Drawing.Point(109, 92);
            this.memoDescription.Name = "memoDescription";
            this.memoDescription.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.memoDescription.Properties.Appearance.Options.UseBackColor = true;
            this.memoDescription.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.memoDescription.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.memoDescription.Properties.MaxLength = 500;
            this.memoDescription.Size = new System.Drawing.Size(191, 125);
            this.memoDescription.TabIndex = 22;
            // 
            // btnExit
            // 
            this.btnExit.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnExit.Appearance.Options.UseForeColor = true;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(320, 176);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 41);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(19, 93);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(53, 13);
            this.lblDescription.TabIndex = 16;
            this.lblDescription.Text = "Description";
            // 
            // lblCashName
            // 
            this.lblCashName.Location = new System.Drawing.Point(18, 65);
            this.lblCashName.Name = "lblCashName";
            this.lblCashName.Size = new System.Drawing.Size(54, 13);
            this.lblCashName.TabIndex = 12;
            this.lblCashName.Text = "Cash Name";
            // 
            // txtCashCode
            // 
            this.txtCashCode.EnterMoveNextControl = true;
            this.txtCashCode.Location = new System.Drawing.Point(109, 36);
            this.txtCashCode.Name = "txtCashCode";
            this.txtCashCode.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtCashCode.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtCashCode.Properties.MaxLength = 50;
            this.txtCashCode.Size = new System.Drawing.Size(191, 20);
            this.txtCashCode.TabIndex = 13;
            // 
            // lblCashCode
            // 
            this.lblCashCode.Location = new System.Drawing.Point(18, 39);
            this.lblCashCode.Name = "lblCashCode";
            this.lblCashCode.Size = new System.Drawing.Size(52, 13);
            this.lblCashCode.TabIndex = 12;
            this.lblCashCode.Text = "Cash Code";
            // 
            // txtCashName
            // 
            this.txtCashName.EnterMoveNextControl = true;
            this.txtCashName.Location = new System.Drawing.Point(109, 62);
            this.txtCashName.Name = "txtCashName";
            this.txtCashName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtCashName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtCashName.Properties.MaxLength = 50;
            this.txtCashName.Size = new System.Drawing.Size(191, 20);
            this.txtCashName.TabIndex = 13;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.memoDescription);
            this.groupControl1.Controls.Add(this.btnExit);
            this.groupControl1.Controls.Add(this.lblDescription);
            this.groupControl1.Controls.Add(this.txtCashName);
            this.groupControl1.Controls.Add(this.lblCashName);
            this.groupControl1.Controls.Add(this.txtCashCode);
            this.groupControl1.Controls.Add(this.lblCashCode);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(437, 239);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Bank Informations";
            // 
            // CashCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 500);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("CashCardForm.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CashCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cash Card";
            this.Load += new System.EventHandler(this.CashCardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCashs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCashs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCashCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCashName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private UserControls.Grids.MyGridControl gridControlCashs;
        private UserControls.Grids.MyGridView gridViewCashs;
        private UserControls.Controls.MySimpleButton btnSave;
        private UserControls.Controls.MySimpleButton btnUpdate;
        private UserControls.Controls.MySimpleButton btnDelete;
        private UserControls.Controls.MyMemoEdit memoDescription;
        private UserControls.Controls.MySimpleButton btnExit;
        private DevExpress.XtraEditors.LabelControl lblDescription;
        private DevExpress.XtraEditors.LabelControl lblCashName;
        private UserControls.Controls.MyTextEdit txtCashCode;
        private DevExpress.XtraEditors.LabelControl lblCashCode;
        private UserControls.Controls.MyTextEdit txtCashName;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colCashCode;
        private UserControls.Grids.MyGridColumn colCashName;
        private UserControls.Grids.MyGridColumn colBalance;
        private UserControls.Grids.MyGridColumn colDescription;
    }
}