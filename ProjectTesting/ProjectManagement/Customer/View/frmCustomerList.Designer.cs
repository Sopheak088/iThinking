namespace ProjectManagement.Customer.View
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
            this.components = new System.ComponentModel.Container();
            Janus.Windows.GridEX.GridEXLayout gridList_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomerList));
            this.uiPanelManager1 = new Janus.Windows.UI.Dock.UIPanelManager(this.components);
            this.uiPanel2 = new Janus.Windows.UI.Dock.UIPanel();
            this.uiPanel2Container = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoInActive = new System.Windows.Forms.RadioButton();
            this.rdoActive = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.rdoByDate = new System.Windows.Forms.RadioButton();
            this.rdoAllDay = new System.Windows.Forms.RadioButton();
            this.uiPanel3 = new Janus.Windows.UI.Dock.UIPanel();
            this.uiPanel3Container = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.gridList = new Janus.Windows.GridEX.GridEX();
            this.ctmMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnView = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.uiPanel0 = new Janus.Windows.UI.Dock.UIPanel();
            this.uiPanel0Container = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.uiPanel1 = new Janus.Windows.UI.Dock.UIPanel();
            this.uiPanel1Container = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.uiPanelGroup1 = new Janus.Windows.UI.Dock.UIPanelGroup();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel2)).BeginInit();
            this.uiPanel2.SuspendLayout();
            this.uiPanel2Container.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel3)).BeginInit();
            this.uiPanel3.SuspendLayout();
            this.uiPanel3Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).BeginInit();
            this.ctmMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).BeginInit();
            this.uiPanel0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel1)).BeginInit();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelGroup1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPanelManager1
            // 
            this.uiPanelManager1.ContainerControl = this;
            this.uiPanel2.Id = new System.Guid("a2bdcdaf-4355-4979-97a7-6bbc1f8b7b59");
            this.uiPanelManager1.Panels.Add(this.uiPanel2);
            this.uiPanel3.Id = new System.Guid("f788f487-8cd6-4b6d-8d7c-11e464681a11");
            this.uiPanelManager1.Panels.Add(this.uiPanel3);
            // 
            // Design Time Panel Info:
            // 
            this.uiPanelManager1.BeginPanelInfo();
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("f788f487-8cd6-4b6d-8d7c-11e464681a11"), Janus.Windows.UI.Dock.PanelDockStyle.Fill, new System.Drawing.Size(794, 362), true);
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("a2bdcdaf-4355-4979-97a7-6bbc1f8b7b59"), Janus.Windows.UI.Dock.PanelDockStyle.Top, new System.Drawing.Size(794, 82), true);
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("5537e0cb-056e-43e1-9af5-f309a820f5da"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, Janus.Windows.UI.Dock.PanelDockStyle.Left, true, new System.Drawing.Size(200, 444), false);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("a2bdcdaf-4355-4979-97a7-6bbc1f8b7b59"), new System.Drawing.Point(343, 169), new System.Drawing.Size(755, 71), false);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("63cbfa5b-d13e-459b-a95b-7b2e5a72d55d"), new System.Drawing.Point(536, 361), new System.Drawing.Size(200, 200), false);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("f788f487-8cd6-4b6d-8d7c-11e464681a11"), new System.Drawing.Point(508, 376), new System.Drawing.Size(200, 200), false);
            this.uiPanelManager1.EndPanelInfo();
            // 
            // uiPanel2
            // 
            this.uiPanel2.AllowResize = Janus.Windows.UI.InheritableBoolean.True;
            this.uiPanel2.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.False;
            this.uiPanel2.FloatingLocation = new System.Drawing.Point(343, 169);
            this.uiPanel2.FloatingSize = new System.Drawing.Size(755, 71);
            this.uiPanel2.InnerContainer = this.uiPanel2Container;
            this.uiPanel2.Location = new System.Drawing.Point(3, 3);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(794, 82);
            this.uiPanel2.TabIndex = 4;
            this.uiPanel2.Text = "Filter";
            // 
            // uiPanel2Container
            // 
            this.uiPanel2Container.Controls.Add(this.btnSearch);
            this.uiPanel2Container.Controls.Add(this.txtSearch);
            this.uiPanel2Container.Controls.Add(this.label2);
            this.uiPanel2Container.Controls.Add(this.rdoInActive);
            this.uiPanel2Container.Controls.Add(this.rdoActive);
            this.uiPanel2Container.Controls.Add(this.panel1);
            this.uiPanel2Container.Location = new System.Drawing.Point(1, 23);
            this.uiPanel2Container.Name = "uiPanel2Container";
            this.uiPanel2Container.Size = new System.Drawing.Size(792, 54);
            this.uiPanel2Container.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::ProjectManagement.Properties.Resources.search;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(694, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(604, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(79, 20);
            this.txtSearch.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(550, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Keyword";
            // 
            // rdoInActive
            // 
            this.rdoInActive.AutoSize = true;
            this.rdoInActive.Location = new System.Drawing.Point(480, 21);
            this.rdoInActive.Name = "rdoInActive";
            this.rdoInActive.Size = new System.Drawing.Size(64, 17);
            this.rdoInActive.TabIndex = 2;
            this.rdoInActive.Text = "InActive";
            this.rdoInActive.UseVisualStyleBackColor = true;
            // 
            // rdoActive
            // 
            this.rdoActive.AutoSize = true;
            this.rdoActive.Checked = true;
            this.rdoActive.Location = new System.Drawing.Point(419, 20);
            this.rdoActive.Name = "rdoActive";
            this.rdoActive.Size = new System.Drawing.Size(55, 17);
            this.rdoActive.TabIndex = 1;
            this.rdoActive.TabStop = true;
            this.rdoActive.Text = "Active";
            this.rdoActive.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Controls.Add(this.rdoByDate);
            this.panel1.Controls.Add(this.rdoAllDay);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 54);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "To";
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(308, 20);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(98, 20);
            this.dtpTo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "From";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(172, 20);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(94, 20);
            this.dtpFrom.TabIndex = 2;
            // 
            // rdoByDate
            // 
            this.rdoByDate.AutoSize = true;
            this.rdoByDate.Location = new System.Drawing.Point(72, 21);
            this.rdoByDate.Name = "rdoByDate";
            this.rdoByDate.Size = new System.Drawing.Size(63, 17);
            this.rdoByDate.TabIndex = 1;
            this.rdoByDate.Text = "By Date";
            this.rdoByDate.UseVisualStyleBackColor = true;
            this.rdoByDate.CheckedChanged += new System.EventHandler(this.RdoByDate_CheckedChanged);
            // 
            // rdoAllDay
            // 
            this.rdoAllDay.AutoSize = true;
            this.rdoAllDay.Checked = true;
            this.rdoAllDay.Location = new System.Drawing.Point(3, 20);
            this.rdoAllDay.Name = "rdoAllDay";
            this.rdoAllDay.Size = new System.Drawing.Size(63, 17);
            this.rdoAllDay.TabIndex = 0;
            this.rdoAllDay.TabStop = true;
            this.rdoAllDay.Text = "All Days";
            this.rdoAllDay.UseVisualStyleBackColor = true;
            this.rdoAllDay.CheckedChanged += new System.EventHandler(this.RdoAllDay_CheckedChanged);
            // 
            // uiPanel3
            // 
            this.uiPanel3.FloatingLocation = new System.Drawing.Point(508, 376);
            this.uiPanel3.InnerContainer = this.uiPanel3Container;
            this.uiPanel3.Location = new System.Drawing.Point(3, 85);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.Size = new System.Drawing.Size(794, 362);
            this.uiPanel3.TabIndex = 4;
            // 
            // uiPanel3Container
            // 
            this.uiPanel3Container.Controls.Add(this.gridList);
            this.uiPanel3Container.Location = new System.Drawing.Point(1, 23);
            this.uiPanel3Container.Name = "uiPanel3Container";
            this.uiPanel3Container.Size = new System.Drawing.Size(792, 338);
            this.uiPanel3Container.TabIndex = 0;
            // 
            // gridList
            // 
            this.gridList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridList.ColumnAutoResize = true;
            this.gridList.ContextMenuStrip = this.ctmMenu;
            gridList_DesignTimeLayout.LayoutString = resources.GetString("gridList_DesignTimeLayout.LayoutString");
            this.gridList.DesignTimeLayout = gridList_DesignTimeLayout;
            this.gridList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridList.Location = new System.Drawing.Point(0, 0);
            this.gridList.Name = "gridList";
            this.gridList.Size = new System.Drawing.Size(792, 338);
            this.gridList.TabIndex = 0;
            this.gridList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
            // 
            // ctmMenu
            // 
            this.ctmMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnEdit,
            this.btnView,
            this.btnRefresh});
            this.ctmMenu.Name = "ctmMenu";
            this.ctmMenu.Size = new System.Drawing.Size(114, 92);
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
            // uiPanel0
            // 
            this.uiPanel0.InnerContainer = this.uiPanel0Container;
            this.uiPanel0.Location = new System.Drawing.Point(0, 0);
            this.uiPanel0.Name = "uiPanel0";
            this.uiPanel0.Size = new System.Drawing.Size(794, 423);
            this.uiPanel0.TabIndex = 4;
            // 
            // uiPanel0Container
            // 
            this.uiPanel0Container.Location = new System.Drawing.Point(0, 0);
            this.uiPanel0Container.Name = "uiPanel0Container";
            this.uiPanel0Container.Size = new System.Drawing.Size(794, 423);
            this.uiPanel0Container.TabIndex = 0;
            // 
            // uiPanel1
            // 
            this.uiPanel1.FloatingLocation = new System.Drawing.Point(536, 361);
            this.uiPanel1.InnerContainer = this.uiPanel1Container;
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(794, 423);
            this.uiPanel1.TabIndex = 4;
            this.uiPanel1.Text = "Panel 1";
            // 
            // uiPanel1Container
            // 
            this.uiPanel1Container.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1Container.Name = "uiPanel1Container";
            this.uiPanel1Container.Size = new System.Drawing.Size(794, 423);
            this.uiPanel1Container.TabIndex = 0;
            // 
            // uiPanelGroup1
            // 
            this.uiPanelGroup1.GroupStyle = Janus.Windows.UI.Dock.PanelGroupStyle.Tab;
            this.uiPanelGroup1.Location = new System.Drawing.Point(3, 3);
            this.uiPanelGroup1.Name = "uiPanelGroup1";
            this.uiPanelGroup1.Size = new System.Drawing.Size(794, 444);
            this.uiPanelGroup1.TabIndex = 0;
            // 
            // FrmCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiPanel3);
            this.Controls.Add(this.uiPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCustomerList";
            this.Text = "CustomerList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCustomerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel2)).EndInit();
            this.uiPanel2.ResumeLayout(false);
            this.uiPanel2Container.ResumeLayout(false);
            this.uiPanel2Container.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel3)).EndInit();
            this.uiPanel3.ResumeLayout(false);
            this.uiPanel3Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).EndInit();
            this.ctmMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).EndInit();
            this.uiPanel0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel1)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelGroup1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.UI.Dock.UIPanelManager uiPanelManager1;
        private Janus.Windows.UI.Dock.UIPanel uiPanel0;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uiPanel0Container;
        private Janus.Windows.UI.Dock.UIPanel uiPanel3;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uiPanel3Container;
        private Janus.Windows.UI.Dock.UIPanel uiPanel2;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uiPanel2Container;
        private Janus.Windows.UI.Dock.UIPanel uiPanel1;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uiPanel1Container;
        private Janus.Windows.UI.Dock.UIPanelGroup uiPanelGroup1;
        private System.Windows.Forms.RadioButton rdoInActive;
        private System.Windows.Forms.RadioButton rdoActive;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.RadioButton rdoByDate;
        private System.Windows.Forms.RadioButton rdoAllDay;
        private Janus.Windows.GridEX.GridEX gridList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip ctmMenu;
        private System.Windows.Forms.ToolStripMenuItem btnNew;
        private System.Windows.Forms.ToolStripMenuItem btnEdit;
        private System.Windows.Forms.ToolStripMenuItem btnView;
        private System.Windows.Forms.ToolStripMenuItem btnRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTo;
    }
}