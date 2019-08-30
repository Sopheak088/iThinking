using ProjectTesting.Company.Entity;
using ProjectTesting.Helper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectTesting.Company.Dao
{
    public static class CompanyDao
    {
        public static void Insert(CompanyEntity company)
        {
            try
            {
                SqlCommand com;
                com = new SqlCommand("InsertCompany", Connection.ToDatabase());
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Id", company.Id);
                com.Parameters.AddWithValue("@Name", company.Name);
                com.Parameters.AddWithValue("@Location", company.Location);
                com.Parameters.AddWithValue("@Email", company.Email);
                com.Parameters.AddWithValue("@Telephone", company.Telephone);
                com.Parameters.AddWithValue("@Fax", company.Fax);
                com.Parameters.AddWithValue("@Logo", company.Logo);
                com.Parameters.AddWithValue("@Branch", company.Branch);
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
        public static void Update(CompanyEntity company)
        {
            try
            {
                SqlCommand com;
                com = new SqlCommand("UpdateCompany", Connection.ToDatabase());
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Id", company.Id);
                com.Parameters.AddWithValue("@Name", company.Name);
                com.Parameters.AddWithValue("@Location", company.Location);
                com.Parameters.AddWithValue("@Email", company.Email);
                com.Parameters.AddWithValue("@Telephone", company.Telephone);
                com.Parameters.AddWithValue("@Fax", company.Fax);
                com.Parameters.AddWithValue("@Logo", company.Logo);
                com.Parameters.AddWithValue("@Branch", company.Branch);
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

        public static DataTable ListAllCompany()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("ListAllCompany", Connection.ToDatabase());
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

        public static DataTable SearchCompanyByName(string search)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("SearchCompanyByName", Connection.ToDatabase());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", search);
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), @"Could not find Stored Procedure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.ToDatabase();
            }
            return dt;
        }

        public static DataTable GetCompanyById(Guid Id)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM COMPANY WHERE ID = '" + Id + "'";
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

        public static byte[] GetLogo(Guid Id)
        {
            try
            {
                string query = "SELECT Logo FROM COMPANY WHERE ID = '" + Id + "'";
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
    }
}
