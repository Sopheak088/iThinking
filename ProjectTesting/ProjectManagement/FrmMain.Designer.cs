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
            this.groupCustomer = new Janus.Windows.Ribbon.RibbonGroup();
            this.cmdCustomerProfile = new Janus.Windows.Ribbon.ButtonCommand();
            this.tabSupplierAndPurchase = new Janus.Windows.Ribbon.RibbonTab();
            this.ribbonGroup3 = new Janus.Windows.Ribbon.RibbonGroup();
            this.cmdSupplierProfile = new Janus.Windows.Ribbon.ButtonCommand();
            this.cmdPurchase = new Janus.Windows.Ribbon.DropDownCommand();
            this.cmdNewPurchase = new Janus.Windows.Ribbon.DropDownCommand();
            this.cmdPurchaseList = new Janus.Windows.Ribbon.DropDownCommand();
            this.Product = new Janus.Windows.Ribbon.RibbonTab();
            this.ribbonGroup7 = new Janus.Windows.Ribbon.RibbonGroup();
            this.btnProduct = new Janus.Windows.Ribbon.ButtonCommand();
            this.btnProductForSale = new Janus.Windows.Ribbon.ButtonCommand();
            this.tabAccountant = new Janus.Windows.Ribbon.RibbonTab();
            this.tabSystemAndManagement = new Janus.Windows.Ribbon.RibbonTab();
            this.ribbonGroup4 = new Janus.Windows.Ribbon.RibbonGroup();
            this.cmdUser = new Janus.Windows.Ribbon.ButtonCommand();
            this.ribbonGroup5 = new Janus.Windows.Ribbon.RibbonGroup();
            this.btnCompany = new Janus.Windows.Ribbon.ButtonCommand();
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
            this.ribbon1.Size = new System.Drawing.Size(727, 159);
            // 
            // 
            // 
            this.ribbon1.SuperTipComponent.AutoPopDelay = 2000;
            this.ribbon1.SuperTipComponent.Font = new System.Drawing.Font("Hanuman", 9F);
            this.ribbon1.SuperTipComponent.ImageList = null;
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.AddRange(new Janus.Windows.Ribbon.RibbonTab[] {
            this.tabCusomerAndSale,
            this.tabSupplierAndPurchase,
            this.Product,
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
            this.groupCustomer});
            this.tabCusomerAndSale.Key = "ribbonTab1";
            this.tabCusomerAndSale.Name = "tabCusomerAndSale";
            this.tabCusomerAndSale.Text = "Customer & Sale";
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
            this.ribbonGroup3.Text = "Supplier and Purchase";
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
            // Product
            // 
            this.Product.Groups.AddRange(new Janus.Windows.Ribbon.RibbonGroup[] {
            this.ribbonGroup7});
            this.Product.Key = "ribbonTab3";
            this.Product.Name = "Product";
            this.Product.Text = "Branch & Product";
            // 
            // ribbonGroup7
            // 
            this.ribbonGroup7.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.btnProduct,
            this.btnProductForSale});
            this.ribbonGroup7.DialogButtonSuperTipSettings.ImageListProvider = this.ribbonGroup7;
            this.ribbonGroup7.Key = "ribbonGroup7";
            this.ribbonGroup7.Name = "ribbonGroup7";
            this.ribbonGroup7.Text = "Product";
            // 
            // btnProduct
            // 
            this.btnProduct.Key = "buttonCommand1";
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Text = "Product";
            // 
            // btnProductForSale
            // 
            this.btnProductForSale.Key = "buttonCommand1";
            this.btnProductForSale.Name = "btnProductForSale";
            this.btnProductForSale.Text = "Product for Sale";
            // 
            // tabAccountant
            // 
            this.tabAccountant.Key = "ribbonTab4";
            this.tabAccountant.Name = "tabAccountant";
            this.tabAccountant.Text = "Accountant";
            // 
            // tabSystemAndManagement
            // 
            this.tabSystemAndManagement.Groups.AddRange(new Janus.Windows.Ribbon.RibbonGroup[] {
            this.ribbonGroup4,
            this.ribbonGroup5});
            this.tabSystemAndManagement.Key = "ribbonTab5";
            this.tabSystemAndManagement.Name = "tabSystemAndManagement";
            this.tabSystemAndManagement.Text = "System & Management";
            // 
            // ribbonGroup4
            // 
            this.ribbonGroup4.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.cmdUser});
            this.ribbonGroup4.DialogButtonSuperTipSettings.ImageListProvider = this.ribbonGroup4;
            this.ribbonGroup4.Key = "ribbonGroup4";
            this.ribbonGroup4.Name = "ribbonGroup4";
            // 
            // cmdUser
            // 
            this.cmdUser.Image = ((System.Drawing.Image)(resources.GetObject("cmdUser.Image")));
            this.cmdUser.Key = "cmdUser";
            this.cmdUser.Name = "cmdUser";
            this.cmdUser.Text = "User Account";
            this.cmdUser.Click += new Janus.Windows.Ribbon.CommandEventHandler(this.CmdUser_Click);
            // 
            // ribbonGroup5
            // 
            this.ribbonGroup5.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.btnCompany});
            this.ribbonGroup5.DialogButtonSuperTipSettings.ImageListProvider = this.ribbonGroup5;
            this.ribbonGroup5.Key = "ribbonGroup5";
            this.ribbonGroup5.Name = "ribbonGroup5";
            // 
            // btnCompany
            // 
            this.btnCompany.Image = ((System.Drawing.Image)(resources.GetObject("btnCompany.Image")));
            this.btnCompany.Key = "buttonCommand1";
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Text = "Company";
            this.btnCompany.Click += new Janus.Windows.Ribbon.CommandEventHandler(this.BtnCompany_Click);
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
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("787c1c43-3b1f-4e86-ba20-1138e26e9c31"), Janus.Windows.UI.Dock.PanelGroupStyle.Tab, Janus.Windows.UI.Dock.PanelDockStyle.Fill, true, new System.Drawing.Size(721, 206), true);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("787c1c43-3b1f-4e86-ba20-1138e26e9c31"), Janus.Windows.UI.Dock.PanelGroupStyle.Tab, true, new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager1.EndPanelInfo();
            // 
            // panelList
            // 
            this.panelList.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.True;
            this.panelList.GroupStyle = Janus.Windows.UI.Dock.PanelGroupStyle.Tab;
            this.panelList.Location = new System.Drawing.Point(3, 162);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(721, 206);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 371);
            this.Controls.Add(this.panelList);
            this.Controls.Add(this.ribbon1);
            this.Font = new System.Drawing.Font("Hanuman", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale Inventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
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
        private Janus.Windows.Ribbon.RibbonTab Product;
        private Janus.Windows.Ribbon.RibbonTab tabAccountant;
        private Janus.Windows.Ribbon.RibbonTab tabSystemAndManagement;
        private Janus.Windows.Ribbon.DropDownCommand btnExit;
        private Janus.Windows.Ribbon.RibbonGroup ribbonGroup1;
        private Janus.Windows.Ribbon.RibbonGroup groupCustomer;
        private Janus.Windows.Ribbon.ButtonCommand cmdCustomerProfile;
        private Janus.Windows.Ribbon.RibbonGroup ribbonGroup3;
        private Janus.Windows.Ribbon.ButtonCommand cmdSupplierProfile;
        private Janus.Windows.Ribbon.DropDownCommand cmdPurchase;
        private Janus.Windows.Ribbon.DropDownCommand cmdNewPurchase;
        private Janus.Windows.Ribbon.DropDownCommand cmdPurchaseList;
        private Janus.Windows.Ribbon.RibbonGroup ribbonGroup4;
        private Janus.Windows.Ribbon.RibbonGroup ribbonGroup5;
        private Janus.Windows.Ribbon.ButtonCommand btnCompany;
        private Janus.Windows.Ribbon.ButtonCommand cmdUser;
        private Janus.Windows.Ribbon.RibbonGroup ribbonGroup7;
        private Janus.Windows.Ribbon.ButtonCommand btnProduct;
        private Janus.Windows.Ribbon.ButtonCommand btnProductForSale;
    }
}