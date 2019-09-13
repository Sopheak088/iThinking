using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagement.UserManagement.Control
{
    public partial class MoneyTextBox : UserControl
    {
        public MoneyTextBox()
        {
            InitializeComponent();
        }

        public string GetText()
        {
            string getString = string.Empty;
            if (!string.IsNullOrEmpty(txtBox.Text) ||
                !string.IsNullOrWhiteSpace(txtBox.Text))
            {
                var s = decimal.Parse(txtBox.Text, NumberStyles.Currency);
                getString = s.ToString();
            }
            return getString;
        }

        public void SetText(object decimalNumber)
        {
            if (!string.IsNullOrWhiteSpace(decimalNumber.ToString()))
                txtBox.Text = string.Format("{0:C}", decimal.Parse(decimalNumber.ToString()));
        }

        public void Disable()
        {
            txtBox.Enabled = false;
        }

        public void Enable()
        {
            txtBox.Enabled = true;
        }

        public void ReadOnly(bool value = true)
        {
            txtBox.ReadOnly = value;
        }

        private void TxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            decimal x;
            char ch = e.KeyChar;
            if (ch == (char)8) //backspace
                e.Handled = false;
            else if (!char.IsDigit(ch) && ch != '.' ||
                     !Decimal.TryParse(txtBox.Text + ch, out x))
                e.Handled = true;
        }

        private void TxtBox_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBox.Text) ||
                !string.IsNullOrWhiteSpace(txtBox.Text))
            {
                var s = decimal.Parse(txtBox.Text, NumberStyles.Currency);
                txtBox.Text = s.ToString();
            }
        }

        private void TxtBox_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBox.Text) ||
                !string.IsNullOrWhiteSpace(txtBox.Text))
                txtBox.Text = string.Format("{0:C}", decimal.Parse(txtBox.Text));
        }
    }
}