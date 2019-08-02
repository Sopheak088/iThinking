using ProjectTesting.Helper;
using ProjectTesting.Supplier.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTesting.Supplier.Dao
{
    public static class SupplierDao
    {
        public static DataTable ListAllProduct()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("ListAllSupplier", Connection.ToDatabase());
                cmd.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), @"Could not find Stored Procedure", MessageBoxButtons.RetryCancel);
            }
            finally
            {
                Connection.ToDatabase().Close();
            }
            return dt;
        }
    }
}