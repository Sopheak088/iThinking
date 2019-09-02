using ProjectTesting.Category.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTesting.Category.View
{
    public partial class FrmCategoryList : Form
    {
        public FrmCategoryList()
        {
            InitializeComponent();
        }

        private void DgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FrmCategoryList_Load(object sender, EventArgs e)
        {
            dgvCategory.DataSource = CategoryDao.ListAllCategory();
            dgvCategory.ColumnHeadersDefaultCellStyle.Font =
                new Font("Time News Roman", 14, FontStyle.Bold);
            dgvCategory.DefaultCellStyle.Font = new Font("Khmer OS System", 12);
            dgvCategory.Columns["ID"].Visible = false;
            dgvCategory.Columns["Category"].Width = 200; //define column width
            dgvCategory.Columns["Des"].Width = 200;
        }

        private void DgvCategory_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu cm = new ContextMenu();
                this.ContextMenu = cm;
                cm.MenuItems.Add(new MenuItem("&Add", new System.EventHandler(this.Add_Click)));
                /*  if (getID != Guid.Empty)
                  {
                      cm.MenuItems.Add(new MenuItem("&Edit", new System.EventHandler(this.Edit_Click)));
                  }
                  cm.Show(this, new Point(e.X, e.Y));*/
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCategory frmCategory = new FrmCategory();

            frmCategory.ShowDialog();
            this.Close();
        }
    }
}