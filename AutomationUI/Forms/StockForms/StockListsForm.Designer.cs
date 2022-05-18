namespace AutomationUI.Forms.StockForms
{
    partial class StockListsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockListsForm));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControlStocks = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtStockBarcode = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.lblStockBarcode = new DevExpress.XtraEditors.LabelControl();
            this.txtStockName = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.lblStockName = new DevExpress.XtraEditors.LabelControl();
            this.txtStockCode = new AutomationUI.UserControls.Controls.MyPrivateCodeTextEdit();
            this.lblStockCode = new DevExpress.XtraEditors.LabelControl();
            this.btnClean = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.btnSearch = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.gridControlStockLists = new AutomationUI.UserControls.Grids.MyGridControl();
            this.gridViewStockLists = new AutomationUI.UserControls.Grids.MyGridView();
            this.colStockName = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colStockCode = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colStockBarcode = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colStockUnit = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colStockPurchasePrice = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colStockSalePrice = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colStockPurchaseVAT = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colSaleVAT = new AutomationUI.UserControls.Grids.MyGridColumn();
            this.colGroupName = new AutomationUI.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlStocks)).BeginInit();
            this.xtraTabControlStocks.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockBarcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStockLists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStockLists)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControlStocks);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControlStockLists);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1483, 548);
            this.splitContainerControl1.SplitterPosition = 229;
            this.splitContainerControl1.TabIndex = 0;
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
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtStockBarcode);
            this.xtraTabPage1.Controls.Add(this.lblStockBarcode);
            this.xtraTabPage1.Controls.Add(this.txtStockName);
            this.xtraTabPage1.Controls.Add(this.lblStockName);
            this.xtraTabPage1.Controls.Add(this.txtStockCode);
            this.xtraTabPage1.Controls.Add(this.lblStockCode);
            this.xtraTabPage1.Controls.Add(this.btnClean);
            this.xtraTabPage1.Controls.Add(this.btnSearch);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(227, 523);
            this.xtraTabPage1.Text = "Search";
            // 
            // txtStockBarcode
            // 
            this.txtStockBarcode.EnterMoveNextControl = true;
            this.txtStockBarcode.Location = new System.Drawing.Point(14, 162);
            this.txtStockBarcode.Name = "txtStockBarcode";
            this.txtStockBarcode.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtStockBarcode.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtStockBarcode.Properties.MaxLength = 50;
            this.txtStockBarcode.Size = new System.Drawing.Size(181, 20);
            this.txtStockBarcode.TabIndex = 7;
            this.txtStockBarcode.EditValueChanged += new System.EventHandler(this.txtStockBarcode_EditValueChanged);
            // 
            // lblStockBarcode
            // 
            this.lblStockBarcode.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblStockBarcode.Appearance.Options.UseForeColor = true;
            this.lblStockBarcode.Location = new System.Drawing.Point(14, 143);
            this.lblStockBarcode.Name = "lblStockBarcode";
            this.lblStockBarcode.Size = new System.Drawing.Size(68, 13);
            this.lblStockBarcode.TabIndex = 6;
            this.lblStockBarcode.Text = "Stock Barcode";
            // 
            // txtStockName
            // 
            this.txtStockName.EnterMoveNextControl = true;
            this.txtStockName.Location = new System.Drawing.Point(14, 116);
            this.txtStockName.Name = "txtStockName";
            this.txtStockName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtStockName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtStockName.Properties.MaxLength = 50;
            this.txtStockName.Size = new System.Drawing.Size(181, 20);
            this.txtStockName.TabIndex = 5;
            this.txtStockName.EditValueChanged += new System.EventHandler(this.txtStockName_EditValueChanged);
            // 
            // lblStockName
            // 
            this.lblStockName.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblStockName.Appearance.Options.UseForeColor = true;
            this.lblStockName.Location = new System.Drawing.Point(13, 97);
            this.lblStockName.Name = "lblStockName";
            this.lblStockName.Size = new System.Drawing.Size(56, 13);
            this.lblStockName.TabIndex = 4;
            this.lblStockName.Text = "Stock Name";
            // 
            // txtStockCode
            // 
            this.txtStockCode.EnterMoveNextControl = true;
            this.txtStockCode.Location = new System.Drawing.Point(14, 70);
            this.txtStockCode.Name = "txtStockCode";
            this.txtStockCode.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtStockCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtStockCode.Properties.Appearance.Options.UseTextOptions = true;
            this.txtStockCode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtStockCode.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtStockCode.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtStockCode.Properties.MaxLength = 20;
            this.txtStockCode.Size = new System.Drawing.Size(181, 20);
            this.txtStockCode.TabIndex = 3;
            this.txtStockCode.EditValueChanged += new System.EventHandler(this.txtStockCode_EditValueChanged);
            // 
            // lblStockCode
            // 
            this.lblStockCode.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblStockCode.Appearance.Options.UseForeColor = true;
            this.lblStockCode.Location = new System.Drawing.Point(14, 51);
            this.lblStockCode.Name = "lblStockCode";
            this.lblStockCode.Size = new System.Drawing.Size(54, 13);
            this.lblStockCode.TabIndex = 2;
            this.lblStockCode.Text = "Stock Code";
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
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
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
            // gridControlStockLists
            // 
            this.gridControlStockLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlStockLists.Location = new System.Drawing.Point(0, 0);
            this.gridControlStockLists.MainView = this.gridViewStockLists;
            this.gridControlStockLists.Name = "gridControlStockLists";
            this.gridControlStockLists.Size = new System.Drawing.Size(1244, 548);
            this.gridControlStockLists.TabIndex = 0;
            this.gridControlStockLists.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewStockLists});
            // 
            // gridViewStockLists
            // 
            this.gridViewStockLists.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewStockLists.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewStockLists.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewStockLists.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewStockLists.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewStockLists.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewStockLists.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewStockLists.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewStockLists.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewStockLists.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewStockLists.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStockName,
            this.colStockCode,
            this.colStockBarcode,
            this.colStockUnit,
            this.colStockPurchasePrice,
            this.colStockSalePrice,
            this.colStockPurchaseVAT,
            this.colSaleVAT,
            this.colGroupName});
            this.gridViewStockLists.GridControl = this.gridControlStockLists;
            this.gridViewStockLists.Name = "gridViewStockLists";
            this.gridViewStockLists.OptionsMenu.EnableColumnMenu = false;
            this.gridViewStockLists.OptionsMenu.EnableFooterMenu = false;
            this.gridViewStockLists.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewStockLists.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewStockLists.OptionsPrint.AutoWidth = false;
            this.gridViewStockLists.OptionsPrint.PrintFooter = false;
            this.gridViewStockLists.OptionsPrint.PrintGroupFooter = false;
            this.gridViewStockLists.OptionsView.ColumnAutoWidth = false;
            this.gridViewStockLists.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewStockLists.OptionsView.RowAutoHeight = true;
            this.gridViewStockLists.OptionsView.ShowAutoFilterRow = true;
            this.gridViewStockLists.OptionsView.ShowGroupPanel = false;
            this.gridViewStockLists.OptionsView.ShowViewCaption = true;
            this.gridViewStockLists.ViewCaption = "Stocks";
            this.gridViewStockLists.DoubleClick += new System.EventHandler(this.gridViewStockLists_DoubleClick);
            // 
            // colStockName
            // 
            this.colStockName.Caption = "Stock Name";
            this.colStockName.FieldName = "StockName";
            this.colStockName.Name = "colStockName";
            this.colStockName.OptionsColumn.AllowEdit = false;
            this.colStockName.Visible = true;
            this.colStockName.VisibleIndex = 2;
            this.colStockName.Width = 200;
            // 
            // colStockCode
            // 
            this.colStockCode.Caption = "Stock Code";
            this.colStockCode.FieldName = "StockCode";
            this.colStockCode.Name = "colStockCode";
            this.colStockCode.OptionsColumn.AllowEdit = false;
            this.colStockCode.Visible = true;
            this.colStockCode.VisibleIndex = 0;
            this.colStockCode.Width = 125;
            // 
            // colStockBarcode
            // 
            this.colStockBarcode.Caption = "Stock Barcode";
            this.colStockBarcode.FieldName = "StockBarcode";
            this.colStockBarcode.Name = "colStockBarcode";
            this.colStockBarcode.OptionsColumn.AllowEdit = false;
            this.colStockBarcode.Visible = true;
            this.colStockBarcode.VisibleIndex = 1;
            this.colStockBarcode.Width = 125;
            // 
            // colStockUnit
            // 
            this.colStockUnit.Caption = "Stock Unit";
            this.colStockUnit.FieldName = "StockUnit";
            this.colStockUnit.Name = "colStockUnit";
            this.colStockUnit.OptionsColumn.AllowEdit = false;
            this.colStockUnit.Visible = true;
            this.colStockUnit.VisibleIndex = 3;
            this.colStockUnit.Width = 125;
            // 
            // colStockPurchasePrice
            // 
            this.colStockPurchasePrice.Caption = "Purchase Price";
            this.colStockPurchasePrice.FieldName = "StockPurchasePrice";
            this.colStockPurchasePrice.Name = "colStockPurchasePrice";
            this.colStockPurchasePrice.OptionsColumn.AllowEdit = false;
            this.colStockPurchasePrice.Visible = true;
            this.colStockPurchasePrice.VisibleIndex = 4;
            this.colStockPurchasePrice.Width = 125;
            // 
            // colStockSalePrice
            // 
            this.colStockSalePrice.Caption = "Sale Price";
            this.colStockSalePrice.FieldName = "StockSalePrice";
            this.colStockSalePrice.Name = "colStockSalePrice";
            this.colStockSalePrice.OptionsColumn.AllowEdit = false;
            this.colStockSalePrice.Visible = true;
            this.colStockSalePrice.VisibleIndex = 5;
            this.colStockSalePrice.Width = 125;
            // 
            // colStockPurchaseVAT
            // 
            this.colStockPurchaseVAT.Caption = "Purchase VAT";
            this.colStockPurchaseVAT.FieldName = "StockPurchaseVAT";
            this.colStockPurchaseVAT.Name = "colStockPurchaseVAT";
            this.colStockPurchaseVAT.OptionsColumn.AllowEdit = false;
            this.colStockPurchaseVAT.Visible = true;
            this.colStockPurchaseVAT.VisibleIndex = 6;
            this.colStockPurchaseVAT.Width = 125;
            // 
            // colSaleVAT
            // 
            this.colSaleVAT.Caption = "Sale VAT";
            this.colSaleVAT.FieldName = "StockSaleVAT";
            this.colSaleVAT.Name = "colSaleVAT";
            this.colSaleVAT.OptionsColumn.AllowEdit = false;
            this.colSaleVAT.Visible = true;
            this.colSaleVAT.VisibleIndex = 8;
            this.colSaleVAT.Width = 125;
            // 
            // colGroupName
            // 
            this.colGroupName.Caption = "Group Name";
            this.colGroupName.FieldName = "GroupName";
            this.colGroupName.Name = "colGroupName";
            this.colGroupName.OptionsColumn.AllowEdit = false;
            this.colGroupName.Visible = true;
            this.colGroupName.VisibleIndex = 7;
            this.colGroupName.Width = 125;
            // 
            // StockListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 568);
            this.Controls.Add(this.splitContainerControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("StockListsForm.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StockListsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Lists";
            this.Load += new System.EventHandler(this.StockListsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlStocks)).EndInit();
            this.xtraTabControlStocks.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockBarcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStockLists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStockLists)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlStocks;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private UserControls.Controls.MySimpleButton btnClean;
        private UserControls.Controls.MySimpleButton btnSearch;
        private UserControls.Controls.MyTextEdit txtStockBarcode;
        private DevExpress.XtraEditors.LabelControl lblStockBarcode;
        private UserControls.Controls.MyTextEdit txtStockName;
        private DevExpress.XtraEditors.LabelControl lblStockName;
        private UserControls.Controls.MyPrivateCodeTextEdit txtStockCode;
        private DevExpress.XtraEditors.LabelControl lblStockCode;
        private UserControls.Grids.MyGridControl gridControlStockLists;
        private UserControls.Grids.MyGridView gridViewStockLists;
        private UserControls.Grids.MyGridColumn colStockName;
        private UserControls.Grids.MyGridColumn colStockCode;
        private UserControls.Grids.MyGridColumn colStockBarcode;
        private UserControls.Grids.MyGridColumn colStockUnit;
        private UserControls.Grids.MyGridColumn colStockPurchasePrice;
        private UserControls.Grids.MyGridColumn colStockSalePrice;
        private UserControls.Grids.MyGridColumn colStockPurchaseVAT;
        private UserControls.Grids.MyGridColumn colSaleVAT;
        private UserControls.Grids.MyGridColumn colGroupName;
    }
}