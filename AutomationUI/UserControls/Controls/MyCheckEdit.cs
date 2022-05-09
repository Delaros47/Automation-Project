using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;

namespace AutomationUI.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyCheckEdit:CheckEdit
    {

        public MyCheckEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.Transparent;

        }

        public override bool EnterMoveNextControl { get; set; } = true;
    }
}
