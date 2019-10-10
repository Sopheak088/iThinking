namespace ProjectManagement.Branch.View
{
    partial class FrmBranchList
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
            Janus.Windows.GridEX.GridEXLayout gridList_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBranchList));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.ctmMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.rdoByDate = new System.Windows.Forms.RadioButton();
            this.rdoAllDays = new System.Windows.Forms.RadioButton();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoInactive = new System.Windows.Forms.RadioButton();
            this.rdoActive = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridList = new Janus.Windows.GridEX.GridEX();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnView = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(-91, 19);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(101, 25);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // ctmMenu
            // 
            this.ctmMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnEdit,
            this.btnView,
            this.btnRefresh});
            this.ctmMenu.Name = "contextMenuStrip1";
            this.ctmMenu.Size = new System.Drawing.Size(114, 92);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Controls.Add(this.rdoByDate);
            this.panel1.Controls.Add(this.rdoAllDays);
            this.panel1.Location = new System.Drawing.Point(16, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 44);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "To";
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd/MM/yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(434, 11);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(98, 26);
            this.dtpTo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "From";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(300, 10);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(98, 26);
            this.dtpFrom.TabIndex = 2;
            // 
            // rdoByDate
            // 
            this.rdoByDate.AutoSize = true;
            this.rdoByDate.Location = new System.Drawing.Point(81, 12);
            this.rdoByDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rdoByDate.Name = "rdoByDate";
            this.rdoByDate.Size = new System.Drawing.Size(70, 25);
            this.rdoByDate.TabIndex = 1;
            this.rdoByDate.Text = "By Date";
            this.rdoByDate.UseVisualStyleBackColor = true;
            this.rdoByDate.CheckedChanged += new System.EventHandler(this.RdoByDate_CheckedChanged);
            // 
            // rdoAllDays
            // 
            this.rdoAllDays.AutoSize = true;
            this.rdoAllDays.Checked = true;
            this.rdoAllDays.Location = new System.Drawing.Point(3, 13);
            this.rdoAllDays.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rdoAllDays.Name = "rdoAllDays";
            this.rdoAllDays.Size = new System.Drawing.Size(72, 25);
            this.rdoAllDays.TabIndex = 0;
            this.rdoAllDays.TabStop = true;
            this.rdoAllDays.Text = "All Days";
            this.rdoAllDays.UseVisualStyleBackColor = true;
            this.rdoAllDays.CheckedChanged += new System.EventHandler(this.RdoAllDays_CheckedChanged);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.uiGroupBox1.Controls.Add(this.btnSearch);
            this.uiGroupBox1.Controls.Add(this.txtKeyword);
            this.uiGroupBox1.Controls.Add(this.label3);
            this.uiGroupBox1.Controls.Add(this.rdoInactive);
            this.uiGroupBox1.Controls.Add(this.rdoActive);
            this.uiGroupBox1.Controls.Add(this.panel1);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(1153, 100);
            this.uiGroupBox1.TabIndex = 7;
            this.uiGroupBox1.Text = "Filter";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(918, 50);
            this.txtKeyword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(140, 26);
            this.txtKeyword.TabIndex = 8;
            this.txtKeyword.TextChanged += new System.EventHandler(this.TxtKeyword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(851, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Keyword";
            // 
            // rdoInactive
            // 
            this.rdoInactive.AutoSize = true;
            this.rdoInactive.Location = new System.Drawing.Point(692, 53);
            this.rdoInactive.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rdoInactive.Name = "rdoInactive";
            this.rdoInactive.Size = new System.Drawing.Size(73, 25);
            this.rdoInactive.TabIndex = 7;
            this.rdoInactive.Text = "Inactive";
            this.rdoInactive.UseVisualStyleBackColor = true;
            // 
            // rdoActive
            // 
            this.rdoActive.AutoSize = true;
            this.rdoActive.Checked = true;
            this.rdoActive.Location = new System.Drawing.Point(623, 52);
            this.rdoActive.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rdoActive.Name = "rdoActive";
            this.rdoActive.Size = new System.Drawing.Size(63, 25);
            this.rdoActive.TabIndex = 6;
            this.rdoActive.TabStop = true;
            this.rdoActive.Text = "Active";
            this.rdoActive.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uiGroupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1153, 100);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1153, 367);
            this.panel3.TabIndex = 9;
            // 
            // gridList
            // 
            this.gridList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridList.BackColor = System.Drawing.Color.MistyRose;
            this.gridList.BackgroundImage = global::ProjectManagement.Properties.Resources.bobapins_1024x1024;
            this.gridList.BackgroundImageDrawMode = Janus.Windows.GridEX.BackgroundImageDrawMode.Stretch;
            this.gridList.ColumnAutoResize = true;
            this.gridList.ContextMenuStrip = this.ctmMenu;
            gridList_DesignTimeLayout.LayoutString = resources.GetString("gridList_DesignTimeLayout.LayoutString");
            this.gridList.DesignTimeLayout = gridList_DesignTimeLayout;
            this.gridList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridList.GroupByBoxVisible = false;
            this.gridList.Location = new System.Drawing.Point(0, 0);
            this.gridList.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gridList.Name = "gridList";
            this.gridList.Size = new System.Drawing.Size(1153, 367);
            this.gridList.TabIndex = 4;
            this.gridList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::ProjectManagement.Properties.Resources.find_24x24;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(1064, 49);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 30);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::ProjectManagement.Properties.Resources.add_16x16;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(113, 22);
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::ProjectManagement.Properties.Resources.edit;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(113, 22);
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnView
            // 
            this.btnView.Image = global::ProjectManagement.Properties.Resources.preview;
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(113, 22);
            this.btnView.Text = "View";
            this.btnView.Click += new System.EventHandler(this.BtnView_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::ProjectManagement.Properties.Resources.refresh;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(113, 22);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // FrmBranchList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 467);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.radioButton1);
            this.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmBranchList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBranchList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBranchList_Load);
            this.ctmMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private Janus.Windows.GridEX.GridEX gridList;
        private System.Windows.Forms.Panel panel1;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.RadioButton rdoAllDays;
        private System.Windows.Forms.RadioButton rdoByDate;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.RadioButton rdoInactive;
        private System.Windows.Forms.RadioButton rdoActive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.ContextMenuStrip ctmMenu;
        private System.Windows.Forms.ToolStripMenuItem btnNew;
        private System.Windows.Forms.ToolStripMenuItem btnEdit;
        private System.Windows.Forms.ToolStripMenuItem btnView;
        private System.Windows.Forms.ToolStripMenuItem btnRefresh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}