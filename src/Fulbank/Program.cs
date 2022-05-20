using System;
using System.Windows.Forms;
using Fulbank.Pages;
using Fulbank.Classes;

namespace Fulbank
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Connection());
        }
    }
}