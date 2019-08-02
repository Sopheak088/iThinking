using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTesting.Supplier.View
{
    public partial class FrmSupplier : Form
    {
        private Guid getId = Guid.Empty;
        private byte[] pic = null;

        public FrmSupplier(Guid? id = null)
        {
            if (id != null)
            {
                getId = Guid.Parse(id.ToString());
                /*DataTable dt = ProductDao.GetProductById(getId);
                if (dt != null)
                {
                    txtName.Text = dt.Rows[0]["Name"].ToString();
                    txtPhone.Text = dt.Rows[0]["Phone"].ToString();
                    dtpMadeDate.Value = DateTime.Parse(dt.Rows[0]["MadeDate"].ToString());
                    dtpExpiredDate.Value = DateTime.Parse(dt.Rows[0]["ExpiredDate"].ToString());
                    chkActive.Checked = (bool)dt.Rows[0]["Active"];
                    pic = ProductDao.GetPhoto(getId);
                    if (pic != null)
                        picProduct.Image = Helpers.ByteArrayToImage(pic);
                }*/
            }
        }
    }
}