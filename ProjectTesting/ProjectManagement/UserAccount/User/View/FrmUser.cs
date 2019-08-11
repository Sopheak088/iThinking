using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectManagement.Helper;

namespace ProjectManagement.UserAccount.User.View
{
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
        }

        private void FrmUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to close?", "Close User",
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
            Save();
            string text = StringCipher.Encrypt(txtPassword.Text);
            MessageBox.Show(text);
        }

        private void Save()
        {
            if (Helpers.CheckEmpty(errorProvider1, txtFirstName, txtLastName, txtUseName,
                txtPassword, txtPhone, cboPosition))
            {
                return;
            }
        }
    }
}