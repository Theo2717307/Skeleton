using System;
using System.Diagnostics;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the product id property
        private Int32 mvehicle_id;
        private string mstockName;
        private string mstockDetails;
        private string munit_price;
        private string mquantity;
        private DateTime mlast_restock_date;
        private bool mdiscontinued;



       
        //product_id public property
        public Int32 vehicle_id
        {
            get
            {
                // this line of code sends data out of the property
                return mvehicle_id;

            }
            set
            {
                mvehicle_id = value;
            }
        }


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
                mstockDetails = value;
            }
        }

        //private data member for the quantity property
        
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


        public bool Find(int stockDetails)
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            // Add the parameter for the Staff_ID to search for
            DB.AddParameter("@stockDetails", stockDetails);

            // Execute the stored procedure
            DB.Execute("sproc_tblStock_FilterBystockDetails");

            // If one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                // Copy the data from the database to the private data members
                mvehicle_id = Convert.ToInt32(DB.DataTable.Rows[0]["vehicle_id"]);
                mstockName = Convert.ToString(DB.DataTable.Rows[0]["stockName"]);
                mstockDetails = Convert.ToString(DB.DataTable.Rows[0]["stockDetails"]);
                mquantity = Convert.ToString(DB.DataTable.Rows[0]["quantity"]);
                munit_price = Convert.ToString(DB.DataTable.Rows[0]["unit_price"]);
                mlast_restock_date = Convert.ToDateTime(DB.DataTable.Rows[0]["last_restock_date"]);
                mdiscontinued = Convert.ToBoolean(DB.DataTable.Rows[0]["discontinued"]);

                // Return that everything worked OK
                return true;
            }
            // If no record was found
            else
            {
                // Return false indicating there is a problem
                return false;
            }
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
        
