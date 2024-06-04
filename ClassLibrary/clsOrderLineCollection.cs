using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Markup;

namespace ClassLibrary
{
    public class clsOrderLineCollection
    {
        //private data members
        private List<clsOrderLine> mOrderLineList = new List<clsOrderLine>();
        private int mCount;
        private clsOrderLine mThisOrderLine = new clsOrderLine();

        public List<clsOrderLine> OrderLineList
        {
            get { return mOrderLineList; }
            set { mOrderLineList = value; }
        }
        public int Count
        {
            get { return mCount; }
            set { mCount = value; }
        }
        public clsOrderLine ThisOrderLine
        {
            get { return mThisOrderLine; }
            set { mThisOrderLine = value; }
        }

        //Constructor for the public class
        public clsOrderLineCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrderLine_SelectAll");
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
            mOrderLineList = new List<clsOrderLine>();
            //while there are records to process
            while (index < record_count)
            {
                //create a blank order object
                clsOrderLine an_order_line = new clsOrderLine();
                //read in the fields from the current record
                an_order_line.Order_id = Convert.ToInt32(DB.DataTable.Rows[index]["order_id"]);
                an_order_line.Product_id = Convert.ToInt32(DB.DataTable.Rows[index]["product_id"]);
                an_order_line.Quantity = Convert.ToInt32(DB.DataTable.Rows[index]["quantity"]);
                an_order_line.Price = Convert.ToInt32(DB.DataTable.Rows[index]["price"]);
                //add the record to the private data member
                mOrderLineList.Add(an_order_line);
                //point to the next record
                index++;

            }
        }


    }
}