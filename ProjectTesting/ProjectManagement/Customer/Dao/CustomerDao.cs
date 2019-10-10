using ProjectManagement.BaseObject;
using ProjectManagement.Customer.Entity;
using ProjectManagement.Helper;
using ProjectManagement.UserManagement.ClassDao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagement.Customer.Dao
{
    public static class CustomerDao
    {
        public static DataTable GetMemberShipToComboBox()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT [ID],[MembershipType]  FROM [MEMBERSHIP] ORDER BY MembershipType", Connect.ToDatabase());
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

        public static DataTable FilterListCustomer(FilterEntity filterEntity)
        {
            DataTable dataTable = new DataTable();
            StringBuilder query = new StringBuilder();
            query.Append("SELECT c.*, m.MembershipType FROM CUSTOMER c INNER JOIN MEMBERSHIP m ON c.MemberShipID=m.ID ")
                .AppendFormat("WHERE c.CustomerName LIKE N'%{0}%'", filterEntity.Keyword);
            if (filterEntity.FromDate != null && filterEntity.ToDate != null)
            {
                query.AppendFormat("OR (CONVERT(DATE,c.CreateDate)>=CONVERT(DATE,'{0}') ", filterEntity.FromDate)
                    .AppendFormat("AND CONVERT(DATE,c.CreateDate)<=CONVERT(DATE,'{0}'))", filterEntity.ToDate);
            }
            query.AppendFormat("AND c.Active='{0}'", filterEntity.Active);
            try
            {
                SqlCommand cmd = new SqlCommand(query.ToString(), Connect.ToDatabase());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dataTable);
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), @"Check you sql", MessageBoxButtons.RetryCancel);
            }
            finally
            {
                Connect.Close();
            }
            return dataTable;
        }

        public static CustomerEntity GetByID(Guid? id)
        {
            CustomerEntity customerEntity = new CustomerEntity();
            try
            {
                string query = string.Format("SELECT*FROM CUSTOMER WHERE ID='{0}'", id);
                SqlCommand cmd = new SqlCommand(query, Connect.ToDatabase());
                cmd.CommandTimeout = 10000;
                var reader = cmd.ExecuteReader();
                int i = reader.FieldCount;
                if (reader.HasRows)
                    while (reader.Read())
                    {
                        customerEntity.ID = (Guid)reader["ID"];
                        customerEntity.CustomerName = reader["CustomerName"].ToString();
                        customerEntity.Gender = reader["Gender"].ToString();
                        customerEntity.Address = reader["Address"].ToString();
                        customerEntity.Active = bool.Parse(reader["Active"].ToString());
                        customerEntity.OtherContact = reader["OtherContact"].ToString();
                        customerEntity.MemberShipID = (Guid)reader["MemberShipID"];
                        customerEntity.Photo = SelectPicture.GetPhoto("Photo", "CUSTOMER", customerEntity.ID);
                    }
                reader.Close();
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
            return customerEntity;
        }

        public static void Insert(CustomerEntity customerEntity)
        {
            try
            {
                var com = new SqlCommand("INSERT_CUSTOMER", Connect.ToDatabase());
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ID", customerEntity.ID);
                com.Parameters.AddWithValue("@CustomerName", customerEntity.CustomerName);
                com.Parameters.AddWithValue("@Gender", customerEntity.Gender);
                com.Parameters.AddWithValue("@Address", customerEntity.Address);
                com.Parameters.AddWithValue("@OtherContact", customerEntity.OtherContact);
                com.Parameters.AddWithValue("@Photo", customerEntity.Photo);
                com.Parameters.AddWithValue("@Active", customerEntity.Active);
                com.Parameters.AddWithValue("@MemberShipID", customerEntity.MemberShipID);
                com.Parameters.AddWithValue("@CreateBy", customerEntity.CreatedBy);
                com.Parameters.AddWithValue("@CreatedDate", customerEntity.CreatedDate);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), @"Could not find Stored Procedure", MessageBoxButtons.RetryCancel);
            }
            finally
            {
                if (Connect.ToDatabase().State != ConnectionState.Closed)
                {
                    Connect.ToDatabase().Close();
                }
            }
        }

        public static void Update(CustomerEntity customerEntity)
        {
            try
            {
                var com = new SqlCommand("UPDATE_CUSTOMER", Connect.ToDatabase());
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ID", customerEntity.ID);
                com.Parameters.AddWithValue("@CustomerName", customerEntity.CustomerName);
                com.Parameters.AddWithValue("@Gender", customerEntity.Gender);
                com.Parameters.AddWithValue("@Address", customerEntity.Address);
                com.Parameters.AddWithValue("@OtherContact", customerEntity.OtherContact);
                com.Parameters.AddWithValue("@Photo", customerEntity.Photo);
                com.Parameters.AddWithValue("@Active", customerEntity.Active);
                com.Parameters.AddWithValue("@MemberShipID", customerEntity.MemberShipID);
                com.Parameters.AddWithValue("@UpdateBy", customerEntity.UpdatedBy);
                com.Parameters.AddWithValue("@UpdateDate", customerEntity.UpdatedDate);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), @"Could not find Stored Procedure", MessageBoxButtons.RetryCancel);
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