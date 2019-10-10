using ProjectManagement.Branch.Dao;
using ProjectManagement.Branch.Entity;
using ProjectManagement.Company.Dao;
using ProjectManagement.Company.Entity;
using ProjectManagement.Helper;
using ProjectManagement.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagement.Branch.View
{
    public partial class FrmBranch : Form
    {
        private Guid BranchID = Guid.Empty;
        public bool SaveCompleted = false;

        public FrmBranch(bool isCanSave = true, Guid? id = null)
        {
            InitializeComponent();
            cboCompany.ValueMember = "ID";
            cboCompany.DisplayMember = "NameInEnglish";
            cboCompany.DataSource = BranchDao.GetCompanyToComboBox();
            if (id != null)
            {
                BranchID = (Guid)id;
                BranchEntity branchEntity = new BranchEntity();
                branchEntity = BranchDao.GetById(id);
                this.Text = this.Text + BranchID;
                txtName.Text = branchEntity.Name;
                txtEmail.Text = branchEntity.Email;
                txtPhone.Text = branchEntity.Phone;
                txtLocation.Text =branchEntity.Location;
                //myPicture1.SetImage(Helpers)
                chkActive.Checked = branchEntity.Active;
                cboCompany.SelectedValue = branchEntity.CompanyId;

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

        private void BtnSaveClose_Click(object sender, EventArgs e)
        {
            if (!chkActive.Checked)
            {
                Save();
                this.Close();
            }
            else
            {
                Save();
                this.Close();
            }
        }
        private void ClearData()
        {
            BranchID = Guid.Empty;
            txtPhone.Text = txtName.Text = txtEmail.Text = txtLocation.Text = null;
            
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
                if (!BranchDao.CheckExistName(txtName.Text))
                {
                    Save();
                    ClearData();
                }
                else
                {
                    MessageBox.Show(@"Branch's name was exist", "Try again");
                }
            }
        }
        private void Save()
        {
            if (Helpers.CheckEmpty(errorProvider1, txtName, txtEmail, txtPhone, txtLocation))
            {
                return;
            }
            else
            {
                SaveCompleted = true;
                errorProvider1.Clear();
                BranchEntity branchEntity = new BranchEntity();
                branchEntity.Name = txtName.Text;
                branchEntity.Email = txtEmail.Text;
                branchEntity.Phone = txtPhone.Text;
                branchEntity.Location = txtLocation.Text;
                branchEntity.Active = chkActive.Checked;
                branchEntity.CompanyId= (Guid)cboCompany.SelectedValue;

                if (BranchID != Guid.Empty)
                {
                    branchEntity.Id = BranchID;
                    branchEntity.Update(USER.UserName);
                    BranchDao.Update(branchEntity);
                }
                else
                {
                    branchEntity.Id = Guid.NewGuid();
                    branchEntity.Create(USER.UserName);
                    BranchDao.Insert(branchEntity);
                }
            }

        }
            private void FrmBranch_Load(object sender, EventArgs e)
        {

        }
    }
    
}

