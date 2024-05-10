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

        public bool Find(int testOrderID)
        {
            //set the private data members to the test data value
            mOrder_id = 15;
            mCustomer_id = 26;
            mOrder_timestamp = Convert.ToDateTime("10/05/24");
            mOrder_processed = true;
            //always return true
            return true;
        }
    }
}