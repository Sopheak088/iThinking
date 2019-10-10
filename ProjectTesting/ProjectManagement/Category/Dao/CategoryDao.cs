using ProjectManagement.BaseObject;
using ProjectManagement.Category.Entity;
using ProjectManagement.Helper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace ProjectManagement.Category.Dao
{
    public static class CategoryDao
    {
        public static DataTable FilterListCategory(FilterEntity filterEntity)
        {
            DataTable dataTable = new DataTable();
            StringBuilder query = new StringBuilder();
            query.Append("SELECT * FROM CATEGORY ")
                    .AppendFormat("WHERE (CategoryName LIKE '%{0}' ", filterEntity.Keyword)
                    .AppendFormat("OR Other LIKE '%{0}') ", filterEntity.Keyword);
            if (filterEntity.FromDate != null && filterEntity.ToDate != null)
            {
                query.AppendFormat("OR (CONVERT(DATE, CreatedDate) >= CONVERT(DATE, '{0}') ", filterEntity.FromDate)
                        .AppendFormat("AND (CONVERT(DATE, CreatedDate) >= CONVERT(DATE, '{0}'))) ", filterEntity.ToDate);
            }
            try
            {
                SqlCommand cmd = new SqlCommand(query.ToString(), Connect.ToDatabase());
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(dataTable);
                data.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), @"Check you SQL", MessageBoxButtons.RetryCancel);
            }
            finally
            {
                if (Connect.ToDatabase().State != ConnectionState.Closed)
                {
                    Connect.ToDatabase().Close();
                }
            }
            return dataTable;


        }
        public static CategoryEntity GetById(Guid? id)
        {
            CategoryEntity categoryEntity = new CategoryEntity();
            try
            {
                string query = string.Format("SELECT * FROM CATEGORY WHERE ID = '{0}'", id);
                SqlCommand cmd = new SqlCommand(query, Connect.ToDatabase());
                cmd.CommandTimeout = 1000;
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        categoryEntity.Id = (Guid)reader["ID"];
                        categoryEntity.CategoryName = reader["CategoryName"].ToString();
                        categoryEntity.Other = reader["Other"].ToString();
                    }
                    reader.Close();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                if (Connect.ToDatabase().State != ConnectionState.Closed)
                {
                    Connect.ToDatabase().Close();
                }
            }
            return categoryEntity;
        }

        public static bool CheckExistName(string name)
        {
            bool isExist = false;
            try
            {
                string query = string.Format("SELECT COUNT(*) FROM COMPANY WHERE NameInEnglish ='{0}' AND Active = 'True'", name);
                SqlCommand cmd = new SqlCommand(query, Connect.ToDatabase());
                cmd.CommandTimeout = 10000;
                var itExists = (Int32)cmd.ExecuteScalar() > 1;
                if (itExists)
                {
                    isExist = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), @"Error", MessageBoxButtons.RetryCancel);
            }
            finally
            {
                Connect.Close();
            }
            return isExist;
        }
        public static void Insert(CategoryEntity categoryEntity)
        {
            try
            {
                var com = new SqlCommand("INSERT_CATEGORY", Connect.ToDatabase());
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Id", categoryEntity.Id);
                com.Parameters.AddWithValue("@CategoryName", categoryEntity.CategoryName);
                com.Parameters.AddWithValue("@Other", categoryEntity.Other);
                com.Parameters.AddWithValue("@CreatedBy", categoryEntity.CreatedBy);
                com.Parameters.AddWithValue("@CreatedDate", categoryEntity.CreatedDate);
                com.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                if (Connect.ToDatabase().State != ConnectionState.Closed)
                {
                    Connect.ToDatabase().Close();
                }
            }
        }

        public static void Update(CategoryEntity categoryEntity)
        {
            try
            {
                var com = new SqlCommand("UPDATE_CATEGORY", Connect.ToDatabase());
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Id", categoryEntity.Id);
                com.Parameters.AddWithValue("@CategoryName", categoryEntity.CategoryName);
                com.Parameters.AddWithValue("@Other", categoryEntity.Other);
                com.Parameters.AddWithValue("@UpdatedBy", categoryEntity.UpdatedBy);
                com.Parameters.AddWithValue("@UpdatedDate", categoryEntity.UpdatedDate);
                com.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                if (Connect.ToDatabase().State != ConnectionState.Closed)
                {
                    Connect.ToDatabase().Close();
                }
            }
        }


    }
}

