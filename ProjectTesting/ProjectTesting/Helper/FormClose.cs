using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTesting.Helper
{
    public class FormClose
    {
        public static bool Yes_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool isYes = true;
            // Display a MsgBox asking the user to save changes or abort.
            if (MessageBox.Show("Do you want to close application?", "Close",
               MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                // Cancel the Closing event from closing the form.
                e.Cancel = true;
                isYes = false;
                // Call method to save file...
            }
            return isYes;
        }
    }
}