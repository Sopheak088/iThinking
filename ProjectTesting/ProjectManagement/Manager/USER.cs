using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Manager
{
    public static class USER
    {
        public static Guid ID { get; set; }
        public static string UserName { get; set; }
        public static string Position { get; set; }

        public static void Load_User()
        {
            UserName = "Admin";
        }
    }
}