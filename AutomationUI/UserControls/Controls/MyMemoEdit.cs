﻿using System;
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
    public class MyMemoEdit:MemoEdit
    {

        public MyMemoEdit()
        {
            
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.Appearance.BackColor = Color.PaleGoldenrod;
            Properties.MaxLength = 500;

        }

        public override bool EnterMoveNextControl { get; set; } = true;
    }
}
