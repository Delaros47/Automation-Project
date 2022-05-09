﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationUI.UserControls.Controls;
using DevExpress.Utils;

namespace AutomationUI.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyPrivateCodeTextEdit:MyTextEdit
    {
        public MyPrivateCodeTextEdit()
        {
            Properties.Appearance.BackColor = Color.PaleGoldenrod;
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.MaxLength = 20;
        }

    }
}
