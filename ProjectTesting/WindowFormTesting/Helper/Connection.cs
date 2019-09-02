using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowFormTesting.Helper
{
    public static class Connection
    {
        public static SqlConnection ToDatabase()
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con = new SqlConnection("Data Source=.; Initial Catalog=DBTest; Integrated Security=true;");
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