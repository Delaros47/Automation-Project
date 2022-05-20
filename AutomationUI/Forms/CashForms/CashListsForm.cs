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

namespace AutomationUI.Forms.CashForms
{
    public partial class CashListsForm : DevExpress.XtraEditors.XtraForm
    {
        private int CashId = -1;
        private readonly ICashService _cashService;
        public CashListsForm()
        {
            InitializeComponent();
            _cashService = InstanceFactory.GetInstance<ICashService>();
        }

        private void CashListsForm_Load(object sender, EventArgs e)
        {

            GetAllCashs();
        }

        private void CleanAll()
        {
            txtCashCode.Text = "";
            txtCashName.Text = "";
        }

        private void GetAllCashs()
        {
            gridControlCashLists.DataSource = _cashService.GetAll().Data;
        }

        private void gridViewCashLists_DoubleClick(object sender, EventArgs e)
        {
            CashId = Convert.ToInt32(gridViewCashLists.GetFocusedRowCellValue("Id").ToString());
            CashPeriodsForm.CashId = CashId;
            CashReceiptsForm.CashId = CashId;
            this.Close();
        }
    }
}