namespace AutomationUI.Forms.StockForms
{
    partial class StockGroups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockGroups));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtGroupName = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.txtGroupCode = new AutomationUI.UserControls.Controls.MyPrivateCodeTextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblGroupCode = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlStockGroups = new AutomationUI.UserControls.Grids.MyGridControl();
            this.gridViewStockGroups = new AutomationUI.UserControls.Grids.MyGridView();
            this.colGroupId = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colGroupCode = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colGroupName = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnUpdate = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.btnExit = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.btnDelete = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.btnSave = new AutomationUI.UserControls.Controls.MySimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStockGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStockGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtGroupName);
            this.groupControl1.Controls.Add(this.txtGroupCode);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.lblGroupCode);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(354, 97);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Group Informations";
            // 
            // txtGroupName
            // 
            this.txtGroupName.EnterMoveNextControl = true;
            this.txtGroupName.Location = new System.Drawing.Point(95, 68);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtGroupName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtGroupName.Properties.MaxLength = 50;
            this.txtGroupName.Size = new System.Drawing.Size(215, 20);
            this.txtGroupName.TabIndex = 3;
            // 
            // txtGroupCode
            // 
            this.txtGroupCode.EnterMoveNextControl = true;
            this.txtGroupCode.Location = new System.Drawing.Point(95, 41);
            this.txtGroupCode.Name = "txtGroupCode";
            this.txtGroupCode.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtGroupCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtGroupCode.Properties.Appearance.Options.UseTextOptions = true;
            this.txtGroupCode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtGroupCode.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtGroupCode.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtGroupCode.Properties.MaxLength = 20;
            this.txtGroupCode.Size = new System.Drawing.Size(215, 20);
            this.txtGroupCode.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Group Name";
            // 
            // lblGroupCode
            // 
            this.lblGroupCode.Location = new System.Drawing.Point(13, 41);
            this.lblGroupCode.Name = "lblGroupCode";
            this.lblGroupCode.Size = new System.Drawing.Size(57, 13);
            this.lblGroupCode.TabIndex = 0;
            this.lblGroupCode.Text = "Group Code";
            // 
            // groupControl2
            // 
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl2.Controls.Add(this.gridControlStockGroups);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 97);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(354, 259);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl2";
            // 
            // gridControlStockGroups
            // 
            this.gridControlStockGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlStockGroups.Location = new System.Drawing.Point(0, 0);
            this.gridControlStockGroups.MainView = this.gridViewStockGroups;
            this.gridControlStockGroups.Name = "gridControlStockGroups";
            this.gridControlStockGroups.Size = new System.Drawing.Size(354, 259);
            this.gridControlStockGroups.TabIndex = 0;
            this.gridControlStockGroups.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewStockGroups});
            // 
            // gridViewStockGroups
            // 
            this.gridViewStockGroups.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewStockGroups.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewStockGroups.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewStockGroups.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewStockGroups.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewStockGroups.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewStockGroups.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewStockGroups.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewStockGroups.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewStockGroups.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewStockGroups.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGroupId,
            this.colGroupCode,
            this.colGroupName});
            this.gridViewStockGroups.GridControl = this.gridControlStockGroups;
            this.gridViewStockGroups.Name = "gridViewStockGroups";
            this.gridViewStockGroups.OptionsMenu.EnableColumnMenu = false;
            this.gridViewStockGroups.OptionsMenu.EnableFooterMenu = false;
            this.gridViewStockGroups.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewStockGroups.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewStockGroups.OptionsPrint.AutoWidth = false;
            this.gridViewStockGroups.OptionsPrint.PrintFooter = false;
            this.gridViewStockGroups.OptionsPrint.PrintGroupFooter = false;
            this.gridViewStockGroups.OptionsView.ColumnAutoWidth = false;
            this.gridViewStockGroups.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewStockGroups.OptionsView.RowAutoHeight = true;
            this.gridViewStockGroups.OptionsView.ShowAutoFilterRow = true;
            this.gridViewStockGroups.OptionsView.ShowGroupPanel = false;
            this.gridViewStockGroups.OptionsView.ShowViewCaption = true;
            this.gridViewStockGroups.ViewCaption = "Stock Groups";
            this.gridViewStockGroups.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewStockGroups_FocusedRowChanged);
            // 
            // colGroupId
            // 
            this.colGroupId.Caption = "ID";
            this.colGroupId.FieldName = "GroupId";
            this.colGroupId.Name = "colGroupId";
            this.colGroupId.OptionsColumn.AllowEdit = false;
            // 
            // colGroupCode
            // 
            this.colGroupCode.Caption = "Group Code";
            this.colGroupCode.FieldName = "GroupCode";
            this.colGroupCode.Name = "colGroupCode";
            this.colGroupCode.OptionsColumn.AllowEdit = false;
            this.colGroupCode.Visible = true;
            this.colGroupCode.VisibleIndex = 0;
            this.colGroupCode.Width = 160;
            // 
            // colGroupName
            // 
            this.colGroupName.Caption = "Group Name";
            this.colGroupName.FieldName = "GroupName";
            this.colGroupName.Name = "colGroupName";
            this.colGroupName.OptionsColumn.AllowEdit = false;
            this.colGroupName.Visible = true;
            this.colGroupName.VisibleIndex = 1;
            this.colGroupName.Width = 160;
            // 
            // groupControl3
            // 
            this.groupControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl3.Controls.Add(this.btnUpdate);
            this.groupControl3.Controls.Add(this.btnExit);
            this.groupControl3.Controls.Add(this.btnDelete);
            this.groupControl3.Controls.Add(this.btnSave);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 356);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(354, 68);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "groupControl3";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnUpdate.Appearance.Options.UseForeColor = true;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(98, 15);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(79, 42);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnExit.Appearance.Options.UseForeColor = true;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(268, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 42);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnDelete.Appearance.Options.UseForeColor = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(183, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 42);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(13, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 42);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // StockGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 424);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("StockGroups.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StockGroups";
            this.Text = "Stock Groups";
            this.Load += new System.EventHandler(this.StockGroups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStockGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStockGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private UserControls.Controls.MyTextEdit txtGroupName;
        private UserControls.Controls.MyPrivateCodeTextEdit txtGroupCode;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblGroupCode;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private UserControls.Grids.MyGridControl gridControlStockGroups;
        private UserControls.Grids.MyGridView gridViewStockGroups;
        private UserControls.Grids.MyGridColumn colGroupId;
        private UserControls.Grids.MyGridColumn colGroupCode;
        private UserControls.Grids.MyGridColumn colGroupName;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private UserControls.Controls.MySimpleButton btnSave;
        private UserControls.Controls.MySimpleButton btnExit;
        private UserControls.Controls.MySimpleButton btnDelete;
        private UserControls.Controls.MySimpleButton btnUpdate;
    }
}