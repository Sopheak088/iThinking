using ProjectTesting.Product.View;
using ProjectTesting.Staffs.View;
using ProjectTesting.User.View;
using System;
using System.Windows.Forms;

namespace ProjectTesting
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void BtnProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmProductList ul = new FrmProductList();
            ul.ShowDialog();
            this.Close();
        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUserList frmUserList = new FrmUserList();
            frmUserList.ShowDialog();
            this.Close();
        }

        private void BtnStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmStaffList u2 = new FrmStaffList();
            u2.ShowDialog();
            this.Close();
        }

        /*   private void BtnCompany_Click(object sender, EventArgs e)
           {
               this.Hide();
               FrmCompanyList u3 = new FrmCompanyList();
               u3.ShowDialog();
               this.Close();
           }*/

        }
    }