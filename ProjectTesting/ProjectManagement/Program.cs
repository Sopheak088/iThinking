using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectManagement.Company.Dao;
using ProjectManagement.Company.Entity;
using ProjectManagement.Manager;

namespace ProjectManagement
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            CompanyEntity c = new CompanyEntity();
            c.Create("Admin");
            c.Id = Guid.NewGuid();
            Guid id = Guid.Empty;
            c.NameInKhmer = "Test";
            c.NameInEnglish = "Test";
            c.Email = "Test";
            c.Phone = "Test";
            c.Location = "Test";
            c.Logo = new byte[0];
            //CompanyDao.Insert(c);
            MANAGE_ROLE.LoadRole();
            bool a = MANAGE_ROLE.ALLOW_ADD_COMPANY;
            bool b = MANAGE_ROLE.ALLOW_EDIT_COMPANY;
            //MessageBox.Show(new DateTime(2025, 6, 25).DayOfWeek.ToString());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogIn());
        }
    }
}