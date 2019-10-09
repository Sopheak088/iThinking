using Janus.Windows.GridEX;
using ProjectManagement.Manager;
using ProjectManagement.MEMBERSHIP.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagement.MemberShip.View
{
    public partial class FrmMemberShipList : Form
    {
        public FrmMemberShipList()
        {
            InitializeComponent();
            LoadData();
            gridList.RootTable.Columns["CreateDate"].FormatString = string.Format("dd-MM-yyyy");
            gridList.RootTable.Columns["UpdateDate"].FormatString = string.Format("dd/MM/yyyy");
            ctmMenu.Opening += CtmMenu_Opening;
        }

        private void CtmMenu_Opening(object sender, CancelEventArgs e)
        {
            GridEXRow currentRow = gridList.GetRow();
            btnNew.Enabled = MANAGE_ROLE.ALLOW_ADD_MEMBERSHIP;
            if (currentRow == null)
            {
                btnView.Enabled = btnEdit.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = MANAGE_ROLE.ALLOW_EDIT_MEMBERSHIP;
                btnView.Enabled = MANAGE_ROLE.ALLOW_VIEW_MEMBERSHIP;
            }
        }

        private void MemberShipList_Load(object sender, EventArgs e)
        {
        }

        private void LoadData()
        {
            gridList.DataSource = MembershipDao.FilterList();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            FrmMemberShip frmMemberShip = new FrmMemberShip();
            frmMemberShip.ShowDialog();
            if (frmMemberShip.SaveCompleted)
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
                FrmMemberShip frmMemberShip = new FrmMemberShip(true, id);
                frmMemberShip.ShowDialog();
                if (frmMemberShip.SaveCompleted)
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
                FrmMemberShip frmMemberShip = new FrmMemberShip(false, id);
                frmMemberShip.ShowDialog();
            }
        }
    }
}