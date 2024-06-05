using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstStock
    {

        //good test data
        // create some data to pass the methods
        
        string stockName = "VW Golf";
        string stockDetails = "1 Litre";
        string quantity = "32";
        string unit_price = "13k";
        string last_restock_date = DateTime.Now.ToShortDateString();


        

        [TestMethod]
        public void InstanceOK()
        {

            clsStock AnStock = new clsStock();

            Assert.IsNotNull(AnStock);


        }



        [TestMethod]
        public void product_idPropertyOK()
        {


            clsStock AnStock = new clsStock();

            Int32 TestData = 10;
            AnStock.product_id = TestData;
            Assert.AreEqual(AnStock.product_id, TestData);
        }

        public void stockNamePropertyOK()
        {


            clsStock AnStock = new clsStock();

            String TestData = "VW Polo";
            AnStock.stockName = TestData;
            Assert.AreEqual(AnStock.stockName, TestData);
        }

        public void stockDetailsPropertyOK()
        {


            clsStock AnStock = new clsStock();

            String TestData = "1 Litre";
            AnStock.stockDetails = TestData;
            Assert.AreEqual(AnStock.stockDetails, TestData);
        }

        public void quantityPropertyOK()
        {


            clsStock AnStock = new clsStock();

            string TestData = "32";
            AnStock.quantity = TestData;
            Assert.AreEqual(AnStock.quantity, TestData);
        }

        public void unit_pricePropertyOK()
        {


            clsStock AnStock = new clsStock();

           string TestData = "13k";
            AnStock.unit_price = TestData;
            Assert.AreEqual(AnStock.unit_price, TestData);
        }

        public void last_restock_datePropertyOK()
        {


            clsStock AnStock = new clsStock();

            DateTime TestData = DateTime.Now.Date;
            AnStock.last_restock_date = TestData;
            Assert.AreEqual(AnStock.last_restock_date, TestData);
        }

        public void discontinuedPropertyOK()
        {


            clsStock AnStock = new clsStock();

            Boolean TestData = false;
            AnStock.discontinued = TestData;
            Assert.AreEqual(AnStock.discontinued, TestData);
        }


        public void FindMethodOK()

        {
            //Create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            // Boolean variable to store results of validation
            Boolean Found = false;
            //Test data to use with the method
            Int32 product_id = 10;
            //Invoke the method
            Found = AnStock.Find(product_id);
            //test to see if results are true
            Assert.IsTrue(Found);

        }

    


        public void Testproduct_idFound()
        {
            //Create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            // Boolean variable to store results of search
            Boolean Found = false;
            //Boolean to record if data is ok
            Boolean OK = true;
            // test data to use with the method
            Int32 product_id = 10;
            //invoke the method
            Found = AnStock.Find(product_id);
            //check the product id 
            if (AnStock.product_id != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);



        }

        public void stockNameFound()
        {
            //Create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            // Boolean variable to store results of search
            Boolean Found = false;
            //Boolean to record if data is ok
            Boolean OK = true;
            // test data to use with the method
            Int32 product_id = 10;
            //invoke the method
            Found = AnStock.Find(product_id);
            //check the product id 
            if (AnStock.stockName != "VW Golf")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);



        }

        public void stockDetailsFound()
        {
            //Create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            // Boolean variable to store results of search
            Boolean Found = false;
            //Boolean to record if data is ok
            Boolean OK = true;
            // test data to use with the method
            Int32 product_id = 10;
            //invoke the method
            Found = AnStock.Find(product_id);
            //check the product id 
            if (AnStock.stockDetails != "1 Litre")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);



        }

        public void quantityFound()
        {
            //Create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            // Boolean variable to store results of search
            Boolean Found = false;
            //Boolean to record if data is ok
            Boolean OK = true;
            // test data to use with the method
            Int32 product_id = 10;
            //invoke the method
            Found = AnStock.Find(product_id);
            //check the product id 
            if (AnStock.quantity != "32")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);



        }

        public void unit_priceFound()
        {
            //Create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            // Boolean variable to store results of search
            Boolean Found = false;
            //Boolean to record if data is ok
            Boolean OK = true;
            // test data to use with the method
            Int32 product_id = 10;
            //invoke the method
            Found = AnStock.Find(product_id);
            //check the product id 
            if (AnStock.unit_price != "13k")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);



        }
        public void last_restock_dateFound()
        {
            //Create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            // Boolean variable to store results of search
            Boolean Found = false;
            //Boolean to record if data is ok
            Boolean OK = true;
            // test data to use with the method
            Int32 product_id = 10;
            //invoke the method
            Found = AnStock.Find(product_id);
            //check the product id 
            if (AnStock.last_restock_date != Convert.ToDateTime("15/01/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);



        }

        public void discontinuedFound()
        {
            //Create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            // Boolean variable to store results of search
            Boolean Found = false;
            //Boolean to record if data is ok
            Boolean OK = true;
            // test data to use with the method
            Int32 product_id = 10;
            //invoke the method
            Found = AnStock.Find(product_id);
            //check the product id 
            if (AnStock.discontinued != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);



        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an intsance of the class we want to create
            clsStock anStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void stockNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String stockName = ""; //This should trigger an error
                                            //invoke the methods
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void stockNameMin()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String stockName = "jjjjjjj"; //This should trigger an error
                                             //invoke the methods
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

       
        public void stockNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String stockName = "jjjjjjjj"; //This should trigger an error
                                     //invoke the methods
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void stockNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String stockName = ""; //This should trigger an error
            stockName = stockName.PadRight(49, 'j');
                                                //invoke the methods
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void stockNameMax()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String stockName = ""; //This should trigger an error
            stockName = stockName.PadRight(50, 'j');
            //invoke the methods
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void stockNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String stockName = ""; //This should trigger an error
            stockName = stockName.PadRight(51, 'j');
            //invoke the methods
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void stockNameMid()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String stockName = ""; //This should trigger an error
            stockName = stockName.PadRight(25, 'j');
            //invoke the methods
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void stockNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String stockName = "";
            stockName = stockName.PadRight(500, 'a'); //This should fail

            //invoke the methods
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }

        public void stockDetailsMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String stockDetails = ""; //This should trigger an error
                                            //invoke the methods
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void stockDetailsMin()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String stockDetails = "JJJJJJJJJJJJJJJ"; //This should trigger an error
                                             //invoke the methods
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

       
        public void stockDetailsMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String stockDetails = "JJJJJJJJJJJJJJJJ"; //This should trigger an error
                                     //invoke the methods
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void stockDetailsMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String stockDetails = ""; //This should trigger an error
                                      //invoke the methods
            stockDetails = stockDetails.PadRight(49, 'j');
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void stockDetailsMax()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String stockDetails = ""; //This should trigger an error
                                                 //invoke the methods
            stockDetails = stockDetails.PadRight(50, 'j');
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void stockDetailsMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String stockDetails = ""; //This should trigger an error
                                         //invoke the methods
            stockDetails = stockDetails.PadRight(51, 'j');
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void stockDetailsMid()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String stockDetails = ""; //This should trigger an error
                                      //invoke the methods
            stockDetails = stockDetails.PadRight(25, 'j');
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void stockDetailsExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String stockDetails = "";
            stockDetails = stockDetails.PadRight(500, 'a'); //This should fail

            //invoke the methods
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }

        public void quantityMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String stockQuantity = ""; //This should trigger an error
                                      //invoke the methods
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void quantityMin()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String quantity = "JJJJJJJJJJJJJJJJJJJJJJJJJ"; //This should trigger an error
                                       //invoke the methods
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

       
        public void quantityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String quantity = "JJJJJJJJJJJJJJJJJJJJJJJJJJ"; //This should trigger an error
                                        //invoke the methods
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void quantityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String quantity = new string ('a',49); //This should trigger an error
                                                   //invoke the methods
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void quantityMax()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String quantity = ""; //This should trigger an error
                                  //invoke the methods
            quantity = quantity.PadRight(50, 'j');
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        public void quantityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String quantity = ""; //This should trigger an error
                                  //invoke the methods
            quantity = quantity.PadRight(51, 'j');
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void quantityMid()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String quantity = ""; //This should trigger an error
                                  //invoke the methods
            quantity = quantity.PadRight(25, 'j');
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void quantityExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String quantity = "";
            quantity = quantity.PadRight(500, 'a'); //This should fail

            //invoke the methods
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }

        public void unit_priceMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String unit_price = "10"; //This should trigger an error
                                       //invoke the methods
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void unit_priceMin()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String unit_price = "10k"; //This should trigger an error
                                   //invoke the methods
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        
        public void unit_priceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String unit_price = ""; //This should trigger an error
                                    //invoke the methods
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void unit_priceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String unit_price = new string ('a',49); //This should trigger an error
                                               //invoke the methods
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void unit_priceMax()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String unit_price = ""; //This should trigger an error
                                    //invoke the methods
            unit_price = unit_price.PadRight(50, 'j');
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        public void unit_priceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String unit_price = ""; //This should trigger an error
                                    //invoke the methods
            unit_price = unit_price.PadRight(51, 'j');
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void unit_priceMid()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String unit_price = ""; //This should trigger an error
                                    //invoke the methods
            unit_price = unit_price.PadRight(25, 'j');
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the restult is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void unit_priceExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string c=variable to stor any error message
            String Error = "";
            //create some test data to pass to the methods
            String unit_price = "";
            unit_price = unit_price.PadRight(500, 'a'); //This should fail

            //invoke the methods
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the restult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void last_restock_dateExtremeMin()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data 
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years 
            TestDate = TestDate.AddYears(-100);
            //convert the data variable to a string variable
            string last_restock_date = TestDate.ToString();
            //invoke the moethods
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void last_restock_dateLessOne()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data 
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years 
            TestDate = TestDate.AddYears(-1);
            //convert the data variable to a string variable
            string last_restock_date = TestDate.ToString();
            //invoke the moethods
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void last_restock_dateMin()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data 
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the data variable to a string variable
            string last_restock_date = TestDate.ToString();
            //invoke the moethods
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void last_restock_dateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the data variable to a string variable
            string last_restock_date = TestDate.ToString();
            //invoke the moethods
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void last_restock_dateExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock anStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data 
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddYears(100);
            //convert the data variable to a string variable
            string last_restock_date = TestDate.ToString();
            //invoke the moethods
            Error = anStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}