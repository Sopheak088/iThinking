using ProjectManagement.Helper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectManagement.LogIn
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private int count = 0;
        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            String un = txtUser.Text.Trim();
            String pw = txtPass.Text.Trim();
            SqlCommand cmd = new SqlCommand("UserLogin", Connect.ToDatabase());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@uid", un);
            cmd.Parameters.AddWithValue("@pwd", Helper.StringCipher.Encrypt(pw));
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = cmd;
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            
            if (dataTable.Rows.Count>0)
            {
                this.Hide();
                FrmMain main = new FrmMain();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                count++;
                MessageBox.Show("Invalid UserName or Password...", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              
            }
            if (count == 3)
            {
                MessageBox.Show("Incorrect 3 time...", "Log Out", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.Exit();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
