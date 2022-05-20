using System;
using System.Windows.Forms;
using Fulbank.Pages;

namespace Fulbank;

static class Program
{
    [STAThread]
    private static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Connection());
    }
}