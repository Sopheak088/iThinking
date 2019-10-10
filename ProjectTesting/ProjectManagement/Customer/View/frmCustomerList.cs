using Janus.Windows.GridEX;
using ProjectManagement.BaseObject;
using ProjectManagement.Customer.Dao;
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
    public partial class FrmCustomerList : Form
    {
        public FrmCustomerList()
        {
            InitializeComponent();
            gridList.RootTable.Columns["CreateDate"].FormatString = string.Format("dd-MM-yyyy");
            gridList.RootTable.Columns["UpdateDate"].FormatString = string.Format("dd/MM/yyyy");
            LoadData();
            ctmMenu.Opening += CtmMenu_Opening;
        }

        private void CtmMenu_Opening(object sender, CancelEventArgs e)
        {
            GridEXRow currentRow = gridList.GetRow();
            btnNew.Enabled = MANAGE_ROLE.ALLOW_ADD_CUSTOMER;
            if (currentRow == null)
            {
                btnView.Enabled = btnEdit.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = MANAGE_ROLE.ALLOW_EDIT_CUSTOMER;
                btnView.Enabled = MANAGE_ROLE.ALLOW_VIEW_CUSTOMER;
            }
        }

        private void FrmCustomerList_Load(object sender, EventArgs e)
        {
            dtpFrom.Enabled = dtpTo.Enabled = false;
        }

        private void LoadData()
        {
            FilterEntity filterEntity = new FilterEntity();
            if (rdoAllDay.Checked)
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
            if (rdoInActive.Checked)
            {
                filterEntity.Active = false;
            }
            filterEntity.Keyword = txtSearch.Text;
            gridList.DataSource = CustomerDao.FilterListCustomer(filterEntity);
            gridList.Refresh();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void RdoAllDay_CheckedChanged(object sender, EventArgs e)
        {
            dtpFrom.Enabled = dtpTo.Enabled;
        }

        private void RdoByDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpFrom.Enabled = dtpTo.Enabled = true;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            BtnRefresh_Click(sender, e);
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            FrmCustomer frmCustomer = new FrmCustomer();
            frmCustomer.ShowDialog();
            // if(frmCustomer.SaveCompleted)
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
                FrmCustomer frmCustomer = new FrmCustomer(true, id);
                frmCustomer.ShowDialog();
                if (frmCustomer.SaveCompleted)
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
                FrmCustomer frmCustomer = new FrmCustomer(false, id);
                frmCustomer.ShowDialog();
            }
        }
    }
}