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
    public class MySimpleButton:SimpleButton
    {

        public MySimpleButton()
        {
            Appearance.ForeColor = Color.Maroon;
        }

    }
}
