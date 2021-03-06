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
using AutomationUI.Forms.BankForms;
using AutomationUI.Forms.CashForms;
using AutomationUI.Forms.CustomerForms;
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
            }
            else if (e.Item == barBtnStockGroups)
            {
                StockGroupsForm stockGroups = new StockGroupsForm();
                stockGroups.ShowDialog();
            }
            else if (e.Item == barBtnStockMovements)
            {
                StockMovementsForm stockMovements = new StockMovementsForm();
                stockMovements.ShowDialog();
            }
            else if (e.Item == barBtnCustomerGroups)
            {
                CustomerGroupsForm customerGroupsForm = new CustomerGroupsForm();
                customerGroupsForm.ShowDialog();
            }
            else if (e.Item == barBtnCustomerCard)
            {
                CustomerCardForm customerCardForm = new CustomerCardForm();
                customerCardForm.ShowDialog();
            }
            else if (e.Item == barBtnCustomerLists)
            {
                CustomerListsForm customerListsForm = new CustomerListsForm();
                customerListsForm.MdiParent = ActiveForm;
                customerListsForm.Show();
            }else if (e.Item==barBtnBankCard)
            {
                BankCardForm bankCardForm = new BankCardForm();
                bankCardForm.ShowDialog();
            }else if (e.Item==barBtnBankMovements)
            {
                BankMovementsForm bankMovementsForm = new BankMovementsForm();
                bankMovementsForm.ShowDialog();
            }else if (e.Item==barBtnBankTransactions)
            {
                BankTransactionsForm bankTransactionsForm = new BankTransactionsForm();
                bankTransactionsForm.ShowDialog();
            }else if (e.Item==barBtnBankLists)
            {
                BankListsForm bankListsForm = new BankListsForm();
                bankListsForm.MdiParent = ActiveForm;
                bankListsForm.Show();
            }else if (e.Item==barBtnMoneyTransfers)
            {
                MoneyTransfersForm moneyTransfersForm = new MoneyTransfersForm();
                moneyTransfersForm.ShowDialog();
            }else if (e.Item==barBtnCashPeriods)
            {
                CashPeriodsForm cashPeriodsForm = new CashPeriodsForm();
                cashPeriodsForm.ShowDialog();
            }else if (e.Item==barBtnCashCard)
            {
                CashCardForm cashCardForm = new CashCardForm();
                cashCardForm.ShowDialog();
            }else if (e.Item==barBtnCashLists)
            {
                CashListsForm cashListsForm = new CashListsForm();
                cashListsForm.MdiParent = ActiveForm;
                cashListsForm.Show();
            }else if (e.Item==barBtnCashReceipts)
            {
                CashReceiptsForm cashReceiptsForm = new CashReceiptsForm();
                cashReceiptsForm.ShowDialog();
            }
            
        }
    }
}