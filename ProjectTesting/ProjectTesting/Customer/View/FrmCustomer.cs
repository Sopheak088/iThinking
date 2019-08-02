using ProjectTesting.Customer.Dao;
using ProjectTesting.Customer.Entity;
using ProjectTesting.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTesting.Customer.View
{
    public partial class FrmCustomer : Form

    {
        public FrmCustomer(Guid? id = null)
        {
            InitializeComponent();

            if (id != null)
            {
                getId = Guid.Parse(id.ToString());
                DataTable dt = CustomerDao.GetCustomerById(getId);
                if (dt != null)
                {
                    txtName.Text = dt.Rows[0]["Name"].ToString();
                    txtPhone.Text = dt.Rows[0]["Phone"].ToString();

                    pic = CustomerDao.GetPhoto(getId);
                    if (pic != null)
                        picCustomer.Image = Helpers.ByteArrayToImage(pic);
                }
            }
        }

        private Guid getId = Guid.Empty;
        private byte[] pic = null;

        private void picCustomer_Click(object sender, EventArgs e)
        {
            string fp;
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "JPEG FILE| *.jpg; *.jpeg|PNG FILE|*.png|BMP FILE|*.bmp";
            fd.Title = "Open an image";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                fp = fd.FileName;
                picCustomer.Image = Image.FromFile(fp);
                pic = Helpers.StringToByteArray(fp);
            }
        }

        private void Save()
        {
            CustomerEntity customerEntity = new CustomerEntity();
            customerEntity.Name = txtName.Text;
            customerEntity.Phone = txtPhone.Text;
            customerEntity.Photo = pic;
            if (getId != Guid.Empty)
            {
                customerEntity.Id = getId;
                CustomerDao.Update(customerEntity);
            }
            else
            {
                customerEntity.Id = Guid.NewGuid();
                CustomerDao.Insert(customerEntity);
            }
        }

        private void BtnSaveNew_Click(object sender, EventArgs e)
        {
            Save();
            getId = Guid.Empty;
            pic = null;
            txtName.Text = txtPhone.Text = null;
            picCustomer.Image = null;
        }

        private void BtnSaveClose_Click(object sender, EventArgs e)
        {
            Save();
            BtnClose_Click(sender, e);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCustomerList frm = new FrmCustomerList();
            frm.ShowDialog();
            //this.Close();
        }
    }
}