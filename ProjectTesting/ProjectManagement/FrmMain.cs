using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectManagement.UserAccount.User.View;

namespace ProjectManagement
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
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
    }
}