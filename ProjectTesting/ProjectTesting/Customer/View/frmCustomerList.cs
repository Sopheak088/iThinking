using ProjectTesting.Customer.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTesting.Customer.View
{
    public partial class FrmCustomerList : Form
    {
        private Guid getId = Guid.Empty;

        public FrmCustomerList()
        {
            InitializeComponent();
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search Name Here";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void FrmCustomerList_Load(object sender, EventArgs e)
        {
            dgvCustomerList.DataSource = CustomerDao.ListAllCustomer();
            dgvCustomerList.ColumnHeadersDefaultCellStyle.Font =
               new Font("Time News Roman", 14, FontStyle.Bold);
            dgvCustomerList.DefaultCellStyle.Font = new Font("Khmer OS System", 12);
            dgvCustomerList.Columns["Name"].Width = 200; //define column width

            //define image size stretch
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)dgvCustomerList.Columns["Photo"];
            img.ImageLayout = DataGridViewImageCellLayout.Zoom;
            foreach (DataGridViewColumn col in dgvCustomerList.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvCustomerList.ClearSelection(); //clear select item in datagridview
        }

        private void DgvCustomerList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu cm = new ContextMenu();
                this.ContextMenu = cm;
                cm.MenuItems.Add(new MenuItem("&Add", new System.EventHandler(this.Add_Click)));
                if (getId != Guid.Empty)
                {
                    cm.MenuItems.Add(new MenuItem("&Edit", new System.EventHandler(this.Edit_Click)));
                }
                cm.Show(this, new Point(e.X, e.Y));
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCustomer frm = new FrmCustomer(getId);

            frm.ShowDialog();
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCustomer frm = new FrmCustomer();
            frm.ShowDialog();
            this.Close();
        }

        private void DgvCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            if (dgvCustomerList.RowCount > 0)
            {
                i = e.RowIndex;
                if (i < 0) return;

                DataGridViewRow row = dgvCustomerList.Rows[i];
                getId = Guid.Parse(row.Cells[0].Value.ToString());
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text) && !txtSearch.Text.Equals("Search Name Here"))
            {
                dgvCustomerList.DataSource = CustomerDao.ListAllCustomerByName(txtSearch.Text);
            }
            else
            {
                FrmCustomerList_Load(sender, e);
            }
        }

        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals("Search Name Here"))
            {
                txtSearch.Text = null;
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search Name Here";
                txtSearch.ForeColor = Color.Gray;
            }
        }
    }
}