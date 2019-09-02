using ProjectTesting.Category.Dao;
using ProjectTesting.Category.Entity;
using ProjectTesting.Helper;
using System;
using System.Data;
using System.Data.SqlClient;
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

        private void BtnSaveClose_Click(object sender, EventArgs e)
        {
        }
    }
}