using ProjectTesting.Helper;
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

namespace ProjectTesting.Test
{
    public partial class FrmGridCombo : Form
    {
        public FrmGridCombo()
        {
            InitializeComponent();
            gridEX1.DropDowns["ddProduct"].SetDataBinding(GetProductById(), "");
            //gridEX1.DropDowns["ddProduct"].DataSource = GetProductById();
        }

        private void FrmGridCombo_Load(object sender, EventArgs e)
        {
        }

        private DataTable GetProductById()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM PRODUCT";
            try
            {
                SqlCommand cmd = new SqlCommand(query, Connection.ToDatabase());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dataTable);
                da.Dispose();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "Check you SQL",
        MessageBoxButtons.RetryCancel);
            }
            finally
            {
                Connection.ToDatabase().Close();
            }
            return dataTable;
        }
    }
}