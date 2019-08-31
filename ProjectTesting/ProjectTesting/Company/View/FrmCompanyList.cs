using ProjectTesting.Company.Dao;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectTesting.Company.View
{
    public partial class FrmCompanyList : Form
    {
        private Guid getId = Guid.Empty;

        public FrmCompanyList()
        {
            InitializeComponent();
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
                txtSearch.Text = "Search Name Here";
                txtSearch.ForeColor = Color.Blue;

        }

        private void FrmCompanyList_Load(object sender, EventArgs e)
        {
            dgvCompany.DataSource = CompanyDao.ListAllCompany();
            dgvCompany.ColumnHeadersDefaultCellStyle.Font =
                new Font("Time News Roman", 14, FontStyle.Bold);
            dgvCompany.DefaultCellStyle.Font = new Font("Khmer OS System", 12);
            dgvCompany.Columns["ID"].Visible = false;
            dgvCompany.Columns["Name"].Width = 200; //define column width
            dgvCompany.Columns["Location"].Width = 300;
            dgvCompany.Columns["Location"].DefaultCellStyle.Format = "c";
            dgvCompany.Columns["Email"].Width = 200;
            dgvCompany.Columns["Email"].DefaultCellStyle.Format = "c";
            dgvCompany.Columns["Telephone"].DefaultCellStyle.Format = "c";
            dgvCompany.Columns["Fax"].DefaultCellStyle.Format = "c";
            //dgvCompany.Columns["Logo"].DefaultCellStyle.Format = "c";
            dgvCompany.Columns["Branch"].DefaultCellStyle.Format = "###";

            //define image size stretch
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)dgvCompany.Columns["Logo"];
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;
            foreach (DataGridViewColumn col in dgvCompany.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            //dgvStaff.ClearSelection(); //clear select item in datagridview
        }

        private void DgvCompany_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            if (dgvCompany.RowCount > 0)
            {
                i = e.RowIndex;
                if (i < 0) return;

                DataGridViewRow row = dgvCompany.Rows[i];
                getId = Guid.Parse(row.Cells[0].Value.ToString());
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCompany frmcompany = new FrmCompany();

            frmcompany.ShowDialog();
            this.Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCompany frmcompany = new FrmCompany(getId);

            frmcompany.ShowDialog();
            this.Close();
        }

        private void DgvCompany_MouseClick(object sender, MouseEventArgs e)
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

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text) && txtSearch.Text.Equals("SearchNameHere"))
            {
                dgvCompany.DataSource = CompanyDao.SearchCompanyByName(txtSearch.Text);
            }
            else
            {
                FrmCompanyList_Load(sender, e);
            }
        }

        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals("Search Name Here"))
                txtSearch.Text = null;
                txtSearch.ForeColor = Color.Black;
        }

        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
                txtSearch.Text = "Search Name Here";
                txtSearch.ForeColor = Color.Blue;
        }
    }
}
