using ProjectTesting.Helper;
using ProjectTesting.Product.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTesting.Product.Dao
{
    public static class ProductDao
    {
        public static DataTable ListAllProduct()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("ListAllProduct", Connection.ToDatabase());
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

        public static void Insert(ProductEntity product)
        {
            try
            {
                SqlCommand com;
                com = new SqlCommand("InsertProduct", Connection.ToDatabase());
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Id", product.Id);
                com.Parameters.AddWithValue("@Name", product.Name);
                com.Parameters.AddWithValue("@Price", product.Price);
                com.Parameters.AddWithValue("@MadeDate", product.MadeDate);
                com.Parameters.AddWithValue("@ExpiredDate", product.ExpiredDate);
                com.Parameters.AddWithValue("@photo", product.Photo);
                com.Parameters.AddWithValue("@Active", product.Active);
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

        public static void Update(ProductEntity productEntity)
        {
            try
            {
                SqlCommand com;
                com = new SqlCommand("UpdateProduct", Connection.ToDatabase());
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Id", productEntity.Id);
                com.Parameters.AddWithValue("@Name", productEntity.Name);
                com.Parameters.AddWithValue("@Price", productEntity.Price);
                com.Parameters.AddWithValue("@MadeDate", productEntity.MadeDate);
                com.Parameters.AddWithValue("@ExpiredDate", productEntity.ExpiredDate);
                com.Parameters.AddWithValue("@photo", productEntity.Photo);
                com.Parameters.AddWithValue("@Active", productEntity.Active);
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

        public static DataTable GetProductById(Guid id)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM PRODUCT WHERE ID = '" + id + "'";
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

        public static byte[] GetPhoto(Guid id)
        {
            string query = "SELECT Photo FROM PRODUCT WHERE ID = '" + id + "'";
            SqlCommand cm = Connection.ToDatabase().CreateCommand();
            cm.CommandText = query;
            Connection.ToDatabase();
            return cm.ExecuteScalar() as byte[];
        }
    }
}