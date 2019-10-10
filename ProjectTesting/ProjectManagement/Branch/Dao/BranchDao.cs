using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using ProjectManagement.BaseObject;
using ProjectManagement.Branch.Entity;
using ProjectManagement.Company.Entity;
using ProjectManagement.Helper;
using ProjectManagement.UserManagement.ClassDao;

namespace ProjectManagement.Branch.Dao
{
    public static class BranchDao
    {
        public static DataTable GetCompanyToComboBox()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT ID, NameInEnglish FROM COMPANY ORDER BY NameInEnglish", Connect.ToDatabase());
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
        public static DataTable FilterListBranch(FilterEntity filterEntity)
        {
            DataTable dataTable = new DataTable();
            StringBuilder query = new StringBuilder();
            query.Append("SELECT * FROM BRANCH ")
                .AppendFormat("WHERE Active = '{0}' ", filterEntity.Active);
            if (!string.IsNullOrWhiteSpace(filterEntity.Keyword))
            {
                query.AppendFormat("AND Name LIKE N'%{0}%' ", filterEntity.Keyword);
            }
            if (filterEntity.FromDate != null && filterEntity.ToDate != null)
            {
                query.AppendFormat("AND ((CONVERT(DATE, CreatedDate) >= CONVERT(DATE, '{0}')) ", filterEntity.FromDate)
                     .AppendFormat("AND (CONVERT(DATE, CreatedDate) <= CONVERT(DATE, '{0}'))) ", filterEntity.ToDate);
            }
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
                if (Connect.ToDatabase().State != ConnectionState.Closed)
                {
                    Connect.ToDatabase().Close();
                }
            }
            return dataTable;
        }


        public static BranchEntity GetById(Guid? id)
        {
            BranchEntity branchEntity = new BranchEntity();
            try
            {
                string query = string.Format("SELECT * FROM BRANCH WHERE ID ='{0}'", id);
                SqlCommand cmd = new SqlCommand(query, Connect.ToDatabase());
                cmd.CommandTimeout = 10000;
                var reader = cmd.ExecuteReader();
                int i = reader.FieldCount;
                if (reader.HasRows)
                    while (reader.Read())
                    {
                        branchEntity.Id = (Guid)reader["ID"];
                        branchEntity.Name = reader["Name"].ToString();
                        branchEntity.Email = reader["Email"].ToString();
                        branchEntity.Phone = reader["Phone"].ToString();
                        branchEntity.Location = reader["Location"].ToString();
                        branchEntity.Active = bool.Parse(reader["Active"].ToString());
                        branchEntity.CompanyId = (Guid)reader["CompanyId"];

                    }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
              //  if (Connect.ToDatabase().State != ConnectionState.Close)
                {
                    Connect.Close();
                }
            }
            return branchEntity;

        }
        public static void Insert(BranchEntity branchEntity)
        {
            try
            {
                var com = new SqlCommand("INSERT_BRANCH", Connect.ToDatabase());
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ID", branchEntity.Id);
                com.Parameters.AddWithValue("@Name", branchEntity.Name);
                com.Parameters.AddWithValue("@Email", branchEntity.Email);
                com.Parameters.AddWithValue("@Phone", branchEntity.Phone);
                com.Parameters.AddWithValue("@Location", branchEntity.Location);
                com.Parameters.AddWithValue("@Active", branchEntity.Active);
                com.Parameters.AddWithValue("@CompanyId", branchEntity.CompanyId);
                com.Parameters.AddWithValue("@CreatedBy", branchEntity.CreatedBy);
                com.Parameters.AddWithValue("@CreatedDate", branchEntity.CreatedDate);
                com.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), @"Could find Store Procedure", MessageBoxButtons.RetryCancel);
            }
            finally
            {
                //if (Connect.ToDatabase().State != ConnectState.Closed)
                
                    Connect.ToDatabase().Close();
                
            }
        }
        public static void Update(BranchEntity branchEntity)
        {
            try
            {
                var com = new SqlCommand("UPDATE_BRANCH", Connect.ToDatabase());
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ID", branchEntity.Id);
                com.Parameters.AddWithValue("@Name", branchEntity.Name);
                com.Parameters.AddWithValue("@Email", branchEntity.Email);
                com.Parameters.AddWithValue("@Phone", branchEntity.Phone);
                com.Parameters.AddWithValue("@Location", branchEntity.Location);
                com.Parameters.AddWithValue("@Active", branchEntity.Active);
                com.Parameters.AddWithValue("@CompanyId", branchEntity.CompanyId);
                com.Parameters.AddWithValue("@UpdatedBy", branchEntity.UpdatedBy);
                com.Parameters.AddWithValue("@UpdatedDate", branchEntity.UpdatedDate);
                com.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), @"Could find Store Procedure", MessageBoxButtons.RetryCancel);
            }
            finally
            {
                //if (Connect.ToDatabase().State != ConnectState.Closed)
                {
                    Connect.ToDatabase().Close();
                }
            }
        }
        public static bool CheckExistName(string name)
        {
            bool isExist = false;
            try
            {
                string query = string.Format("SELECT COUNT(*) FROM BRANCH WHERE Name ='{0}' AND Active = 'True'", name);
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
 