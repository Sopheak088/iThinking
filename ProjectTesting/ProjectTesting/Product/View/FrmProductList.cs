using ProjectTesting.Customer.Dao;
using ProjectTesting.Helper;
using ProjectTesting.Product.Dao;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectTesting.Product.View
{
    public partial class FrmProductList : Form
    {
        private Guid getId = Guid.Empty;

        public FrmProductList()
        {
            InitializeComponent();
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search Name Here";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void FrmProductList_Load(object sender, EventArgs e)
        {
            dgvProduct.DataSource = ProductDao.ListAllProduct();
            dgvProduct.ColumnHeadersDefaultCellStyle.Font =
                new Font("Time News Roman", 14, FontStyle.Bold);
            dgvProduct.DefaultCellStyle.Font = new Font("Khmer OS System", 12);
            dgvProduct.Columns["ID"].Visible = false;
            dgvProduct.Columns["Name"].Width = 200; //define column width
            dgvProduct.Columns["Price"].DefaultCellStyle.Format = "c";
            dgvProduct.Columns["MadeDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvProduct.Columns["ExpiredDate"].DefaultCellStyle.Format = "dd/MM/yyyy";

            // define image size stretch
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)dgvProduct.Columns["Photo"];
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;
            foreach (DataGridViewColumn col in dgvProduct.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvProduct.ClearSelection(); //clear select item in datagridview
        }

        private void DgvProduct_MouseClick(object sender, MouseEventArgs e)
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
            FrmProduct frmProduct = new FrmProduct(getId);

            frmProduct.ShowDialog();
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmProduct frmProduct = new FrmProduct();

            frmProduct.ShowDialog();
            this.Close();
        }

        private void DgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            if (dgvProduct.RowCount > 0)
            {
                i = e.RowIndex;
                if (i < 0) return;

                DataGridViewRow row = dgvProduct.Rows[i];
                getId = Guid.Parse(row.Cells[0].Value.ToString());
            }
        }

        private void DgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text) && !txtSearch.Text.Equals("Search Name Here"))
            {
                dgvProduct.DataSource = CustomerDao.ListAllCustomerByName(txtSearch.Text);
            }
            else
            {
                FrmProductList_Load(sender, e);
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
            if (txtSearch.Text.Equals("Search Name Here"))
            {
                txtSearch.Text = null;
                txtSearch.ForeColor = Color.Black;
            }
        }
    }
}