using ProjectTesting.Helper;
using ProjectTesting.Staffs.Dao;
using ProjectTesting.Staffs.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTesting.Staffs.View
{
    public partial class FrmStaff : Form
    {

        private Guid getId = Guid.Empty;
        private byte[] pic = null;
        public FrmStaff(Guid? id = null)
        {
            InitializeComponent();
            if (id != null)
            {
                getId = Guid.Parse(id.ToString());
                DataTable dt = StaffDao.GetStaffById(getId);
                if (dt != null)
                {
                    txtName.Text = dt.Rows[0]["Name"].ToString();
                    txtSalary.Text = dt.Rows[0]["Salary"].ToString();
                    dtpHireDate.Value = DateTime.Parse(dt.Rows[0]["HireDate"].ToString());
                    dtpStopDate.Value = DateTime.Parse(dt.Rows[0]["StopDate"].ToString());
                    pic = StaffDao.GetPhoto(getId);
                    if (pic != null)
                        picStaff.Image = Helpers.ByteArrayToImage(pic);
                }
            }
        }

        private void TxtSalary_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSalary.Text) ||
               !string.IsNullOrWhiteSpace(txtSalary.Text))
                txtSalary.Text = string.Format("{0:C}", decimal.Parse(txtSalary.Text));
        }

        private void TxtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            decimal x;
            char ch = e.KeyChar;
            if (ch == (char)8) //backspace
                e.Handled = false;
            else if (!char.IsDigit(ch) && ch != '.' ||
                    !Decimal.TryParse(txtSalary.Text + ch, out x))
                e.Handled = true;
        }

        private void TxtSalary_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSalary.Text) ||
                !string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                var s = decimal.Parse(txtSalary.Text, NumberStyles.Currency);
                txtSalary.Text = s.ToString();
            }
        }

        private void Save()
        {
            StaffEntity StaffEntity = new StaffEntity();
            StaffEntity.Name = txtName.Text;
            StaffEntity.Salary = decimal.Parse(Helpers.CurrencyToString(txtSalary.Text).ToString());
            StaffEntity.HireDate = DateTime.Parse(dtpHireDate.Value.ToString("dd/MM/yyyy"));
            StaffEntity.StopDate = DateTime.Parse(dtpStopDate.Value.ToString("dd/MM/yyyy"));
            StaffEntity.Photo = pic;
            if (getId != Guid.Empty)
            {
                StaffEntity.Id = getId;
                StaffDao.Update(StaffEntity);
            }
            else
            {
                StaffEntity.Id = Guid.NewGuid();
                StaffDao.Insert(StaffEntity);
            }
        }

        private void BtnSaveNew_Click(object sender, EventArgs e)
        {
            Save();
            getId = Guid.Empty;
            pic = null;
            txtName.Text = txtSalary.Text = null;
            dtpHireDate.Value = dtpStopDate.Value = DateTime.Today;
            picStaff.Image = null;
        }

        private void BtnSaveClose_Click(object sender, EventArgs e)
        {
            Save();
            BtnClose_Click_1(sender, e);
        }

      /*  private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmStaffList frm = new FrmStaffList();
            frm.ShowDialog();
            this.Close();
        }*/

        private void PicStaff_Click(object sender, EventArgs e)
        {
            string fp;
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "JPEG FILE| *.jpg; *.jpeg|PNG FILE|*.png|BMP FILE|*.bmp";
            fd.Title = "Open an image";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                fp = fd.FileName;
                picStaff.Image = Image.FromFile(fp);
                pic = Helpers.StringToByteArray(fp);

            }
        }
        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmStaffList frm = new FrmStaffList();
            frm.ShowDialog();
            this.Close();
        }
    }
}
