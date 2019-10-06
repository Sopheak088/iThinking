using ProjectManagement.BaseObject;
using ProjectManagement.Helper;
using ProjectManagement.Product.Entity;
using ProjectManagement.UserManagement.ClassDao;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace ProjectManagement.Product.Dao
{
    public class ProductDao : FilterEntity
    {
        public static DataTable GetCategoryTocombobox()
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT ID , CategoryName FROM CATEGORY ORDER BY CategoryName", Connect.ToDatabase());
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dataTable);
                sqlDataAdapter.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Connect.Close();
            }
            return dataTable;
        }

        public static byte[] GetPhoto(Guid id)
        {
            return SelectPicture.GetPhoto("Photo", "PRODUCT", id);
        }
        public static ProductEntity GetById(Guid? id)
        {
            ProductEntity productEntity = new ProductEntity();
            try
            {
                string query = string.Format("SELECT * FROM PRODUCT WHERE ID='{0}'", id);
                SqlCommand cmd = new SqlCommand(query, Connect.ToDatabase());
                cmd.CommandTimeout = 10000;
                var reader = cmd.ExecuteReader();
                int i = reader.FieldCount;
                if (reader.HasRows)
                    while (reader.Read())
                    {
                        productEntity.Id = (Guid)reader["ID"];
                        productEntity.CategoryId = (Guid)reader["CategoryID"];
                        productEntity.ProductName = reader["ProductName"].ToString();
                        productEntity.Price = decimal.Parse(reader["Price"].ToString());
                        productEntity.MadeDate = DateTime.Parse(reader["MadeDate"].ToString());
                        productEntity.ExpireDate = DateTime.Parse(reader["ExpireDate"].ToString());
                        productEntity.Barcode = reader["Barcode"].ToString();
                        productEntity.Active = bool.Parse(reader["Active"].ToString());
                        productEntity.Photo = SelectPicture.GetPhoto("Photo", "PRODUCT", productEntity.Id);
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
            return productEntity;
        }

        public static DataTable FilterListProduct(FilterEntity filterEntity)
        {
            DataTable dataTable = new DataTable();
            StringBuilder query = new StringBuilder();
            query.Append("SELECT p.*, c.CategoryName FROM PRODUCT p INNER JOIN  CATEGORY c ON c.ID=p.CategoryID ")
                .AppendFormat("WHERE (p.ProductName LIKE N'%{0}%' OR c.CategoryName LIKE N'%{0}%' ", filterEntity.Keyword)
                .AppendFormat("OR p.Price LIKE '%{0}%' ", filterEntity.Keyword)
                .AppendFormat("OR p.CreatedBy LIKE '%{0}%' ", filterEntity.Keyword);
               /* .AppendFormat("OR (CONVERT(DATE, MadeDate) >= CONVERT(DATE, '{0}') ", filterEntity.Keyword)
                .AppendFormat("OR (CONVERT(DATE, ExpireDate) >= CONVERT(DATE, '{0}') ", filterEntity.Keyword);*/
                if (filterEntity.FromDate != null && filterEntity.ToDate != null)
                {
                    query.AppendFormat("OR (CONVERT(DATE, p.CreatedDate) >= CONVERT(DATE, '{0}') ", filterEntity.FromDate)
                        .AppendFormat(" AND CONVERT(DATE, p.CreatedDate) <= CONVERT(DATE, '{0}')) ", filterEntity.ToDate);
                }

            query.AppendFormat("AND p.Active = '{0}')", filterEntity.Active);
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

        public static bool CheckExistName(string name)
        {
            bool isExist = false;
            try
            {
                string query = string.Format("SELECT COUNT(*) FROM PRODUCT WHERE ProductName ='{0}' AND Active = 'True'", name);
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

        public static void Insert(ProductEntity productEntity)
        {
            try
            {
                var com = new SqlCommand("INSERT_PRODUCT", Connect.ToDatabase());
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Id", productEntity.Id);
                com.Parameters.AddWithValue("@CategoryId", productEntity.CategoryId);
                com.Parameters.AddWithValue("@ProductName", productEntity.ProductName);
                com.Parameters.AddWithValue("@Price", productEntity.Price);
                com.Parameters.AddWithValue("@MadeDate", productEntity.MadeDate);
                com.Parameters.AddWithValue("@ExpireDate", productEntity.ExpireDate);
                com.Parameters.AddWithValue("@Barcode", productEntity.Barcode);
                com.Parameters.AddWithValue("@Photo", productEntity.Photo);
                com.Parameters.AddWithValue("@Active", productEntity.Active);
                com.Parameters.AddWithValue("@CreatedBy", productEntity.CreatedBy);
                com.Parameters.AddWithValue("@CreatedDate", productEntity.CreatedDate);
                com.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), @"Could not find Stored Procedure", MessageBoxButtons.RetryCancel);
            }
            finally
            {
                if(Connect.ToDatabase().State!=ConnectionState.Closed)
                {
                    Connect.ToDatabase().Close();
                }
            }

        }

        public static void Update(ProductEntity productEntity)
        {
            try
            {
                var com = new SqlCommand("UPDATE_PRODUCT", Connect.ToDatabase());
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Id", productEntity.Id);
                com.Parameters.AddWithValue("@CategoryId", productEntity.CategoryId);
                com.Parameters.AddWithValue("@ProductName", productEntity.ProductName);
                com.Parameters.AddWithValue("@Price", productEntity.Price);
                com.Parameters.AddWithValue("@MadeDate", productEntity.MadeDate);
                com.Parameters.AddWithValue("@ExpireDate", productEntity.ExpireDate);
                com.Parameters.AddWithValue("@Barcode", productEntity.Barcode);
                com.Parameters.AddWithValue("@Photo", productEntity.Photo);
                com.Parameters.AddWithValue("@Active", productEntity.Active);
                com.Parameters.AddWithValue("@UpdatedBy", productEntity.UpdatedBy);
                com.Parameters.AddWithValue("@UpdatedDate", productEntity.UpdatedDate);
                com.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), @"Could not find Stored Procedure", MessageBoxButtons.RetryCancel);
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
