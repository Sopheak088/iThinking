using Janus.Windows.GridEX;
using ProjectManagement.BaseObject;
using ProjectManagement.Branch.Dao;
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
    public partial class FrmBranchList : Form
    {
        public FrmBranchList()
        {
            InitializeComponent();
            gridList.RootTable.Columns["CreatedDate"].FormatString = String.Format("dd/MM/yyyy");
            gridList.RootTable.Columns["UpdatedDate"].FormatString = String.Format("dd/MM/yyyy");
            LoadData();
            ctmMenu.Opening += CtmMenu_Opening;

        }

        private void CtmMenu_Opening(object sender, CancelEventArgs e)
        {
            GridEXRow currentRow = gridList.GetRow();
            btnNew.Enabled = MANAGE_ROLE.ALLOW_ADD_BRANCH;
            if (currentRow == null)
            {
                btnView.Enabled = btnEdit.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = MANAGE_ROLE.ALLOW_EDIT_BRANCH;
                btnView.Enabled = MANAGE_ROLE.ALLOW_VIEW_BRANCH;
            }
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
            gridList.DataSource = BranchDao.FilterListBranch(filterEntity);
            gridList.Refresh();
        }

        private void FrmBranchList_Load(object sender, EventArgs e)
        {
            dtpFrom.Enabled = dtpTo.Enabled = false;
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
            dtpFrom.Enabled = dtpTo.Enabled = false;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            BtnSearch_Click(sender, e);
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            FrmBranch frmBranch = new FrmBranch();
            frmBranch.ShowDialog();
            if (frmBranch.SaveCompleted)
            {
                LoadData();
            }
        }

        private void TxtKeyword_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            GridEXRow currentRow = gridList.GetRow();
            if (currentRow != null || currentRow.RowType == RowType.Record)
            {
                Guid id = Guid.Parse(currentRow.Cells["ID"].Value.ToString());
                FrmBranch frmBranch  = new FrmBranch(true, id);
                frmBranch.ShowDialog();
                if (frmBranch.SaveCompleted)
                {
                    LoadData();
                }
            }
        }
       

        private void BtnView_Click_1(object sender, EventArgs e)
        {
            GridEXRow currentRow = gridList.GetRow();
            if (currentRow != null || currentRow.RowType == RowType.Record)
            {
                Guid id = Guid.Parse(currentRow.Cells["ID"].Value.ToString());
                FrmBranch frmBranch = new FrmBranch(false, id);
                frmBranch.ShowDialog();
            }
        }
    }
}
