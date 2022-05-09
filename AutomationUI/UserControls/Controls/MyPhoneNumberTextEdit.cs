using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationUI.UserControls.Controls;
using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;

namespace AutomationUI.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyPhoneNumberTextEdit:MyTextEdit
    {
        public MyPhoneNumberTextEdit()
        {
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.Mask.MaskType = MaskType.Regular;
            Properties.Mask.EditMask = @"(0\d?\d?\d?) \d?\d?\d? \d?\d? \d?\d?";
            Properties.Mask.AutoComplete = AutoCompleteType.None;
        }

    }
}
