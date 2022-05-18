namespace AutomationUI.Forms.BankForms
{
    partial class BankListsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankListsForm));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControlStocks = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtIBAN = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.lblIBAN = new DevExpress.XtraEditors.LabelControl();
            this.txtAccountNumber = new AutomationUI.UserControls.Controls.MyTextEdit();
            this.lblAccountNumber = new DevExpress.XtraEditors.LabelControl();
            this.txtAccountName = new AutomationUI.UserControls.Controls.MyPrivateCodeTextEdit();
            this.lblAccountName = new DevExpress.XtraEditors.LabelControl();
            this.btnClean = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.btnSearch = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.gridControlBankLists = new AutomationUI.UserControls.Grids.MyGridControl();
            this.gridViewBankLists = new AutomationUI.UserControls.Grids.MyGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlStocks)).BeginInit();
            this.xtraTabControlStocks.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIBAN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBankLists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBankLists)).BeginInit();
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
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControlBankLists);
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
            this.xtraTabPage1.Controls.Add(this.txtIBAN);
            this.xtraTabPage1.Controls.Add(this.lblIBAN);
            this.xtraTabPage1.Controls.Add(this.txtAccountNumber);
            this.xtraTabPage1.Controls.Add(this.lblAccountNumber);
            this.xtraTabPage1.Controls.Add(this.txtAccountName);
            this.xtraTabPage1.Controls.Add(this.lblAccountName);
            this.xtraTabPage1.Controls.Add(this.btnClean);
            this.xtraTabPage1.Controls.Add(this.btnSearch);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(227, 523);
            this.xtraTabPage1.Text = "Search";
            // 
            // txtIBAN
            // 
            this.txtIBAN.EnterMoveNextControl = true;
            this.txtIBAN.Location = new System.Drawing.Point(14, 162);
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtIBAN.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtIBAN.Properties.MaxLength = 50;
            this.txtIBAN.Size = new System.Drawing.Size(181, 20);
            this.txtIBAN.TabIndex = 7;
            // 
            // lblIBAN
            // 
            this.lblIBAN.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblIBAN.Appearance.Options.UseForeColor = true;
            this.lblIBAN.Location = new System.Drawing.Point(14, 143);
            this.lblIBAN.Name = "lblIBAN";
            this.lblIBAN.Size = new System.Drawing.Size(24, 13);
            this.lblIBAN.TabIndex = 6;
            this.lblIBAN.Text = "IBAN";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.EnterMoveNextControl = true;
            this.txtAccountNumber.Location = new System.Drawing.Point(14, 116);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtAccountNumber.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAccountNumber.Properties.MaxLength = 50;
            this.txtAccountNumber.Size = new System.Drawing.Size(181, 20);
            this.txtAccountNumber.TabIndex = 5;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblAccountNumber.Appearance.Options.UseForeColor = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(13, 97);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(79, 13);
            this.lblAccountNumber.TabIndex = 4;
            this.lblAccountNumber.Text = "Account Number";
            // 
            // txtAccountName
            // 
            this.txtAccountName.EnterMoveNextControl = true;
            this.txtAccountName.Location = new System.Drawing.Point(14, 70);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtAccountName.Properties.Appearance.Options.UseBackColor = true;
            this.txtAccountName.Properties.Appearance.Options.UseTextOptions = true;
            this.txtAccountName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtAccountName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtAccountName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAccountName.Properties.MaxLength = 20;
            this.txtAccountName.Size = new System.Drawing.Size(181, 20);
            this.txtAccountName.TabIndex = 3;
            // 
            // lblAccountName
            // 
            this.lblAccountName.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblAccountName.Appearance.Options.UseForeColor = true;
            this.lblAccountName.Location = new System.Drawing.Point(14, 51);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(69, 13);
            this.lblAccountName.TabIndex = 2;
            this.lblAccountName.Text = "Account Name";
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
            // gridControlBankLists
            // 
            this.gridControlBankLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlBankLists.Location = new System.Drawing.Point(0, 0);
            this.gridControlBankLists.MainView = this.gridViewBankLists;
            this.gridControlBankLists.Name = "gridControlBankLists";
            this.gridControlBankLists.Size = new System.Drawing.Size(1244, 548);
            this.gridControlBankLists.TabIndex = 0;
            this.gridControlBankLists.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBankLists});
            // 
            // gridViewBankLists
            // 
            this.gridViewBankLists.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewBankLists.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewBankLists.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewBankLists.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewBankLists.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewBankLists.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewBankLists.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewBankLists.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBankLists.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewBankLists.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewBankLists.GridControl = this.gridControlBankLists;
            this.gridViewBankLists.Name = "gridViewBankLists";
            this.gridViewBankLists.OptionsMenu.EnableColumnMenu = false;
            this.gridViewBankLists.OptionsMenu.EnableFooterMenu = false;
            this.gridViewBankLists.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewBankLists.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewBankLists.OptionsPrint.AutoWidth = false;
            this.gridViewBankLists.OptionsPrint.PrintFooter = false;
            this.gridViewBankLists.OptionsPrint.PrintGroupFooter = false;
            this.gridViewBankLists.OptionsView.ColumnAutoWidth = false;
            this.gridViewBankLists.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewBankLists.OptionsView.RowAutoHeight = true;
            this.gridViewBankLists.OptionsView.ShowAutoFilterRow = true;
            this.gridViewBankLists.OptionsView.ShowGroupPanel = false;
            this.gridViewBankLists.OptionsView.ShowViewCaption = true;
            this.gridViewBankLists.ViewCaption = "Banks";
            // 
            // BankListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 568);
            this.Controls.Add(this.splitContainerControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BankListsForm.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BankListsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bank Lists";
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
            ((System.ComponentModel.ISupportInitialize)(this.txtIBAN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBankLists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBankLists)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlStocks;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private UserControls.Controls.MyTextEdit txtIBAN;
        private DevExpress.XtraEditors.LabelControl lblIBAN;
        private UserControls.Controls.MyTextEdit txtAccountNumber;
        private DevExpress.XtraEditors.LabelControl lblAccountNumber;
        private UserControls.Controls.MyPrivateCodeTextEdit txtAccountName;
        private DevExpress.XtraEditors.LabelControl lblAccountName;
        private UserControls.Controls.MySimpleButton btnClean;
        private UserControls.Controls.MySimpleButton btnSearch;
        private UserControls.Grids.MyGridControl gridControlBankLists;
        private UserControls.Grids.MyGridView gridViewBankLists;
    }
}