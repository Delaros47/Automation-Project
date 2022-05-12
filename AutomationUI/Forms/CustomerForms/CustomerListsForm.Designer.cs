namespace AutomationUI.Forms.CustomerForms
{
    partial class CustomerListsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerListsForm));
            this.txtCustomerGroup = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.lblCustomerGroup = new DevExpress.XtraEditors.LabelControl();
            this.txtCustomerName = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.lblCustomerName = new DevExpress.XtraEditors.LabelControl();
            this.txtCustomerCode = new AutomationUI.UserControls.Controls.MyPrivateCodeTextEdit();
            this.lblCustomerCode = new DevExpress.XtraEditors.LabelControl();
            this.btnClean = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.btnSearch = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.gridViewCustomerLists = new AutomationUI.UserControls.Grids.MyGridView();
            this.colCustomerCode = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colCustomerName = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colTaxNumber = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colTaxOffice = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colGroupName = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colCountry = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colCity = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colDistrict = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colAddress = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colPhone1 = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colPhone2 = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colFax1 = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colFax2 = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colWebAddress = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colMailInfo = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colAuthorized1 = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colAuthorizedEmail1 = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colAuthorized2 = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colAuthorizedEmail2 = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.gridControlCustomerLists = new AutomationUI.UserControls.Grids.MyGridControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControlStocks = new DevExpress.XtraTab.XtraTabControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomerLists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustomerLists)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlStocks)).BeginInit();
            this.xtraTabControlStocks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCustomerGroup
            // 
            this.txtCustomerGroup.EnterMoveNextControl = true;
            this.txtCustomerGroup.Location = new System.Drawing.Point(14, 162);
            this.txtCustomerGroup.Name = "txtCustomerGroup";
            this.txtCustomerGroup.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtCustomerGroup.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtCustomerGroup.Properties.MaxLength = 50;
            this.txtCustomerGroup.Size = new System.Drawing.Size(181, 20);
            this.txtCustomerGroup.TabIndex = 7;
            this.txtCustomerGroup.EditValueChanged += new System.EventHandler(this.txtCustomerGroup_EditValueChanged);
            // 
            // lblCustomerGroup
            // 
            this.lblCustomerGroup.Location = new System.Drawing.Point(14, 143);
            this.lblCustomerGroup.Name = "lblCustomerGroup";
            this.lblCustomerGroup.Size = new System.Drawing.Size(78, 13);
            this.lblCustomerGroup.TabIndex = 6;
            this.lblCustomerGroup.Text = "Customer Group";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.EnterMoveNextControl = true;
            this.txtCustomerName.Location = new System.Drawing.Point(14, 116);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtCustomerName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtCustomerName.Properties.MaxLength = 50;
            this.txtCustomerName.Size = new System.Drawing.Size(181, 20);
            this.txtCustomerName.TabIndex = 5;
            this.txtCustomerName.EditValueChanged += new System.EventHandler(this.txtCustomerName_EditValueChanged);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Location = new System.Drawing.Point(13, 97);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(76, 13);
            this.lblCustomerName.TabIndex = 4;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.EnterMoveNextControl = true;
            this.txtCustomerCode.Location = new System.Drawing.Point(14, 70);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtCustomerCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtCustomerCode.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCustomerCode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtCustomerCode.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtCustomerCode.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtCustomerCode.Properties.MaxLength = 20;
            this.txtCustomerCode.Size = new System.Drawing.Size(181, 20);
            this.txtCustomerCode.TabIndex = 3;
            this.txtCustomerCode.EditValueChanged += new System.EventHandler(this.txtCustomerCode_EditValueChanged);
            // 
            // lblCustomerCode
            // 
            this.lblCustomerCode.Location = new System.Drawing.Point(14, 51);
            this.lblCustomerCode.Name = "lblCustomerCode";
            this.lblCustomerCode.Size = new System.Drawing.Size(74, 13);
            this.lblCustomerCode.TabIndex = 2;
            this.lblCustomerCode.Text = "Customer Code";
            // 
            // btnClean
            // 
            this.btnClean.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnClean.Appearance.Options.UseForeColor = true;
            this.btnClean.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClean.ImageOptions.Image")));
            this.btnClean.Location = new System.Drawing.Point(113, 204);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(82, 48);
            this.btnClean.TabIndex = 1;
            this.btnClean.Text = "Clean";
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnSearch.Appearance.Options.UseForeColor = true;
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.Location = new System.Drawing.Point(14, 204);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 48);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gridViewCustomerLists
            // 
            this.gridViewCustomerLists.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewCustomerLists.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewCustomerLists.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewCustomerLists.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewCustomerLists.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewCustomerLists.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewCustomerLists.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewCustomerLists.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCustomerLists.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewCustomerLists.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewCustomerLists.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerCode,
            this.colCustomerName,
            this.colTaxNumber,
            this.colTaxOffice,
            this.colGroupName,
            this.colCountry,
            this.colCity,
            this.colDistrict,
            this.colAddress,
            this.colPhone1,
            this.colPhone2,
            this.colFax1,
            this.colFax2,
            this.colWebAddress,
            this.colMailInfo,
            this.colAuthorized1,
            this.colAuthorizedEmail1,
            this.colAuthorized2,
            this.colAuthorizedEmail2});
            this.gridViewCustomerLists.GridControl = this.gridControlCustomerLists;
            this.gridViewCustomerLists.Name = "gridViewCustomerLists";
            this.gridViewCustomerLists.OptionsMenu.EnableColumnMenu = false;
            this.gridViewCustomerLists.OptionsMenu.EnableFooterMenu = false;
            this.gridViewCustomerLists.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewCustomerLists.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewCustomerLists.OptionsPrint.AutoWidth = false;
            this.gridViewCustomerLists.OptionsPrint.PrintFooter = false;
            this.gridViewCustomerLists.OptionsPrint.PrintGroupFooter = false;
            this.gridViewCustomerLists.OptionsView.ColumnAutoWidth = false;
            this.gridViewCustomerLists.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewCustomerLists.OptionsView.RowAutoHeight = true;
            this.gridViewCustomerLists.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCustomerLists.OptionsView.ShowGroupPanel = false;
            this.gridViewCustomerLists.OptionsView.ShowViewCaption = true;
            this.gridViewCustomerLists.ViewCaption = "Customers";
            this.gridViewCustomerLists.DoubleClick += new System.EventHandler(this.gridViewCustomerLists_DoubleClick);
            // 
            // colCustomerCode
            // 
            this.colCustomerCode.Caption = "Customer Code";
            this.colCustomerCode.FieldName = "CustomerCode";
            this.colCustomerCode.Name = "colCustomerCode";
            this.colCustomerCode.OptionsColumn.AllowEdit = false;
            this.colCustomerCode.Visible = true;
            this.colCustomerCode.VisibleIndex = 0;
            this.colCustomerCode.Width = 100;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Customer Name";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.OptionsColumn.AllowEdit = false;
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 1;
            this.colCustomerName.Width = 100;
            // 
            // colTaxNumber
            // 
            this.colTaxNumber.Caption = "Tax Number";
            this.colTaxNumber.FieldName = "TaxNumber";
            this.colTaxNumber.Name = "colTaxNumber";
            this.colTaxNumber.OptionsColumn.AllowEdit = false;
            this.colTaxNumber.Visible = true;
            this.colTaxNumber.VisibleIndex = 2;
            // 
            // colTaxOffice
            // 
            this.colTaxOffice.Caption = "Tax Office";
            this.colTaxOffice.FieldName = "TaxOffice";
            this.colTaxOffice.Name = "colTaxOffice";
            this.colTaxOffice.OptionsColumn.AllowEdit = false;
            this.colTaxOffice.Visible = true;
            this.colTaxOffice.VisibleIndex = 3;
            // 
            // colGroupName
            // 
            this.colGroupName.Caption = "Group Name";
            this.colGroupName.FieldName = "GroupName";
            this.colGroupName.Name = "colGroupName";
            this.colGroupName.OptionsColumn.AllowEdit = false;
            this.colGroupName.Visible = true;
            this.colGroupName.VisibleIndex = 4;
            // 
            // colCountry
            // 
            this.colCountry.Caption = "Country";
            this.colCountry.FieldName = "Country";
            this.colCountry.Name = "colCountry";
            this.colCountry.OptionsColumn.AllowEdit = false;
            this.colCountry.Visible = true;
            this.colCountry.VisibleIndex = 5;
            // 
            // colCity
            // 
            this.colCity.Caption = "City";
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.OptionsColumn.AllowEdit = false;
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 6;
            // 
            // colDistrict
            // 
            this.colDistrict.Caption = "District";
            this.colDistrict.FieldName = "District";
            this.colDistrict.Name = "colDistrict";
            this.colDistrict.OptionsColumn.AllowEdit = false;
            this.colDistrict.Visible = true;
            this.colDistrict.VisibleIndex = 7;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Address";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.OptionsColumn.AllowEdit = false;
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 8;
            // 
            // colPhone1
            // 
            this.colPhone1.Caption = "Phone 1";
            this.colPhone1.FieldName = "Phone1";
            this.colPhone1.Name = "colPhone1";
            this.colPhone1.OptionsColumn.AllowEdit = false;
            this.colPhone1.Visible = true;
            this.colPhone1.VisibleIndex = 9;
            // 
            // colPhone2
            // 
            this.colPhone2.Caption = "Phone 2";
            this.colPhone2.FieldName = "Phone2";
            this.colPhone2.Name = "colPhone2";
            this.colPhone2.OptionsColumn.AllowEdit = false;
            this.colPhone2.Visible = true;
            this.colPhone2.VisibleIndex = 10;
            // 
            // colFax1
            // 
            this.colFax1.Caption = "Fax 1";
            this.colFax1.FieldName = "Fax1";
            this.colFax1.Name = "colFax1";
            this.colFax1.OptionsColumn.AllowEdit = false;
            this.colFax1.Visible = true;
            this.colFax1.VisibleIndex = 11;
            // 
            // colFax2
            // 
            this.colFax2.Caption = "Fax 2";
            this.colFax2.FieldName = "Fax2";
            this.colFax2.Name = "colFax2";
            this.colFax2.OptionsColumn.AllowEdit = false;
            this.colFax2.Visible = true;
            this.colFax2.VisibleIndex = 12;
            // 
            // colWebAddress
            // 
            this.colWebAddress.Caption = "Web Address";
            this.colWebAddress.FieldName = "WebAddress";
            this.colWebAddress.Name = "colWebAddress";
            this.colWebAddress.OptionsColumn.AllowEdit = false;
            this.colWebAddress.Visible = true;
            this.colWebAddress.VisibleIndex = 13;
            // 
            // colMailInfo
            // 
            this.colMailInfo.Caption = "Email Address";
            this.colMailInfo.FieldName = "MailInfo";
            this.colMailInfo.Name = "colMailInfo";
            this.colMailInfo.OptionsColumn.AllowEdit = false;
            this.colMailInfo.Visible = true;
            this.colMailInfo.VisibleIndex = 14;
            // 
            // colAuthorized1
            // 
            this.colAuthorized1.Caption = "Authorized 1";
            this.colAuthorized1.FieldName = "Authorized1";
            this.colAuthorized1.Name = "colAuthorized1";
            this.colAuthorized1.OptionsColumn.AllowEdit = false;
            this.colAuthorized1.Visible = true;
            this.colAuthorized1.VisibleIndex = 15;
            // 
            // colAuthorizedEmail1
            // 
            this.colAuthorizedEmail1.Caption = "Authorized Email 1";
            this.colAuthorizedEmail1.FieldName = "AuthorizedEmail1";
            this.colAuthorizedEmail1.Name = "colAuthorizedEmail1";
            this.colAuthorizedEmail1.OptionsColumn.AllowEdit = false;
            this.colAuthorizedEmail1.Visible = true;
            this.colAuthorizedEmail1.VisibleIndex = 16;
            // 
            // colAuthorized2
            // 
            this.colAuthorized2.Caption = "Authorized 2";
            this.colAuthorized2.FieldName = "Authorized2";
            this.colAuthorized2.Name = "colAuthorized2";
            this.colAuthorized2.OptionsColumn.AllowEdit = false;
            this.colAuthorized2.Visible = true;
            this.colAuthorized2.VisibleIndex = 17;
            // 
            // colAuthorizedEmail2
            // 
            this.colAuthorizedEmail2.Caption = "Authorized Email 2";
            this.colAuthorizedEmail2.FieldName = "AuthorizedEmail2";
            this.colAuthorizedEmail2.Name = "colAuthorizedEmail2";
            this.colAuthorizedEmail2.OptionsColumn.AllowEdit = false;
            this.colAuthorizedEmail2.Visible = true;
            this.colAuthorizedEmail2.VisibleIndex = 18;
            // 
            // gridControlCustomerLists
            // 
            this.gridControlCustomerLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCustomerLists.Location = new System.Drawing.Point(0, 0);
            this.gridControlCustomerLists.MainView = this.gridViewCustomerLists;
            this.gridControlCustomerLists.Name = "gridControlCustomerLists";
            this.gridControlCustomerLists.Size = new System.Drawing.Size(1244, 548);
            this.gridControlCustomerLists.TabIndex = 0;
            this.gridControlCustomerLists.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCustomerLists});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtCustomerGroup);
            this.xtraTabPage1.Controls.Add(this.lblCustomerGroup);
            this.xtraTabPage1.Controls.Add(this.txtCustomerName);
            this.xtraTabPage1.Controls.Add(this.lblCustomerName);
            this.xtraTabPage1.Controls.Add(this.txtCustomerCode);
            this.xtraTabPage1.Controls.Add(this.lblCustomerCode);
            this.xtraTabPage1.Controls.Add(this.btnClean);
            this.xtraTabPage1.Controls.Add(this.btnSearch);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(227, 523);
            this.xtraTabPage1.Text = "Search";
            // 
            // xtraTabControlStocks
            // 
            this.xtraTabControlStocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlStocks.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControlStocks.Name = "xtraTabControlStocks";
            this.xtraTabControlStocks.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControlStocks.Size = new System.Drawing.Size(229, 548);
            this.xtraTabControlStocks.TabIndex = 0;
            this.xtraTabControlStocks.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControlStocks.Tag = "";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Location = new System.Drawing.Point(8, 10);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControlStocks);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControlCustomerLists);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1483, 548);
            this.splitContainerControl1.SplitterPosition = 229;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // CustomerListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 568);
            this.Controls.Add(this.splitContainerControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("CustomerListsForm.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerListsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer Lists";
            this.Load += new System.EventHandler(this.CustomerListsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomerLists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustomerLists)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlStocks)).EndInit();
            this.xtraTabControlStocks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private UserControls.Controls.MyTextEdit txtCustomerGroup;
        private DevExpress.XtraEditors.LabelControl lblCustomerGroup;
        private UserControls.Controls.MyTextEdit txtCustomerName;
        private DevExpress.XtraEditors.LabelControl lblCustomerName;
        private UserControls.Controls.MyPrivateCodeTextEdit txtCustomerCode;
        private DevExpress.XtraEditors.LabelControl lblCustomerCode;
        private UserControls.Controls.MySimpleButton btnClean;
        private UserControls.Controls.MySimpleButton btnSearch;
        private UserControls.Grids.MyGridView gridViewCustomerLists;
        private UserControls.Grids.MyGridControl gridControlCustomerLists;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlStocks;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private UserControls.Grids.MyGridColumn colCustomerCode;
        private UserControls.Grids.MyGridColumn colCustomerName;
        private UserControls.Grids.MyGridColumn colTaxNumber;
        private UserControls.Grids.MyGridColumn colTaxOffice;
        private UserControls.Grids.MyGridColumn colGroupName;
        private UserControls.Grids.MyGridColumn colCountry;
        private UserControls.Grids.MyGridColumn colCity;
        private UserControls.Grids.MyGridColumn colDistrict;
        private UserControls.Grids.MyGridColumn colAddress;
        private UserControls.Grids.MyGridColumn colPhone1;
        private UserControls.Grids.MyGridColumn colPhone2;
        private UserControls.Grids.MyGridColumn colFax1;
        private UserControls.Grids.MyGridColumn colFax2;
        private UserControls.Grids.MyGridColumn colWebAddress;
        private UserControls.Grids.MyGridColumn colMailInfo;
        private UserControls.Grids.MyGridColumn colAuthorized1;
        private UserControls.Grids.MyGridColumn colAuthorizedEmail1;
        private UserControls.Grids.MyGridColumn colAuthorized2;
        private UserControls.Grids.MyGridColumn colAuthorizedEmail2;
    }
}