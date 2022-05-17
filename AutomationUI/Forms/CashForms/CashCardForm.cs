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
    public partial class CashCardForm : DevExpress.XtraEditors.XtraForm
    {
        private int CashId = -1;
        private readonly ICashService _cashService;
        public CashCardForm()
        {
            InitializeComponent();
            _cashService = InstanceFactory.GetInstance<ICashService>();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var result = _cashService.Add(new Cash
            {
                CashCode = txtCashCode.Text,
                CashName = txtCashName.Text,
                Description = memoDescription.Text,
                CashSaveDate = DateTime.Now,
                CashSaveUser = MainForm.UserId,
            });
            if (result.Success)
            {
                MyMessageBox.Add(result.Message);
                CleanAll();
                GetAllCash();
            }
        }

        private void CleanAll()
        {
            txtCashCode.Text = "";
            txtCashName.Text = "";
            memoDescription.Text = "";
        }

        private void GetAllCash()
        {
            gridControlCashs.DataSource = _cashService.GetAll().Data;
        }


        private void CashCardForm_Load(object sender, EventArgs e)
        {
            GetAllCash();
        }

        private void gridViewCashs_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle > -1)
            {
                txtCashCode.Text = gridViewCashs.GetFocusedRowCellValue("CashCode").ToString();
                txtCashName.Text = gridViewCashs.GetFocusedRowCellValue("CashName").ToString();
                memoDescription.Text = gridViewCashs.GetFocusedRowCellValue("Description").ToString();
                CashId = Convert.ToInt32(gridViewCashs.GetFocusedRowCellValue("Id").ToString());

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var result = _cashService.Update(new Cash
            {
                Id = CashId,
                CashCode = txtCashCode.Text,
                CashName = txtCashName.Text,
                Description = memoDescription.Text,
                CashSaveDate = DateTime.Now,
                CashSaveUser = MainForm.UserId,
            });
            if (result.Success)
            {
                MyMessageBox.Update(result.Message);
                CleanAll();
                GetAllCash();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = _cashService.Delete(new Cash
            {
                Id = CashId,

            });
            if (result.Success)
            {
                MyMessageBox.Delete(result.Message);
                CleanAll();
                GetAllCash();
            }
        }
    }
}