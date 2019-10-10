using ProjectManagement.Helper;
using ProjectManagement.MemberShip.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagement.MEMBERSHIP.Dao
{
    internal class MembershipDao
    {
        public static DataTable FilterList()
        {
            DataTable dataTable = new DataTable();
            StringBuilder query = new StringBuilder();
            query.Append("SELECT * FROM MEMBERSHIP");
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

        public static MemberShipEntity GetByID(Guid? id)
        {
            MemberShipEntity memberShipEntity = new MemberShipEntity();
            try
            {
                string query = string.Format("SELECT*FROM MEMBERSHIP WHERE ID='{0}'", id);
                SqlCommand cmd = new SqlCommand(query, Connect.ToDatabase());
                cmd.CommandTimeout = 10000;
                var reader = cmd.ExecuteReader();
                int i = reader.FieldCount;
                if (reader.HasRows)
                    while (reader.Read())
                    {
                        memberShipEntity.ID = (Guid)reader["ID"];
                        memberShipEntity.MembershipType = reader["MembershipType"].ToString();
                        memberShipEntity.DiscountValue = int.Parse(reader["DiscountValue"].ToString());
                        memberShipEntity.DiscountText = reader["DiscountText"].ToString();
                        memberShipEntity.Other = reader["Other"].ToString();
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
            return memberShipEntity;
        }

        public static void Insert(MemberShipEntity memberShipEntity)
        {
            try
            {
                var com = new SqlCommand("INSERT_MEMBERSHIP", Connect.ToDatabase());
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ID", memberShipEntity.ID);
                com.Parameters.AddWithValue("@MembershipType", memberShipEntity.MembershipType);
                com.Parameters.AddWithValue("@DiscountValue", memberShipEntity.DiscountValue);
                com.Parameters.AddWithValue("@DiscountText", memberShipEntity.DiscountText);
                com.Parameters.AddWithValue("@Other", memberShipEntity.Other);
                com.Parameters.AddWithValue("@CreateBy", memberShipEntity.CreatedBy);
                com.Parameters.AddWithValue("@CreateDate", memberShipEntity.CreatedDate);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), @"Could not find Stored Procedure");
            }
            finally
            {
                if (Connect.ToDatabase().State != ConnectionState.Closed) ;
            }
            {
                Connect.ToDatabase().Close();
            }
        }

        public static void Update(MemberShipEntity memberShipEntity)
        {
            try
            {
                var com = new SqlCommand("UPDATE_MEMBERSHIP", Connect.ToDatabase());
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ID", memberShipEntity.ID);
                com.Parameters.AddWithValue("@MembershipType", memberShipEntity.MembershipType);
                com.Parameters.AddWithValue("@DiscountValue", memberShipEntity.DiscountValue);
                com.Parameters.AddWithValue("@DiscountText", memberShipEntity.DiscountText);
                com.Parameters.AddWithValue("@Other", memberShipEntity.Other);
                com.Parameters.AddWithValue("@UpdateBy", memberShipEntity.UpdatedBy);
                com.Parameters.AddWithValue("@UpdateDate", memberShipEntity.UpdatedDate);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), @"Could not find Stored Procedure");
            }
            finally
            {
                if (Connect.ToDatabase().State != ConnectionState.Closed) ;
            }
            {
                Connect.ToDatabase().Close();
            }
        }
    }
}