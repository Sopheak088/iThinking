namespace ProjectManagement.Category.View
{
    partial class FrmCategoryList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoryList));
            this.panelMain = new System.Windows.Forms.Panel();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoByDate = new Janus.Windows.EditControls.UIRadioButton();
            this.rdoAllDays = new Janus.Windows.EditControls.UIRadioButton();
            this.gridList = new Janus.Windows.GridEX.GridEX();
            this.CtmsMenuBar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnView = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).BeginInit();
            this.CtmsMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.gridList);
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.uiGroupBox1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(929, 381);
            this.panelMain.TabIndex = 0;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.btnSearch);
            this.uiGroupBox1.Controls.Add(this.txtKeyword);
            this.uiGroupBox1.Controls.Add(this.label3);
            this.uiGroupBox1.Controls.Add(this.panel1);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(929, 77);
            this.uiGroupBox1.TabIndex = 1;
            this.uiGroupBox1.Text = "Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::ProjectManagement.Properties.Resources.search;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(819, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(625, 37);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(188, 20);
            this.txtKeyword.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Keyword";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rdoByDate);
            this.panel1.Controls.Add(this.rdoAllDays);
            this.panel1.Location = new System.Drawing.Point(36, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 51);
            this.panel1.TabIndex = 0;
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd/MM/yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(322, 15);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(106, 20);
            this.dtpTo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "To";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(177, 15);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(106, 20);
            this.dtpFrom.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "From";
            // 
            // rdoByDate
            // 
            this.rdoByDate.Location = new System.Drawing.Point(67, 15);
            this.rdoByDate.Name = "rdoByDate";
            this.rdoByDate.Size = new System.Drawing.Size(73, 23);
            this.rdoByDate.TabIndex = 2;
            this.rdoByDate.Text = "By Date";
            this.rdoByDate.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
            this.rdoByDate.CheckedChanged += new System.EventHandler(this.RdoByDate_CheckedChanged);
            // 
            // rdoAllDays
            // 
            this.rdoAllDays.Checked = true;
            this.rdoAllDays.Location = new System.Drawing.Point(3, 15);
            this.rdoAllDays.Name = "rdoAllDays";
            this.rdoAllDays.Size = new System.Drawing.Size(73, 23);
            this.rdoAllDays.TabIndex = 1;
            this.rdoAllDays.TabStop = true;
            this.rdoAllDays.Text = "All Days";
            this.rdoAllDays.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
            this.rdoAllDays.CheckedChanged += new System.EventHandler(this.RdoAllDays_CheckedChanged);
            // 
            // gridList
            // 
            this.gridList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridList.ColumnAutoResize = true;
            gridList_DesignTimeLayout.LayoutString = resources.GetString("gridList_DesignTimeLayout.LayoutString");
            this.gridList.DesignTimeLayout = gridList_DesignTimeLayout;
            this.gridList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridList.GroupByBoxVisible = false;
            this.gridList.Location = new System.Drawing.Point(0, 77);
            this.gridList.Name = "gridList";
            this.gridList.Size = new System.Drawing.Size(929, 304);
            this.gridList.TabIndex = 0;
            this.gridList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
            // 
            // CtmsMenuBar
            // 
            this.CtmsMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnEdit,
            this.btnView,
            this.btnRefresh});
            this.CtmsMenuBar.Name = "CtmsMenuBar";
            this.CtmsMenuBar.Size = new System.Drawing.Size(114, 92);
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
            this.btnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::ProjectManagement.Properties.Resources.refresh;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(113, 22);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(929, 304);
            this.panel2.TabIndex = 2;
            // 
            // FrmCategoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 381);
            this.ContextMenuStrip = this.CtmsMenuBar;
            this.Controls.Add(this.panelMain);
            this.MaximizeBox = false;
            this.Name = "FrmCategoryList";
            this.Text = "FrmCategoryList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCategoryList_Load);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).EndInit();
            this.CtmsMenuBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private Janus.Windows.GridEX.GridEX gridList;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.Panel panel1;
        private Janus.Windows.EditControls.UIRadioButton rdoByDate;
        private Janus.Windows.EditControls.UIRadioButton rdoAllDays;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip CtmsMenuBar;
        private System.Windows.Forms.ToolStripMenuItem btnNew;
        private System.Windows.Forms.ToolStripMenuItem btnEdit;
        private System.Windows.Forms.ToolStripMenuItem btnView;
        private System.Windows.Forms.ToolStripMenuItem btnRefresh;
        private System.Windows.Forms.Panel panel2;
    }
}