using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;

namespace AutomationUI.Functions
{
    public class MyMessageBox
    {


        public static void Add(string content)
        {
            XtraMessageBox.Show(content, "Adding a new.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Update(string content)
        {
            XtraMessageBox.Show(content, "Updating the currrent.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void Delete(string content)
        {
            XtraMessageBox.Show(content, "Deleting the current", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
