using System;
using System.Windows.Forms;
using ProjectManagement.BaseObject;
using ProjectManagement.UserAccount.User.Dao;

namespace ProjectManagement.UserAccount.User.View
{
    public partial class FrmUserList : Form
    {
        public FrmUserList()
        {
            InitializeComponent();
        }

        private void FrmUserList_Load(object sender, EventArgs e)
        {
            dtpFrom.Enabled = dtpTo.Enabled = false;
            UserDao.ListAllUser();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            FilterEntity filterEntity = new FilterEntity();
            if (rdoAllDays.Checked)
            {
                filterEntity.FromDate = null;
                filterEntity.ToDate = null;
            }
            else if (rdoActive.Checked)
            {
                filterEntity.FromDate = dtpFrom.Value;
                filterEntity.ToDate = dtpTo.Value;
            }
            if (rdoActive.Checked)
            {
                filterEntity.Active = rdoActive.Checked;
            }
            else if (rdoInactive.Checked)
            {
                filterEntity.Active = rdoInactive.Checked;
            }
            filterEntity.Keyword = txtKeyword.Text;
            UserDao.FilterListAllUser(filterEntity);
        }

        private void RdoAllDays_CheckedChanged(object sender, EventArgs e)
        {
            dtpFrom.Enabled = dtpTo.Enabled = false;
        }

        private void RdoByDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpFrom.Enabled = dtpTo.Enabled = true;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            BtnSearch_Click(sender, e);
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            FrmUser frm = new FrmUser();
            frm.ShowDialog();
        }
    }
}