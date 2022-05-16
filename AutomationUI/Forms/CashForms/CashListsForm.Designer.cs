namespace AutomationUI.Forms.CashForms
{
    partial class CashListsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashListsForm));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControlStocks = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtCashName = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.lblCashName = new DevExpress.XtraEditors.LabelControl();
            this.txtCashCode = new AutomationUI.UserControls.Controls.MyPrivateCodeTextEdit();
            this.lblCashCode = new DevExpress.XtraEditors.LabelControl();
            this.btnClean = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.btnSearch = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.gridControlCashLists = new AutomationUI.UserControls.Grids.MyGridControl();
            this.gridViewCashLists = new AutomationUI.UserControls.Grids.MyGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlStocks)).BeginInit();
            this.xtraTabControlStocks.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCashName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCashCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCashLists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCashLists)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControlCashLists);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1483, 548);
            this.splitContainerControl1.SplitterPosition = 229;
            this.splitContainerControl1.TabIndex = 2;
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
            this.xtraTabPage1.Controls.Add(this.txtCashName);
            this.xtraTabPage1.Controls.Add(this.lblCashName);
            this.xtraTabPage1.Controls.Add(this.txtCashCode);
            this.xtraTabPage1.Controls.Add(this.lblCashCode);
            this.xtraTabPage1.Controls.Add(this.btnClean);
            this.xtraTabPage1.Controls.Add(this.btnSearch);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(227, 523);
            this.xtraTabPage1.Text = "Search";
            // 
            // txtCashName
            // 
            this.txtCashName.EnterMoveNextControl = true;
            this.txtCashName.Location = new System.Drawing.Point(14, 116);
            this.txtCashName.Name = "txtCashName";
            this.txtCashName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtCashName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtCashName.Properties.MaxLength = 50;
            this.txtCashName.Size = new System.Drawing.Size(181, 20);
            this.txtCashName.TabIndex = 5;
            // 
            // lblCashName
            // 
            this.lblCashName.Location = new System.Drawing.Point(13, 97);
            this.lblCashName.Name = "lblCashName";
            this.lblCashName.Size = new System.Drawing.Size(54, 13);
            this.lblCashName.TabIndex = 4;
            this.lblCashName.Text = "Cash Name";
            // 
            // txtCashCode
            // 
            this.txtCashCode.EnterMoveNextControl = true;
            this.txtCashCode.Location = new System.Drawing.Point(14, 70);
            this.txtCashCode.Name = "txtCashCode";
            this.txtCashCode.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtCashCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtCashCode.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCashCode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtCashCode.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtCashCode.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtCashCode.Properties.MaxLength = 20;
            this.txtCashCode.Size = new System.Drawing.Size(181, 20);
            this.txtCashCode.TabIndex = 3;
            // 
            // lblCashCode
            // 
            this.lblCashCode.Location = new System.Drawing.Point(14, 51);
            this.lblCashCode.Name = "lblCashCode";
            this.lblCashCode.Size = new System.Drawing.Size(52, 13);
            this.lblCashCode.TabIndex = 2;
            this.lblCashCode.Text = "Cash Code";
            // 
            // btnClean
            // 
            this.btnClean.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnClean.Appearance.Options.UseForeColor = true;
            this.btnClean.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClean.ImageOptions.Image")));
            this.btnClean.Location = new System.Drawing.Point(113, 164);
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
            this.btnSearch.Location = new System.Drawing.Point(14, 164);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 48);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            // 
            // gridControlCashLists
            // 
            this.gridControlCashLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCashLists.Location = new System.Drawing.Point(0, 0);
            this.gridControlCashLists.MainView = this.gridViewCashLists;
            this.gridControlCashLists.Name = "gridControlCashLists";
            this.gridControlCashLists.Size = new System.Drawing.Size(1244, 548);
            this.gridControlCashLists.TabIndex = 0;
            this.gridControlCashLists.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCashLists});
            // 
            // gridViewCashLists
            // 
            this.gridViewCashLists.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewCashLists.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewCashLists.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewCashLists.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewCashLists.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewCashLists.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewCashLists.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewCashLists.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCashLists.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewCashLists.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewCashLists.GridControl = this.gridControlCashLists;
            this.gridViewCashLists.Name = "gridViewCashLists";
            this.gridViewCashLists.OptionsMenu.EnableColumnMenu = false;
            this.gridViewCashLists.OptionsMenu.EnableFooterMenu = false;
            this.gridViewCashLists.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewCashLists.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewCashLists.OptionsPrint.AutoWidth = false;
            this.gridViewCashLists.OptionsPrint.PrintFooter = false;
            this.gridViewCashLists.OptionsPrint.PrintGroupFooter = false;
            this.gridViewCashLists.OptionsView.ColumnAutoWidth = false;
            this.gridViewCashLists.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewCashLists.OptionsView.RowAutoHeight = true;
            this.gridViewCashLists.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCashLists.OptionsView.ShowGroupPanel = false;
            this.gridViewCashLists.OptionsView.ShowViewCaption = true;
            this.gridViewCashLists.ViewCaption = "Cash Lists";
            // 
            // CashListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 568);
            this.Controls.Add(this.splitContainerControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("CashListsForm.IconOptions.LargeImage")));
            this.Name = "CashListsForm";
            this.Text = "Cash Lists";
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
            ((System.ComponentModel.ISupportInitialize)(this.txtCashName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCashCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCashLists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCashLists)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlStocks;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private UserControls.Controls.MyTextEdit txtCashName;
        private DevExpress.XtraEditors.LabelControl lblCashName;
        private UserControls.Controls.MyPrivateCodeTextEdit txtCashCode;
        private DevExpress.XtraEditors.LabelControl lblCashCode;
        private UserControls.Controls.MySimpleButton btnClean;
        private UserControls.Controls.MySimpleButton btnSearch;
        private UserControls.Grids.MyGridControl gridControlCashLists;
        private UserControls.Grids.MyGridView gridViewCashLists;
    }
}