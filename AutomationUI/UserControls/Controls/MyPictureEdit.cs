using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace AutomationUI.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyPictureEdit : PictureEdit
    {
        public MyPictureEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.Appearance.ForeColor = Color.Maroon;
            Properties.NullText = "No Picture";
            Properties.SizeMode = PictureSizeMode.Stretch;
            //We dont want default menu to be shown we will later create own Menu
        }

        public override bool EnterMoveNextControl { get; set; } = true;

    }
}
