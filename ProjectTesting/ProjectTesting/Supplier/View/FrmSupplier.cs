using ProjectTesting.Helper;
using ProjectTesting.Supplier.Dao;
using ProjectTesting.Supplier.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTesting.Supplier.View
{
    public partial class FrmSupplier : Form
    {
        public FrmSupplier(Guid? ID = null)
        {
            InitializeComponent();
            if (ID != null)
            {
                getID = Guid.Parse(ID.ToString());
                DataTable dt = SupplierDao.GetSupplierById(getID);
                if (dt != null)
                {
                    txtName.Text = dt.Rows[0]["Name"].ToString();
                    txtPhone.Text = dt.Rows[0]["Phone"].ToString();
                    txtDescritp.Text = dt.Rows[0]["Descript"].ToString();

                    pic = SupplierDao.GetPhoto(getID);
                    if (pic != null)
                        picSupplier.Image = Helpers.ByteArrayToImage(pic);
                }
            }
        }

        private Guid getID = Guid.Empty;
        private byte[] pic = null;

        private void Save()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtDescritp.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) || picSupplier.Image == null)
            {
                MessageBox.Show("Please  input some data!!");
                return;
            }
            SupplierEntity supplierEntity = new SupplierEntity();
            supplierEntity.Name = txtName.Text;
            supplierEntity.Phone = txtPhone.Text;
            supplierEntity.Descritp = txtDescritp.Text;
            supplierEntity.Photo = pic;
            if (getID != Guid.Empty)
            {
                supplierEntity.ID = getID;
                SupplierDao.Update(supplierEntity);
            }
            else
            {
                supplierEntity.ID = Guid.NewGuid();
                SupplierDao.Insert(supplierEntity);
            }
        }

        private void FrmSupplier_Load(object sender, EventArgs e)
        {
        }

        private void BtnSaveNew_Click(object sender, EventArgs e)
        {
            Save();
            getID = Guid.Empty;
            pic = null;
            txtName.Text = txtPhone.Text = txtDescritp.Text = null;
            picSupplier.Image = null;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmListAllSupplier frm = new FrmListAllSupplier();
            frm.ShowDialog();
            this.Close();
        }

        private void PicSupplier_Click(object sender, EventArgs e)
        {
            string fp;
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "JPEG FILE| *.jpg; *.jpeg|PNG FILE|*.png|BMP FILE|*.bmp";
            fd.Title = "Open an image";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                fp = fd.FileName;
                picSupplier.Image = Image.FromFile(fp);
                pic = Helpers.StringToByteArray(fp);
            }
        }

        private void BtnSaveClose_Click(object sender, EventArgs e)
        {
            Save();
            BtnClose_Click(sender, e);
        }
    }
}