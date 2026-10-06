using System;
using System.Windows.Forms;

namespace DynamicButtonMatrix
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmNhapLieu());
        }
    }
}