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
            this.txtCustomerBarcode = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.lblCustomerBarcode = new DevExpress.XtraEditors.LabelControl();
            this.txtCustomerName = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.lblCustomerName = new DevExpress.XtraEditors.LabelControl();
            this.txtCustomerCode = new AutomationUI.UserControls.Controls.MyPrivateCodeTextEdit();
            this.lblCustomerCode = new DevExpress.XtraEditors.LabelControl();
            this.btnClean = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.btnSearch = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.gridViewCustomerLists = new AutomationUI.UserControls.Grids.MyGridView();
            this.gridControlCustomerLists = new AutomationUI.UserControls.Grids.MyGridControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControlStocks = new DevExpress.XtraTab.XtraTabControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerBarcode.Properties)).BeginInit();
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
            // txtCustomerBarcode
            // 
            this.txtCustomerBarcode.EnterMoveNextControl = true;
            this.txtCustomerBarcode.Location = new System.Drawing.Point(14, 162);
            this.txtCustomerBarcode.Name = "txtCustomerBarcode";
            this.txtCustomerBarcode.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtCustomerBarcode.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtCustomerBarcode.Properties.MaxLength = 50;
            this.txtCustomerBarcode.Size = new System.Drawing.Size(181, 20);
            this.txtCustomerBarcode.TabIndex = 7;
            // 
            // lblCustomerBarcode
            // 
            this.lblCustomerBarcode.Location = new System.Drawing.Point(14, 143);
            this.lblCustomerBarcode.Name = "lblCustomerBarcode";
            this.lblCustomerBarcode.Size = new System.Drawing.Size(88, 13);
            this.lblCustomerBarcode.TabIndex = 6;
            this.lblCustomerBarcode.Text = "Customer Barcode";
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
            this.xtraTabPage1.Controls.Add(this.txtCustomerBarcode);
            this.xtraTabPage1.Controls.Add(this.lblCustomerBarcode);
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
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerBarcode.Properties)).EndInit();
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
        private UserControls.Controls.MyTextEdit txtCustomerBarcode;
        private DevExpress.XtraEditors.LabelControl lblCustomerBarcode;
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
    }
}