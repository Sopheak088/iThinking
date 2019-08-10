namespace ProjectManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbon1 = new Janus.Windows.Ribbon.Ribbon();
            this.btnExit = new Janus.Windows.Ribbon.DropDownCommand();
            this.tabCusomerAndSale = new Janus.Windows.Ribbon.RibbonTab();
            this.ribbonGroup2 = new Janus.Windows.Ribbon.RibbonGroup();
            this.groupCustomer = new Janus.Windows.Ribbon.RibbonGroup();
            this.cmdCustomerProfile = new Janus.Windows.Ribbon.ButtonCommand();
            this.tabSupplierAndPurchase = new Janus.Windows.Ribbon.RibbonTab();
            this.ribbonGroup3 = new Janus.Windows.Ribbon.RibbonGroup();
            this.cmdSupplierProfile = new Janus.Windows.Ribbon.ButtonCommand();
            this.cmdPurchase = new Janus.Windows.Ribbon.DropDownCommand();
            this.cmdNewPurchase = new Janus.Windows.Ribbon.DropDownCommand();
            this.cmdPurchaseList = new Janus.Windows.Ribbon.DropDownCommand();
            this.tabWarehouseAndProduct = new Janus.Windows.Ribbon.RibbonTab();
            this.tabAccountant = new Janus.Windows.Ribbon.RibbonTab();
            this.tabSystemAndManagement = new Janus.Windows.Ribbon.RibbonTab();
            this.uiPanelManager1 = new Janus.Windows.UI.Dock.UIPanelManager(this.components);
            this.panelList = new Janus.Windows.UI.Dock.UIPanelGroup();
            this.ribbonGroup1 = new Janus.Windows.Ribbon.RibbonGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelList)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.BackstageMenuData = "<?xml version=\"1.0\" encoding=\"utf-8\"?><BackstageMenu><ImageKey /><Key /><Text>Fil" +
    "e</Text></BackstageMenu>";
            this.ribbon1.ControlBoxMenu.LeftCommands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.btnExit});
            // 
            // 
            // 
            this.ribbon1.HelpButton.Image = ((System.Drawing.Image)(resources.GetObject("ribbon1.HelpButton.Image")));
            this.ribbon1.HelpButton.Key = "HelpButton";
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Name = "ribbon1";
            this.ribbon1.Size = new System.Drawing.Size(831, 168);
            // 
            // 
            // 
            this.ribbon1.SuperTipComponent.AutoPopDelay = 2000;
            this.ribbon1.SuperTipComponent.Font = new System.Drawing.Font("Hanuman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbon1.SuperTipComponent.ImageList = null;
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.AddRange(new Janus.Windows.Ribbon.RibbonTab[] {
            this.tabCusomerAndSale,
            this.tabSupplierAndPurchase,
            this.tabWarehouseAndProduct,
            this.tabAccountant,
            this.tabSystemAndManagement});
            this.ribbon1.Text = "";
            // 
            // btnExit
            // 
            this.btnExit.Key = "dropDownCommand1";
            this.btnExit.Name = "btnExit";
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new Janus.Windows.Ribbon.CommandEventHandler(this.BtnExit_Click);
            // 
            // tabCusomerAndSale
            // 
            this.tabCusomerAndSale.Groups.AddRange(new Janus.Windows.Ribbon.RibbonGroup[] {
            this.ribbonGroup2,
            this.groupCustomer});
            this.tabCusomerAndSale.Key = "ribbonTab1";
            this.tabCusomerAndSale.Name = "tabCusomerAndSale";
            this.tabCusomerAndSale.Text = "Customer & Sale";
            // 
            // ribbonGroup2
            // 
            this.ribbonGroup2.DialogButtonSuperTipSettings.ImageListProvider = this.ribbonGroup2;
            this.ribbonGroup2.Key = "ribbonGroup2";
            this.ribbonGroup2.Name = "ribbonGroup2";
            this.ribbonGroup2.Text = "Group 0";
            // 
            // groupCustomer
            // 
            this.groupCustomer.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.cmdCustomerProfile});
            this.groupCustomer.DialogButtonSuperTipSettings.ImageListProvider = this.groupCustomer;
            this.groupCustomer.Key = "ribbonGroup3";
            this.groupCustomer.Name = "groupCustomer";
            this.groupCustomer.Text = "Customer and Sale";
            // 
            // cmdCustomerProfile
            // 
            this.cmdCustomerProfile.Image = ((System.Drawing.Image)(resources.GetObject("cmdCustomerProfile.Image")));
            this.cmdCustomerProfile.Key = "buttonCommand1";
            this.cmdCustomerProfile.Name = "cmdCustomerProfile";
            this.cmdCustomerProfile.Text = "Customer Profile";
            // 
            // tabSupplierAndPurchase
            // 
            this.tabSupplierAndPurchase.Groups.AddRange(new Janus.Windows.Ribbon.RibbonGroup[] {
            this.ribbonGroup3});
            this.tabSupplierAndPurchase.Key = "ribbonTab2";
            this.tabSupplierAndPurchase.Name = "tabSupplierAndPurchase";
            this.tabSupplierAndPurchase.Text = "Supplier & Purchase";
            // 
            // ribbonGroup3
            // 
            this.ribbonGroup3.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.cmdSupplierProfile,
            this.cmdPurchase});
            this.ribbonGroup3.DialogButtonSuperTipSettings.ImageListProvider = this.ribbonGroup3;
            this.ribbonGroup3.Key = "ribbonGroup3";
            this.ribbonGroup3.Name = "ribbonGroup3";
            this.ribbonGroup3.Text = "Group 0";
            // 
            // cmdSupplierProfile
            // 
            this.cmdSupplierProfile.Image = ((System.Drawing.Image)(resources.GetObject("cmdSupplierProfile.Image")));
            this.cmdSupplierProfile.Key = "buttonCommand1";
            this.cmdSupplierProfile.Name = "cmdSupplierProfile";
            this.cmdSupplierProfile.Text = "Supplier Profile";
            // 
            // cmdPurchase
            // 
            this.cmdPurchase.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.cmdNewPurchase,
            this.cmdPurchaseList});
            this.cmdPurchase.Image = ((System.Drawing.Image)(resources.GetObject("cmdPurchase.Image")));
            this.cmdPurchase.Key = "dropDownCommand1";
            this.cmdPurchase.Name = "cmdPurchase";
            this.cmdPurchase.Text = "Purchase";
            // 
            // cmdNewPurchase
            // 
            this.cmdNewPurchase.Image = ((System.Drawing.Image)(resources.GetObject("cmdNewPurchase.Image")));
            this.cmdNewPurchase.Key = "dropDownCommand1";
            this.cmdNewPurchase.Name = "cmdNewPurchase";
            this.cmdNewPurchase.Text = "New Purchase";
            // 
            // cmdPurchaseList
            // 
            this.cmdPurchaseList.Image = ((System.Drawing.Image)(resources.GetObject("cmdPurchaseList.Image")));
            this.cmdPurchaseList.Key = "dropDownCommand2";
            this.cmdPurchaseList.Name = "cmdPurchaseList";
            this.cmdPurchaseList.Text = "Purchase List";
            // 
            // tabWarehouseAndProduct
            // 
            this.tabWarehouseAndProduct.Key = "ribbonTab3";
            this.tabWarehouseAndProduct.Name = "tabWarehouseAndProduct";
            this.tabWarehouseAndProduct.Text = "Warehouse & Product";
            // 
            // tabAccountant
            // 
            this.tabAccountant.Key = "ribbonTab4";
            this.tabAccountant.Name = "tabAccountant";
            this.tabAccountant.Text = "Accountant";
            // 
            // tabSystemAndManagement
            // 
            this.tabSystemAndManagement.Key = "ribbonTab5";
            this.tabSystemAndManagement.Name = "tabSystemAndManagement";
            this.tabSystemAndManagement.Text = "System & Management";
            // 
            // uiPanelManager1
            // 
            this.uiPanelManager1.ContainerControl = this;
            this.panelList.Id = new System.Guid("787c1c43-3b1f-4e86-ba20-1138e26e9c31");
            this.panelList.StaticGroup = true;
            this.uiPanelManager1.Panels.Add(this.panelList);
            // 
            // Design Time Panel Info:
            // 
            this.uiPanelManager1.BeginPanelInfo();
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("787c1c43-3b1f-4e86-ba20-1138e26e9c31"), Janus.Windows.UI.Dock.PanelGroupStyle.Tab, Janus.Windows.UI.Dock.PanelDockStyle.Fill, true, new System.Drawing.Size(825, 210), true);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("787c1c43-3b1f-4e86-ba20-1138e26e9c31"), Janus.Windows.UI.Dock.PanelGroupStyle.Tab, true, new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager1.EndPanelInfo();
            // 
            // panelList
            // 
            this.panelList.GroupStyle = Janus.Windows.UI.Dock.PanelGroupStyle.Tab;
            this.panelList.Location = new System.Drawing.Point(3, 171);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(825, 210);
            this.panelList.TabIndex = 4;
            this.panelList.Text = "Panel 0";
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.DialogButtonSuperTipSettings.ImageListProvider = this.ribbonGroup1;
            this.ribbonGroup1.Key = "ribbonGroup1";
            this.ribbonGroup1.Name = "ribbonGroup1";
            this.ribbonGroup1.Text = "Group 0";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 384);
            this.Controls.Add(this.panelList);
            this.Controls.Add(this.ribbon1);
            this.Font = new System.Drawing.Font("Hanuman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.Ribbon.Ribbon ribbon1;
        private Janus.Windows.Ribbon.RibbonTab tabCusomerAndSale;
        private Janus.Windows.UI.Dock.UIPanelManager uiPanelManager1;
        private Janus.Windows.UI.Dock.UIPanelGroup panelList;
        private Janus.Windows.Ribbon.RibbonTab tabSupplierAndPurchase;
        private Janus.Windows.Ribbon.RibbonTab tabWarehouseAndProduct;
        private Janus.Windows.Ribbon.RibbonTab tabAccountant;
        private Janus.Windows.Ribbon.RibbonTab tabSystemAndManagement;
        private Janus.Windows.Ribbon.DropDownCommand btnExit;
        private Janus.Windows.Ribbon.RibbonGroup ribbonGroup1;
        private Janus.Windows.Ribbon.RibbonGroup ribbonGroup2;
        private Janus.Windows.Ribbon.RibbonGroup groupCustomer;
        private Janus.Windows.Ribbon.ButtonCommand cmdCustomerProfile;
        private Janus.Windows.Ribbon.RibbonGroup ribbonGroup3;
        private Janus.Windows.Ribbon.ButtonCommand cmdSupplierProfile;
        private Janus.Windows.Ribbon.DropDownCommand cmdPurchase;
        private Janus.Windows.Ribbon.DropDownCommand cmdNewPurchase;
        private Janus.Windows.Ribbon.DropDownCommand cmdPurchaseList;
    }
}