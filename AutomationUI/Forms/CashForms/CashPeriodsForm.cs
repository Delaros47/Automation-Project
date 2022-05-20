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
using AutomationUI.Functions;
using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using Entities.Concrete;

namespace AutomationUI.Forms.CashForms
{
    public partial class CashPeriodsForm : DevExpress.XtraEditors.XtraForm
    {
        public static int CashId = -1;
        private readonly ICashMovementService _cashMovementService;
        private readonly ICashService _cashService;
        public CashPeriodsForm()
        {
            InitializeComponent();
            _cashMovementService = InstanceFactory.GetInstance<ICashMovementService>();
            _cashService = InstanceFactory.GetInstance<ICashService>();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            var result = _cashMovementService.Add(new CashMovement
            {
                Description = memoDescription.Text,
                DocumentNumber = btnCashCode.Text,
                CashId = CashId,
                Date = Convert.ToDateTime(deDate.Text),
                Total = Convert.ToDecimal(txtTotal.Text),
                PaperType = "Cash Period Card",
                EnterExitCode = toggleSwitchEnterTransaction.IsOn ? "Enter" : "Exit",
                SaveDate = DateTime.Now,
                SaveUser = MainForm.UserId,

            });
            if (result.Success)
            {
                MyMessageBox.Add(result.Message);
                CleanAll();
            }
        }

        private void CleanAll()
        {
            txtCashName.Text = "";
            btnDocumentNumber.Text = "";
            txtTotal.Text = "";
            btnCashCode.Text = "";
            memoDescription.Text = "";
            deDate.Text = "";
            toggleSwitchEnterTransaction.IsOn = false;
            toggleSwitchExitTransaction.IsOn = false;
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
                    btnCashCode.Text = result.Data.CashCode;
                    txtCashName.Text = result.Data.CashName;
                }
            }

        }

        private void toggleSwitchEnterTransaction_Toggled(object sender, EventArgs e)
        {
            toggleSwitchExitTransaction.IsOn = false;
        }

        private void toggleSwitchExitTransaction_Toggled(object sender, EventArgs e)
        {
            toggleSwitchEnterTransaction.IsOn = false;
        }

        private void CashPeriodsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }
    }
}