using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectManagement.Helper;

namespace ProjectManagement.UserAccount.Database
{
    public class UserTable
    {
        public static void USER()
        {
            string query = @"SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME='USER'";
            try
            {
                SqlCommand cmd = new SqlCommand(query, Connect.ToDatabase());
                cmd.CommandTimeout = 10000;
                var itExists = (Int32)cmd.ExecuteScalar() > 0;
                Connect.ToDatabase().Close();
                if (!itExists)
                {
                    StringBuilder queryCreate = new StringBuilder();
                    queryCreate.Append("CREATE TABLE [USER](")
                        .Append("ID UNIQUEIDENTIFIER CONSTRAINT USER_PK PRIMARY KEY DEFAULT NEWID(),")
                        .Append("FirstName NVARCHAR(255) COLLATE SQL_Latin1_General_CP437_BIN2 ,")
                        .Append("LastName NVARCHAR(255) COLLATE SQL_Latin1_General_CP437_BIN2 ,")
                        .Append("Username NVARCHAR(255) COLLATE SQL_Latin1_General_CP437_BIN2 CONSTRAINT IX_USER_UserName_UK UNIQUE NULL,")
                        .Append("[Password] NVARCHAR(255) COLLATE SQL_Latin1_General_CP437_BIN2 NULL,")
                        .Append("Position NVARCHAR(255) COLLATE SQL_Latin1_General_CP437_BIN2 NULL,")
                        .Append("Phone NVARCHAR(255) COLLATE SQL_Latin1_General_CP437_BIN2 NULL,	")
                        .Append("Active BIT NOT NULL DEFAULT 1,")
                        .Append("CreatedBy NVARCHAR(255) COLLATE SQL_Latin1_General_CP437_BIN2 NULL,")
                        .Append("CreatedDate DATETIME NULL,")
                        .Append("UpdatedBy NVARCHAR(255) COLLATE SQL_Latin1_General_CP437_BIN2 NULL,")
                        .Append("UpdatedDate DATETIME NULL)");
                    SqlCommand sqlCommand = new SqlCommand(queryCreate.ToString(), Connect.ToDatabase());
                    sqlCommand.CommandTimeout = 10000;
                    sqlCommand.ExecuteNonQuery();
                    Connect.ToDatabase().Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally { Connect.ToDatabase().Close(); }
        }

        public static void GROUP()
        {
            string query = @"SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME='GROUP'";
            try
            {
                SqlCommand cmd = new SqlCommand(query, Connect.ToDatabase());
                cmd.CommandTimeout = 10000;
                var itExists = (Int32)cmd.ExecuteScalar() > 0;
                Connect.ToDatabase().Close();
                if (!itExists)
                {
                    StringBuilder queryCreate = new StringBuilder();
                    queryCreate.Append("CREATE TABLE [GROUP](")
                        .Append("ID UNIQUEIDENTIFIER CONSTRAINT GROUP_PK PRIMARY KEY DEFAULT NEWID(),")
                        .Append("GroupName  NVARCHAR(255) COLLATE SQL_Latin1_General_CP437_BIN2 CONSTRAINT IX_GROUP_GroupName_UK UNIQUE NULL,")
                        .Append("[Description] NVARCHAR(2500) COLLATE SQL_Latin1_General_CP437_BIN2 ,")
                        .Append("CreatedBy NVARCHAR(255) COLLATE SQL_Latin1_General_CP437_BIN2 NULL,")
                        .Append("CreatedDate DATETIME NULL,")
                        .Append("UpdatedBy NVARCHAR(255) COLLATE SQL_Latin1_General_CP437_BIN2 NULL,")
                        .Append("UpdatedDate DATETIME NULL)");
                    SqlCommand sqlCommand = new SqlCommand(queryCreate.ToString(), Connect.ToDatabase());
                    sqlCommand.CommandTimeout = 10000;
                    sqlCommand.ExecuteNonQuery();
                    Connect.ToDatabase().Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally { Connect.ToDatabase().Close(); }
        }

        public static void USER_GROUP()
        {
            string query = @"SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME='USER_GROUP'";
            try
            {
                SqlCommand cmd = new SqlCommand(query, Connect.ToDatabase());
                cmd.CommandTimeout = 10000;
                var itExists = (Int32)cmd.ExecuteScalar() > 0;
                Connect.ToDatabase().Close();
                if (!itExists)
                {
                    StringBuilder queryCreate = new StringBuilder();
                    queryCreate.Append("CREATE TABLE [GROUP](")
                        .Append("ID UNIQUEIDENTIFIER CONSTRAINT GROUP_PK PRIMARY KEY DEFAULT NEWID(),")
                        .Append("GroupName  NVARCHAR(255) COLLATE SQL_Latin1_General_CP437_BIN2 CONSTRAINT IX_GROUP_GroupName_UK UNIQUE NULL,")
                        .Append("[Description] NVARCHAR(2500) COLLATE SQL_Latin1_General_CP437_BIN2 ,")
                        .Append("CreatedBy NVARCHAR(255) COLLATE SQL_Latin1_General_CP437_BIN2 NULL,")
                        .Append("CreatedDate DATETIME NULL,")
                        .Append("UpdatedBy NVARCHAR(255) COLLATE SQL_Latin1_General_CP437_BIN2 NULL,")
                        .Append("UpdatedDate DATETIME NULL)");
                    SqlCommand sqlCommand = new SqlCommand(queryCreate.ToString(), Connect.ToDatabase());
                    sqlCommand.CommandTimeout = 10000;
                    sqlCommand.ExecuteNonQuery();
                    Connect.ToDatabase().Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally { Connect.ToDatabase().Close(); }
        }
    }
}