﻿namespace AutomationUI.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnStockCard = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnStockLists = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnStockGroups = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnStockMovements = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barBtnStockCard,
            this.barBtnStockLists,
            this.barBtnStockGroups,
            this.barBtnStockMovements});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(924, 158);
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
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Stock";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 742);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Automation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barBtnStockCard;
        private DevExpress.XtraBars.BarButtonItem barBtnStockLists;
        private DevExpress.XtraBars.BarButtonItem barBtnStockGroups;
        private DevExpress.XtraBars.BarButtonItem barBtnStockMovements;
    }
}