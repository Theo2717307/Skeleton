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
        private clsOrder mThisOrder = new clsOrder();

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
            get { return mThisOrder; }
            set { mThisOrder = value; }
        }

        //Constructor for the public class
        public clsOrderCollection()
        {
            //variable for index
            //Int32 index = 0;
            //var to store record count
            //Int32 record_count = 0;
            //object for data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            
            DB.Execute("sproc_tblOrder_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);

            /* old way of populating
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
            **/

        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@customer_id", mThisOrder.Customer_id);
            DB.AddParameter("@order_timestamp", mThisOrder.Order_timestamp);
            DB.AddParameter("@order_processed", mThisOrder.Order_processed);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@order_id", mThisOrder.Order_id);
            //execute the stored parameter
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void FilterByDate(string from_date_temp, string to_date_temp)
        {
            //filter the records by a date range
            clsDataConnection DB = new clsDataConnection();
            //convert parameters to datetime types
            //if the dates are blank select all 
            DateTime from_date;
            DateTime to_date;
            if (from_date_temp != "" ) { from_date = Convert.ToDateTime(from_date_temp); }
            else { from_date = Convert.ToDateTime("1754/01/01"); }

            if (to_date_temp != "") { to_date = Convert.ToDateTime(to_date_temp); } 
            else { to_date = Convert.ToDateTime("9998/12/31"); }
            
            //set the parameters for the stored procedure
            DB.AddParameter("@from_date", from_date);
            DB.AddParameter("@to_date", to_date);
            //execute the stored parameter
            DB.Execute("sproc_tblOrder_FilterByDate");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 index = 0;
            //variable to store the record count
            Int32 record_count;
            //get the count of records
            record_count = DB.Count;
            //clear the private array list
            mOrderList = new List<clsOrder>();
            //while there are records to process
            while (index < record_count)
            {
                //create a blank order object
                clsOrder an_order = new clsOrder();
                //read in the fields from the current record
                an_order.Order_id = Convert.ToInt32(DB.DataTable.Rows[index]["order_id"]);
                an_order.Customer_id = Convert.ToInt32(DB.DataTable.Rows[index]["customer_id"]);
                an_order.Order_timestamp = Convert.ToDateTime(DB.DataTable.Rows[index]["order_timestamp"]);
                an_order.Order_processed = Convert.ToBoolean(DB.DataTable.Rows[index]["order_processed"]);
                //add the record to the private data member
                mOrderList.Add(an_order);
                //point to the next record
                index++;
            }
        }


    }
}