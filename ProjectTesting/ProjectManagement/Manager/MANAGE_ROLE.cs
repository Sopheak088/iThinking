using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Manager
{
    public static class MANAGE_ROLE
    {
        //Company
        public static bool ALLOW_ADD_COMPANY { get; set; }

        public static bool ALLOW_EDIT_COMPANY { get; set; }
        public static bool ALLOW_VIEW_COMPANY { get; set; }

        //Product
        public static bool ALLOW_ADD_PRODUCT { get; set; }

        public static bool ALLOW_EDIT_PRODUCT { get; set; }
        public static bool ALLOW_VIEW_PRODUCT { get; set; }

        //Category
        public static bool ALLOW_ADD_CATEGORY { get; set; }

        public static bool ALLOW_EDIT_CATEGORY { get; set; }
        public static bool ALLOW_VIEW_CATEGORY { get; set; }

        //Customer
        public static bool ALLOW_ADD_CUSTOMER { get; set; }

        public static bool ALLOW_EDIT_CUSTOMER { get; set; }
        public static bool ALLOW_VIEW_CUSTOMER { get; set; }

        //Staff
        public static bool ALLOW_ADD_STAFF { get; set; }

        public static bool ALLOW_EDIT_STAFF { get; set; }
        public static bool ALLOW_VIEW_STAFF { get; set; }

        //Invoice
        public static bool ALLOW_ADD_INVOCIE { get; set; }

        public static bool ALLOW_EDIT_INVOCIE { get; set; }
        public static bool ALLOW_VIEW_INVOCIE { get; set; }

        //Import
        public static bool ALLOW_ADD_IMPORT { get; set; }

        public static bool ALLOW_EDIT_IMPORT { get; set; }
        public static bool ALLOW_VIEW_IMPORT { get; set; }

        //Supplier
        public static bool ALLOW_ADD_SUPPLIER { get; set; }

        public static bool ALLOW_EDIT_SUPPLIER { get; set; }
        public static bool ALLOW_VIEW_SUPPLIER { get; set; }

        //User
        public static bool ALLOW_ADD_USER { get; set; }

        public static bool ALLOW_EDIT_USER { get; set; }
        public static bool ALLOW_VIEW_USER { get; set; }

        //Branch
        public static bool ALLOW_ADD_BRANCH { get; set; }

        public static bool ALLOW_EDIT_BRANCH { get; set; }
        public static bool ALLOW_VIEW_BRANCH { get; set; }

        //Product Menu
        public static bool ALLOW_ADD_PRODUCT_MENU { get; set; }

        public static bool ALLOW_EDIT_PRODUCT_MENU { get; set; }
        public static bool ALLOW_VIEW_PRODUCT_MENU { get; set; }

        //Transfer
        public static bool ALLOW_ADD_TRANSFER_PRODUCT { get; set; }

        public static bool ALLOW_EDIT_TRANSFER_PRODUCT { get; set; }
        public static bool ALLOW_VIEW_TRANSFER_PRODUCT { get; set; }

        //Product Size
        public static bool ALLOW_ADD_PRODUCT_SIZE { get; set; }

        public static bool ALLOW_EDIT_PRODUCT_SIZE { get; set; }

        public static bool ALLOW_VIEW_PRODUCT_SIZE { get; set; }

        //Product Type
        public static bool ALLOW_ADD_PRODUCT_TYPE { get; set; }

        public static bool ALLOW_EDIT_PRODUCT_TYPE { get; set; }
        public static bool ALLOW_VIEW_PRODUCT_TYPE { get; set; }

        //Invoice
        public static bool ALLOW_ADD_INVOICE { get; set; }

        public static bool ALLOW_EDIT_INVOICE { get; set; }
        public static bool ALLOW_VIEW_INVOICE { get; set; }

        //Sell
        public static bool ALLOW_SELL { get; set; }

        public static void LoadRole()
        {
            //Company
            ALLOW_ADD_COMPANY = true;
            ALLOW_EDIT_COMPANY = true;
            ALLOW_VIEW_COMPANY = true;
            //Product
            ALLOW_ADD_PRODUCT = true;
            ALLOW_EDIT_PRODUCT = true;
            ALLOW_VIEW_PRODUCT = true;
            //Category
            ALLOW_ADD_CATEGORY = true;
            ALLOW_EDIT_CATEGORY = true;
            ALLOW_VIEW_CATEGORY = true;
            //Customer
            ALLOW_ADD_CUSTOMER = true;
            ALLOW_EDIT_CUSTOMER = true;
            ALLOW_VIEW_CUSTOMER = true;
            //Staff
            ALLOW_ADD_STAFF = true;
            ALLOW_EDIT_STAFF = true;
            ALLOW_VIEW_STAFF = true;
            //Invoice
            ALLOW_ADD_INVOCIE = true;
            ALLOW_EDIT_INVOCIE = true;
            ALLOW_VIEW_INVOCIE = true;
            //Import
            ALLOW_ADD_IMPORT = true;
            ALLOW_EDIT_IMPORT = true;
            ALLOW_VIEW_IMPORT = true;
            //Supplier
            ALLOW_ADD_SUPPLIER = true;
            ALLOW_EDIT_SUPPLIER = true;
            ALLOW_VIEW_SUPPLIER = true;
            //User
            ALLOW_ADD_USER = true;
            ALLOW_EDIT_USER = true;
            ALLOW_VIEW_USER = true;
            //Branch
            ALLOW_ADD_BRANCH = true;
            ALLOW_EDIT_BRANCH = true;
            ALLOW_VIEW_BRANCH = true;
            //Product Menu
            ALLOW_ADD_PRODUCT_MENU = true;
            ALLOW_EDIT_PRODUCT_MENU = true;
            ALLOW_VIEW_PRODUCT_MENU = true;
            //Transfer
            ALLOW_ADD_TRANSFER_PRODUCT = true;
            ALLOW_EDIT_TRANSFER_PRODUCT = true;
            ALLOW_VIEW_TRANSFER_PRODUCT = true;
            //Product Size
            ALLOW_ADD_PRODUCT_SIZE = true;
            ALLOW_EDIT_PRODUCT_SIZE = true;
            ALLOW_VIEW_PRODUCT_SIZE = true;
            //Product Type
            ALLOW_ADD_PRODUCT_TYPE = true;
            ALLOW_EDIT_PRODUCT_TYPE = true;
            ALLOW_VIEW_PRODUCT_TYPE = true;
            //Invoice
            ALLOW_ADD_INVOICE = true;
            ALLOW_EDIT_INVOICE = true;
            ALLOW_VIEW_INVOICE = true;
            //Sell
            ALLOW_SELL = true;
        }
    }
}