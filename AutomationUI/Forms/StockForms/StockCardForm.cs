using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomationUI.Functions;
using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using Entities.Concrete;

namespace AutomationUI.Forms.StockForms
{
    public partial class StockCardForm : DevExpress.XtraEditors.XtraForm
    {
        public static int StockId = -1;
        public static int GroupId = -1;
        private readonly IStockService _stockService;
        private readonly IStockGroupService _stockGroupService;
        public StockCardForm()
        {
            InitializeComponent();
            _stockService = InstanceFactory.GetInstance<IStockService>();
            _stockGroupService = InstanceFactory.GetInstance<IStockGroupService>();
        }

        private void StockCard_Load(object sender, EventArgs e)
        {

        }

        private void ClearAll()
        {
            txtStockName.Text = "";
            txtStockBarcode.Text = "";
            txtGroupName.Text = "";
            txtPurchasePrice.Text = "0";
            txtPurchaseVat.Text = "0";
            txtSalePrice.Text = "0";
            txtSaleVAT.Text = "0";
            cmbStockUnit.SelectedIndex = 0;
            btnGroupCode.Text = "";
            btnStockCode.Text = "";
            pictureEditStock.Image = null;
            StockId = -1;
            GroupId = -1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var result = _stockService.Add(new Stock
            {
                StockName = txtStockName.Text,
                StockCode = btnStockCode.Text,
                StockBarcode = txtStockBarcode.Text,
                StockPurchasePrice = decimal.Parse(txtPurchasePrice.Text),
                StockSalePrice = decimal.Parse(txtSalePrice.Text),
                StockPurchaseVAT = decimal.Parse(txtPurchaseVat.Text),
                StockSaleVAT = decimal.Parse(txtSaleVAT.Text),
                GroupId = GroupId,
                StockUnit = cmbStockUnit.Text,
                StockSaveDate = DateTime.Now,
                StockSaveUser = MainForm.UserId,
                StockImage = File.ReadAllBytes(pictureEditStock.GetLoadedImageLocation()),
            });
            if (result.Success)
            {
                MyMessageBox.Add("Stock");
                ClearAll();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var result = _stockService.Update(new Stock
            {
                Id = StockId,
                StockName = txtStockName.Text,
                StockCode = btnStockCode.Text,
                StockBarcode = txtStockBarcode.Text,
                StockPurchasePrice = decimal.Parse(txtPurchasePrice.Text),
                StockSalePrice = decimal.Parse(txtSalePrice.Text),
                StockPurchaseVAT = decimal.Parse(txtPurchaseVat.Text),
                StockSaleVAT = decimal.Parse(txtSaleVAT.Text),
                GroupId = GroupId,
                StockUnit = cmbStockUnit.Text,
                StockEditDate = DateTime.Now,
                StockEditUser = MainForm.UserId,
                StockImage = File.ReadAllBytes(pictureEditStock.GetLoadedImageLocation()),
            });
            if (result.Success)
            {
                MyMessageBox.Update("Stock");
                ClearAll();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = _stockService.Delete(new Stock
            {
                Id = StockId
            });
            if (result.Success)
            {
                MyMessageBox.Delete("Stock");
                ClearAll();
            }
        }


        private void btnGroupCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            StockGroupsForm stockgroupsForm = new StockGroupsForm();
            stockgroupsForm.ShowDialog();
            if (GroupId != -1)
            {
                var result = _stockGroupService.Get(GroupId);
                if (result.Success)
                {
                    btnGroupCode.Text = result.Data.GroupCode;
                    txtGroupName.Text = result.Data.GroupName;
                }
            }


        }

        private void btnStockCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            StockListsForm stockListsForm = new StockListsForm();
            stockListsForm.ShowDialog();
            if (StockId != -1)
            {
                var result = _stockService.Get(StockId);
                var group = _stockGroupService.Get(result.Data.GroupId);
                if (result.Success)
                {
                    btnStockCode.Text = result.Data.StockCode;
                    txtPurchasePrice.Text = result.Data.StockPurchasePrice.ToString();
                    txtPurchaseVat.Text = result.Data.StockPurchaseVAT.ToString();
                    txtSalePrice.Text = result.Data.StockSalePrice.ToString();
                    txtSaleVAT.Text = result.Data.StockSaleVAT.ToString();
                    txtStockBarcode.Text = result.Data.StockBarcode;
                    txtStockName.Text = result.Data.StockName;
                    btnGroupCode.Text = group.Data.GroupCode;
                    txtGroupName.Text = group.Data.GroupName;
                    using (MemoryStream memoryStream = new MemoryStream((byte[])result.Data.StockImage))
                    {
                        pictureEditStock.Image = Image.FromStream(memoryStream);
                    }
                }
            }

        }
    }
}