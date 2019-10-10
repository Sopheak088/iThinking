namespace ProjectManagement.MemberShip.View
{
    partial class FrmMemberShip
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
            this.txtMemberShipType = new System.Windows.Forms.TextBox();
            this.txtDiscountValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiscountText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "MemberShipType";
            // 
            // txtMemberShipType
            // 
            this.txtMemberShipType.Location = new System.Drawing.Point(149, 13);
            this.txtMemberShipType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMemberShipType.Name = "txtMemberShipType";
            this.txtMemberShipType.Size = new System.Drawing.Size(334, 27);
            this.txtMemberShipType.TabIndex = 1;
            // 
            // txtDiscountValue
            // 
            this.txtDiscountValue.Location = new System.Drawing.Point(149, 67);
            this.txtDiscountValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiscountValue.Name = "txtDiscountValue";
            this.txtDiscountValue.Size = new System.Drawing.Size(334, 27);
            this.txtDiscountValue.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "DiscountValue";
            // 
            // txtDiscountText
            // 
            this.txtDiscountText.Location = new System.Drawing.Point(149, 117);
            this.txtDiscountText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiscountText.Name = "txtDiscountText";
            this.txtDiscountText.Size = new System.Drawing.Size(334, 27);
            this.txtDiscountText.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "DiscountText";
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(149, 162);
            this.txtOther.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOther.Multiline = true;
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(334, 56);
            this.txtOther.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Other";
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(149, 254);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(82, 38);
            this.btnSaveNew.TabIndex = 8;
            this.btnSaveNew.Text = "Save New";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.BtnSaveNew_Click);
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Location = new System.Drawing.Point(258, 254);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(82, 38);
            this.btnSaveClose.TabIndex = 9;
            this.btnSaveClose.Text = "Save Close";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.BtnSaveClose_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(373, 254);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 38);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmMemberShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 304);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDiscountText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiscountValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMemberShipType);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Hanuman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMemberShip";
            this.Text = "FrmMemberShip";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemberShipType;
        private System.Windows.Forms.TextBox txtDiscountValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiscountText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}