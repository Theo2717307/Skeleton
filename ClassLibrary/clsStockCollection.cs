using System;
using System.Collections.Generic;


namespace ClassLibrary
{ 
    public class clsStockCollection
    {
        //Private datamember for the list
        private List<clsStock> mStockList = new List<clsStock>();
       
        


        public clsStock ThisStock { get; set; }

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
            


        public clsStockCollection()
        {

            //constructor for the class
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
     }

    }

}
    
