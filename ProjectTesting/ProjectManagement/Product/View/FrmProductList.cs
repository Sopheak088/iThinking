using Janus.Windows.GridEX;
using ProjectManagement.BaseObject;
using ProjectManagement.Manager;
using ProjectManagement.Product.Dao;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace ProjectManagement.Product.View
{
    public partial class FrmProductList : Form
    {
        public FrmProductList()
        {
            InitializeComponent();
            gridList.RootTable.Columns["CreatedDate"].FormatString = String.Format("dd/MM/yyyy");
            gridList.RootTable.Columns["UpdatedDate"].FormatString = String.Format("dd/MM/yyyy");
            gridList.RootTable.Columns["MadeDate"].FormatString = String.Format("dd/MM/yyyy");
            gridList.RootTable.Columns["ExpireDate"].FormatString = String.Format("dd/MM/yyyy");
            gridList.RootTable.Columns["Price"].FormatString = String.Format("0.00 $");
            LoadData();
            ctmsMenuBar.Opening += CtmsMenuBarOnOpening;
        }
        private void CtmsMenuBarOnOpening(object sender, CancelEventArgs e)
        {
            GridEXRow currentRow = gridList.GetRow();
            btnNew.Enabled = MANAGE_ROLE.ALLOW_ADD_PRODUCT;
            if(currentRow==null)
            {
                btnEdit.Enabled = btnView.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = MANAGE_ROLE.ALLOW_EDIT_PRODUCT;
                btnView.Enabled = MANAGE_ROLE.ALLOW_VIEW_PRODUCT;
            }
        }
        private void FrmProductList_Load(object sender, EventArgs e)
        {
            dtpFrom.Enabled = dtpTo.Enabled = false;
        }
        public void LoadData()
        {
            FilterEntity filterEntity = new FilterEntity();
            if(rdoAllDays.Checked)
            {
                filterEntity.FromDate = filterEntity.ToDate = null;
            }
            else if(rdoByDate.Checked)
            {
                filterEntity.FromDate = dtpFrom.Value;
                filterEntity.ToDate = dtpTo.Value;
            }
            if(rdoActive.Checked)
            {
                filterEntity.Active = true;
            }
            else if(rdoInActive.Checked)
            {
                filterEntity.Active = false;
            }
            
            filterEntity.Keyword = txtKeyword.Text;
            //I added it
            DataTable data = new DataTable();
            data= ProductDao.FilterListProduct(filterEntity);
            gridList.DataSource = data;
            int count = data.Rows.Count;
            if (count == 0)
            {
                MessageBox.Show("Search not found!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           // gridList.Refresh();

        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            this.Hide();//Hide the form
            FrmProduct frmProduct = new FrmProduct();
            frmProduct.ShowDialog();
            this.Close();//Close the form
            
            if(frmProduct.SaveCompleted)
            {
                LoadData();
            }
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            GridEXRow currentRow = gridList.GetRow();
            if(currentRow != null || currentRow.RowType == RowType.Record)
            {
                Guid id = Guid.Parse(currentRow.Cells["ID"].Value.ToString());
                this.Hide();
                FrmProduct frmProduct = new FrmProduct(true, id);
                frmProduct.ShowDialog();
                this.Close();
                
                if (frmProduct.SaveCompleted)
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
                this.Hide();
                FrmProduct frmProduct = new FrmProduct(false, id);
                frmProduct.ShowDialog();
                this.Close();
                
            }
        }
        private void RdoByDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpFrom.Enabled = dtpTo.Enabled = true;
        }
        private void RdoAllDays_CheckedChanged(object sender, EventArgs e)
        {
            dtpFrom.Enabled = dtpTo.Enabled = false;
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            BtnSearch_Click(sender, e);
        }
    }
}
