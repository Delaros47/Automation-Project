using AutomationUI.Forms;
using AutomationUI.Forms.StockForms;

namespace AutomationUI
{
    internal static class Program
    {
  
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}