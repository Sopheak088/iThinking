using System;
using System.Windows.Forms;

namespace ProjectManagement
{
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();
            this.Close();
            /*
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
             */
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}