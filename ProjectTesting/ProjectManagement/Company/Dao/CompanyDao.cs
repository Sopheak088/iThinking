using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using ProjectManagement.BaseObject;
using ProjectManagement.Company.Entity;
using ProjectManagement.Helper;
using ProjectManagement.UserManagement.ClassDao;

namespace ProjectManagement.Company.Dao
{
    public static class CompanyDao
    {
        public static byte[] GetPhoto(Guid id)
        {
            return SelectPicture.GetPhoto("Logo", "COMPANY", id);
        }

        public static DataTable FilterListCompany(FilterEntity filterEntity)
        {
            DataTable dataTable = new DataTable();
            StringBuilder query = new StringBuilder();
            query.Append("SELECT * FROM COMPANY ")
                .AppendFormat("WHERE (NameInKhmer LIKE N'%{0}%' ", filterEntity.Keyword)
                .AppendFormat("OR NameInEnglish LIKE '%{0}%') ", filterEntity.Keyword);
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

        public static CompanyEntity GetById(Guid? id)
        {
            CompanyEntity companyEntity = new CompanyEntity();
            try
            {
                string query = string.Format("SELECT * FROM COMPANY WHERE ID='{0}'", id);
                SqlCommand cmd = new SqlCommand(query, Connect.ToDatabase());
                cmd.CommandTimeout = 10000;
                var reader = cmd.ExecuteReader();
                int i = reader.FieldCount;
                if (reader.HasRows)
                    while (reader.Read())
                    {
                        companyEntity.Id = (Guid)reader["ID"];
                        companyEntity.NameInEnglish = reader["NameInEnglish"].ToString();
                        companyEntity.NameInKhmer = reader["NameInKhmer"].ToString();
                        companyEntity.Email = reader["Email"].ToString();
                        companyEntity.Phone = reader["Phone"].ToString();
                        companyEntity.Location = reader["Location"].ToString();
                        companyEntity.Active = bool.Parse(reader["Active"].ToString());
                        companyEntity.Logo = SelectPicture.GetPhoto("Logo", "COMPANY", companyEntity.Id);
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
            return companyEntity;
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

        public static void Insert(CompanyEntity companyEntity)
        {
            try
            {
                var com = new SqlCommand("INSERT_COMPANY", Connect.ToDatabase());
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Id", companyEntity.Id);
                com.Parameters.AddWithValue("@NameInKhmer", companyEntity.NameInKhmer);
                com.Parameters.AddWithValue("@NameInEnglish", companyEntity.NameInEnglish);
                com.Parameters.AddWithValue("@Email", companyEntity.Email);
                com.Parameters.AddWithValue("@Phone", companyEntity.Phone);
                com.Parameters.AddWithValue("@Location", companyEntity.Location);
                com.Parameters.AddWithValue("@Active", companyEntity.Active);
                com.Parameters.AddWithValue("@Logo", companyEntity.Logo);
                com.Parameters.AddWithValue("@CreatedBy", companyEntity.CreatedBy);
                com.Parameters.AddWithValue("@CreatedDate", companyEntity.CreatedDate);
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

        public static void Update(CompanyEntity companyEntity)
        {
            try
            {
                var com = new SqlCommand("UPDATE_COMPANY", Connect.ToDatabase());
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Id", companyEntity.Id);
                com.Parameters.AddWithValue("@NameInKhmer", companyEntity.NameInKhmer);
                com.Parameters.AddWithValue("@NameInEnglish", companyEntity.NameInEnglish);
                com.Parameters.AddWithValue("@Email", companyEntity.Email);
                com.Parameters.AddWithValue("@Phone", companyEntity.Phone);
                com.Parameters.AddWithValue("@Location", companyEntity.Location);
                com.Parameters.AddWithValue("@Active", companyEntity.Active);
                com.Parameters.AddWithValue("@Logo", companyEntity.Logo);
                com.Parameters.AddWithValue("@UpdatedBy", companyEntity.UpdatedBy);
                com.Parameters.AddWithValue("@UpdatedDate", companyEntity.UpdatedDate);
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
    }
}