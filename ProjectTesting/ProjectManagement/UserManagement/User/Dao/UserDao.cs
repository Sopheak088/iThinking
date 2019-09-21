using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using ProjectManagement.BaseObject;
using ProjectManagement.Helper;
using ProjectManagement.UserManagement.User.Entity;

namespace ProjectManagement.UserManagement.User.Dao
{
    public static class UserDao
    {
        public static DataTable GetBranchToComboBox()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT ID, Name FROM BRANCH ORDER BY Name", Connect.ToDatabase());
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
                Connect.Close();
            }
            return dt;
        }

        public static DataTable FilterListUser(FilterEntity filterEntity)
        {
            DataTable dataTable = new DataTable();
            StringBuilder query = new StringBuilder();
            query.Append("SELECT * FROM [USER]")
                .AppendFormat("WHERE (Username LIKE N'%{0}%' ", filterEntity.Keyword)
                .AppendFormat("OR Position LIKE '%{0}%') ", filterEntity.Keyword);
            if (filterEntity.FromDate != null && filterEntity.ToDate != null)
            {
                query.AppendFormat("OR (CONVERT(DATE, CreatedDate) >= CONVERT(DATE, '{0}') ", filterEntity.FromDate)
                    .AppendFormat(" AND CONVERT(DATE, CreatedDate) <= CONVERT(DATE, '{0}')) ", filterEntity.ToDate);
            }

            query.AppendFormat("AND Active = '{0}'", filterEntity.Active);
            try
            {
                SqlCommand cmd = new SqlCommand(query.ToString(), Connect.ToDatabase());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dataTable);
                da.Dispose();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), @"Check you SQL",
                    MessageBoxButtons.RetryCancel);
            }
            finally
            {
                Connect.Close();
            }
            return dataTable;
        }

        public static UserEntity GetById(Guid? id)
        {
            UserEntity userEntity = new UserEntity();
            try
            {
                string query = string.Format("SELECT * FROM [USER] WHERE ID='{0}'", id);
                SqlCommand cmd = new SqlCommand(query, Connect.ToDatabase());
                cmd.CommandTimeout = 10000;
                var reader = cmd.ExecuteReader();
                int i = reader.FieldCount;
                if (reader.HasRows)
                    while (reader.Read())
                    {
                        userEntity.Id = (Guid)reader["ID"];
                        userEntity.FirstName = reader["FirstName"].ToString();
                        userEntity.LastName = reader["LastName"].ToString();
                        userEntity.Username = reader["Username"].ToString();
                        userEntity.Password = reader["Password"].ToString();
                        userEntity.Phone = reader["Phone"].ToString();
                        userEntity.Position = reader["Position"].ToString();
                        userEntity.Active = bool.Parse(reader["Active"].ToString());
                        userEntity.BranchId = (Guid)reader["BranchId"];
                    }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                Connect.Close();
            }
            return userEntity;
        }

        public static void Insert(UserEntity userEntity)
        {
            try
            {
                var com = new SqlCommand("INSERT_USER", Connect.ToDatabase());
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Id", userEntity.Id);
                com.Parameters.AddWithValue("@FirstName", userEntity.FirstName);
                com.Parameters.AddWithValue("@LastName", userEntity.LastName);
                com.Parameters.AddWithValue("@Username", userEntity.Username);
                com.Parameters.AddWithValue("@Password", userEntity.Password);
                com.Parameters.AddWithValue("@Position", userEntity.Position);
                com.Parameters.AddWithValue("@Active", userEntity.Active);
                com.Parameters.AddWithValue("@Phone", userEntity.Phone);
                com.Parameters.AddWithValue("@BranchId", userEntity.BranchId);
                com.Parameters.AddWithValue("@CreatedBy", userEntity.CreatedBy);
                com.Parameters.AddWithValue("@CreatedDate", userEntity.CreatedDate);
                com.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), @"Could not find Stored Procedure", MessageBoxButtons.RetryCancel);
            }
            finally
            {
                Connect.Close();
            }
        }

        public static void Update(UserEntity userEntity)
        {
            try
            {
                var com = new SqlCommand("UPDATE_USER", Connect.ToDatabase());
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Id", userEntity.Id);
                com.Parameters.AddWithValue("@FirstName", userEntity.FirstName);
                com.Parameters.AddWithValue("@LastName", userEntity.LastName);
                com.Parameters.AddWithValue("@Username", userEntity.Username);
                com.Parameters.AddWithValue("@Password", userEntity.Password);
                com.Parameters.AddWithValue("@Position", userEntity.Position);
                com.Parameters.AddWithValue("@Active", userEntity.Active);
                com.Parameters.AddWithValue("@Phone", userEntity.Phone);
                com.Parameters.AddWithValue("@BranchId", userEntity.BranchId);
                com.Parameters.AddWithValue("@UpdatedBy", userEntity.UpdatedBy);
                com.Parameters.AddWithValue("@UpdatedDate", userEntity.UpdatedDate);
                com.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), @"Could not find Stored Procedure", MessageBoxButtons.RetryCancel);
            }
            finally
            {
                Connect.Close();
            }
        }

        public static bool CheckExistName(string name)
        {
            bool isExist = false;
            try
            {
                string query = string.Format("SELECT COUNT(*) FROM [USER] WHERE Username ='{0}' AND Active = 'True'", name);
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
    }
}