using ProjectManagement.Helper;
using ProjectManagement.Manager;
using ProjectManagement.Product.Dao;
using ProjectManagement.Product.Entity;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace ProjectManagement.Product.View
{
    public partial class FrmProduct : Form
    {
        //Instance Variable
        private Guid productID = Guid.Empty;
        public bool SaveCompleted = false;

        //Constructor with parameter
        public FrmProduct(bool isCanSave = true, Guid? id = null)
        {
            InitializeComponent();
            cboCategory.ValueMember = "ID";
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.DataSource = ProductDao.GetCategoryTocombobox();
            if (id != null)
            {
                productID = (Guid)id;
                ProductEntity productEntity = new ProductEntity();
                productEntity = ProductDao.GetById(id);
                this.Text = this.Text + productID;//Show ID on the top of the form
                txtProductName.Text = productEntity.ProductName;
                txtPrice.Text = productEntity.Price.ToString();
                dtpMadeDate.Text = productEntity.MadeDate.ToString();
                dtpExpireDate.Text = productEntity.ExpireDate.ToString();
                txtBarcode.Text = productEntity.Barcode;
                myPicture1.SetImage(Helpers.ByteArrayToImage(productEntity.Photo));
                chkActive.Checked = productEntity.Active;
                cboCategory.SelectedValue = productEntity.CategoryId;
            }

            btnSaveClose.Enabled = btnSaveNew.Enabled = isCanSave;

        }

        private void FrmProduct_FormClosing(object sender, FormClosingEventArgs e)
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
            //FrmProductList frmProductList = new FrmProductList();
            //frmProductList.Show();
            
        }

        private void BtnSaveNew_Click(object sender, EventArgs e)
        {
            if (!chkActive.Checked)
            {
                Save();
                ClearData();
            }
            else
            {
                if (!ProductDao.CheckExistName(txtProductName.Text))
                {
                    Save();
                    ClearData();
                }
                else
                {
                    MessageBox.Show(@"Product's name was exist", "Try again");
                }
            }
        }

        private void ClearData()
        {
            productID = Guid.Empty;
            txtProductName.Text = txtPrice.Text = txtBarcode.Text = dtpMadeDate.Text=dtpExpireDate.Text = null;
            myPicture1.ClearImage();
            cboCategory.SelectedItem = -1;
        }

        private void Save()
        {
            if (Helpers.CheckEmpty(errorProvider1, txtProductName, txtPrice, dtpMadeDate, dtpExpireDate, txtBarcode))

            {
                return;
            }
            else
            {
                SaveCompleted = true;
                errorProvider1.Clear();
                ProductEntity productEntity = new ProductEntity();
                productEntity.ProductName = txtProductName.Text;
                productEntity.Price = decimal.Parse(txtPrice.Text, NumberStyles.Currency);
                productEntity.Barcode = txtBarcode.Text;
                productEntity.MadeDate = DateTime.Parse(dtpMadeDate.Text);
                productEntity.ExpireDate = DateTime.Parse(dtpExpireDate.Text);
                productEntity.Active = chkActive.Checked;
                productEntity.Photo = myPicture1.GetByteArrayFromBrowse();
                productEntity.CategoryId = (Guid)cboCategory.SelectedValue;

                if (productID != Guid.Empty)
                {
                    productEntity.Id = productID;
                    productEntity.Update(USER.UserName);
                    ProductDao.Update(productEntity);
                }
                else
                {
                    productEntity.Id = Guid.NewGuid();
                    productEntity.Create(USER.UserName);
                    ProductDao.Insert(productEntity);
                }
            }
        }

        private void BtnSaveClose_Click(object sender, EventArgs e)
        {
            if (!chkActive.Checked)
            {
                Save();
                this.Close();
            }
            else
            {
                if (!ProductDao.CheckExistName(txtProductName.Text))
                {
                    Save();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(@"Product's name was exist", "Try again");
                }
            }
        }

        private void TxtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            decimal x;
            char ch = e.KeyChar;
            if (ch == (char)8)
                e.Handled = false;
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(txtPrice.Text + ch, out x))
                e.Handled = true;
        }

        private void TxtPrice_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPrice.Text) || !string.IsNullOrWhiteSpace(txtPrice.Text))
                txtPrice.Text = string.Format("{0:C}", decimal.Parse(txtPrice.Text));
        }

        private void TxtPrice_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPrice.Text) || !string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                var s = decimal.Parse(txtPrice.Text, NumberStyles.Currency);
                txtPrice.Text = s.ToString();
            }

        }
    }
  }
