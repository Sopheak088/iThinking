using ProjectTesting.User.Dao;
using ProjectTesting.User.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTesting.User.View
{
    public partial class FrmUser : Form
    {
        private Guid getId = Guid.Empty;

        public FrmUser(Guid? id = null)
        {
            InitializeComponent();

            if (id != null)
            {
                getId = Guid.Parse(id.ToString());
                DataTable dt = UserDao.GetUserById(getId);
                if (dt != null)
                {
                    txtUserName.Text = dt.Rows[0]["UserName"].ToString();
                    txtPassword.Text = dt.Rows[0]["UserPassword"].ToString();
                    txtPosition.Text = dt.Rows[0]["Position"].ToString();
                }
            }
        }

        private void Save()
        {
            UserEntity userEntity = new UserEntity();
            userEntity.UserName = txtUserName.Text;
            userEntity.UserPassword = txtPassword.Text;
            userEntity.Position = txtPosition.Text;

            if (getId != Guid.Empty)
            {
                userEntity.ID = getId;
                UserDao.Update(userEntity);
            }
            else
            {
                userEntity.ID = Guid.NewGuid();
                UserDao.Insert(userEntity);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUserList frm = new FrmUserList();
            frm.ShowDialog();
            this.Close();
        }

        private void BtnSaveNew_Click(object sender, EventArgs e)
        {
            Save();
            //MessageBox.Show("Data was saved");
            getId = Guid.Empty;

            txtUserName.Text = txtPassword.Text = txtPosition.Text = null;
        }

        private void BtnSaveClose_Click(object sender, EventArgs e)
        {
            Save();
            getId = Guid.Empty;
            this.Hide();
            FrmUserList frm = new FrmUserList();
            frm.ShowDialog();
            this.Close();
        }
    }
}