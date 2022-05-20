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
using AutomationUI.Forms.CustomerForms;
using AutomationUI.Functions;
using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using Entities.Concrete;

namespace AutomationUI.Forms.CashForms
{
    public partial class CashReceiptsForm : DevExpress.XtraEditors.XtraForm
    {
        public static int CashId = -1;
        public static int CustomerID = -1;
        private readonly ICashMovementService _cashMovementService;
        private readonly ICashService _cashService;
        private readonly ICustomerService _customerService;
        public CashReceiptsForm()
        {
            InitializeComponent();
            _cashMovementService = InstanceFactory.GetInstance<ICashMovementService>();
            _cashService = InstanceFactory.GetInstance<ICashService>();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
        }

        private void CashReceiptsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCashCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            CashListsForm cashListsForm = new CashListsForm();
            cashListsForm.ShowDialog();
            if (CashId != -1)
            {
                var result = _cashService.Get(CashId);
                if (result.Success)
                {
                    txtCashName.Text = result.Data.CashName;
                    btnCashCode.Text = result.Data.CashCode;
                }
            }
        }

        private void btnCustomerCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            CustomerListsForm customerListsForm = new CustomerListsForm();
            customerListsForm.ShowDialog();
            if (CustomerID != -1)
            {
                var result = _customerService.Get(CustomerID);
                if (result.Success)
                {
                    txtCustomerName.Text = result.Data.CustomerName;
                    btnCustomerCode.Text = result.Data.CustomerCode;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string enterExitCode = "";
            if (cbmProcessType.SelectedIndex == 0)
            {
                enterExitCode = "Enter";
            }
            else
            {
                enterExitCode = "Exit";
            }
            var result = _cashMovementService.Add(new CashMovement
            {
                CustomerId = CustomerID,
                Date = Convert.ToDateTime(deDate.Text),
                Description = memoDescription.Text,
                DocumentNumber = txtDocumentNumber.Text,
                Total = Convert.ToDecimal(txtTotal.Text),
                SaveDate = DateTime.Now,
                SaveUser = MainForm.UserId,
                CashId = CashId,
                EnterExitCode = enterExitCode,
                PaperType = cbmProcessType.Text,
            });
            if (result.Success)
            {
                MyMessageBox.Add(result.Message);
                CleanAll();
            }
        }

        private void CleanAll()
        {
            txtDocumentNumber.Text = "";
            txtTotal.Text = "";
            txtCashName.Text = "";
            txtCustomerName.Text = "";
            btnCashCode.Text = "";
            btnCustomerCode.Text = "";
            deDate.Text = "";
            memoDescription.Text = "";
            cbmProcessType.SelectedIndex = -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}