using System;
using System.Windows.Forms;

namespace EF_DBFirstProduct_2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new FrmCategory());
            // Application.Run(new FrmProduct());
            Application.Run(new FrmHomePage());
        }
    }
}
