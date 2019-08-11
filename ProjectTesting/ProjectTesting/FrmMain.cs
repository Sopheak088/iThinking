using ProjectTesting.Product.View;
using ProjectTesting.Supplier.View;
using ProjectTesting.User.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void BtnSupplier_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmListAllSupplier frm = new FrmListAllSupplier();
            frm.ShowDialog();
            this.Close();
        }
    }
}