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
            this.btnMemberShip = new Janus.Windows.Ribbon.ButtonCommand();
            this.ribbonGroup5 = new Janus.Windows.Ribbon.RibbonGroup();
            this.buttonCommand1 = new Janus.Windows.Ribbon.ButtonCommand();
            this.tabSupplierAndPurchase = new Janus.Windows.Ribbon.RibbonTab();
            this.ribbonGroup3 = new Janus.Windows.Ribbon.RibbonGroup();
            this.cmdSupplierProfile = new Janus.Windows.Ribbon.ButtonCommand();
            this.cmdPurchase = new Janus.Windows.Ribbon.DropDownCommand();
            this.cmdNewPurchase = new Janus.Windows.Ribbon.DropDownCommand();
            this.cmdPurchaseList = new Janus.Windows.Ribbon.DropDownCommand();
            this.Product = new Janus.Windows.Ribbon.RibbonTab();
            this.ribbonGroup7 = new Janus.Windows.Ribbon.RibbonGroup();
            this.btnProduct = new Janus.Windows.Ribbon.ButtonCommand();
            this.btnCategory = new Janus.Windows.Ribbon.ButtonCommand();
            this.ribbonGroup2 = new Janus.Windows.Ribbon.RibbonGroup();
            this.btnProductSize = new Janus.Windows.Ribbon.ButtonCommand();
            this.btnProductType = new Janus.Windows.Ribbon.ButtonCommand();
            this.dropDownCommand1 = new Janus.Windows.Ribbon.DropDownCommand();
            this.cmdAddProductMenu = new Janus.Windows.Ribbon.DropDownCommand();
            this.dropDownCommand2 = new Janus.Windows.Ribbon.DropDownCommand();
            this.cmdAddProductSize = new Janus.Windows.Ribbon.DropDownCommand();
            this.cmdAddProductType = new Janus.Windows.Ribbon.DropDownCommand();
            this.ribbonGroup6 = new Janus.Windows.Ribbon.RibbonGroup();
            this.dropDownCommand3 = new Janus.Windows.Ribbon.DropDownCommand();
            this.cmdAddCompany = new Janus.Windows.Ribbon.DropDownCommand();
            this.cmdCompanyList = new Janus.Windows.Ribbon.DropDownCommand();
            this.dropDownCommand4 = new Janus.Windows.Ribbon.DropDownCommand();
            this.cmdAddBranch = new Janus.Windows.Ribbon.DropDownCommand();
            this.cmdBranch = new Janus.Windows.Ribbon.DropDownCommand();
            this.tabAccountant = new Janus.Windows.Ribbon.RibbonTab();
            this.tabSystemAndManagement = new Janus.Windows.Ribbon.RibbonTab();
            this.ribbonGroup4 = new Janus.Windows.Ribbon.RibbonGroup();
            this.cmdUser = new Janus.Windows.Ribbon.ButtonCommand();
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
            this.ribbon1.Size = new System.Drawing.Size(727, 163);
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
            this.groupCustomer,
            this.ribbonGroup5});
            this.tabCusomerAndSale.Key = "ribbonTab1";
            this.tabCusomerAndSale.Name = "tabCusomerAndSale";
            this.tabCusomerAndSale.Text = "Customer & Sale";
            // 
            // groupCustomer
            // 
            this.groupCustomer.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.cmdCustomerProfile,
            this.btnMemberShip});
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
            // btnMemberShip
            // 
            this.btnMemberShip.Image = ((System.Drawing.Image)(resources.GetObject("btnMemberShip.Image")));
            this.btnMemberShip.Key = "buttonCommand4";
            this.btnMemberShip.Name = "btnMemberShip";
            this.btnMemberShip.Text = "Member ship";
            // 
            // ribbonGroup5
            // 
            this.ribbonGroup5.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.buttonCommand1});
            this.ribbonGroup5.DialogButtonSuperTipSettings.ImageListProvider = this.ribbonGroup5;
            this.ribbonGroup5.Key = "ribbonGroup5";
            this.ribbonGroup5.Name = "ribbonGroup5";
            this.ribbonGroup5.Text = "POS";
            // 
            // buttonCommand1
            // 
            this.buttonCommand1.Image = ((System.Drawing.Image)(resources.GetObject("buttonCommand1.Image")));
            this.buttonCommand1.Key = "buttonCommand1";
            this.buttonCommand1.Name = "buttonCommand1";
            this.buttonCommand1.Text = "POS Screen";
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
            this.ribbonGroup7,
            this.ribbonGroup2,
            this.ribbonGroup6});
            this.Product.Key = "ribbonTab3";
            this.Product.Name = "Product";
            this.Product.Text = "Branch & Product";
            // 
            // ribbonGroup7
            // 
            this.ribbonGroup7.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.btnProduct,
            this.btnCategory});
            this.ribbonGroup7.DialogButtonSuperTipSettings.ImageListProvider = this.ribbonGroup7;
            this.ribbonGroup7.Key = "ribbonGroup7";
            this.ribbonGroup7.Name = "ribbonGroup7";
            this.ribbonGroup7.Text = "Product";
            // 
            // btnProduct
            // 
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.Key = "buttonCommand1";
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Text = "Product";
            // 
            // btnCategory
            // 
            this.btnCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnCategory.Image")));
            this.btnCategory.Key = "buttonCommand1";
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Text = "Category";
            // 
            // ribbonGroup2
            // 
            this.ribbonGroup2.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.btnProductSize,
            this.btnProductType,
            this.dropDownCommand1});
            this.ribbonGroup2.DialogButtonSuperTipSettings.ImageListProvider = this.ribbonGroup2;
            this.ribbonGroup2.Key = "ribbonGroup2";
            this.ribbonGroup2.Name = "ribbonGroup2";
            this.ribbonGroup2.Text = "Menu";
            // 
            // btnProductSize
            // 
            this.btnProductSize.Image = ((System.Drawing.Image)(resources.GetObject("btnProductSize.Image")));
            this.btnProductSize.Key = "buttonCommand1";
            this.btnProductSize.Name = "btnProductSize";
            this.btnProductSize.SizeStyle = Janus.Windows.Ribbon.CommandSizeStyle.Small;
            this.btnProductSize.Text = "Product Size";
            // 
            // btnProductType
            // 
            this.btnProductType.Image = ((System.Drawing.Image)(resources.GetObject("btnProductType.Image")));
            this.btnProductType.Key = "buttonCommand2";
            this.btnProductType.Name = "btnProductType";
            this.btnProductType.SizeStyle = Janus.Windows.Ribbon.CommandSizeStyle.Small;
            this.btnProductType.Text = "Product Type";
            // 
            // dropDownCommand1
            // 
            this.dropDownCommand1.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.cmdAddProductMenu,
            this.dropDownCommand2,
            this.cmdAddProductSize,
            this.cmdAddProductType});
            this.dropDownCommand1.Image = ((System.Drawing.Image)(resources.GetObject("dropDownCommand1.Image")));
            this.dropDownCommand1.Key = "dropDownCommand1";
            this.dropDownCommand1.Name = "dropDownCommand1";
            this.dropDownCommand1.SizeStyle = Janus.Windows.Ribbon.CommandSizeStyle.Small;
            this.dropDownCommand1.Text = "Product Menu";
            // 
            // cmdAddProductMenu
            // 
            this.cmdAddProductMenu.Image = ((System.Drawing.Image)(resources.GetObject("cmdAddProductMenu.Image")));
            this.cmdAddProductMenu.Key = "dropDownCommand3";
            this.cmdAddProductMenu.Name = "cmdAddProductMenu";
            this.cmdAddProductMenu.Text = "Add Product Menu";
            // 
            // dropDownCommand2
            // 
            this.dropDownCommand2.Image = ((System.Drawing.Image)(resources.GetObject("dropDownCommand2.Image")));
            this.dropDownCommand2.Key = "dropDownCommand2";
            this.dropDownCommand2.Name = "dropDownCommand2";
            this.dropDownCommand2.Text = "Product Menu List";
            // 
            // cmdAddProductSize
            // 
            this.cmdAddProductSize.Image = ((System.Drawing.Image)(resources.GetObject("cmdAddProductSize.Image")));
            this.cmdAddProductSize.Key = "dropDownCommand4";
            this.cmdAddProductSize.Name = "cmdAddProductSize";
            this.cmdAddProductSize.Text = "Add Product Size";
            // 
            // cmdAddProductType
            // 
            this.cmdAddProductType.Image = ((System.Drawing.Image)(resources.GetObject("cmdAddProductType.Image")));
            this.cmdAddProductType.Key = "dropDownCommand5";
            this.cmdAddProductType.Name = "cmdAddProductType";
            this.cmdAddProductType.Text = "Add Product Type";
            // 
            // ribbonGroup6
            // 
            this.ribbonGroup6.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.dropDownCommand3,
            this.dropDownCommand4});
            this.ribbonGroup6.DialogButtonSuperTipSettings.ImageListProvider = this.ribbonGroup6;
            this.ribbonGroup6.Key = "ribbonGroup6";
            this.ribbonGroup6.Name = "ribbonGroup6";
            this.ribbonGroup6.Text = "Company";
            // 
            // dropDownCommand3
            // 
            this.dropDownCommand3.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.cmdAddCompany,
            this.cmdCompanyList});
            this.dropDownCommand3.Image = ((System.Drawing.Image)(resources.GetObject("dropDownCommand3.Image")));
            this.dropDownCommand3.Key = "dropDownCommand3";
            this.dropDownCommand3.Name = "dropDownCommand3";
            this.dropDownCommand3.Text = "Company";
            // 
            // cmdAddCompany
            // 
            this.cmdAddCompany.Image = ((System.Drawing.Image)(resources.GetObject("cmdAddCompany.Image")));
            this.cmdAddCompany.Key = "dropDownCommand4";
            this.cmdAddCompany.Name = "cmdAddCompany";
            this.cmdAddCompany.Text = "Add Company";
            this.cmdAddCompany.Click += new Janus.Windows.Ribbon.CommandEventHandler(this.CmdAddCompany_Click);
            // 
            // cmdCompanyList
            // 
            this.cmdCompanyList.Image = ((System.Drawing.Image)(resources.GetObject("cmdCompanyList.Image")));
            this.cmdCompanyList.Key = "dropDownCommand5";
            this.cmdCompanyList.Name = "cmdCompanyList";
            this.cmdCompanyList.Text = "Company List";
            this.cmdCompanyList.Click += new Janus.Windows.Ribbon.CommandEventHandler(this.CmdCompanyList_Click);
            // 
            // dropDownCommand4
            // 
            this.dropDownCommand4.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.cmdAddBranch,
            this.cmdBranch});
            this.dropDownCommand4.Image = ((System.Drawing.Image)(resources.GetObject("dropDownCommand4.Image")));
            this.dropDownCommand4.Key = "dropDownCommand4";
            this.dropDownCommand4.Name = "dropDownCommand4";
            this.dropDownCommand4.Text = "Branch";
            // 
            // cmdAddBranch
            // 
            this.cmdAddBranch.Image = ((System.Drawing.Image)(resources.GetObject("cmdAddBranch.Image")));
            this.cmdAddBranch.Key = "dropDownCommand5";
            this.cmdAddBranch.Name = "cmdAddBranch";
            this.cmdAddBranch.Text = "Add Branch";
            // 
            // cmdBranch
            // 
            this.cmdBranch.Image = ((System.Drawing.Image)(resources.GetObject("cmdBranch.Image")));
            this.cmdBranch.Key = "dropDownCommand6";
            this.cmdBranch.Name = "cmdBranch";
            this.cmdBranch.Text = "Branch List";
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
            this.ribbonGroup4});
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
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("787c1c43-3b1f-4e86-ba20-1138e26e9c31"), Janus.Windows.UI.Dock.PanelGroupStyle.Tab, Janus.Windows.UI.Dock.PanelDockStyle.Fill, true, new System.Drawing.Size(721, 204), true);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("787c1c43-3b1f-4e86-ba20-1138e26e9c31"), Janus.Windows.UI.Dock.PanelGroupStyle.Tab, true, new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager1.EndPanelInfo();
            // 
            // panelList
            // 
            this.panelList.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.True;
            this.panelList.GroupStyle = Janus.Windows.UI.Dock.PanelGroupStyle.Tab;
            this.panelList.Location = new System.Drawing.Point(3, 166);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(721, 204);
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
            this.ClientSize = new System.Drawing.Size(727, 373);
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
        private Janus.Windows.Ribbon.ButtonCommand cmdUser;
        private Janus.Windows.Ribbon.RibbonGroup ribbonGroup7;
        private Janus.Windows.Ribbon.ButtonCommand btnProduct;
        private Janus.Windows.Ribbon.ButtonCommand btnCategory;
        private Janus.Windows.Ribbon.RibbonGroup ribbonGroup2;
        private Janus.Windows.Ribbon.ButtonCommand btnProductSize;
        private Janus.Windows.Ribbon.ButtonCommand btnProductType;
        private Janus.Windows.Ribbon.ButtonCommand btnMemberShip;
        private Janus.Windows.Ribbon.DropDownCommand dropDownCommand1;
        private Janus.Windows.Ribbon.DropDownCommand cmdAddProductMenu;
        private Janus.Windows.Ribbon.DropDownCommand dropDownCommand2;
        private Janus.Windows.Ribbon.DropDownCommand cmdAddProductSize;
        private Janus.Windows.Ribbon.DropDownCommand cmdAddProductType;
        private Janus.Windows.Ribbon.RibbonGroup ribbonGroup6;
        private Janus.Windows.Ribbon.DropDownCommand dropDownCommand3;
        private Janus.Windows.Ribbon.DropDownCommand cmdAddCompany;
        private Janus.Windows.Ribbon.DropDownCommand cmdCompanyList;
        private Janus.Windows.Ribbon.DropDownCommand dropDownCommand4;
        private Janus.Windows.Ribbon.DropDownCommand cmdAddBranch;
        private Janus.Windows.Ribbon.DropDownCommand cmdBranch;
        private Janus.Windows.Ribbon.RibbonGroup ribbonGroup5;
        private Janus.Windows.Ribbon.ButtonCommand buttonCommand1;
    }
}