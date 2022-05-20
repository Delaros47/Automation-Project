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
using AutomationUI.Forms.CashForms;
using Business.Abstract;
using Business.DependencyResolvers.AutoFac;

namespace AutomationUI.Forms.CustomerForms
{
    public partial class CustomerListsForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly ICustomerService _customerService;
        private readonly ICustomerGroupService _customerGroupService;
        private int CustomerId = -1;
        public CustomerListsForm()
        {
            InitializeComponent();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
            _customerGroupService = InstanceFactory.GetInstance<ICustomerGroupService>();
        }

        private void CustomerListsForm_Load(object sender, EventArgs e)
        {
            GetCustomerDetailDto();
        }

        private void GetCustomerDetailDto()
        {
            gridControlCustomerLists.DataSource = _customerService.GetCustomerDetailDto().Data;
        }

        private void gridViewCustomerLists_DoubleClick(object sender, EventArgs e)
        {
            CustomerCardForm.CustomerId = Convert.ToInt32(gridViewCustomerLists.GetFocusedRowCellValue("Id").ToString());
            CustomerCardForm.CustomerGroupId = _customerGroupService.GetCustomerGroupId(gridViewCustomerLists.GetFocusedRowCellValue("GroupName").ToString()).Data;
            CashReceiptsForm.CustomerID = Convert.ToInt32(gridViewCustomerLists.GetFocusedRowCellValue("Id").ToString());
            this.Close();
        }

        private void txtCustomerCode_EditValueChanged(object sender, EventArgs e)
        {
            SearchCustomerCodeDetailDto();
        }

        private void SearchCustomerNameDetailDto()
        {
            gridControlCustomerLists.DataSource =
                _customerService.SearchCustomerNameDetailDto(txtCustomerName.Text).Data;
        }

        private void SearchCustomerCodeDetailDto()
        {
            gridControlCustomerLists.DataSource =
                _customerService.SearchCustomerCodeDetailDto(txtCustomerCode.Text).Data;
        }

        private void SearchCustomerGroupDetailDto()
        {
            gridControlCustomerLists.DataSource =
                _customerService.SearchCustomerGroupDetailDto(txtCustomerGroup.Text).Data;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtCustomerCode.Text != "")
            {
                SearchCustomerCodeDetailDto();
            }

            if (txtCustomerGroup.Text != "")
            {
                SearchCustomerGroupDetailDto();
            }

            if (txtCustomerName.Text != "")
            {
                SearchCustomerNameDetailDto();
            }
        }

        private void txtCustomerName_EditValueChanged(object sender, EventArgs e)
        {
            SearchCustomerNameDetailDto();
        }

        private void txtCustomerGroup_EditValueChanged(object sender, EventArgs e)
        {
            SearchCustomerGroupDetailDto();
        }
    }
}