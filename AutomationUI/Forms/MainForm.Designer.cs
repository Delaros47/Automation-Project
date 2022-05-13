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
            this.barBtnBankCard = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnMoneyTransfers = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnBankLists = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnBankTransactions = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnBankMovements = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCashCard = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCashLists = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCashPeriods = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCashReceipts = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageStocks = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupStocks = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageCustomers = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupCustomers = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageBanks = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupBanks = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageCash = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupCash = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
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
            this.barBtnCustomerMovements,
            this.barBtnBankCard,
            this.barBtnMoneyTransfers,
            this.barBtnBankLists,
            this.barBtnBankTransactions,
            this.barBtnBankMovements,
            this.barBtnCashCard,
            this.barBtnCashLists,
            this.barBtnCashPeriods,
            this.barBtnCashReceipts});
            this.ribbonControlAutomation.Location = new System.Drawing.Point(0, 0);
            this.ribbonControlAutomation.MaxItemId = 23;
            this.ribbonControlAutomation.Name = "ribbonControlAutomation";
            this.ribbonControlAutomation.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageStocks,
            this.ribbonPageCustomers,
            this.ribbonPageBanks,
            this.ribbonPageCash,
            this.ribbonPage1});
            this.ribbonControlAutomation.Size = new System.Drawing.Size(1498, 177);
            // 
            // barBtnStockCard
            // 
            this.barBtnStockCard.Caption = "Stock Card";
            this.barBtnStockCard.Id = 1;
            this.barBtnStockCard.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnStockCard.ImageOptions.LargeImage")));
            this.barBtnStockCard.LargeWidth = 100;
            this.barBtnStockCard.Name = "barBtnStockCard";
            // 
            // barBtnStockLists
            // 
            this.barBtnStockLists.Caption = "Stock Lists";
            this.barBtnStockLists.Id = 2;
            this.barBtnStockLists.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnStockLists.ImageOptions.LargeImage")));
            this.barBtnStockLists.LargeWidth = 100;
            this.barBtnStockLists.Name = "barBtnStockLists";
            // 
            // barBtnStockGroups
            // 
            this.barBtnStockGroups.Caption = "Stock Groups";
            this.barBtnStockGroups.Id = 3;
            this.barBtnStockGroups.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnStockGroups.ImageOptions.LargeImage")));
            this.barBtnStockGroups.LargeWidth = 100;
            this.barBtnStockGroups.Name = "barBtnStockGroups";
            // 
            // barBtnStockMovements
            // 
            this.barBtnStockMovements.Caption = "Stock Movements";
            this.barBtnStockMovements.Id = 4;
            this.barBtnStockMovements.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnStockMovements.ImageOptions.LargeImage")));
            this.barBtnStockMovements.LargeWidth = 100;
            this.barBtnStockMovements.Name = "barBtnStockMovements";
            // 
            // barBtnCustomerCard
            // 
            this.barBtnCustomerCard.Caption = "Customer Card";
            this.barBtnCustomerCard.Id = 5;
            this.barBtnCustomerCard.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnCustomerCard.ImageOptions.LargeImage")));
            this.barBtnCustomerCard.LargeWidth = 100;
            this.barBtnCustomerCard.Name = "barBtnCustomerCard";
            // 
            // barBtnCustomerGroups
            // 
            this.barBtnCustomerGroups.Caption = "Customer Groups";
            this.barBtnCustomerGroups.Id = 6;
            this.barBtnCustomerGroups.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnCustomerGroups.ImageOptions.LargeImage")));
            this.barBtnCustomerGroups.LargeWidth = 100;
            this.barBtnCustomerGroups.Name = "barBtnCustomerGroups";
            // 
            // barBtnCustomerLists
            // 
            this.barBtnCustomerLists.Caption = "Customer Lists";
            this.barBtnCustomerLists.Id = 7;
            this.barBtnCustomerLists.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnCustomerLists.ImageOptions.LargeImage")));
            this.barBtnCustomerLists.LargeWidth = 100;
            this.barBtnCustomerLists.Name = "barBtnCustomerLists";
            // 
            // barBtnCustomerMovements
            // 
            this.barBtnCustomerMovements.Caption = "Customer Movements";
            this.barBtnCustomerMovements.Id = 8;
            this.barBtnCustomerMovements.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnCustomerMovements.ImageOptions.LargeImage")));
            this.barBtnCustomerMovements.LargeWidth = 100;
            this.barBtnCustomerMovements.Name = "barBtnCustomerMovements";
            // 
            // barBtnBankCard
            // 
            this.barBtnBankCard.Caption = "Bank Card";
            this.barBtnBankCard.Id = 14;
            this.barBtnBankCard.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnBankCard.ImageOptions.LargeImage")));
            this.barBtnBankCard.LargeWidth = 100;
            this.barBtnBankCard.Name = "barBtnBankCard";
            // 
            // barBtnMoneyTransfers
            // 
            this.barBtnMoneyTransfers.Caption = "Money Transfers";
            this.barBtnMoneyTransfers.Id = 15;
            this.barBtnMoneyTransfers.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnMoneyTransfers.ImageOptions.LargeImage")));
            this.barBtnMoneyTransfers.LargeWidth = 100;
            this.barBtnMoneyTransfers.Name = "barBtnMoneyTransfers";
            // 
            // barBtnBankLists
            // 
            this.barBtnBankLists.Caption = "Bank Lists";
            this.barBtnBankLists.Id = 16;
            this.barBtnBankLists.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnBankLists.ImageOptions.LargeImage")));
            this.barBtnBankLists.LargeWidth = 100;
            this.barBtnBankLists.Name = "barBtnBankLists";
            // 
            // barBtnBankTransactions
            // 
            this.barBtnBankTransactions.Caption = "Bank Transactions";
            this.barBtnBankTransactions.Id = 17;
            this.barBtnBankTransactions.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnBankTransactions.ImageOptions.LargeImage")));
            this.barBtnBankTransactions.LargeWidth = 100;
            this.barBtnBankTransactions.Name = "barBtnBankTransactions";
            // 
            // barBtnBankMovements
            // 
            this.barBtnBankMovements.Caption = "Bank Movements";
            this.barBtnBankMovements.Id = 18;
            this.barBtnBankMovements.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnBankMovements.ImageOptions.LargeImage")));
            this.barBtnBankMovements.LargeWidth = 100;
            this.barBtnBankMovements.Name = "barBtnBankMovements";
            // 
            // barBtnCashCard
            // 
            this.barBtnCashCard.Caption = "Cash Card";
            this.barBtnCashCard.Id = 19;
            this.barBtnCashCard.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnCashCard.ImageOptions.LargeImage")));
            this.barBtnCashCard.LargeWidth = 100;
            this.barBtnCashCard.Name = "barBtnCashCard";
            // 
            // barBtnCashLists
            // 
            this.barBtnCashLists.Caption = "Cash Lists";
            this.barBtnCashLists.Id = 20;
            this.barBtnCashLists.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnCashLists.ImageOptions.LargeImage")));
            this.barBtnCashLists.LargeWidth = 100;
            this.barBtnCashLists.Name = "barBtnCashLists";
            // 
            // barBtnCashPeriods
            // 
            this.barBtnCashPeriods.Caption = "Cash Periods";
            this.barBtnCashPeriods.Id = 21;
            this.barBtnCashPeriods.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnCashPeriod.ImageOptions.SvgImage")));
            this.barBtnCashPeriods.LargeWidth = 100;
            this.barBtnCashPeriods.Name = "barBtnCashPeriods";
            // 
            // barBtnCashReceipts
            // 
            this.barBtnCashReceipts.Caption = "Cash Receipts";
            this.barBtnCashReceipts.Id = 22;
            this.barBtnCashReceipts.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnCashReceipts.ImageOptions.LargeImage")));
            this.barBtnCashReceipts.LargeWidth = 100;
            this.barBtnCashReceipts.Name = "barBtnCashReceipts";
            // 
            // ribbonPageStocks
            // 
            this.ribbonPageStocks.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupStocks});
            this.ribbonPageStocks.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageStocks.ImageOptions.Image")));
            this.ribbonPageStocks.Name = "ribbonPageStocks";
            this.ribbonPageStocks.Text = "Stocks";
            // 
            // ribbonPageGroupStocks
            // 
            this.ribbonPageGroupStocks.ItemLinks.Add(this.barBtnStockCard);
            this.ribbonPageGroupStocks.ItemLinks.Add(this.barBtnStockLists);
            this.ribbonPageGroupStocks.ItemLinks.Add(this.barBtnStockGroups);
            this.ribbonPageGroupStocks.ItemLinks.Add(this.barBtnStockMovements);
            this.ribbonPageGroupStocks.Name = "ribbonPageGroupStocks";
            this.ribbonPageGroupStocks.Text = "Stock Transactions";
            // 
            // ribbonPageCustomers
            // 
            this.ribbonPageCustomers.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupCustomers});
            this.ribbonPageCustomers.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPageCustomers.ImageOptions.SvgImage")));
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
            // ribbonPageBanks
            // 
            this.ribbonPageBanks.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupBanks});
            this.ribbonPageBanks.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageBanks.ImageOptions.Image")));
            this.ribbonPageBanks.Name = "ribbonPageBanks";
            this.ribbonPageBanks.Text = "Banks";
            // 
            // ribbonPageGroupBanks
            // 
            this.ribbonPageGroupBanks.ItemLinks.Add(this.barBtnBankCard);
            this.ribbonPageGroupBanks.ItemLinks.Add(this.barBtnMoneyTransfers);
            this.ribbonPageGroupBanks.ItemLinks.Add(this.barBtnBankLists);
            this.ribbonPageGroupBanks.ItemLinks.Add(this.barBtnBankTransactions);
            this.ribbonPageGroupBanks.ItemLinks.Add(this.barBtnBankMovements);
            this.ribbonPageGroupBanks.Name = "ribbonPageGroupBanks";
            this.ribbonPageGroupBanks.Text = "Bank Transections";
            // 
            // ribbonPageCash
            // 
            this.ribbonPageCash.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupCash});
            this.ribbonPageCash.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageCash.ImageOptions.Image")));
            this.ribbonPageCash.Name = "ribbonPageCash";
            this.ribbonPageCash.Text = "Cash";
            // 
            // ribbonPageGroupCash
            // 
            this.ribbonPageGroupCash.ItemLinks.Add(this.barBtnCashCard);
            this.ribbonPageGroupCash.ItemLinks.Add(this.barBtnCashLists);
            this.ribbonPageGroupCash.ItemLinks.Add(this.barBtnCashPeriods);
            this.ribbonPageGroupCash.ItemLinks.Add(this.barBtnCashReceipts);
            this.ribbonPageGroupCash.Name = "ribbonPageGroupCash";
            this.ribbonPageGroupCash.Text = "Cash Transactions";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
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
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupStocks;
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
        private DevExpress.XtraBars.BarButtonItem barBtnBankCard;
        private DevExpress.XtraBars.BarButtonItem barBtnMoneyTransfers;
        private DevExpress.XtraBars.BarButtonItem barBtnBankLists;
        private DevExpress.XtraBars.BarButtonItem barBtnBankTransactions;
        private DevExpress.XtraBars.BarButtonItem barBtnBankMovements;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageBanks;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupBanks;
        private DevExpress.XtraBars.BarButtonItem barBtnCashCard;
        private DevExpress.XtraBars.BarButtonItem barBtnCashLists;
        private DevExpress.XtraBars.BarButtonItem barBtnCashPeriods;
        private DevExpress.XtraBars.BarButtonItem barBtnCashReceipts;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageCash;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupCash;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}