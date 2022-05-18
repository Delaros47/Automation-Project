namespace AutomationUI.Forms.InvoiceForms
{
    partial class InvoiceListsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceListsForm));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControlStocks = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.deDate = new AutomationUI.UserControls.Controls.MyDateEdit();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.myPrivateCodeTextEdit1 = new AutomationUI.UserControls.Controls.MyPrivateCodeTextEdit();
            this.cmbInvoiceTypes = new AutomationUI.UserControls.Controls.MyComboBoxEdit();
            this.lblInvoiceNumber = new DevExpress.XtraEditors.LabelControl();
            this.lblInvoiceType = new DevExpress.XtraEditors.LabelControl();
            this.btnClean = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.btnSearch = new AutomationUI.UserControls.Controls.MySimpleButton();
            this.gridControlInvoiceLists = new AutomationUI.UserControls.Grids.MyGridControl();
            this.gridViewInvoiceLists = new AutomationUI.UserControls.Grids.MyGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlStocks)).BeginInit();
            this.xtraTabControlStocks.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPrivateCodeTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInvoiceTypes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInvoiceLists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInvoiceLists)).BeginInit();
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
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControlInvoiceLists);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1483, 548);
            this.splitContainerControl1.SplitterPosition = 229;
            this.splitContainerControl1.TabIndex = 3;
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
            this.xtraTabPage1.Controls.Add(this.deDate);
            this.xtraTabPage1.Controls.Add(this.lblDate);
            this.xtraTabPage1.Controls.Add(this.myPrivateCodeTextEdit1);
            this.xtraTabPage1.Controls.Add(this.cmbInvoiceTypes);
            this.xtraTabPage1.Controls.Add(this.lblInvoiceNumber);
            this.xtraTabPage1.Controls.Add(this.lblInvoiceType);
            this.xtraTabPage1.Controls.Add(this.btnClean);
            this.xtraTabPage1.Controls.Add(this.btnSearch);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(227, 523);
            this.xtraTabPage1.Text = "Search";
            // 
            // deDate
            // 
            this.deDate.EditValue = null;
            this.deDate.EnterMoveNextControl = true;
            this.deDate.Location = new System.Drawing.Point(13, 161);
            this.deDate.Name = "deDate";
            this.deDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.deDate.Properties.Appearance.Options.UseTextOptions = true;
            this.deDate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.deDate.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.deDate.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.deDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDate.Size = new System.Drawing.Size(181, 20);
            this.deDate.TabIndex = 9;
            // 
            // lblDate
            // 
            this.lblDate.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblDate.Appearance.Options.UseForeColor = true;
            this.lblDate.Location = new System.Drawing.Point(13, 142);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(23, 13);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Date";
            // 
            // myPrivateCodeTextEdit1
            // 
            this.myPrivateCodeTextEdit1.EnterMoveNextControl = true;
            this.myPrivateCodeTextEdit1.Location = new System.Drawing.Point(13, 116);
            this.myPrivateCodeTextEdit1.Name = "myPrivateCodeTextEdit1";
            this.myPrivateCodeTextEdit1.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.myPrivateCodeTextEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.myPrivateCodeTextEdit1.Properties.Appearance.Options.UseTextOptions = true;
            this.myPrivateCodeTextEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.myPrivateCodeTextEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.myPrivateCodeTextEdit1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.myPrivateCodeTextEdit1.Properties.MaxLength = 20;
            this.myPrivateCodeTextEdit1.Size = new System.Drawing.Size(183, 20);
            this.myPrivateCodeTextEdit1.TabIndex = 7;
            // 
            // cmbInvoiceTypes
            // 
            this.cmbInvoiceTypes.EnterMoveNextControl = true;
            this.cmbInvoiceTypes.Location = new System.Drawing.Point(13, 71);
            this.cmbInvoiceTypes.Name = "cmbInvoiceTypes";
            this.cmbInvoiceTypes.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.cmbInvoiceTypes.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.cmbInvoiceTypes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbInvoiceTypes.Properties.Items.AddRange(new object[] {
            "Sales Invoice",
            "Sales Return Invoice",
            "Purchase Invoice",
            "Purchase Return Invoice"});
            this.cmbInvoiceTypes.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbInvoiceTypes.Size = new System.Drawing.Size(181, 20);
            this.cmbInvoiceTypes.TabIndex = 6;
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblInvoiceNumber.Appearance.Options.UseForeColor = true;
            this.lblInvoiceNumber.Location = new System.Drawing.Point(13, 97);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Size = new System.Drawing.Size(75, 13);
            this.lblInvoiceNumber.TabIndex = 4;
            this.lblInvoiceNumber.Text = "Invoice Number";
            // 
            // lblInvoiceType
            // 
            this.lblInvoiceType.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblInvoiceType.Appearance.Options.UseForeColor = true;
            this.lblInvoiceType.Location = new System.Drawing.Point(14, 51);
            this.lblInvoiceType.Name = "lblInvoiceType";
            this.lblInvoiceType.Size = new System.Drawing.Size(62, 13);
            this.lblInvoiceType.TabIndex = 2;
            this.lblInvoiceType.Text = "Invoice Type";
            // 
            // btnClean
            // 
            this.btnClean.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnClean.Appearance.Options.UseForeColor = true;
            this.btnClean.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClean.ImageOptions.Image")));
            this.btnClean.Location = new System.Drawing.Point(114, 217);
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
            this.btnSearch.Location = new System.Drawing.Point(15, 217);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 48);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            // 
            // gridControlInvoiceLists
            // 
            this.gridControlInvoiceLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlInvoiceLists.Location = new System.Drawing.Point(0, 0);
            this.gridControlInvoiceLists.MainView = this.gridViewInvoiceLists;
            this.gridControlInvoiceLists.Name = "gridControlInvoiceLists";
            this.gridControlInvoiceLists.Size = new System.Drawing.Size(1244, 548);
            this.gridControlInvoiceLists.TabIndex = 0;
            this.gridControlInvoiceLists.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewInvoiceLists});
            // 
            // gridViewInvoiceLists
            // 
            this.gridViewInvoiceLists.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewInvoiceLists.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewInvoiceLists.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewInvoiceLists.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewInvoiceLists.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewInvoiceLists.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewInvoiceLists.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewInvoiceLists.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewInvoiceLists.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewInvoiceLists.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewInvoiceLists.GridControl = this.gridControlInvoiceLists;
            this.gridViewInvoiceLists.Name = "gridViewInvoiceLists";
            this.gridViewInvoiceLists.OptionsMenu.EnableColumnMenu = false;
            this.gridViewInvoiceLists.OptionsMenu.EnableFooterMenu = false;
            this.gridViewInvoiceLists.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewInvoiceLists.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewInvoiceLists.OptionsPrint.AutoWidth = false;
            this.gridViewInvoiceLists.OptionsPrint.PrintFooter = false;
            this.gridViewInvoiceLists.OptionsPrint.PrintGroupFooter = false;
            this.gridViewInvoiceLists.OptionsView.ColumnAutoWidth = false;
            this.gridViewInvoiceLists.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewInvoiceLists.OptionsView.RowAutoHeight = true;
            this.gridViewInvoiceLists.OptionsView.ShowAutoFilterRow = true;
            this.gridViewInvoiceLists.OptionsView.ShowGroupPanel = false;
            this.gridViewInvoiceLists.OptionsView.ShowViewCaption = true;
            this.gridViewInvoiceLists.ViewCaption = "Inovice Lists";
            // 
            // InvoiceListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 568);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "InvoiceListsForm";
            this.Text = "Invoice Lists";
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
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPrivateCodeTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInvoiceTypes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInvoiceLists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInvoiceLists)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlStocks;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.LabelControl lblInvoiceNumber;
        private DevExpress.XtraEditors.LabelControl lblInvoiceType;
        private UserControls.Controls.MySimpleButton btnClean;
        private UserControls.Controls.MySimpleButton btnSearch;
        private UserControls.Grids.MyGridControl gridControlInvoiceLists;
        private UserControls.Grids.MyGridView gridViewInvoiceLists;
        private UserControls.Controls.MyComboBoxEdit cmbInvoiceTypes;
        private UserControls.Controls.MyDateEdit deDate;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private UserControls.Controls.MyPrivateCodeTextEdit myPrivateCodeTextEdit1;
    }
}