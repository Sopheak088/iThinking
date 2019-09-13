using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagement.Helper
{
    public static class Connect
    {
        public static SqlConnection ToDatabase()
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection_String"].ConnectionString);

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return con;
        }

        public static void Close()
        {
            if (ToDatabase().State != ConnectionState.Closed)
            {
                ToDatabase().Close();
            }
        }
    }
}