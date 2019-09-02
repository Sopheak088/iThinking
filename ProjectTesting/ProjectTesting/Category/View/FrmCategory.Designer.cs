namespace ProjectTesting.Category.View
{
    partial class FrmCategory
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.Label();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(144, 43);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(227, 26);
            this.txtCategory.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 26);
            this.textBox1.TabIndex = 3;
            // 
            // txtDes
            // 
            this.txtDes.AutoSize = true;
            this.txtDes.Location = new System.Drawing.Point(42, 98);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(38, 20);
            this.txtDes.TabIndex = 2;
            this.txtDes.Text = "Des";
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(46, 158);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(109, 34);
            this.btnSaveNew.TabIndex = 4;
            this.btnSaveNew.Text = "Save New";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.BtnSaveNew_Click);
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Location = new System.Drawing.Point(185, 158);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(109, 34);
            this.btnSaveClose.TabIndex = 5;
            this.btnSaveClose.Text = "Save Close";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.BtnSaveClose_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(331, 158);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 34);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // FrmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 265);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCategory";
            this.Text = "FrmCategory";
            this.Load += new System.EventHandler(this.FrmCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtDes;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnClose;
    }
}