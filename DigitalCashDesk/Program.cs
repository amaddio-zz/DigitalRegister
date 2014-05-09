using System;
using System.Collections.Generic;
//using System.Linq;
using System.Windows.Forms;

namespace DigitalCashDesk
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                CashMainMdi mainwindow = new CashMainMdi();
                Application.Run(mainwindow);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n" + e.StackTrace + "\n Inner exception: " + e.InnerException, "Fehler aufgetreten");
            }
        }
    }
}
