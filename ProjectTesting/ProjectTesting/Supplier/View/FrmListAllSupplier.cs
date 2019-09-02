using ProjectTesting.Supplier.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTesting.Supplier.View
{
    public partial class FrmListAllSupplier : Form
    {
        private Guid getID = Guid.Empty;

        public FrmListAllSupplier()
        {
            InitializeComponent();
        }

        private void DgvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FrmListAllSupplier_Load(object sender, EventArgs e)
        {
            dgvSupplier.DataSource = SupplierDao.ListAllSupplier();
            dgvSupplier.ColumnHeadersDefaultCellStyle.Font =
               new Font("Time News Roman", 14, FontStyle.Bold);
            dgvSupplier.DefaultCellStyle.Font = new Font("Khmer OS System", 12);
            dgvSupplier.Columns["ID"].Width = 0;
            dgvSupplier.Columns["Name"].Width = 150;//define column width
            dgvSupplier.Columns["Phone"].Width = 150;
            dgvSupplier.Columns["Descript"].Width = 100;

            //define image size stretch
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)dgvSupplier.Columns["Photo"];
            img.ImageLayout = DataGridViewImageCellLayout.Zoom;
            foreach (DataGridViewColumn col in dgvSupplier.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvSupplier.ClearSelection(); //clear select item in datagridview
        }

        private void DgvSupplier_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu cm = new ContextMenu();
                this.ContextMenu = cm;
                cm.MenuItems.Add(new MenuItem("&Add", new System.EventHandler(this.Add_Click)));
                if (getID != Guid.Empty)
                {
                    cm.MenuItems.Add(new MenuItem("&Edit", new System.EventHandler(this.Edit_Click)));
                }
                cm.Show(this, new Point(e.X, e.Y));
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSupplier frm = new FrmSupplier();
            frm.ShowDialog();
            this.Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSupplier frmsupplier = new FrmSupplier(getID);

            frmsupplier.ShowDialog();
            this.Close();
        }

        private void DgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            if (dgvSupplier.RowCount > 0)
            {
                i = e.RowIndex;
                if (i < 0) return;

                DataGridViewRow row = dgvSupplier.Rows[i];
                getID = Guid.Parse(row.Cells[0].Value.ToString());
            }
        }
    }
}