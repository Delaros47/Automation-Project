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
    public partial class StockLists : DevExpress.XtraEditors.XtraForm
    {

        private readonly IStockService _stockService;

        public StockLists()
        {
            InitializeComponent();
            _stockService = InstanceFactory.GetInstance<IStockService>();
        }

        private void StockLists_Load(object sender, EventArgs e)
        {
            GetAllStockDetailDto();
        }

        private void GetAllStockDetailDto()
        {
            gridControlStockLists.DataSource = _stockService.GetStockDetailDto().Data;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gridControlStockLists.DataSource = _stockService.GetStockDetailDto().Data.Where(s=>s.StockCode==txtStockCode.Text || s.StockBarcode==txtStockBarcode.Text || s.StockName==txtStockName.Text);
        }
    }
}