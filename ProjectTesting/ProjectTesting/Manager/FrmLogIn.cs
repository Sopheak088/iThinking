using ProjectTesting.Helper;
using ProjectTesting.User.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTesting.Manager
{
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private int count = 0;

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            string un = txtUser.Text.Trim();
            string pw = txtPassword.Text.Trim();
            SqlCommand com = new SqlCommand("UserLogin", Connection.ToDatabase());
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@uid", un);
            com.Parameters.AddWithValue("@pwd", pw);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                FrmMain ul = new FrmMain();
                ul.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Your username and password incorrect...", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                count++;
            }
            if (count == 3)
            {
                MessageBox.Show("You have log incorect 3 time...", "Bye Bye", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.Exit();
            }
        }
    }
}