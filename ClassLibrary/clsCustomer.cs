using System;
using static System.Net.Mime.MediaTypeNames;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //Private data member for the address ID, firstname, lastname, phonenumber, email, password, address, and active property
        private Int32 mCustomer_Id;
        private string mCustomer_FirstName;
        private string mCustomer_LastName;
        private string mCustomer_PhoneNumber;
        private string mCustomer_Email;
        private string mCustomer_Password;
        private string mCustomer_Address;
        private Boolean mActive;

        //CustomerId public property

        public string Customer_Address {
            get 
            {
                //This line of code send data out of the property
                return mCustomer_Address;
            }
            set 
            {
                //This line of code allows data into the property
                mCustomer_Address = value;
            } 

        }

        //CustomerId public property
        public Int32 Customer_Id {
            get
            {
                //this Line of code send data out of the property
                return mCustomer_Id;
            }
            set
            {
                //this line of code allows data into the property
                mCustomer_Id = value;
            }
        }

        public bool Active { 
            get 
            {
                //this line of code send data out of the property
                return mActive;
            } 
            set 
            { 
                //this line of code allows data into the property 
                mActive = value;
            } 
        }
        public string Customer_Password{ 
            get 
            {
                //This line of code send data out of the property
                return mCustomer_Password;
            } 
            set 
            { 
                //This  line of code allows data into the property
                mCustomer_Password = value;      
            } 
        }
        public string Customer_Email{
            get 
            {
                //this Line of code send data out of the property
                return mCustomer_Email;
            }
            set 
            {
                //this line of code allows data into the property
                mCustomer_Email = value;
            }
                }
        public string Customer_PhoneNumber{ 
            get 
            {
                //this line of code send data out of the property
                return mCustomer_PhoneNumber;
            } 
            set 
            { 
                //this line of code allows data into the property
                mCustomer_PhoneNumber = value;
            } 
        }
        public string Customer_LastName {
            get {
                //this Line of code send data out of the property
                return mCustomer_LastName;
            }
            set {
                //this line of code allows data into the property
                mCustomer_LastName = value;
            }
        }
        public string Customer_FirstName{
            get
            {
                //this line of code sends data out of the property
                return mCustomer_FirstName;
            }
            set
            {
                //this line of code allows data into the property
                mCustomer_FirstName = value;
            }

        }

        public bool Find(int Customer_Id)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for
            DB.AddParameter("@Customer_Id", Customer_Id);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");
            //if one record is found (there should be either one or zero)
            if(DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomer_Id = Convert.ToInt32(DB.DataTable.Rows[0]["Customer_Id"]);
                mCustomer_FirstName = Convert.ToString(DB.DataTable.Rows[0]["Customer_FirstName"]);
                mCustomer_LastName = Convert.ToString(DB.DataTable.Rows[0]["Customer_LastName"]);
                mCustomer_PhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["Customer_PhoneNumber"]);
                mCustomer_Email = Convert.ToString(DB.DataTable.Rows[0]["Customer_Email"]);
                mCustomer_Password = Convert.ToString(DB.DataTable.Rows[0]["Customer_Password"]);
                mCustomer_Address = Convert.ToString(DB.DataTable.Rows[0]["Customer_Address"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);

                //return that everything worked OK
                return true;

            }
            //if no record was found 
            else
            {
                //return false indicating there is a problem 
                return false;
            }
        }
    }
}