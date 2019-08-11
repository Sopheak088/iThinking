namespace ProjectTesting
{
    partial class FrmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 450);
            this.panel1.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(12, 414);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(215, 27);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "label2";
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(12, 371);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(215, 32);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSupplier);
            this.panel2.Controls.Add(this.btnUser);
            this.panel2.Controls.Add(this.btnProduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(234, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 450);
            this.panel2.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick_1);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Image = global::ProjectTesting.Properties.Resources.icons8_Supplier_50px;
            this.btnSupplier.Location = new System.Drawing.Point(346, 12);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(146, 96);
            this.btnSupplier.TabIndex = 2;
            this.btnSupplier.Text = "Supplier";
            this.btnSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.BtnSupplier_Click);
            // 
            // btnUser
            // 
            this.btnUser.Image = global::ProjectTesting.Properties.Resources.icons8_User_50px_1;
            this.btnUser.Location = new System.Drawing.Point(176, 12);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(146, 96);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "User";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.BtnUser_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Image = global::ProjectTesting.Properties.Resources.icons8_move_by_trolley_50px;
            this.btnProduct.Location = new System.Drawing.Point(6, 12);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(146, 96);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "Product";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.BtnProduct_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnSupplier;
    }
}