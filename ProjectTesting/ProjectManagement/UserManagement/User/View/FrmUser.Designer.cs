﻿namespace ProjectManagement.UserManagement.User.View
{
    partial class FrmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUser));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.cboBranch = new Janus.Windows.EditControls.UIComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(107, 14);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(271, 26);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(107, 46);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(271, 26);
            this.txtLastName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(107, 78);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(271, 26);
            this.txtUsername.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(107, 110);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(271, 26);
            this.txtPassword.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Position";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(107, 143);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(271, 26);
            this.txtPosition.TabIndex = 4;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Location = new System.Drawing.Point(107, 235);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(58, 21);
            this.chkActive.TabIndex = 5;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::ProjectManagement.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(308, 266);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 24);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Image = global::ProjectManagement.Properties.Resources.save;
            this.btnSaveClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveClose.Location = new System.Drawing.Point(207, 266);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(95, 24);
            this.btnSaveClose.TabIndex = 7;
            this.btnSaveClose.Text = "Save Close";
            this.btnSaveClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.BtnSaveClose_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Image = global::ProjectManagement.Properties.Resources.text_add;
            this.btnSaveNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveNew.Location = new System.Drawing.Point(106, 266);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(95, 24);
            this.btnSaveNew.TabIndex = 6;
            this.btnSaveNew.Text = "Save New";
            this.btnSaveNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.BtnSaveNew_Click);
            // 
            // cboBranch
            // 
            this.cboBranch.BorderStyle = Janus.Windows.UI.BorderStyle.Flat;
            this.cboBranch.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.cboBranch.Location = new System.Drawing.Point(107, 203);
            this.cboBranch.Name = "cboBranch";
            this.cboBranch.Size = new System.Drawing.Size(271, 26);
            this.cboBranch.TabIndex = 12;
            this.cboBranch.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Branch";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(107, 173);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(271, 26);
            this.txtPhone.TabIndex = 15;
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 296);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboBranch);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Hanuman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUser_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label6;
        private Janus.Windows.EditControls.UIComboBox cboBranch;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label7;
    }
}