using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        // Private field
        List<clsCustomer> mCustomerList = new List<clsCustomer>();


        //Constructor

       /* public clsCustomerCollection()
        {
            //create the itesm of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.Customer_Id = 1;
            TestItem.Customer_FirstName = "Sahil";
            TestItem.Customer_LastName = "Suresh";
            TestItem.Customer_PhoneNumber = "1234567890";
            TestItem.Customer_Email = "sahilsuresh@gmail.com";
            TestItem.Customer_Address = "Some Street";
            TestItem.Customer_PostCode = "LE4 5UU";
            TestItem.Registration = DateTime.Now;
            //add the test items to the test list
            mCustomerList.Add(TestItem);
            //reintialise the object for some new data
            TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.Customer_Id = 2;
            TestItem.Customer_FirstName = "Roman";
            TestItem.Customer_LastName = "Reign";
            TestItem.Customer_PhoneNumber = "0987654321";
            TestItem.Customer_Email = "RomanReign@gmail.com";
            TestItem.Customer_Address = "Two Street";
            TestItem.Customer_PostCode = "BS7 5UU";
            TestItem.Registration = DateTime.Now;
            //add the test items to the test list
            mCustomerList.Add(TestItem);
        }*/

        //Construtor for the class
        public clsCustomerCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //varible to store the record count
            Int32 RecordCount = 0;
            //onject for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount) 
            {
                //create a blank address
                clsCustomer anCustomer = new clsCustomer();
                //read in the fields for the current records
                anCustomer.Customer_Id = Convert.ToInt32(DB.DataTable.Rows[Index]["Customer_Id"]);
                anCustomer.Customer_FirstName = Convert.ToString(DB.DataTable.Rows[Index]["Customer_FirstName"]);
                anCustomer.Customer_LastName = Convert.ToString(DB.DataTable.Rows[Index]["Customer_LastName"]);
                anCustomer.Customer_PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["Customer_PhoneNumber"]);
                anCustomer.Customer_Email = Convert.ToString(DB.DataTable.Rows[Index]["Customer_Email"]);
                anCustomer.Customer_Password = Convert.ToString(DB.DataTable.Rows[Index]["Customer_Password"]);
                anCustomer.Customer_Address = Convert.ToString(DB.DataTable.Rows[Index]["Customer_Address"]);
                anCustomer.Customer_PostCode = Convert.ToString(DB.DataTable.Rows[Index]["Customer_PostCode"]);
                anCustomer.Registration = Convert.ToDateTime(DB.DataTable.Rows[Index]["Registration"]);
                anCustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);

                //add the record to the private data member
                mCustomerList.Add(anCustomer);
                //point at the next records
                Index++;  
            }
        }

        //public field

        public List<clsCustomer> CustomerList 
        {
            get 
            {
                //return the private data
                return mCustomerList;
            } 
            set 
            {
                //set the private data
                mCustomerList = value;
            } 
        }
        public int Count 
        {
            get 
            {
                //return the count of the list
                return mCustomerList.Count;
            } 
            set 
            {
                
            } 
        }
        public clsCustomer ThisAddress { get; set; }

       

        }


    
}