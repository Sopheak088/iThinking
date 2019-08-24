using ProjectTesting.Company.View;
using ProjectTesting.Manager;
using System;
using System.Windows.Forms;

namespace ProjectTesting
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmCompany());
        }
    }
}