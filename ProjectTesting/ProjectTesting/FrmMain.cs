using ProjectTesting.Product.View;
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

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void BtnProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmProductList ul = new FrmProductList();
            ul.ShowDialog();
            this.Close();
        }
    }
}