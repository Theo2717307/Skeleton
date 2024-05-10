using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data members for the properties
        private Int32 mOrder_id;
        private Int32 mCustomer_id;
        private DateTime mOrder_timestamp;
        private Boolean mOrder_processed;

        public bool Order_processed
        {
            get
            {
                return mOrder_processed;
            }
            set 
            { 
                mOrder_processed = value; 
            }
        }
        public DateTime Order_timestamp
        {
            get
            {
                return mOrder_timestamp;
            }
            set
            {
                mOrder_timestamp = value;
            }
        }
        public int Order_id
        {
            get
            {
                return mOrder_id;
            }
            set
            {
                mOrder_id = value;
            }
        }
        public int Customer_id
        {
            get
            {
                return mCustomer_id;
            }
            set
            {
                mCustomer_id = value;
            }
        }

        public bool Find_old(int testOrderID)
        {
            //set the private data members to the test data value
            mOrder_id = 15;
            mCustomer_id = 26;
            mOrder_timestamp = Convert.ToDateTime("10/05/24");
            mOrder_processed = true;
            //always return true
            return true;
        }
        public bool Find(int orderID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for
            DB.AddParameter("@orderID", orderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderId");
            //if one record is found (there should be one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrder_id = Convert.ToInt32(DB.DataTable.Rows[0]["order_id"]);
                mCustomer_id = Convert.ToInt32(DB.DataTable.Rows[0]["customer_id"]);
                mOrder_timestamp = Convert.ToDateTime(DB.DataTable.Rows[0]["order_timestamp"]);
                mOrder_processed = Convert.ToBoolean(DB.DataTable.Rows[0]["order_processed"]);
                //return that everything is OK
                return true;
            }
            //if no record was found
            else
            {
                //return a false indicating there is a 
                return false;
            }
        }
    }
}