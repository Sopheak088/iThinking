using ProjectTesting.Helper;
using ProjectTesting.User.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTesting.User.Dao
{
    internal class UserDao
    {
        public static DataTable ListUser()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("ListAllUser", Connection.ToDatabase());
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

        public static DataTable GetUserById(Guid id)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM [USER] WHERE ID = '" + id + "'";
            try
            {
                SqlCommand cmd = new SqlCommand(query, Connection.ToDatabase());
                // create data adapter
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // this will query your database and return the result to your datatable
                da.Fill(dataTable);
                da.Dispose();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "Check you SQL",
        MessageBoxButtons.RetryCancel);
            }
            finally
            {
                Connection.ToDatabase().Close();
            }
            return dataTable;
        }

        public static void Insert(UserEntity user)
        {
            try
            {
                SqlCommand com;
                com = new SqlCommand("InsertUser", Connection.ToDatabase());
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ID", user.ID);
                com.Parameters.AddWithValue("@UserName", user.UserName);
                com.Parameters.AddWithValue("@UserPassword", user.UserPassword);
                com.Parameters.AddWithValue("@Position", user.Position);
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

        public static void Update(UserEntity userEntity)
        {
            try
            {
                SqlCommand com;
                com = new SqlCommand("UpdateUser", Connection.ToDatabase());
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ID", userEntity.ID);
                com.Parameters.AddWithValue("@UserName", userEntity.UserName);
                com.Parameters.AddWithValue("@UserPassword", userEntity.UserPassword);
                com.Parameters.AddWithValue("@Position", userEntity.Position);

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