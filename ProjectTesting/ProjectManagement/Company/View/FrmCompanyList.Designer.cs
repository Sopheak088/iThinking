namespace ProjectManagement.Company.View
{
    partial class FrmCompanyList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompanyList));
            this.panelUser = new Janus.Windows.UI.Dock.UIPanel();
            this.panelUserContainer = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.uiPanel2 = new Janus.Windows.UI.Dock.UIPanel();
            this.uiPanel1Container = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.uiPanel1 = new Janus.Windows.UI.Dock.UIPanel();
            this.gridList = new Janus.Windows.GridEX.GridEX();
            this.ctmsMenuBar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnView = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.uiPanelManager1 = new Janus.Windows.UI.Dock.UIPanelManager(this.components);
            this.panelMain = new Janus.Windows.UI.Dock.UIPanelGroup();
            this.panelFilter = new Janus.Windows.UI.Dock.UIPanel();
            this.uiPanel3Container = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoByDate = new Janus.Windows.EditControls.UIRadioButton();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.rdoAllDays = new Janus.Windows.EditControls.UIRadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoInactive = new Janus.Windows.EditControls.UIRadioButton();
            this.rdoActive = new Janus.Windows.EditControls.UIRadioButton();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.UserList = new Janus.Windows.UI.Dock.UIPanel();
            this.panelDetail = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            ((System.ComponentModel.ISupportInitialize)(this.panelUser)).BeginInit();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel1)).BeginInit();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).BeginInit();
            this.ctmsMenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelFilter)).BeginInit();
            this.panelFilter.SuspendLayout();
            this.uiPanel3Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserList)).BeginInit();
            this.UserList.SuspendLayout();
            this.panelDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUser
            // 
            this.panelUser.InnerContainer = this.panelUserContainer;
            this.panelUser.Location = new System.Drawing.Point(0, 0);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(544, 204);
            this.panelUser.TabIndex = 4;
            this.panelUser.Text = "User List";
            // 
            // panelUserContainer
            // 
            this.panelUserContainer.Location = new System.Drawing.Point(0, 0);
            this.panelUserContainer.Name = "panelUserContainer";
            this.panelUserContainer.Size = new System.Drawing.Size(544, 204);
            this.panelUserContainer.TabIndex = 0;
            // 
            // uiPanel2
            // 
            this.uiPanel2.FloatingLocation = new System.Drawing.Point(284, 233);
            this.uiPanel2.FloatingSize = new System.Drawing.Size(588, 200);
            this.uiPanel2.Location = new System.Drawing.Point(3, 3);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(588, 200);
            this.uiPanel2.TabIndex = 4;
            this.uiPanel2.Text = "Panel 2";
            // 
            // uiPanel1Container
            // 
            this.uiPanel1Container.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1Container.Name = "uiPanel1Container";
            this.uiPanel1Container.Size = new System.Drawing.Size(613, 88);
            this.uiPanel1Container.TabIndex = 0;
            // 
            // uiPanel1
            // 
            this.uiPanel1.FloatingLocation = new System.Drawing.Point(285, 135);
            this.uiPanel1.FloatingSize = new System.Drawing.Size(613, 88);
            this.uiPanel1.InnerContainer = this.uiPanel1Container;
            this.uiPanel1.Location = new System.Drawing.Point(3, 3);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(613, 88);
            this.uiPanel1.TabIndex = 4;
            this.uiPanel1.Text = "Panel 1";
            // 
            // gridList
            // 
            this.gridList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridList.ColumnAutoResize = true;
            this.gridList.ContextMenuStrip = this.ctmsMenuBar;
            gridList_DesignTimeLayout.LayoutString = resources.GetString("gridList_DesignTimeLayout.LayoutString");
            this.gridList.DesignTimeLayout = gridList_DesignTimeLayout;
            this.gridList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridList.FilterMode = Janus.Windows.GridEX.FilterMode.Manual;
            this.gridList.GroupByBoxVisible = false;
            this.gridList.Location = new System.Drawing.Point(0, 0);
            this.gridList.Name = "gridList";
            this.gridList.Size = new System.Drawing.Size(923, 144);
            this.gridList.TabIndex = 0;
            this.gridList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
            // 
            // ctmsMenuBar
            // 
            this.ctmsMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnEdit,
            this.btnView,
            this.btnRefresh});
            this.ctmsMenuBar.Name = "ctmsMenuBar";
            this.ctmsMenuBar.Size = new System.Drawing.Size(114, 92);
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
            // uiPanelManager1
            // 
            this.uiPanelManager1.ContainerControl = this;
            this.panelMain.Id = new System.Guid("83d2dcb8-0ffb-4873-a353-729b3b733fd4");
            this.panelMain.StaticGroup = true;
            this.panelFilter.Id = new System.Guid("de1f1912-d111-4b4e-b42f-826bd482fd17");
            this.panelMain.Panels.Add(this.panelFilter);
            this.UserList.Id = new System.Guid("d6333d30-d61f-4a07-ad93-c40bce8116bb");
            this.panelMain.Panels.Add(this.UserList);
            this.uiPanelManager1.Panels.Add(this.panelMain);
            // 
            // Design Time Panel Info:
            // 
            this.uiPanelManager1.BeginPanelInfo();
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("83d2dcb8-0ffb-4873-a353-729b3b733fd4"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, Janus.Windows.UI.Dock.PanelDockStyle.Fill, true, new System.Drawing.Size(925, 214), true);
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("de1f1912-d111-4b4e-b42f-826bd482fd17"), new System.Guid("83d2dcb8-0ffb-4873-a353-729b3b733fd4"), 48, true);
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("d6333d30-d61f-4a07-ad93-c40bce8116bb"), new System.Guid("83d2dcb8-0ffb-4873-a353-729b3b733fd4"), 335, true);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("83d2dcb8-0ffb-4873-a353-729b3b733fd4"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, true, new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("de1f1912-d111-4b4e-b42f-826bd482fd17"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("d6333d30-d61f-4a07-ad93-c40bce8116bb"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager1.EndPanelInfo();
            // 
            // panelMain
            // 
            this.panelMain.CaptionFormatStyle.BackColor = System.Drawing.Color.White;
            this.panelMain.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.True;
            this.panelMain.Location = new System.Drawing.Point(3, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(925, 214);
            this.panelMain.TabIndex = 4;
            // 
            // panelFilter
            // 
            this.panelFilter.CaptionVisible = Janus.Windows.UI.InheritableBoolean.False;
            this.panelFilter.InnerContainer = this.uiPanel3Container;
            this.panelFilter.Location = new System.Drawing.Point(0, 24);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(925, 40);
            this.panelFilter.TabIndex = 4;
            this.panelFilter.Text = "Filter";
            // 
            // uiPanel3Container
            // 
            this.uiPanel3Container.Controls.Add(this.uiGroupBox1);
            this.uiPanel3Container.Location = new System.Drawing.Point(1, 1);
            this.uiPanel3Container.Name = "uiPanel3Container";
            this.uiPanel3Container.Size = new System.Drawing.Size(923, 38);
            this.uiPanel3Container.TabIndex = 0;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.panel1);
            this.uiGroupBox1.Controls.Add(this.btnSearch);
            this.uiGroupBox1.Controls.Add(this.label3);
            this.uiGroupBox1.Controls.Add(this.rdoInactive);
            this.uiGroupBox1.Controls.Add(this.rdoActive);
            this.uiGroupBox1.Controls.Add(this.txtKeyword);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(923, 38);
            this.uiGroupBox1.TabIndex = 0;
            this.uiGroupBox1.Text = "Filter";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rdoByDate);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.rdoAllDays);
            this.panel1.Location = new System.Drawing.Point(34, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 38);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "To";
            // 
            // rdoByDate
            // 
            this.rdoByDate.Location = new System.Drawing.Point(76, 4);
            this.rdoByDate.Name = "rdoByDate";
            this.rdoByDate.Size = new System.Drawing.Size(73, 23);
            this.rdoByDate.TabIndex = 19;
            this.rdoByDate.Text = "By Date";
            this.rdoByDate.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
            this.rdoByDate.CheckedChanged += new System.EventHandler(this.RdoByDate_CheckedChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(185, 4);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(100, 26);
            this.dtpFrom.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "From";
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd/MM/yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(313, 4);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(100, 26);
            this.dtpTo.TabIndex = 21;
            // 
            // rdoAllDays
            // 
            this.rdoAllDays.Checked = true;
            this.rdoAllDays.Location = new System.Drawing.Point(4, 4);
            this.rdoAllDays.Name = "rdoAllDays";
            this.rdoAllDays.Size = new System.Drawing.Size(66, 23);
            this.rdoAllDays.TabIndex = 18;
            this.rdoAllDays.TabStop = true;
            this.rdoAllDays.Text = "All Days";
            this.rdoAllDays.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
            this.rdoAllDays.CheckedChanged += new System.EventHandler(this.RdoAllDays_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::ProjectManagement.Properties.Resources.search;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(817, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 26);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(604, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Keyword";
            // 
            // rdoInactive
            // 
            this.rdoInactive.Location = new System.Drawing.Point(525, 17);
            this.rdoInactive.Name = "rdoInactive";
            this.rdoInactive.Size = new System.Drawing.Size(73, 23);
            this.rdoInactive.TabIndex = 8;
            this.rdoInactive.Text = "Inactive";
            this.rdoInactive.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
            // 
            // rdoActive
            // 
            this.rdoActive.Checked = true;
            this.rdoActive.Location = new System.Drawing.Point(466, 17);
            this.rdoActive.Name = "rdoActive";
            this.rdoActive.Size = new System.Drawing.Size(66, 23);
            this.rdoActive.TabIndex = 7;
            this.rdoActive.TabStop = true;
            this.rdoActive.Text = "Active";
            this.rdoActive.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(662, 17);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(149, 26);
            this.txtKeyword.TabIndex = 6;
            // 
            // UserList
            // 
            this.UserList.CaptionVisible = Janus.Windows.UI.InheritableBoolean.False;
            this.UserList.InnerContainer = this.panelDetail;
            this.UserList.Location = new System.Drawing.Point(0, 68);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(925, 146);
            this.UserList.TabIndex = 4;
            // 
            // panelDetail
            // 
            this.panelDetail.Controls.Add(this.gridList);
            this.panelDetail.Location = new System.Drawing.Point(1, 1);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(923, 144);
            this.panelDetail.TabIndex = 0;
            // 
            // FrmCompanyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 220);
            this.ControlBox = false;
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Hanuman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCompanyList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCompanyList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelUser)).EndInit();
            this.panelUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel1)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).EndInit();
            this.ctmsMenuBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).EndInit();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelFilter)).EndInit();
            this.panelFilter.ResumeLayout(false);
            this.uiPanel3Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserList)).EndInit();
            this.UserList.ResumeLayout(false);
            this.panelDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.UI.Dock.UIPanel panelUser;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer panelUserContainer;
        private Janus.Windows.UI.Dock.UIPanel uiPanel2;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uiPanel1Container;
        private Janus.Windows.UI.Dock.UIPanel uiPanel1;
        private Janus.Windows.GridEX.GridEX gridList;
        private Janus.Windows.UI.Dock.UIPanelManager uiPanelManager1;
        private Janus.Windows.UI.Dock.UIPanelGroup panelMain;
        private Janus.Windows.UI.Dock.UIPanel panelFilter;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uiPanel3Container;
        private Janus.Windows.UI.Dock.UIPanel UserList;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer panelDetail;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private Janus.Windows.EditControls.UIRadioButton rdoInactive;
        private Janus.Windows.EditControls.UIRadioButton rdoActive;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Janus.Windows.EditControls.UIRadioButton rdoByDate;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private Janus.Windows.EditControls.UIRadioButton rdoAllDays;
        private System.Windows.Forms.ContextMenuStrip ctmsMenuBar;
        private System.Windows.Forms.ToolStripMenuItem btnNew;
        private System.Windows.Forms.ToolStripMenuItem btnEdit;
        private System.Windows.Forms.ToolStripMenuItem btnView;
        private System.Windows.Forms.ToolStripMenuItem btnRefresh;
    }
}