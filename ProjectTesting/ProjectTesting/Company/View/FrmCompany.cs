using ProjectTesting.Company.Dao;
using ProjectTesting.Company.Entity;
using ProjectTesting.Helper;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectTesting.Company.View
{
    public partial class FrmCompany : Form
    {
        private Guid getId = Guid.Empty;
        private byte[] pic = null;
        public FrmCompany(Guid? id = null)
        {
            InitializeComponent();
            if (id != null)
            {
                getId = Guid.Parse(id.ToString());
                DataTable dt = CompanyDao.GetCompanyById(getId);
                if (dt != null)
                {
                    txtName.Text = dt.Rows[0]["Name"].ToString();
                    txtLocation.Text = dt.Rows[0]["Location"].ToString();
                    txtEmail.Text = dt.Rows[0]["Email"].ToString();
                    txtTel.Text = dt.Rows[0]["Telephone"].ToString();
                    txtFax.Text = dt.Rows[0]["Fax"].ToString();
                    txtBranch.Text = dt.Rows[0]["Branch"].ToString();
                    pic = CompanyDao.GetLogo(getId);
                    if (pic != null)
                        picCompany.Image = Helpers.ByteArrayToImage(pic);
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCompanyList frm = new FrmCompanyList();
            frm.ShowDialog();
            this.Close();
        }

        private void Save()
        {
            CompanyEntity comEntity = new CompanyEntity();
            comEntity.Name = txtName.Text;
            comEntity.Location = txtLocation.Text;
            comEntity.Email = txtEmail.Text;
            comEntity.Telephone = txtTel.Text;
            comEntity.Fax = txtFax.Text;
            comEntity.Branch = int.Parse(txtBranch.Text);
            comEntity.Logo = pic;
            if (getId != Guid.Empty)
            {
                comEntity.Id = getId;
               // CompanyDao.Update(comEntity);
            }
            else
            {
                comEntity.Id = Guid.NewGuid();
               // CompanyDao.Insert(comEntity);
            }
        }

        private void BtnSaveNew_Click(object sender, EventArgs e)
        {
            Save();
            getId = Guid.Empty;
            pic = null;
            txtName.Text = txtLocation.Text = txtEmail.Text = txtTel.Text = txtFax.Text = txtBranch.Text = null;
            picCompany.Image = null;
        }

        private void BtnSaveClose_Click(object sender, EventArgs e)
        {
            Save();
            BtnClose_Click(sender, e);
        }

        private void PicCompany_Click(object sender, EventArgs e)
        {
            string fp;
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "JPEG FILE| *.jpg; *.jpeg|PNG FILE|*.png|BMP FILE|*.bmp";
            fd.Title = "Open an image";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                fp = fd.FileName;
                picCompany.Image = Image.FromFile(fp);
                pic = Helpers.StringToByteArray(fp);

            }
        }
    }
}
