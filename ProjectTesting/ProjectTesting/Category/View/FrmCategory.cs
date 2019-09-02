using ProjectTesting.Category.Dao;
using ProjectTesting.Category.Entity;
using ProjectTesting.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTesting.Category.View
{
    public partial class FrmCategory : Form
    {
        private Guid getID = Guid.Empty;

        public FrmCategory(Guid? ID = null)
        {
            InitializeComponent();
            if (ID != null)
            {
                getID = Guid.Parse(ID.ToString());
                DataTable dt = CategoryDao.GetCategoryById(getID);
                if (dt != null)
                {
                    txtCategory.Text = dt.Rows[0]["Category"].ToString();
                    txtDes.Text = dt.Rows[0]["Des"].ToString();
                }
            }
        }

        private void Save()
        {
            CategoryEntity categoryEntity = new CategoryEntity();
            categoryEntity.Category = txtCategory.Text;
            categoryEntity.Des = txtDes.Text;

            if (getID != Guid.Empty)
            {
                categoryEntity.ID = getID;
                CategoryDao.Update(categoryEntity);
            }
            else
            {
                categoryEntity.ID = Guid.NewGuid();
                CategoryDao.Insert(categoryEntity);
            }
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
        }

        private void BtnSaveNew_Click(object sender, EventArgs e)
        {
            Save();
            getID = Guid.Empty;
            txtCategory.Text = txtDes.Text = null;
        }

        public static DataTable ListAllProductByName(string search)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("SearchCustomerByName", Connection.ToDatabase());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", search);
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

        private void BtnSaveClose_Click(object sender, EventArgs e)
        {
        }
    }
}