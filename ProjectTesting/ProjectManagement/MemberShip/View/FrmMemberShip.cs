using ProjectManagement.Manager;
using ProjectManagement.MemberShip.Entity;
using ProjectManagement.MEMBERSHIP.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagement.MemberShip.View
{
    public partial class FrmMemberShip : Form
    {
        public bool SaveCompleted = false;
        private Guid membershipID = Guid.Empty;

        public FrmMemberShip(bool isCanSave = true, Guid? id = null)
        {
            InitializeComponent();
            if (id != null)
            {
                membershipID = (Guid)id;
                MemberShipEntity memberShipEntity = new MemberShipEntity();
                memberShipEntity = MembershipDao.GetByID(id);
                this.Text = this.Text + membershipID;
                txtMemberShipType.Text = memberShipEntity.MembershipType;
                txtDiscountValue.Text = memberShipEntity.DiscountValue.ToString();
                txtDiscountText.Text = memberShipEntity.DiscountText;
                txtOther.Text = memberShipEntity.Other;
            }
            btnSaveClose.Enabled = btnSaveNew.Enabled = isCanSave;
        }

        private void BtnSaveNew_Click(object sender, EventArgs e)
        {
            Save();
            ClearData();
        }

        private void Save()
        {
            SaveCompleted = true;
            errorProvider1.Clear();
            MemberShipEntity memberShipEntity = new MemberShipEntity();
            memberShipEntity.MembershipType = txtMemberShipType.Text;
            memberShipEntity.DiscountValue = int.Parse(txtDiscountValue.Text);
            memberShipEntity.DiscountText = txtDiscountText.Text;
            memberShipEntity.Other = txtOther.Text;
            if (membershipID != Guid.Empty)
            {
                memberShipEntity.ID = membershipID;
                memberShipEntity.Update(USER.UserName);
                MembershipDao.Update(memberShipEntity);
            }
            else
            {
                memberShipEntity.ID = Guid.NewGuid();
                memberShipEntity.Create(USER.UserName);
                MembershipDao.Insert(memberShipEntity);
            }
        }

        private void ClearData()
        {
            membershipID = Guid.Empty;
            txtMemberShipType.Text = txtDiscountText.Text = txtDiscountValue.Text = txtOther.Text = null;
        }

        private void BtnSaveClose_Click(object sender, EventArgs e)
        {
            Save();
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}