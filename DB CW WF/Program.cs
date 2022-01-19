using System;
using System.Windows.Forms;
using DB_CW_WF.Forms;

namespace DB_CW_WF
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //DbTestFiller.ReFillDb();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Hotels());
        }
    }
}
