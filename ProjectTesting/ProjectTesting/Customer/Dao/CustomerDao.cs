using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProjectTesting.Helper;
using System.Windows.Forms;
using ProjectTesting.Customer.Entity;

namespace ProjectTesting.Customer.Dao
{
    public static class CustomerDao
    {
        public static DataTable ListAllCustomer()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("ListAllCustomer", Connection.ToDatabase());
                cmd.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), @"Could not find store procedure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.ToDatabase();
            }
            return dt;
        }

        public static void Insert(CustomerEntity customer)
        {
            try
            {
                SqlCommand com;
                com = new SqlCommand("InsertCustomer", Connection.ToDatabase());
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Id", customer.Id);
                com.Parameters.AddWithValue("@Name", customer.Name);
                com.Parameters.AddWithValue("@Phone", customer.Phone);
                com.Parameters.AddWithValue("@Photo", customer.Photo);
                com.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), @"Could not find Stored Procedure", MessageBoxButtons.RetryCancel);
            }
            finally
            {
                Connection.ToDatabase().Close();
            }
        }
    }
}