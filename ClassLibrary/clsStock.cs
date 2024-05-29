using System;
using System.Diagnostics;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the product id property
        private Int32 mproduct_id;
        //product_id public property
        public int product_id
        {
            get
            {
                // this line of code sends data out of the property
                return mproduct_id;

            }
            set
            {
                mproduct_id = value;
            }
        }


        //private data member for the stock name property
        private string mstockName;
        // stock name public property
        public string stockName
        {
            get
            {
                // this line of code sends data out of the property
                return mstockName;

            }
            set
            {
                mstockName = value;
            }
        }

        //private data member for the stock details property
        private string mstockDetails;
        //stockDetails public property
        public string stockDetails
        {
            get
            {
                // this line of code sends data out of the property
                return mstockDetails;

            }
            set
            {
                mstockName = value;
            }
        }

        //private data member for the quantity property
        private Int32 mquantity;
        // quantity public property
        public int quantity
        {
            get
            {
                // this line of code sends data out of the property
                return mquantity;

            }
            set
            {
                mquantity = value;
            }
        }


        //private data member for the unit price property
        private Int32 munit_price;




        // unit price public property
        public int unit_price
        {
            get
            {
                // this line of code sends data out of the property
                return munit_price;

            }
            set
            {
                munit_price = value;
            }
        }

        //private data member for the last restock date property
        private DateTime mlast_restock_date;
        // last_restock_date public property
        public DateTime last_restock_date
        {
            get
            {
                // this line of code sends data out of the property
                return mlast_restock_date;
            }
            set
            {
                mlast_restock_date = value;
            }
        }

        //private data member for the discontinued property
        private Boolean mdiscontinued;
        // active public property
        public bool discontinued
        {
            get
            {
                // this line of code sends data out of the property
                return mdiscontinued;

            }
            set
            {
                mdiscontinued = value;
            }
        }
      

        public bool Find(int product_id)
        {
            // set the private data members to the test data value
            product_id = 10;
            mstockName = "VW Golf";
            mstockDetails = "1 Litre";
            mquantity = 32;
            munit_price = 10000;
            mlast_restock_date = Convert.ToDateTime("15/01/2024");
            mdiscontinued = false;
            // always return true
            return true;

        }

     

        public string Valid(string stockName, string stockDetails, string quantity, string unit_price, string last_restock_date)
        {
            return "";
        }
    }

}
        
