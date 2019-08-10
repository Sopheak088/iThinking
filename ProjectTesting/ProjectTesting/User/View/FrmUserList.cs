using ProjectTesting.User.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTesting.User.View
{
    public partial class FrmUserList : Form
    {
        public FrmUserList()
        {
            InitializeComponent();
        }

        private Guid getId = Guid.Empty;

        private void FrmUserList_Load(object sender, EventArgs e)
        {
            dgvUser.DataSource = UserDao.ListUser();
            //Visible(false) hide ID
            dgvUser.Columns["ID"].Visible = false;
            dgvUser.Columns["UserName"].Width = 150; //define column width
            dgvUser.Columns["UserPassword"].Width = 150;
            dgvUser.Columns["Position"].Width = 170;
        }

        private void DgvUser_MouseClick(object sender, MouseEventArgs e)
        {
            ContextMenu cm = new ContextMenu();
            this.ContextMenu = cm;
            if (e.Button == MouseButtons.Right)
            {
                cm.MenuItems.Add(new MenuItem("&Add", new System.EventHandler(this.Add_Click)));
                if (getId != Guid.Empty)
                {
                    cm.MenuItems.Add(new MenuItem("&Edit", new System.EventHandler(this.Edit_Click)));
                }
            }

            cm.Show(this, new Point(e.X, e.Y));
        }

        private void Add_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUser frmUser = new FrmUser();
            frmUser.ShowDialog();
            this.Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUser frmUser = new FrmUser(getId);
            frmUser.ShowDialog();
            this.Close();
        }

        private void DgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            if (dgvUser.RowCount > 0)
            {
                i = e.RowIndex;
                if (i < 0) return;

                DataGridViewRow row = dgvUser.Rows[i];
                getId = Guid.Parse(row.Cells[0].Value.ToString());
            }
        }
    }
}