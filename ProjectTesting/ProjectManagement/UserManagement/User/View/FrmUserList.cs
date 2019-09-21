using System;
using System.ComponentModel;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using ProjectManagement.BaseObject;
using ProjectManagement.Company.Dao;
using ProjectManagement.Manager;
using ProjectManagement.UserManagement.User.Dao;

namespace ProjectManagement.UserManagement.User.View
{
    public partial class FrmUserList : Form
    {
        public FrmUserList()
        {
            InitializeComponent();
            gridList.RootTable.Columns["CreatedDate"].FormatString = String.Format("dd/MM/yyyy");
            gridList.RootTable.Columns["UpdatedDate"].FormatString = String.Format("dd/MM/yyyy");
            LoadData();
            ctmsMenuBar.Opening += CtmsMenuBarOnOpening;
        }

        private void CtmsMenuBarOnOpening(object sender, CancelEventArgs cancelEventArgs)
        {
            GridEXRow currentRow = gridList.GetRow();
            btnNew.Enabled = MANAGE_ROLE.ALLOW_ADD_COMPANY;
            if (currentRow == null)
            {
                btnView.Enabled = btnEdit.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = MANAGE_ROLE.ALLOW_EDIT_COMPANY;
                btnView.Enabled = MANAGE_ROLE.ALLOW_VIEW_COMPANY;
            }
        }

        private void FrmCompanyList_Load(object sender, EventArgs e)
        {
            dtpFrom.Enabled = dtpTo.Enabled = false;
            // LoadData();
        }

        public void LoadData()
        {
            FilterEntity filterEntity = new FilterEntity();
            if (rdoAllDays.Checked)
            {
                filterEntity.FromDate = null;
                filterEntity.ToDate = null;
            }
            else if (rdoByDate.Checked)
            {
                filterEntity.FromDate = dtpFrom.Value;
                filterEntity.ToDate = dtpTo.Value;
            }
            if (rdoActive.Checked)
            {
                filterEntity.Active = true;
            }
            else if (rdoInactive.Checked)
            {
                filterEntity.Active = false;
            }
            filterEntity.Keyword = txtKeyword.Text;
            gridList.DataSource = UserDao.FilterListUser(filterEntity);
            gridList.Refresh();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
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
            FrmUser frmUser = new FrmUser();
            frmUser.ShowDialog();
            if (frmUser.SaveCompleted)
            {
                LoadData();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            GridEXRow currentRow = gridList.GetRow();
            if (currentRow != null || currentRow.RowType == RowType.Record)
            {
                Guid id = Guid.Parse(currentRow.Cells["ID"].Value.ToString());
                FrmUser frmUser = new FrmUser(true, id);
                frmUser.ShowDialog();
                if (frmUser.SaveCompleted)
                {
                    LoadData();
                }
            }
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            GridEXRow currentRow = gridList.GetRow();
            if (currentRow != null || currentRow.RowType == RowType.Record)
            {
                Guid id = Guid.Parse(currentRow.Cells["ID"].Value.ToString());
                FrmUser frmUser = new FrmUser(false, id);
                frmUser.ShowDialog();
            }
        }
    }
}