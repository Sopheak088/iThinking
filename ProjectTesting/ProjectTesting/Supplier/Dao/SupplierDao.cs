using ProjectTesting.Helper;
using ProjectTesting.Supplier.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTesting.Supplier.Dao
{
    internal class SupplierDao
    {
        public static DataTable ListAllSupplier()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("ListAllSupplier", Connection.ToDatabase());
                cmd.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), @"Could not find store procedure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.ToDatabase();
            }
            return dt;
        }

        public static DataTable GetSupplierById(Guid ID)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM SUPPLIER WHERE ID = '" + ID + "'";
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

        public static byte[] GetPhoto(Guid ID)
        {
            try
            {
                string query = "SELECT Photo FROM SUPPLIER WHERE ID = '" + ID + "'";
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

        public static void Insert(SupplierEntity supplier)
        {
            try
            {
                SqlCommand com;
                com = new SqlCommand("InsertSupplier", Connection.ToDatabase());
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ID", supplier.ID);
                com.Parameters.AddWithValue("@Name", supplier.Name);
                com.Parameters.AddWithValue("@Phone", supplier.Phone);
                com.Parameters.AddWithValue("@Descript", supplier.Descritp);
                com.Parameters.AddWithValue("@Photo", supplier.Photo);

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

        public static void Update(SupplierEntity supplierEntity)
        {
            try
            {
                SqlCommand com;
                com = new SqlCommand("UpdateSupplier", Connection.ToDatabase());
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ID", supplierEntity.ID);
                com.Parameters.AddWithValue("@Name", supplierEntity.Name);
                com.Parameters.AddWithValue("@Phone", supplierEntity.Phone);
                com.Parameters.AddWithValue("@Descript", supplierEntity.Descritp);
                com.Parameters.AddWithValue("@Photo", supplierEntity.Photo);
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
    }
}