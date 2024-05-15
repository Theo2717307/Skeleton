using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Markup;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data members
        private List<clsOrder>  mOrderList = new List<clsOrder>();
        private int mCount;
        private clsOrder mOrder;

        public List<clsOrder> OrderList
        {
            get { return mOrderList; }
            set { mOrderList = value; }
        }

        public int Count
        {
            get { return OrderList.Count; }
            set { mCount = value; }
        }
        public clsOrder ThisOrder
        {
            get { return mOrder; }
            set { mOrder = value; }
        }

        //Constructor for the public class
        public clsOrderCollection()
        {
            /*
            clsOrder test_order = new clsOrder();
            test_order.Order_id = 1;
            test_order.Customer_id = 2;
            test_order.Order_timestamp = DateTime.Now;
            test_order.Order_processed = false;
            //add to list
            mOrderList.Add(test_order);
             */
            //variable for index
            Int32 index = 0;
            //var to store record count
            Int32 record_count = 0;
            //object for data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //get the count of records
            record_count = DB.Count;
            //while there are records to process
            while (index < record_count)
            {
                //create a blank order 
                clsOrder an_order = new clsOrder();
                //read in the fields are add to properties
                an_order.Order_id = Convert.ToInt32(DB.DataTable.Rows[0]["order_id"]);
                an_order.Customer_id = Convert.ToInt32(DB.DataTable.Rows[0]["customer_id"]);
                an_order.Order_timestamp = Convert.ToDateTime(DB.DataTable.Rows[0]["order_timestamp"]);
                an_order.Order_processed = Convert.ToBoolean(DB.DataTable.Rows[0]["order_processed"]);
                //add the record to the private data member
                mOrderList.Add(an_order);
                //point to the next record
                index++;
            }

        }
    }
}