using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationUI.UserControls.Controls;
using DevExpress.XtraEditors.Mask;

namespace AutomationUI.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyIbanTextEdit:MyTextEdit
    {
        public MyIbanTextEdit()
        {
            Properties.Mask.MaskType = MaskType.Regular;
            //Iban has 26 digits since first two letter is country code
            Properties.Mask.EditMask = @"TR\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?";
            Properties.Mask.AutoComplete = AutoCompleteType.None;
        }

    }
}
