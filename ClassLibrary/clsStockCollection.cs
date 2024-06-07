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


        // Constructor for the class



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

        // Constructor for the class
        public clsStockCollection()
        {
            // Object for the data connection
            clsDataConnection DB = new clsDataConnection();
            // Execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            // Populate the array list with the data table
            PopulateArray(DB);
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

        public clsStock Find(int vehicle_id)
        {
            // Loop through each stock in the list
            foreach (clsStock stock in mStockList)
            {
                // If the vehicle ID matches, return the stock 
                if (stock.vehicle_id == vehicle_id)
                {
                    return stock;
                }
            }
            // If no match is found, return null
            return null;
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@vehicle_id", mThisStock.vehicle_id);
            DB.Execute("sproc_tblStock_Delete");
        }





        public void Update()
        {
            // Updates the record pointed to by mThisStock
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure
            DB.AddParameter("@vehicle_id", mThisStock.vehicle_id);
            DB.AddParameter("@stockName", mThisStock.stockName);
            DB.AddParameter("@stockDetails", mThisStock.stockDetails);
            DB.AddParameter("@quantity", mThisStock.quantity);
            DB.AddParameter("@unit_price", mThisStock.unit_price);
            DB.AddParameter("@last_restock_date", mThisStock.last_restock_date);
            DB.AddParameter("@discontinued", mThisStock.discontinued);
            // Execute the query
            DB.Execute("sproc_tblStock_Update");
        }



        public void ReportBystockDetails(string stockDetails)
        {
            // Filters the records based on a full or partial position
            clsDataConnection DB = new clsDataConnection();
            // Send the Position parameter to the database
            DB.AddParameter("@stockDetails", stockDetails);
            // Execute the stored procedure
            DB.Execute("sproc_tblStock_FilterBystockDetails");
            // Populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            // Populate the array list based on the data table in the parameter DB
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mStockList = new List<clsStock>();
            while (Index < RecordCount)
            {
                clsStock AnStock = new clsStock();
                AnStock.vehicle_id = Convert.ToInt32(DB.DataTable.Rows[Index]["vehicle_id"]);
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


    }
}



