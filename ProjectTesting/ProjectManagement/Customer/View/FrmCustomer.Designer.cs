namespace ProjectManagement.Customer.View
{
    partial class FrmCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.txtMemberShipID = new System.Windows.Forms.Label();
            this.txtOtherContact = new System.Windows.Forms.TextBox();
            this.lblOtherContact = new System.Windows.Forms.Label();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboMemberShip = new Janus.Windows.EditControls.UIComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.picCustomer = new ProjectManagement.UserManagement.Control.MyPicture();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CustomerName";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(98, 9);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(199, 20);
            this.txtCustomerName.TabIndex = 1;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(98, 46);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(199, 20);
            this.txtGender.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gender";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(98, 85);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(199, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Address";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Location = new System.Drawing.Point(98, 202);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(56, 17);
            this.chkActive.TabIndex = 6;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // txtMemberShipID
            // 
            this.txtMemberShipID.AutoSize = true;
            this.txtMemberShipID.Location = new System.Drawing.Point(13, 164);
            this.txtMemberShipID.Name = "txtMemberShipID";
            this.txtMemberShipID.Size = new System.Drawing.Size(77, 13);
            this.txtMemberShipID.TabIndex = 10;
            this.txtMemberShipID.Text = "MemberShipID";
            // 
            // txtOtherContact
            // 
            this.txtOtherContact.Location = new System.Drawing.Point(98, 122);
            this.txtOtherContact.Name = "txtOtherContact";
            this.txtOtherContact.Size = new System.Drawing.Size(199, 20);
            this.txtOtherContact.TabIndex = 4;
            // 
            // lblOtherContact
            // 
            this.lblOtherContact.AutoSize = true;
            this.lblOtherContact.Location = new System.Drawing.Point(13, 125);
            this.lblOtherContact.Name = "lblOtherContact";
            this.lblOtherContact.Size = new System.Drawing.Size(70, 13);
            this.lblOtherContact.TabIndex = 8;
            this.lblOtherContact.Text = "OtherContact";
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(98, 234);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNew.TabIndex = 13;
            this.btnSaveNew.Text = "Save New";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.BtnSaveNew_Click);
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Location = new System.Drawing.Point(197, 234);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(75, 23);
            this.btnSaveClose.TabIndex = 14;
            this.btnSaveClose.Text = "Save Close";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.BtnSaveClose_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(298, 234);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = " Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // cboMemberShip
            // 
            this.cboMemberShip.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.cboMemberShip.Location = new System.Drawing.Point(98, 160);
            this.cboMemberShip.Name = "cboMemberShip";
            this.cboMemberShip.Size = new System.Drawing.Size(199, 20);
            this.cboMemberShip.TabIndex = 5;
            this.cboMemberShip.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // picCustomer
            // 
            this.picCustomer.BackColor = System.Drawing.Color.Transparent;
            this.picCustomer.Location = new System.Drawing.Point(318, 12);
            this.picCustomer.Name = "picCustomer";
            this.picCustomer.Size = new System.Drawing.Size(136, 162);
            this.picCustomer.TabIndex = 7;
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 270);
            this.Controls.Add(this.picCustomer);
            this.Controls.Add(this.cboMemberShip);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.txtMemberShipID);
            this.Controls.Add(this.txtOtherContact);
            this.Controls.Add(this.lblOtherContact);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label1);
            this.Name = "FrmCustomer";
            this.Text = "FrmCustomer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCustomer_FormClosing_1);
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Label txtMemberShipID;
        private System.Windows.Forms.TextBox txtOtherContact;
        private System.Windows.Forms.Label lblOtherContact;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnClose;
        private Janus.Windows.EditControls.UIComboBox cboMemberShip;
        private UserManagement.Control.MyPicture picCustomer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}