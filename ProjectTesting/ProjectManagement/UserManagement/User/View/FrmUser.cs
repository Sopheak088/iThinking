using ProjectManagement.Company.Dao;
using ProjectManagement.Company.Entity;
using ProjectManagement.Helper;
using System;
using System.Windows.Forms;
using ProjectManagement.Manager;
using ProjectManagement.UserManagement.User.Dao;
using ProjectManagement.UserManagement.User.Entity;

namespace ProjectManagement.UserManagement.User.View
{
    public partial class FrmUser : Form
    {
        private Guid userID = Guid.Empty;
        public bool SaveCompleted = false;

        public FrmUser(bool isCanSave = true, Guid? id = null)
        {
            InitializeComponent();
            cboBranch.ValueMember = "ID";
            cboBranch.DisplayMember = "Name";
            cboBranch.DataSource = UserDao.GetBranchToComboBox();
            if (id != null)
            {
                userID = (Guid)id;
                UserEntity userEntity = new UserEntity();
                userEntity = UserDao.GetById(id);
                this.Text = this.Text + userID;
                txtFirstName.Text = userEntity.FirstName;
                txtLastName.Text = userEntity.LastName;
                txtUsername.Text = userEntity.Username;
                txtPassword.Text = StringCipher.Decrypt(userEntity.Password);
                txtPosition.Text = userEntity.Position;
                txtPhone.Text = userEntity.Phone;
                chkActive.Checked = userEntity.Active;
                cboBranch.SelectedValue = userEntity.BranchId;
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
                if (!UserDao.CheckExistName(txtPosition.Text))
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
            if (Helpers.CheckEmpty(errorProvider1, txtFirstName, txtLastName, txtUsername,
                txtPassword, txtPosition))
            {
                return;
            }
            else
            {
                SaveCompleted = true;
                errorProvider1.Clear();
                UserEntity userEntity = new UserEntity();
                userEntity.LastName = txtLastName.Text;
                userEntity.FirstName = txtFirstName.Text;
                userEntity.Username = txtUsername.Text;
                userEntity.Password = StringCipher.Encrypt(txtPassword.Text);
                userEntity.Position = txtPosition.Text;
                userEntity.Phone = txtPhone.Text;
                userEntity.Active = chkActive.Checked;
                userEntity.BranchId = (Guid)cboBranch.SelectedValue;

                if (userID != Guid.Empty)
                {
                    userEntity.Id = userID;
                    userEntity.Update(USER.UserName);
                    UserDao.Update(userEntity);
                }
                else
                {
                    userEntity.Id = Guid.NewGuid();
                    userEntity.Create(USER.UserName);
                    UserDao.Insert(userEntity);
                }
            }
        }

        private void ClearData()
        {
            cboBranch.SelectedIndex = -1;
            userID = Guid.Empty;
            txtPhone.Text = txtPassword.Text = txtLastName.Text = txtFirstName.Text = txtUsername.Text = txtPosition.Text = null;
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
                if (!UserDao.CheckExistName(txtPosition.Text))
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