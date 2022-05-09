using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace AutomationUI.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MySpinEdit:SpinEdit
    {

        public MySpinEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DefaultBoolean.False;
            //Here is d is only numeric without putting point every three digits
            Properties.EditMask = "d";
        }

        public override bool EnterMoveNextControl { get; set; } = true;
    }
}
