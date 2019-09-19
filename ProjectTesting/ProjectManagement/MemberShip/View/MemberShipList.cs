using Janus.Windows.GridEX;
using ProjectManagement.MEMBERSHIP.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagement.MemberShip.View
{
    public partial class MemberShipList : Form
    {
        public MemberShipList()
        {
            InitializeComponent();
            LoadData();
            gridList.RootTable.Columns["CreateDate"].FormatString = string.Format("dd/MM/YYYY");
            gridList.RootTable.Columns["UpdateDate"].FormatString = string.Format("dd/MM/yyyy");
            ctmMenu.Opening += CtmMenu_Opening;
        }

        private void CtmMenu_Opening(object sender, CancelEventArgs e)
        {
            GridEXRow currentRow = gridList.GetRow();
            
        }

        private void MemberShipList_Load(object sender, EventArgs e)
        {
        }

        private void LoadData()
        {
            gridList.DataSource = MembershipDao.FilterList();
        }
    }
}