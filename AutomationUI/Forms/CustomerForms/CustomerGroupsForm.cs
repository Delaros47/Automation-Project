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

namespace AutomationUI.Forms.CustomerForms
{
    public partial class CustomerGroupsForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly ICustomerGroupService _customerGroupService;
        public static int CustomerGroupId = -1;
        public CustomerGroupsForm()
        {
            InitializeComponent();
            _customerGroupService = InstanceFactory.GetInstance<ICustomerGroupService>();
        }

        private void CustomerGroupsForm_Load(object sender, EventArgs e)
        {
            GetAllCustomerGroups();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetAllCustomerGroups()
        {
            gridControlCustomerGroups.DataSource = _customerGroupService.GetAll().Data;
        }

        private void CleanAll()
        {
            txtGroupCode.Text = "";
            txtGroupName.Text = "";
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            var result = _customerGroupService.Add(new CustomerGroup
            {
                GroupName = txtGroupName.Text,
                GroupCode = txtGroupCode.Text,
                GroupSaveDate = DateTime.Now,
                GroupSaveUser = MainForm.UserId
            });

            if (result.Success)
            {
                MyMessageBox.Add(result.Message);
                GetAllCustomerGroups();
                CleanAll();
            }


        }

        private void gridViewCustomerGroups_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle > -1)
            {
                txtGroupCode.Text = gridViewCustomerGroups.GetFocusedRowCellValue("GroupCode").ToString();
                txtGroupName.Text = gridViewCustomerGroups.GetFocusedRowCellValue("GroupName").ToString();
                CustomerGroupId = Convert.ToInt32(gridViewCustomerGroups.GetFocusedRowCellValue("Id").ToString());
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var result = _customerGroupService.Update(new CustomerGroup
            {
                Id = CustomerGroupId,
                GroupName = txtGroupName.Text,
                GroupCode = txtGroupCode.Text,
                GroupEditDate = DateTime.Now,
                GroupEditUser = MainForm.UserId
            });

            if (result.Success)
            {
                MyMessageBox.Add(result.Message);
                GetAllCustomerGroups();
                CleanAll();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = _customerGroupService.Delete(new CustomerGroup
            {
                Id = CustomerGroupId,
            });

            if (result.Success)
            {
                MyMessageBox.Add(result.Message);
                GetAllCustomerGroups();
                CleanAll();
            }
        }

        private void gridViewCustomerGroups_DoubleClick(object sender, EventArgs e)
        {
            CustomerCardForm.CustomerGroupId = CustomerGroupId;
            this.Close();
        }
    }
}