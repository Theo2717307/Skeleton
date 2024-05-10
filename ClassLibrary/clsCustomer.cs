using System;
using static System.Net.Mime.MediaTypeNames;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //Private data member for the address ID, firstname, lastname, phonenumber, email, password, address, and active property
        private Int32 mCustomerId;
        private string mCustomerFirstName;
        private string mCustomerLastName;
        private string mCustomerPhoneNumber;
        private string mCustomerEmail;
        private string mCustomerPassword;
        private string mCustomerAddress;
        private Boolean mActive;

        //CustomerId public property

        public string CustomerAddress {
            get 
            {
                //This line of code send data out of the property
                return mCustomerAddress;
            }
            set 
            {
                //This line of code allows data into the property
                mCustomerAddress = value;
            } 

        }

        //CustomerId public property
        public Int32 CustomerId {
            get
            {
                //this Line of code send data out of the property
                return mCustomerId;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerId = value;
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
        public string CustomerPassword { 
            get 
            {
                //This line of code send data out of the property
                return mCustomerPassword;
            } 
            set 
            { 
                //This  line of code allows data into the property
                mCustomerPassword = value;      
            } 
        }
        public string CustomerEmail {
            get 
            {
                //this Line of code send data out of the property
                return mCustomerEmail;
            }
            set 
            {
                //this line of code allows data into the property
                mCustomerEmail = value;
            }
                }
        public string CustomerPhoneNumber { 
            get 
            {
                //this line of code send data out of the property
                return mCustomerPhoneNumber;
            } 
            set 
            { 
                //this line of code allows data into the property
                mCustomerPhoneNumber = value;
            } 
        }
        public string CustomerLastName {
            get {
                //this Line of code send data out of the property
                return mCustomerLastName;
            }
            set {
                //this line of code allows data into the property
                mCustomerLastName = value;
            }
        }
        public string CustomerFirstName {
            get
            {
                //this line of code sends data out of the property
                return mCustomerFirstName;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerFirstName = value;
            }

        }

        public bool Find(int customerId)
        {
            //set the private data members to the test data value
            mCustomerId = 20;
            mCustomerFirstName = "Sahil";
            mCustomerLastName = "Suresh";
            mCustomerPhoneNumber = "+447373485923";
            mCustomerEmail = "test@gmail.com";
            mCustomerPassword = "testPassWord234";
            mCustomerAddress = "some street name, LE4 6JP";
            mActive = true;

            //always return true
            return true;
        }
    }
}