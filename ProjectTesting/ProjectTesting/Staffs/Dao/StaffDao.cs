using ProjectTesting.Helper;
using ProjectTesting.Staffs.Entity;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectTesting.Staffs.Dao
{

    public static class StaffDao
    {
        public static void Insert(StaffEntity staff)
        {
            try
            {
                SqlCommand com;
                com = new SqlCommand("InsertStaff", Connection.ToDatabase());
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Id", staff.Id);
                com.Parameters.AddWithValue("@Name", staff.Name);
                com.Parameters.AddWithValue("@Salary", staff.Salary);
                com.Parameters.AddWithValue("@HireDate", staff.HireDate);
                com.Parameters.AddWithValue("@StopDate", staff.StopDate);
                com.Parameters.AddWithValue("@photo", staff.Photo);
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

        public static void Update(StaffEntity staffEntity)
        {
            try
            {
                SqlCommand com;
                com = new SqlCommand("UpdateStaff", Connection.ToDatabase());
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Id", staffEntity.Id);
                com.Parameters.AddWithValue("@Name", staffEntity.Name);
                com.Parameters.AddWithValue("@Salary", staffEntity.Salary);
                com.Parameters.AddWithValue("@HireDate", staffEntity.HireDate);
                com.Parameters.AddWithValue("@StopDate", staffEntity.StopDate);
                com.Parameters.AddWithValue("@photo", staffEntity.Photo);
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

        public static DataTable ListAllStaff()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("ListAllStaff", Connection.ToDatabase());
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

        public static DataTable GetStaffById(Guid id)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM STAFF WHERE ID = '" + id + "'";
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

        public static byte[] GetPhoto(Guid id)
        {
            try
            {
                string query = "SELECT Photo FROM STAFF WHERE ID = '" + id + "'";
                SqlCommand cm = Connection.ToDatabase().CreateCommand();
                cm.CommandText = query;
                return cm.ExecuteScalar() as byte[];
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                Connection.ToDatabase().Close();
            }

        }

        public static DataTable GetStaffToComboBox()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT ID, Name FROM STAFF", Connection.ToDatabase());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Connection.ToDatabase().Close();
            }
            return dt;
        }

    }
}
