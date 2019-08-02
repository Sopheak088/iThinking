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
    public partial class FrmSupplierList : Form
    {
        private Guid getId = Guid.Empty;

        public FrmSupplierList()
        {
            InitializeComponent();
        }

        private void DgvSupplier_MouseClick(object sender, MouseEventArgs e)
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
            FrmSupplier frmProduct = new FrmSupplier(getId);
            frmProduct.ShowDialog();
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
                getId = Guid.Parse(row.Cells[0].Value.ToString());
            }
        }
    }
}