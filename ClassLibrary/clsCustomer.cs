using System;
using System.Web;
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

        //Function for the public validation methods
        public string Valid(string Customer_FirstName,
                              string Customer_LastName,
                              string Customer_PhoneNumber,
                              string Customer_Email,
                              string Customer_Password,
                              string Customer_Address)
            ////this function accepts 6 parameters for validation
            ///this function returns a string containing any error message
            ///if no errors found then a blank string is returnd 
        {
            //create a string variable to store the errors
            String Error = "";
            //if the customer first name is blank
            if (Customer_FirstName.Length == 0)
            {
                //records the error 
                Error = Error + "The FirstName may not be blank : ";
            }

            //if the Customer first name is greater than 50 character
            if(Customer_FirstName.Length > 50)
            {
                //record the error
                Error = Error + "The FirstName must be less than 50 Character : ";
            }

            if (Customer_LastName.Length == 0)
            {
                //records the error 
                Error = Error + "The LastName may not be blank : ";
            }

            //if the Customer PhoneNumber is greater than 50 character
            if (Customer_LastName.Length > 50)
            {
                //record the error
                Error = Error + "The LastName must be less than 50 Character : ";
            }

            if (Customer_PhoneNumber.Length == 0)
            {
                //records the error 
                Error = Error + "The PhoneNumber may not be blank : ";
            }

            //if the Customer PhoneNumber is greater than 20 character
            if (Customer_PhoneNumber.Length > 20)
            {
                //record the error
                Error = Error + "The PhoneNumber must be less than 20 Character : ";
            }

            //if the customer PhoneNumber is less than 11 character
            if (Customer_PhoneNumber.Length < 11)
            {
                //record the error
                Error = Error + "The PhoneNumber length is too short : ";
            }

            if (Customer_Email.Length == 0)
            {
                //records the error 
                Error = Error + "The Email may not be blank : ";
            }

            //if the Customer email is greater than 20 character
            if (Customer_Email.Length > 100)
            {
                //record the error
                Error = Error + "The Email Address must be less than 100 Character : ";
            }

            //if the customer email is less than 11 character
            if (Customer_Email.Length < 3)
            {
                //record the error
                Error = Error + "The Email Address length is too short : ";
            }


            if (Customer_Password.Length == 0)
            {
                //records the error 
                Error = Error + "The password may not be blank : ";
            }

            //if the Customer password is greater than 20 character
            if (Customer_Password.Length > 200)
            {
                //record the error
                Error = Error + "The password must be less than 200 Character : ";
            }

            //if the customer password is less than 11 character
            if (Customer_Password.Length < 8)
            {
                //record the error
                Error = Error + "The passsword length is too short : ";
            }


            if (Customer_Address.Length == 0)
            {
                //records the error 
                Error = Error + "The password may not be blank : ";
            }

            //if the Customer password is greater than 20 character
            if (Customer_Address.Length > 200)
            {
                //record the error
                Error = Error + "The password must be less than 200 Character : ";
            }

            //if the customer password is less than 11 character
            if (Customer_Address.Length < 7)
            {
                //record the error
                Error = Error + "The Address is too short : ";
            }




            //return the error messages
            return Error; 
        }

     


    }
}