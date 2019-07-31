namespace ProjectTesting.Customer.View
{
    partial class FrmCustomerList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCustomerList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomerList
            // 
            this.dgvCustomerList.AllowUserToAddRows = false;
            this.dgvCustomerList.AllowUserToDeleteRows = false;
            this.dgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomerList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomerList.EnableHeadersVisualStyles = false;
            this.dgvCustomerList.Location = new System.Drawing.Point(-3, -2);
            this.dgvCustomerList.Name = "dgvCustomerList";
            this.dgvCustomerList.ReadOnly = true;
            this.dgvCustomerList.RowHeadersWidth = 62;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCustomerList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomerList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvCustomerList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvCustomerList.RowTemplate.Height = 80;
            this.dgvCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerList.Size = new System.Drawing.Size(801, 469);
            this.dgvCustomerList.TabIndex = 0;
            this.dgvCustomerList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCustomerList_CellContentClick);
            this.dgvCustomerList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DgvCustomerList_MouseClick);
            // 
            // FrmCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.dgvCustomerList);
            this.Name = "FrmCustomerList";
            this.Text = "frmCustomer";
            this.Load += new System.EventHandler(this.FrmCustomerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomerList;
    }
}