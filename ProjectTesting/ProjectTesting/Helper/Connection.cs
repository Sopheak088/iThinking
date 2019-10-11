using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTesting.Helper
{
    public static class Connection
    {
        public static SqlConnection ToDatabase()
        {
            SqlConnection con = new SqlConnection();
            try
            {
                //Data Source=.; Initial Catalog=DBTEST; Integrated Security=true;
                con = new SqlConnection("Data Source=.; Initial Catalog=CAFE; Integrated Security=true;");
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return con;
        }
    }
}