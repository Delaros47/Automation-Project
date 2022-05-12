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
    public partial class CustomerCardForm : DevExpress.XtraEditors.XtraForm
    {
        public static int CustomerGroupId = -1;
        public static int CustomerId = -1;
        private readonly ICustomerService _customerService;
        private readonly ICustomerGroupService _customerGroupService;
        public CustomerCardForm()
        {
            InitializeComponent();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
            _customerGroupService = InstanceFactory.GetInstance<ICustomerGroupService>();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearAll()
        {
            txtCity.Text = "";
            txtAuthorized1.Text = "";
            txtAuthorized2.Text = "";
            txtAuthorizedEmail1.Text = "";
            txtAuthorizedEmail2.Text = "";
            txtCountry.Text = "";
            txtCustomerName.Text = "";
            txtDistrict.Text = "";
            txtEmailInfo.Text = "";
            txtFax1.Text = "";
            txtFax2.Text = "";
            txtPhoneNumber1.Text = "";
            txtPhoneNumber2.Text = "";
            txtTaxNumber.Text = "";
            txtTaxOffice.Text = "";
            txtWebAddress.Text = "";
            memoAddress.Text = "";
            btnCustomerCode.Text = "";
            btnCustomerGroupCode.Text = "";
            txtCustomerGroupName.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var result = _customerService.Add(new Customer
            {
                CustomerCode = btnCustomerCode.Text,
                Address = memoAddress.Text,
                City = txtCity.Text,
                Country = txtCountry.Text,
                Authorized1 = txtAuthorized1.Text,
                Authorized2 = txtAuthorized2.Text,
                AuthorizedEmail1 = txtAuthorizedEmail1.Text,
                AuthorizedEmail2 = txtAuthorizedEmail2.Text,
                CustomerSaveDate = DateTime.Now,
                CustomerSaveUser = MainForm.UserId,
                CustomerName = txtCustomerName.Text,
                District = txtDistrict.Text,
                Fax1 = txtFax1.Text,
                Fax2 = txtFax2.Text,
                MailInfo = txtEmailInfo.Text,
                Phone1 = txtPhoneNumber1.Text,
                Phone2 = txtPhoneNumber2.Text,
                TaxNumber = txtTaxNumber.Text,
                TaxOffice = txtTaxOffice.Text,
                WebAddress = txtWebAddress.Text,
                CustomerGroupId = CustomerGroupId,

            });
            if (result.Success)
            {
                MyMessageBox.Add(result.Message);
                ClearAll();
            }
        }

        private void btnCustomerGroupCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            CustomerGroupsForm customerGroupsForm = new CustomerGroupsForm();
            customerGroupsForm.ShowDialog();
            if (CustomerGroupId != -1)
            {
                var result = _customerGroupService.Get(CustomerGroupId);
                if (result.Success)
                {
                    btnCustomerGroupCode.Text = result.Data.GroupCode;
                    txtCustomerGroupName.Text = result.Data.GroupName;
                }
            }
        }

        private void CustomerCardForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCustomerCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            CustomerListsForm customerListsForm = new CustomerListsForm();
            customerListsForm.ShowDialog();
            if (CustomerId != -1)
            {
                var result = _customerService.Get(CustomerId);
                if (result.Success)
                {
                    txtCity.Text = result.Data.City;
                    txtCustomerName.Text = result.Data.CustomerName;
                    txtAuthorized2.Text = result.Data.Authorized2;
                    txtAuthorized1.Text = result.Data.Authorized1;
                    txtAuthorizedEmail1.Text = result.Data.AuthorizedEmail1;
                    txtAuthorizedEmail2.Text = result.Data.AuthorizedEmail2;
                    txtCountry.Text = result.Data.Country;
                    txtDistrict.Text = result.Data.District;
                    txtEmailInfo.Text = result.Data.MailInfo;
                    txtFax1.Text = result.Data.Fax1;
                    txtFax2.Text = result.Data.Fax2;
                    txtPhoneNumber1.Text = result.Data.Phone1;
                    txtPhoneNumber2.Text = result.Data.Phone2;
                    txtTaxNumber.Text = result.Data.TaxNumber;
                    txtTaxOffice.Text = result.Data.TaxOffice;
                    txtWebAddress.Text = result.Data.WebAddress;
                    btnCustomerCode.Text = result.Data.CustomerCode;
                    memoAddress.Text = result.Data.Address;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var result = _customerService.Update(new Customer
            {
                Id = CustomerId,
                CustomerCode = btnCustomerCode.Text,
                Address = memoAddress.Text,
                City = txtCity.Text,
                Country = txtCountry.Text,
                Authorized1 = txtAuthorized1.Text,
                Authorized2 = txtAuthorized2.Text,
                AuthorizedEmail1 = txtAuthorizedEmail1.Text,
                AuthorizedEmail2 = txtAuthorizedEmail2.Text,
                CustomerSaveDate = DateTime.Now,
                CustomerSaveUser = MainForm.UserId,
                CustomerName = txtCustomerName.Text,
                District = txtDistrict.Text,
                Fax1 = txtFax1.Text,
                Fax2 = txtFax2.Text,
                MailInfo = txtEmailInfo.Text,
                Phone1 = txtPhoneNumber1.Text,
                Phone2 = txtPhoneNumber2.Text,
                TaxNumber = txtTaxNumber.Text,
                TaxOffice = txtTaxOffice.Text,
                WebAddress = txtWebAddress.Text,
                CustomerGroupId = CustomerGroupId,

            });
            if (result.Success)
            {
                MyMessageBox.Update(result.Message);
                ClearAll();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = _customerService.Delete(new Customer
            {
                Id = CustomerId
            });
            if (result.Success)
            {
                MyMessageBox.Delete(result.Message);
                ClearAll();
            }
        }
    }
}