using ProjectManagement.Customer.Dao;
using ProjectManagement.Customer.Entity;
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

namespace ProjectManagement.Customer.View
{
    public partial class FrmCustomer : Form
    {
        private Guid CustomerID = Guid.Empty;
        public bool SaveCompleted = false;

        public FrmCustomer(bool isCanSave = true, Guid? id = null)
        {
            InitializeComponent();
            cboMemberShip.ValueMember = "ID";
            cboMemberShip.DisplayMember = "MembershipType";
            cboMemberShip.DataSource = CustomerDao.GetMemberShipToComboBox();
            if (id != null)
            {
                CustomerID = (Guid)id;
                CustomerEntity customerEntity = new CustomerEntity();
                customerEntity = CustomerDao.GetByID(id);
                this.Text = this.Text + CustomerID;
                txtCustomerName.Text = customerEntity.CustomerName;
                txtGender.Text = customerEntity.Gender;
                txtAddress.Text = customerEntity.Address;
                picCustomer.SetImage(Helpers.ByteArrayToImage(customerEntity.Photo));
                txtOtherContact.Text = customerEntity.OtherContact;
                chkActive.Checked = customerEntity.Active;
                cboMemberShip.SelectedValue = customerEntity.MemberShipID;
            }
            btnSaveClose.Enabled = btnSaveNew.Enabled = isCanSave;
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
        }

        private void BtnSaveNew_Click(object sender, EventArgs e)
        {
            Save();
            ClearData();
        }

        private void Save()
        {
            if (Helpers.CheckEmpty(errorProvider1, txtCustomerName, txtGender, txtAddress, lblOtherContact))
            {
                return;
            }
            else
            {
                SaveCompleted = true;
                errorProvider1.Clear();
                //string text = StringCipher.Encrypt
                CustomerEntity customerEntity = new CustomerEntity();
                customerEntity.CustomerName = txtCustomerName.Text;
                customerEntity.Gender = txtGender.Text;
                customerEntity.Address = txtAddress.Text;
                customerEntity.Photo = picCustomer.GetByteArrayFromBrowse();
                customerEntity.Active = chkActive.Checked;
                customerEntity.MemberShipID = (Guid)cboMemberShip.SelectedValue;
                customerEntity.OtherContact = txtOtherContact.Text;
                if (CustomerID != Guid.Empty)
                {
                    customerEntity.ID = CustomerID;
                    customerEntity.Update(USER.UserName);
                    CustomerDao.Update(customerEntity);
                }
                else
                {
                    customerEntity.ID = Guid.NewGuid();
                    customerEntity.Create(USER.UserName);
                    CustomerDao.Insert(customerEntity);
                }
            }
        }

        private void BtnSaveClose_Click(object sender, EventArgs e)
        {
            Save();
            this.Close();
        }

        private void ClearData()
        {
            CustomerID = Guid.Empty;
            txtAddress.Text = txtCustomerName.Text = txtGender.Text = lblOtherContact.Text = null;
            picCustomer.ClearImage();
            cboMemberShip.SelectedIndex = -1;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCustomer_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(@"Are you sure to close?", "Close",
                    MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}