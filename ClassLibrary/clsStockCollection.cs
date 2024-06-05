using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;


namespace ClassLibrary
{ 
    public class clsStockCollection
    {
        //Private datamember for the list
        private List<clsStock> mStockList = new List<clsStock>();


        // private data member for ThisStock
        clsStock mThisStock = new clsStock();

        public clsStock ThisStock
        {
            get
            {
                //return the private data
                return mThisStock;
            
            }
            set
            {
                //set the private data
                mThisStock = value;
            }
        }



        //public property for the stock list
        public List<clsStock> StockList
        {

            get
            {

                //set the private data
                return mStockList;
            
            
            }
            set
            {

                //set the private data
                mStockList = value;
            }

        
        
        }
       
        
        //public property for count 
        public int Count
        {

            get
            {

                return mStockList.Count;

            }

            set
            {

                //later
            }   
        
        }
        public int Add()
        {
            //adds a record to the database based on the values of mThisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@stockName", mThisStock.stockName);
            DB.AddParameter("@stockDetails", mThisStock.stockDetails);
            DB.AddParameter("@quantity", mThisStock.quantity);
            DB.AddParameter("@unit_price", mThisStock.unit_price);
            DB.AddParameter("@last_restock_date", mThisStock.last_restock_date);
            DB.AddParameter("@discontinued", mThisStock.discontinued);
            // Execute the query returning the primary key value
            return DB.Execute("sproc_tblStock_Insert");

        }




        //constructor for the class
        public clsStockCollection()
        {

            clsStock TestItem = new clsStock();
            //setting properties
            TestItem.discontinued = true;
            TestItem.product_id = 9;
            TestItem.stockName = "VW Golf";
            TestItem.stockDetails = "1 litre";
            TestItem.quantity = "30";
            TestItem.unit_price = "13k";
            TestItem.last_restock_date = DateTime.Now;
            //add item to the test list
            mStockList.Add(TestItem);
            //re initialise thee object for some new data
            TestItem = new clsStock();
            //set the properties
            TestItem.discontinued = true;
            TestItem.product_id = 1;
            TestItem.stockName = "BMW 4 Series";
            TestItem.stockDetails = "2 litre";
            TestItem.quantity = "20";
            TestItem.unit_price = "15k";
            TestItem.last_restock_date = DateTime.Now;
            //add item to the test list
            mStockList.Add(TestItem);


            //variable for the index
            Int32 Index = 0;
            //variable to store record count
            Int32 RecordCount = 0;
            //onject for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //get count records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsStock AnStock = new clsStock();
                // read in fields for current record

                AnStock.product_id = Convert.ToInt32(DB.DataTable.Rows[Index]["product_id"]);
                AnStock.stockName = Convert.ToString(DB.DataTable.Rows[Index]["stockName"]);
                AnStock.stockDetails = Convert.ToString(DB.DataTable.Rows[Index]["stockDetails"]);
                AnStock.quantity = Convert.ToString(DB.DataTable.Rows[Index]["quantity"]);
                AnStock.unit_price = Convert.ToString(DB.DataTable.Rows[Index]["unit_price"]);
                AnStock.last_restock_date = Convert.ToDateTime(DB.DataTable.Rows[Index]["last_restock_date"]);
                AnStock.discontinued = Convert.ToBoolean(DB.DataTable.Rows[Index]["discontinued"]);
                mStockList.Add(AnStock);
                Index++;


            }
        }



            public void Update()
            {
                // Updates the record pointed to by mThisStaff
                clsDataConnection DB = new clsDataConnection();
                // Set the parameters for the stored procedure
                DB.AddParameter("@product_id", mThisStock.product_id);
                DB.AddParameter("@stockName", mThisStock.stockName);
                DB.AddParameter("@stockDetails", mThisStock.stockDetails);
                DB.AddParameter("@quantity", mThisStock.quantity);
                DB.AddParameter("@unit_price", mThisStock.unit_price);
                DB.AddParameter("@last_restock_date", mThisStock.last_restock_date);
                DB.AddParameter("@discontinued", mThisStock.discontinued);
                // Execute the query
                DB.Execute("sproc_tblStock_Update");
            }
            
            


        }
        

    }

    
