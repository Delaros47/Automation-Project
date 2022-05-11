namespace AutomationUI.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControlAutomation = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnStockCard = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnStockLists = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnStockGroups = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnStockMovements = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCustomerCard = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCustomerGroups = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCustomerLists = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCustomerMovements = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageStocks = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageCustomers = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupCustomers = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAutomation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControlAutomation
            // 
            this.ribbonControlAutomation.ExpandCollapseItem.Id = 0;
            this.ribbonControlAutomation.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControlAutomation.ExpandCollapseItem,
            this.ribbonControlAutomation.SearchEditItem,
            this.barBtnStockCard,
            this.barBtnStockLists,
            this.barBtnStockGroups,
            this.barBtnStockMovements,
            this.barBtnCustomerCard,
            this.barBtnCustomerGroups,
            this.barBtnCustomerLists,
            this.barBtnCustomerMovements});
            this.ribbonControlAutomation.Location = new System.Drawing.Point(0, 0);
            this.ribbonControlAutomation.MaxItemId = 9;
            this.ribbonControlAutomation.Name = "ribbonControlAutomation";
            this.ribbonControlAutomation.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageStocks,
            this.ribbonPageCustomers});
            this.ribbonControlAutomation.Size = new System.Drawing.Size(1498, 158);
            // 
            // barBtnStockCard
            // 
            this.barBtnStockCard.Caption = "Stock Card";
            this.barBtnStockCard.Id = 1;
            this.barBtnStockCard.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnStockCard.ImageOptions.LargeImage")));
            this.barBtnStockCard.Name = "barBtnStockCard";
            // 
            // barBtnStockLists
            // 
            this.barBtnStockLists.Caption = "Stock Lists";
            this.barBtnStockLists.Id = 2;
            this.barBtnStockLists.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnStockLists.ImageOptions.LargeImage")));
            this.barBtnStockLists.Name = "barBtnStockLists";
            // 
            // barBtnStockGroups
            // 
            this.barBtnStockGroups.Caption = "Stock Groups";
            this.barBtnStockGroups.Id = 3;
            this.barBtnStockGroups.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnStockGroups.ImageOptions.LargeImage")));
            this.barBtnStockGroups.Name = "barBtnStockGroups";
            // 
            // barBtnStockMovements
            // 
            this.barBtnStockMovements.Caption = "Stock Movements";
            this.barBtnStockMovements.Id = 4;
            this.barBtnStockMovements.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnStockMovements.ImageOptions.LargeImage")));
            this.barBtnStockMovements.Name = "barBtnStockMovements";
            // 
            // barBtnCustomerCard
            // 
            this.barBtnCustomerCard.Caption = "Customer Card";
            this.barBtnCustomerCard.Id = 5;
            this.barBtnCustomerCard.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnCustomerCard.ImageOptions.LargeImage")));
            this.barBtnCustomerCard.Name = "barBtnCustomerCard";
            // 
            // barBtnCustomerGroups
            // 
            this.barBtnCustomerGroups.Caption = "Customer Groups";
            this.barBtnCustomerGroups.Id = 6;
            this.barBtnCustomerGroups.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnCustomerGroups.ImageOptions.LargeImage")));
            this.barBtnCustomerGroups.Name = "barBtnCustomerGroups";
            // 
            // barBtnCustomerLists
            // 
            this.barBtnCustomerLists.Caption = "Customer Lists";
            this.barBtnCustomerLists.Id = 7;
            this.barBtnCustomerLists.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnCustomerLists.ImageOptions.LargeImage")));
            this.barBtnCustomerLists.Name = "barBtnCustomerLists";
            // 
            // barBtnCustomerMovements
            // 
            this.barBtnCustomerMovements.Caption = "Customer Movements";
            this.barBtnCustomerMovements.Id = 8;
            this.barBtnCustomerMovements.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnCustomerMovements.ImageOptions.LargeImage")));
            this.barBtnCustomerMovements.Name = "barBtnCustomerMovements";
            // 
            // ribbonPageStocks
            // 
            this.ribbonPageStocks.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPageStocks.Name = "ribbonPageStocks";
            this.ribbonPageStocks.Text = "Stocks";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnStockCard);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnStockLists);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnStockGroups);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnStockMovements);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Stock Transections";
            // 
            // ribbonPageCustomers
            // 
            this.ribbonPageCustomers.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupCustomers});
            this.ribbonPageCustomers.Name = "ribbonPageCustomers";
            this.ribbonPageCustomers.Text = "Customers";
            // 
            // ribbonPageGroupCustomers
            // 
            this.ribbonPageGroupCustomers.ItemLinks.Add(this.barBtnCustomerCard);
            this.ribbonPageGroupCustomers.ItemLinks.Add(this.barBtnCustomerGroups);
            this.ribbonPageGroupCustomers.ItemLinks.Add(this.barBtnCustomerLists);
            this.ribbonPageGroupCustomers.ItemLinks.Add(this.barBtnCustomerMovements);
            this.ribbonPageGroupCustomers.Name = "ribbonPageGroupCustomers";
            this.ribbonPageGroupCustomers.Text = "Customer Process";
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.MdiParent = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 799);
            this.Controls.Add(this.ribbonControlAutomation);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControlAutomation;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automation";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAutomation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageStocks;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barBtnStockCard;
        private DevExpress.XtraBars.BarButtonItem barBtnStockLists;
        private DevExpress.XtraBars.BarButtonItem barBtnStockGroups;
        private DevExpress.XtraBars.BarButtonItem barBtnStockMovements;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        public DevExpress.XtraBars.Ribbon.RibbonControl ribbonControlAutomation;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageCustomers;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupCustomers;
        private DevExpress.XtraBars.BarButtonItem barBtnCustomerCard;
        private DevExpress.XtraBars.BarButtonItem barBtnCustomerGroups;
        private DevExpress.XtraBars.BarButtonItem barBtnCustomerLists;
        private DevExpress.XtraBars.BarButtonItem barBtnCustomerMovements;
    }
}