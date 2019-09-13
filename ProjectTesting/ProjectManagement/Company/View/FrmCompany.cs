using ProjectManagement.Company.Dao;
using ProjectManagement.Company.Entity;
using ProjectManagement.Helper;
using System;
using System.Windows.Forms;
using ProjectManagement.Manager;

namespace ProjectManagement.Company.View
{
    public partial class FrmCompany : Form
    {
        private Guid companyID = Guid.Empty;
        public bool SaveCompleted = false;

        public FrmCompany(bool isCanSave = true, Guid? id = null)
        {
            InitializeComponent();
            if (id != null)
            {
                companyID = (Guid)id;
                CompanyEntity companyEntity = new CompanyEntity();
                companyEntity = CompanyDao.GetById(id);
                this.Text = this.Text + companyID;
                txtNameInKhmer.Text = companyEntity.NameInKhmer;
                txtNameInEnglish.Text = companyEntity.NameInEnglish;
                txtEmail.Text = companyEntity.Email;
                txtPhone.Text = companyEntity.Phone;
                txtLocation.Text = companyEntity.Location;
                myPicture1.SetImage(Helpers.ByteArrayToImage(companyEntity.Logo));
                chkActive.Checked = companyEntity.Active;
            }

            btnSaveClose.Enabled = btnSaveNew.Enabled = isCanSave;
        }

        private void FrmUser_FormClosing(object sender, FormClosingEventArgs e)
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

        private void BtnSaveNew_Click(object sender, EventArgs e)
        {
            if (!chkActive.Checked)
            {
                Save();
                ClearData();
            }
            else
            {
                if (!CompanyDao.CheckExistName(txtNameInEnglish.Text))
                {
                    Save();
                    ClearData();
                }
                else
                {
                    MessageBox.Show(@"Company's name was exist", "Try again");
                }
            }
        }

        private void Save()
        {
            if (Helpers.CheckEmpty(errorProvider1, txtNameInKhmer, txtNameInEnglish, txtEmail,
                txtPhone, txtLocation))
            {
                return;
            }
            else
            {
                SaveCompleted = true;
                errorProvider1.Clear();
                string text = StringCipher.Encrypt(txtPhone.Text);
                CompanyEntity companyEntity = new CompanyEntity();
                companyEntity.NameInEnglish = txtNameInEnglish.Text;
                companyEntity.NameInKhmer = txtNameInKhmer.Text;
                companyEntity.Email = txtEmail.Text;
                companyEntity.Phone = txtPhone.Text;
                companyEntity.Location = txtLocation.Text;
                companyEntity.Active = chkActive.Checked;
                companyEntity.Logo = myPicture1.GetByteArrayFromBrowse();

                if (companyID != Guid.Empty)
                {
                    companyEntity.Id = companyID;
                    companyEntity.Update(USER.UserName);
                    CompanyDao.Update(companyEntity);
                }
                else
                {
                    companyEntity.Id = Guid.NewGuid();
                    companyEntity.Create(USER.UserName);
                    CompanyDao.Insert(companyEntity);
                }
            }
        }

        private void ClearData()
        {
            companyID = Guid.Empty;
            txtPhone.Text = txtNameInEnglish.Text = txtNameInKhmer.Text = txtEmail.Text = txtLocation.Text = null;
            myPicture1.ClearImage();
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
                if (!CompanyDao.CheckExistName(txtNameInEnglish.Text))
                {
                    Save();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(@"Company's name was exist", "Try again");
                }
            }
        }
    }
}