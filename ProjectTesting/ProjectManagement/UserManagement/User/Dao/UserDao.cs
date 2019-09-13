using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectManagement.BaseObject;
using ProjectManagement.Helper;

namespace ProjectManagement.UserAccount.User.Dao
{
    public class UserDao
    {
        public static DataTable ListAllUser()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("ListAllUser", Connect.ToDatabase());
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
                Connect.ToDatabase().Close();
            }
            return dt;
        }

        public static DataTable FilterListAllUser(FilterEntity filterEntity)
        {
            DataTable dataTable = new DataTable();
            StringBuilder query = new StringBuilder();
            query.Append("SELECT * FROM [USER] ")
                .AppendFormat("WHERE (Username LIKE '%{0}%' ", filterEntity.Keyword)
                .AppendFormat("OR FirstName LIKE '%{0}%' ", filterEntity.Keyword)
                .AppendFormat("OR LastName LIKE '%{0}%') ", filterEntity.Keyword)

                .AppendFormat("OR (CONVERT(DATE, CreatedDate) >= CONVERT(DATE, '{0}') ", filterEntity.FromDate)
                .AppendFormat(" AND CONVERT(DATE, CreatedDate) <= CONVERT(DATE, '{0}')) ", filterEntity.ToDate)

                .AppendFormat("AND Active = '{0}'", filterEntity.Active);
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
                Connect.ToDatabase().Close();
            }
            return dataTable;
        }
    }
}