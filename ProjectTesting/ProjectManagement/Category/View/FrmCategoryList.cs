using Janus.Windows.GridEX;
using ProjectManagement.BaseObject;
using ProjectManagement.Category.Dao;
using ProjectManagement.Manager;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ProjectManagement.Category.View
{
    public partial class FrmCategoryList : Form
    {
        public FrmCategoryList()
        {
            InitializeComponent();
            LoadData();
            gridList.RootTable.Columns["CreatedDate"].FormatString = String.Format("dd/MM/yyyy");
            gridList.RootTable.Columns["UpdatedDate"].FormatString = String.Format("dd/MM/yyyy");
            CtmsMenuBar.Opening += CtmsMenuBarOnOpening;
        }

        private void CtmsMenuBarOnOpening(object sender, CancelEventArgs e)
        {
            GridEXRow currentRow = gridList.GetRow();
            btnNew.Enabled = MANAGE_ROLE.ALLOW_ADD_CATEGORY;
            if (currentRow == null)
            {
                btnView.Enabled = btnEdit.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = MANAGE_ROLE.ALLOW_EDIT_CATEGORY;
                btnView.Enabled = MANAGE_ROLE.ALLOW_VIEW_CATEGORY;
            }
        }

        private void FrmCategoryList_Load(object sender, EventArgs e)
        {
            dtpFrom.Enabled = dtpTo.Enabled = false;
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
            filterEntity.Keyword = txtKeyword.Text;
            gridList.DataSource = CategoryDao.FilterListCategory(filterEntity);
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
            FrmCategory frmCategory = new FrmCategory();
            frmCategory.ShowDialog();
            if (frmCategory.SaveCompleted)
            {
                LoadData();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            GridEXRow currentRow = gridList.GetRow();
            if (currentRow != null || currentRow.RowType == RowType.Record)
            {
                //Note*
                Guid id = Guid.Parse(currentRow.Cells["ID"].Value.ToString());
                FrmCategory frmCategory = new FrmCategory(true, id);
                frmCategory.ShowDialog();
                if (frmCategory.SaveCompleted)
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
                //Note*
                Guid id = Guid.Parse(currentRow.Cells["ID"].Value.ToString());
                FrmCategory frmCategory = new FrmCategory(false, id);
                frmCategory.ShowDialog();
            }
        }
    }
}
