using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Manager
{
    public static class COMPANY
    {
        public static Guid ID { get; set; }
        public static string Name { get; set; }
        public static string Location { get; set; }

        public static void Load_Company()
        {
        }
    }
}