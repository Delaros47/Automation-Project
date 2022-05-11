using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
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

namespace AutomationUI.Forms.StockForms
{
    public partial class StockListsForm : DevExpress.XtraEditors.XtraForm
    {

        private readonly IStockService _stockService;

        public StockListsForm()
        {
            InitializeComponent();
            _stockService = InstanceFactory.GetInstance<IStockService>();
        }

        private void GetAllStockDetailDto()
        {
            gridControlStockLists.DataSource = _stockService.GetStockDetailDto().Data;
        }

        private void ClearAll()
        {
            txtStockName.Text = "";
            txtStockBarcode.Text = "";
            txtStockCode.Text = "";
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gridControlStockLists.DataSource = _stockService
                .SearchStockDetailDto(txtStockCode.Text, txtStockBarcode.Text, txtStockName.Text).Data;
        }



        private void StockListsForm_Load(object sender, EventArgs e)
        {
            gridControlStockLists.DataSource = _stockService.GetStockDetailDto().Data;

        }

        private void gridViewStockLists_DoubleClick(object sender, EventArgs e)
        {
            StockCardForm.StockId = Convert.ToInt32(gridViewStockLists.GetFocusedRowCellValue("Id").ToString());
            this.Close();
        }
    }
}