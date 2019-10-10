using System;
using System.Windows.Forms;
using ProjectManagement.Branch.View;
using ProjectManagement.Category.View;
using ProjectManagement.Company.View;
using ProjectManagement.Customer.View;
using ProjectManagement.Manager;
using ProjectManagement.MemberShip.View;
using ProjectManagement.Product.View;
using ProjectManagement.UserManagement.User.View;

namespace ProjectManagement
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            timer1.Start();
            lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void BtnExit_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            this.Close();
        }

        private void CmdUser_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            //panelList.Controls.Clear();
            FrmUserList frm = new FrmUserList { TopLevel = false, AutoScroll = true };
            panelList.Controls.Add(frm);
            //panelList.Dock = DockStyle.Top;//Fill;
            panelList.Visible = true;
            frm.Show();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to close?", "Close Sale Inventory",
                    MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
        }

        private void CmdCompanyList_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FrmCompanyList frm = new FrmCompanyList { TopLevel = false, AutoScroll = true };
            panelList.Controls.Add(frm);
            panelList.Visible = true;
            frm.Show();
        }

        private void CmdAddCompany_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FrmCompany frmCompany = new FrmCompany();
            frmCompany.ShowDialog();
        }

        private void BtnCategory_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FrmCategoryList frm = new FrmCategoryList { TopLevel = false, AutoScroll = true };
            panelList.Controls.Add(frm);
            panelList.Visible = true;
            frm.Show();
        }

        private void BtnProduct_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FrmProductList frm = new FrmProductList { TopLevel = false, AutoScroll = true };
            panelList.Controls.Add(frm);
            panelList.Visible = true;
            frm.Show();
        }

        private void CmdCustomerProfile_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FrmCustomerList frm = new FrmCustomerList { TopLevel = false, AutoScroll = true };
            panelList.Controls.Add(frm);
            panelList.Visible = true;
            frm.Show();
        }

        private void BtnMemberShip_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FrmMemberShipList frm = new FrmMemberShipList { TopLevel = false, AutoScroll = true };
            panelList.Controls.Add(frm);
            panelList.Visible = true;
            frm.Show();
        }

        private void CmdBranch_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FrmBranchList frm = new FrmBranchList { TopLevel = false, AutoScroll = true };
            panelList.Controls.Add(frm);
            panelList.Visible = true;
            frm.Show();
        }

        private void CmdAddBranch_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FrmBranch frm = new FrmBranch { TopLevel = false, AutoScroll = true };
            panelList.Controls.Add(frm);
            panelList.Visible = true;
            frm.Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}