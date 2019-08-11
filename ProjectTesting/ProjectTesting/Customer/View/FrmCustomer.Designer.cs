namespace ProjectTesting.Customer.View
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.picCustomer = new System.Windows.Forms.PictureBox();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSaveClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(143, 87);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(294, 38);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(143, 145);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(294, 38);
            this.txtPhone.TabIndex = 2;
            // 
            // picCustomer
            // 
            this.picCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCustomer.Location = new System.Drawing.Point(501, 24);
            this.picCustomer.Name = "picCustomer";
            this.picCustomer.Size = new System.Drawing.Size(166, 214);
            this.picCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCustomer.TabIndex = 4;
            this.picCustomer.TabStop = false;
            this.picCustomer.Click += new System.EventHandler(this.picCustomer_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(141, 268);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(134, 35);
            this.btnSaveNew.TabIndex = 5;
            this.btnSaveNew.Text = "SaveNew";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.BtnSaveNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(421, 268);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 35);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Location = new System.Drawing.Point(281, 267);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(134, 35);
            this.btnSaveClose.TabIndex = 7;
            this.btnSaveClose.Text = "SaveClose";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.BtnSaveClose_Click);
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 438);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.picCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("Hanuman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCustomer";
            this.Text = "FrmCustomer";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.PictureBox picCustomer;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSaveClose;
    }
}