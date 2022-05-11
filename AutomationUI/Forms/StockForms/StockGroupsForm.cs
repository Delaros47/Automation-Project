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
using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using Entities.Concrete;
using AutomationUI.Functions;

namespace AutomationUI.Forms.StockForms
{
    public partial class StockGroupsForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly IStockGroupService _stockGroupService;
        public StockGroupsForm()
        {
            InitializeComponent();
            _stockGroupService = InstanceFactory.GetInstance<IStockGroupService>();
        }

        private void GetAllStockGroups()
        {
            gridControlStockGroups.DataSource = _stockGroupService.GetAll().Data;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            var result = _stockGroupService.Add(new StockGroup
            {
                GroupCode = txtGroupCode.Text,
                GroupName = txtGroupName.Text,
                GroupSaveDate = DateTime.Now,
                GroupSaveUser = MainForm.UserId
            });

            if (result.Success)
            {
                MyMessageBox.Add(result.Message);
                GetAllStockGroups();
                Clean();
            }

        }

        private void Clean()
        {
            txtGroupCode.Text = "";
            txtGroupName.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var result = _stockGroupService.Update(new StockGroup
            {
                Id = Convert.ToInt32(gridViewStockGroups.GetFocusedRowCellValue("Id").ToString()),
                GroupCode = txtGroupCode.Text,
                GroupName = txtGroupName.Text,
                GroupEditDate = DateTime.Now,
                GroupEditUser = MainForm.UserId
            });
            if (result.Success)
            {
                MyMessageBox.Update(result.Message);
                GetAllStockGroups();
                Clean();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            var result = _stockGroupService.Delete(new StockGroup
            {
                Id = Convert.ToInt32(gridViewStockGroups.GetFocusedRowCellValue("Id").ToString())
            });
            if (result.Success)
            {
                MyMessageBox.Delete(result.Message);
                GetAllStockGroups();
                Clean();
            }
        }

        private void gridViewStockGroups_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle > -1)
            {
                txtGroupCode.Text = gridViewStockGroups.GetFocusedRowCellValue("GroupCode").ToString();
                txtGroupName.Text = gridViewStockGroups.GetFocusedRowCellValue("GroupName").ToString();
            }

        }

        private void gridViewStockGroups_DoubleClick(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(gridViewStockGroups.GetFocusedRowCellValue("Id").ToString());
            StockCardForm.GroupId = Convert.ToInt32(gridViewStockGroups.GetFocusedRowCellValue("Id").ToString());
            this.Close();
        }

        private void StockGroupsForm_Load(object sender, EventArgs e)
        {
            GetAllStockGroups();
        }
    }
}