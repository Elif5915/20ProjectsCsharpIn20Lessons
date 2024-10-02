using System;
using System.Windows.Forms;

namespace AdoNetCustomer_1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMap()); // uygulama ayağa kalkınca ilk hangi form açılsın ayarının yapıldığı yer.
        }
    }
}
