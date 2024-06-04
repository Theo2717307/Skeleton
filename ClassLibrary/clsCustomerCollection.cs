using System;
using System.Collections.Generic;
using System.Reflection;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        // Private field
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();


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
            //onject for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
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
        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            //set the parameters of the stored procedure
            DB.AddParameter("@Customer_FirstName", mThisCustomer.Customer_FirstName);
            DB.AddParameter("@Customer_LastName", mThisCustomer.Customer_LastName);
            DB.AddParameter("@Customer_PhoneNumber", mThisCustomer.Customer_PhoneNumber);
            DB.AddParameter("@Customer_Email", mThisCustomer.Customer_Email);
            DB.AddParameter("@Customer_Address", mThisCustomer.Customer_Address);
            DB.AddParameter("@Customer_PostCode", mThisCustomer.Customer_PostCode);
            DB.AddParameter("@Registration", mThisCustomer.Registration);
            DB.AddParameter("@Active", mThisCustomer.Active);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisCustomer
            //connects to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters For the Stored procedure
            DB.AddParameter("@Customer_Id", mThisCustomer.Customer_Id);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByPostCode(string Customer_PostCode)
        {
            //Filters the records based on a full or partial post code
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode parameter to the database
            DB.AddParameter("@Customer_PostCode", Customer_PostCode);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByPostCode");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            //set the parameters of the stored procedure
            DB.AddParameter("@Customer_Id", mThisCustomer.Customer_Id);
            DB.AddParameter("@Customer_FirstName", mThisCustomer.Customer_FirstName);
            DB.AddParameter("@Customer_LastName", mThisCustomer.Customer_LastName);
            DB.AddParameter("@Customer_PhoneNumber", mThisCustomer.Customer_PhoneNumber);
            DB.AddParameter("@Customer_Email", mThisCustomer.Customer_Email);
            DB.AddParameter("@Customer_Address", mThisCustomer.Customer_Address);
            DB.AddParameter("@Customer_PostCode", mThisCustomer.Customer_PostCode);
            DB.AddParameter("@Registration", mThisCustomer.Registration);
            DB.AddParameter("@Active", mThisCustomer.Active);

            //execute the query returning the primary key value
            DB.Execute("sproc_tblCustomer_Update");
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //varible to store the record count
            Int32 RecordCount = 0;
            // get the count of records
            RecordCount = DB.Count;
            // Clear the private array list
            mCustomerList = new List<clsCustomer>();
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

    }

    public class clsStockCollection
    {
        public int StockList { get; set; }
        public int Count { get; set; }
    }
}