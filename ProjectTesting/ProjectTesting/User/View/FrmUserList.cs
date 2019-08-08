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

        private void FrmUserList_Load(object sender, EventArgs e)
        {
            dgvUser.DataSource = UserDao.ListUser();
            dgvUser.ColumnHeadersDefaultCellStyle.Font =
                new Font("Time News Roman", 14, FontStyle.Bold);
            dgvUser.DefaultCellStyle.Font = new Font("Khmer OS System", 12);
            dgvUser.Columns["ID"].Width = 0;
            dgvUser.Columns["UserName"].Width = 150; //define column width
            dgvUser.Columns["UserPassword"].Width = 150;
            dgvUser.Columns["Position"].Width = 170;
        }

        private void DgvUser_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu cm = new ContextMenu();
                this.ContextMenu = cm;
                cm.MenuItems.Add(new MenuItem("&Add", new System.EventHandler(this.Add_Click)));
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUser frmUser = new FrmUser();

            frmUser.ShowDialog();
            this.Close();
        }

        private void DgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}