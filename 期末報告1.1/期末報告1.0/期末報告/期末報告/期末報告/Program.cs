using System;
using System.Windows.Forms;

namespace 視窗程式設計
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormIntro());
        }
    }
}
