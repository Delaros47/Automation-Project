using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomationUI.Forms.StockForms;
using DevExpress.XtraBars;

namespace AutomationUI.Forms
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static int UserId = -1;
        public static int TransferId = -1;

        public MainForm()
        {
            InitializeComponent();
            EventLoads();
        }

        private void EventLoads()
        {
            foreach (var item in ribbonControlAutomation.Items)
            {
                switch (item)
                {
                    case BarButtonItem btn:
                        btn.ItemClick += Btn_ItemClick;
                        break;
                }
            }
        }

        public void Btn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item == barBtnStockLists)
            {
                StockListsForm stockLists = new StockListsForm();
                stockLists.MdiParent = ActiveForm;
                stockLists.Show();
            }
            else if (e.Item == barBtnStockCard)
            {
                StockCardForm stockCard = new StockCardForm();
                stockCard.ShowDialog();
            }else if (e.Item==barBtnStockGroups)
            {
                StockGroupsForm stockGroups = new StockGroupsForm();
                stockGroups.ShowDialog();
            }else if (e.Item==barBtnStockMovements)
            {
                StockMovementsForm stockMovements = new StockMovementsForm();
                stockMovements.ShowDialog();
            }
        }
    }
}