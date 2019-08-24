using ProjectTesting.Staffs.Dao;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectTesting.Staffs.View
{
    public partial class FrmStaffList : Form
    {
        private Guid getId = Guid.Empty;
        public FrmStaffList()
        {
            InitializeComponent();
        }

      
        private void FrmStaffList_Load(object sender, EventArgs e)
        {
            dgvStaff.DataSource = StaffDao.ListAllStaff();
            dgvStaff.ColumnHeadersDefaultCellStyle.Font =
                new Font("Time News Roman", 14, FontStyle.Bold);
            dgvStaff.DefaultCellStyle.Font = new Font("Khmer OS System", 12);
            dgvStaff.Columns["ID"].Visible = false;
            dgvStaff.Columns["Name"].Width = 200; //define column width
            dgvStaff.Columns["Salary"].DefaultCellStyle.Format = "c";
            dgvStaff.Columns["HireDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvStaff.Columns["StopDate"].DefaultCellStyle.Format = "dd/MM/yyyy";

            //define image size stretch
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)dgvStaff.Columns["Photo"];
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;
            foreach (DataGridViewColumn col in dgvStaff.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            //dgvStaff.ClearSelection(); //clear select item in datagridview
        }

        private void Add_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmStaff frmStaff = new FrmStaff();

            frmStaff.ShowDialog();
            this.Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmStaff frmStaff = new FrmStaff(getId);

            frmStaff.ShowDialog();
            this.Close();
        }

        private void DgvStaff_MouseClick(object sender, MouseEventArgs e)
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

        private void DgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            if (dgvStaff.RowCount > 0)
            {
                i = e.RowIndex;
                if (i < 0) return;

                DataGridViewRow row = dgvStaff.Rows[i];
                getId = Guid.Parse(row.Cells[0].Value.ToString());
            }
        }

    }
}
