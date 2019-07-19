using ProjectTesting.Helper;
using ProjectTesting.Product.Dao;
using ProjectTesting.Product.Entity;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace ProjectTesting.Product.View
{
    public partial class FrmProduct : Form
    {
        private Guid getId = Guid.Empty;
        private byte[] pic = null;

        public FrmProduct(Guid? id = null)
        {
            InitializeComponent();
            if (id != null)
            {
                getId = Guid.Parse(id.ToString());
                DataTable dt = ProductDao.GetProductById(getId);
                if (dt != null)
                {
                    txtName.Text = dt.Rows[0]["Name"].ToString();
                    txtPrice.Text = dt.Rows[0]["Price"].ToString();
                    dtpMadeDate.Value = DateTime.Parse(dt.Rows[0]["MadeDate"].ToString());
                    dtpExpiredDate.Value = DateTime.Parse(dt.Rows[0]["ExpiredDate"].ToString());
                    pic = ProductDao.GetPhoto(getId);
                    picProduct.Image = Helpers.ByteArrayToImage(pic);
                }
            }
        }

        private void TxtPrice_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPrice.Text) ||
               !string.IsNullOrWhiteSpace(txtPrice.Text))
                txtPrice.Text = string.Format("{0:C}", decimal.Parse(txtPrice.Text));
        }

        private void TxtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            decimal x;
            char ch = e.KeyChar;
            if (ch == (char)8) //backspace
                e.Handled = false;
            else if (!char.IsDigit(ch) && ch != '.' ||
                    !Decimal.TryParse(txtPrice.Text + ch, out x))
                e.Handled = true;
        }

        private void TxtPrice_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPrice.Text) ||
                !string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                var s = decimal.Parse(txtPrice.Text, NumberStyles.Currency);
                txtPrice.Text = s.ToString();
            }
        }

        private void PicProduct_Click(object sender, EventArgs e)
        {
            string fp;
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "JPEG FILE| *.jpg; *.jpeg|PNG FILE|*.png|BMP FILE|*.bmp";
            fd.Title = "Open an image";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                fp = fd.FileName;
                picProduct.Image = Image.FromFile(fp);
                pic = Helpers.StringToByteArray(fp);
            }
        }

        private void BtnSaveNew_Click(object sender, EventArgs e)
        {
        }

        private void Save()
        {
            ProductEntity productEntity = new ProductEntity();
            productEntity.Name = txtName.Text;
            productEntity.Price = decimal.Parse(Helpers.CurrencyToString(txtPrice.Text).ToString());
            productEntity.MadeDate = DateTime.Parse(dtpMadeDate.Value.ToString("dd/MM/yyyy"));
            productEntity.ExpiredDate = DateTime.Parse(dtpExpiredDate.Value.ToString("dd/MM/yyyy"));
            productEntity.Active = chkActive.Checked;
            productEntity.Photo = pic;
            if (getId != Guid.Empty)
            {
                productEntity.Id = getId;
                ProductDao.Update(productEntity);
            }
            else
            {
                productEntity.Id = Guid.NewGuid();
                ProductDao.Insert(productEntity);
            }
        }

        private void BtnSaveClose_Click(object sender, EventArgs e)
        {
            Save();
            this.Close();
        }
    }
}