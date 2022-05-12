namespace AutomationUI.Forms.CustomerForms
{
    partial class CustomerGroupsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerGroupsForm));
            this.gridControlCustomerGroups = new AutomationUI.UserControls.Grids.MyGridControl();
            this.gridViewCustomerGroups = new AutomationUI.UserControls.Grids.MyGridView();
            this.colGroupId = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colGroupCode = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colGroupName = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnUpdate = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.btnSave = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.btnDelete = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.btnExit = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtGroupName = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.txtGroupCode = new AutomationUI.UserControls.Controls.MyPrivateCodeTextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblGroupCode = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustomerGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomerGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlCustomerGroups
            // 
            this.gridControlCustomerGroups.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlCustomerGroups.Location = new System.Drawing.Point(0, 0);
            this.gridControlCustomerGroups.MainView = this.gridViewCustomerGroups;
            this.gridControlCustomerGroups.Name = "gridControlCustomerGroups";
            this.gridControlCustomerGroups.Size = new System.Drawing.Size(348, 256);
            this.gridControlCustomerGroups.TabIndex = 3;
            this.gridControlCustomerGroups.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCustomerGroups});
            // 
            // gridViewCustomerGroups
            // 
            this.gridViewCustomerGroups.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewCustomerGroups.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewCustomerGroups.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewCustomerGroups.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewCustomerGroups.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewCustomerGroups.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewCustomerGroups.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewCustomerGroups.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCustomerGroups.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewCustomerGroups.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewCustomerGroups.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGroupId,
            this.colGroupCode,
            this.colGroupName});
            this.gridViewCustomerGroups.GridControl = this.gridControlCustomerGroups;
            this.gridViewCustomerGroups.Name = "gridViewCustomerGroups";
            this.gridViewCustomerGroups.OptionsMenu.EnableColumnMenu = false;
            this.gridViewCustomerGroups.OptionsMenu.EnableFooterMenu = false;
            this.gridViewCustomerGroups.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewCustomerGroups.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewCustomerGroups.OptionsPrint.AutoWidth = false;
            this.gridViewCustomerGroups.OptionsPrint.PrintFooter = false;
            this.gridViewCustomerGroups.OptionsPrint.PrintGroupFooter = false;
            this.gridViewCustomerGroups.OptionsView.ColumnAutoWidth = false;
            this.gridViewCustomerGroups.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewCustomerGroups.OptionsView.RowAutoHeight = true;
            this.gridViewCustomerGroups.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCustomerGroups.OptionsView.ShowGroupPanel = false;
            this.gridViewCustomerGroups.OptionsView.ShowViewCaption = true;
            this.gridViewCustomerGroups.ViewCaption = "Stock Groups";
            // 
            // colGroupId
            // 
            this.colGroupId.Caption = "ID";
            this.colGroupId.FieldName = "Id";
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
            this.groupControl3.Controls.Add(this.gridControlCustomerGroups);
            this.groupControl3.Controls.Add(this.groupControl2);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 97);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(348, 321);
            this.groupControl3.TabIndex = 5;
            this.groupControl3.Text = "groupControl3";
            // 
            // groupControl2
            // 
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl2.Controls.Add(this.btnUpdate);
            this.groupControl2.Controls.Add(this.btnSave);
            this.groupControl2.Controls.Add(this.btnDelete);
            this.groupControl2.Controls.Add(this.btnExit);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 253);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(348, 68);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "groupControl2";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnUpdate.Appearance.Options.UseForeColor = true;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(92, 14);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(79, 42);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(7, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 42);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnDelete.Appearance.Options.UseForeColor = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(177, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 42);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            // 
            // btnExit
            // 
            this.btnExit.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnExit.Appearance.Options.UseForeColor = true;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(262, 14);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 42);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
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
            this.groupControl1.Size = new System.Drawing.Size(348, 97);
            this.groupControl1.TabIndex = 4;
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
            // CustomerGroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 418);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("CustomerGroupsForm.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerGroupsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer Groups";
            this.Load += new System.EventHandler(this.CustomerGroupsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustomerGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomerGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.Grids.MyGridControl gridControlCustomerGroups;
        private UserControls.Grids.MyGridView gridViewCustomerGroups;
        private UserControls.Grids.MyGridColumn colGroupId;
        private UserControls.Grids.MyGridColumn colGroupCode;
        private UserControls.Grids.MyGridColumn colGroupName;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private UserControls.Controls.MySimpleButton btnUpdate;
        private UserControls.Controls.MySimpleButton btnExit;
        private UserControls.Controls.MySimpleButton btnDelete;
        private UserControls.Controls.MySimpleButton btnSave;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private UserControls.Controls.MyTextEdit txtGroupName;
        private UserControls.Controls.MyPrivateCodeTextEdit txtGroupCode;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblGroupCode;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}