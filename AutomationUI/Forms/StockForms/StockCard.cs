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

namespace AutomationUI.Forms.StockForms
{
    public partial class StockCard : DevExpress.XtraEditors.XtraForm
    {
        private int StockId = -1;
        private int GroupId = -1;
        private readonly IStockService _stockService;
        public StockCard()
        {
            InitializeComponent();
            _stockService = InstanceFactory.GetInstance<IStockService>();
        }

        private void StockCard_Load(object sender, EventArgs e)
        {

        }
    }
}