using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraExport.Xls;

namespace AutomationUI.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyButtonEdit : ButtonEdit
    {
        public MyButtonEdit()
        {
            //Disable text edit in our ButtonEdit we cannot write anything in ButtonEdit
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            Properties.AppearanceFocused.BackColor = Color.LightCyan;


        }
        public override bool EnterMoveNextControl { get; set; } = true;




      

    }
    
}
