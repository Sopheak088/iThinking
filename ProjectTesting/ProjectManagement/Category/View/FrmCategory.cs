using ProjectManagement.Category.Dao;
using ProjectManagement.Category.Entity;
using ProjectManagement.Helper;
using ProjectManagement.Manager;
using System;
using System.Windows.Forms;

namespace ProjectManagement.Category.View
{
    public partial class FrmCategory : Form
    {
        private Guid categoryID = Guid.Empty;
        public bool SaveCompleted = false;
        public FrmCategory(bool isCansave = true, Guid? id = null)
        {
            InitializeComponent();
            if (id != null)
            {
                //*Note
                categoryID = (Guid)id;
                CategoryEntity categoryEntity = new CategoryEntity();
                categoryEntity = CategoryDao.GetById(id);
                this.Text = this.Text + categoryID;
                txtName.Text = categoryEntity.CategoryName;
                txtOther.Text = categoryEntity.Other;
            }
            btnSaveClose.Enabled = btnSaveNew.Enabled = isCansave;
        }

        private void FrmCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(@"Are you sure to close?", "Close",
                    MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearData()
        {
            categoryID = Guid.Empty;
            txtName.Text = txtOther.Text = null;
        }

        private void Save()
        {
            //Note*
            if (Helpers.CheckEmpty(errorProvider1, txtName, txtOther))
            {
                return;
            }
            else
            {
                SaveCompleted = true;
                errorProvider1.Clear();
                CategoryEntity categoryEntity = new CategoryEntity();
                categoryEntity.CategoryName = txtName.Text;
                categoryEntity.Other = txtOther.Text;
                if (categoryID != Guid.Empty)
                {
                    categoryEntity.Id = categoryID;
                    categoryEntity.Update(USER.UserName);
                    CategoryDao.Update(categoryEntity);
                }
                else
                {
                    categoryEntity.Id = Guid.NewGuid();
                    categoryEntity.Create(USER.UserName);
                    CategoryDao.Insert(categoryEntity);
                }
            }
        }
        private void BtnSaveNew_Click(object sender, EventArgs e)
        {
            if (!CategoryDao.CheckExistName(txtName.Text))
            {
                Save();
                ClearData();
            }
            else
            {
                MessageBox.Show(@"Category's Name Was Already Exist!", "Try Once Again!");
            }
        }

        private void BtnSaveClose_Click(object sender, EventArgs e)
        {
            if (!CategoryDao.CheckExistName(txtName.Text))
            {
                Save();
                this.Close();
            }
            else
            {
                MessageBox.Show(@"Category's Name Was Already Exist!", "Try Once Again!");
            }
        }
    }
}
