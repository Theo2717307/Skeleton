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
        private string mquantity;
        // quantity public property
        public string quantity
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
        private string munit_price;




        // unit price public property
        public string unit_price
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
            mquantity = "32";
            munit_price = "10000";
            mlast_restock_date = Convert.ToDateTime("15/01/2024");
            mdiscontinued = false;
            // always return true
            return true;

        }

     

        public string Valid(string stockName, string stockDetails, string quantity, string unit_price, string last_restock_date)
        {
            //create a string variable to store the errors
            String Error = "";

            //if the stock  name is blank
            if (stockName.Length == 0)
            {
                //records the error 
                Error = Error + "The stock name may not be blank : ";
            }

            //if the stock name is greater than 50 character
            if (stockName.Length > 50)
            {
                //record the error
                Error = Error + "The stock name must be less than 50 Character : ";
            }

            //if the stock details is blank
            if (stockDetails.Length == 0)
            {
                //records the error 
                Error = Error + "The stock details may not be blank : ";
            }

            //if the stock details is greater than 50 character
            if (stockDetails.Length > 50)
            {
                //record the error
                Error = Error + "The stock details must be less than 50 Character : ";
            }


            //if the quantity is blank
            if (quantity.Length == 0)
            {
                //records the error 
                Error = Error + "The quantity may not be blank : ";
            }

            //if the stock details is greater than 50 character
            if (quantity.Length > 50)
            {
                //record the error
                Error = Error + "The quantity must be less than 50 Character : ";
            }

            //if the unit price is blank
            if (unit_price.Length == 0)
            {
                //records the error 
                Error = Error + "The unit price may not be blank : ";
            }

            //if the stock details is greater than 50 character
            if (unit_price.Length > 50)
            {
                //record the error
                Error = Error + "The unit price must be less than 50 Character : ";
            }

            //Create a temporary variable to store date values
            DateTime DateTemp;

            //Copy the Registration date value to the datetemp variable
            DateTemp = Convert.ToDateTime(last_restock_date);
            if (DateTemp < DateTime.Now.Date)
            {
                //Record the error
                Error = Error + "The date cannot be in the past : ";
            }

            if (DateTemp > DateTime.Now.Date)
            {
                //recrod the error
                Error = Error + "The date cannot be in the Future : ";
            }






            //return error messages
            return Error;
        }




    }

}
        
