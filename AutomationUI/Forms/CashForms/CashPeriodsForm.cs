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
        private int CashId = -1;
        private readonly ICashMovementService _cashMovementService;
        public CashPeriodsForm()
        {
            InitializeComponent();
            _cashMovementService = InstanceFactory.GetInstance<ICashMovementService>();
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

    }
}