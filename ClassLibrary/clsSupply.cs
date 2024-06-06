using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ClassLibrary
{
    public class clsSupply
    {
        private Int32 mSupplier_Id;
        private String mSupplier_Name;
        private String mSupplier_Phone_Number;
        private String mSupplier_Address;
        private String mSupplier_Email;
        private String mSupplier_Country;
        private bool mSupplier_Export;
        private bool mSupplier_Trade_Restrictions;

        public string Supplier_Name
        {
            get
            {
                return mSupplier_Name;
            }
            set
            {
                mSupplier_Name = value;
            }
        }
        public string Supplier_Phone_Number
        {
            get
            {
                return mSupplier_Phone_Number;
            }
            set
            {
                mSupplier_Phone_Number = value;
            }
        }
        public string Supplier_Address
        {
            get
            {
                return mSupplier_Address;
            }
            set
            {
                mSupplier_Address = value;
            }
        }
        public string Supplier_Email
        {
            get
            {
                return mSupplier_Email;
            }
            set
            {
                mSupplier_Email = value;
            }
        }
        public string Supplier_Country
        {
            get
            {
                return mSupplier_Country;
            }
            set
            {
                mSupplier_Country = value;
            }

        }
        public bool Supplier_Export {
            get 
            {
                return mSupplier_Export;
            } set
            {
                mSupplier_Export = value;
            }
        }
        public bool Supplier_Trade_Restrictions
        {
            get
            {
                return mSupplier_Trade_Restrictions;
            }
            set
            {
                mSupplier_Trade_Restrictions = value;
            }
        }
        public Int32 Supplier_Id {
            get
            {
                return mSupplier_Id;
            }
            set
            {
                mSupplier_Id = value;
            }
        }

        // FIND METHOD //
      
        public bool Find(int Supplier_Id)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the supplier name to search for
            DB.AddParameter("@Supplier_Id", Supplier_Id);
            //execute the stored procedure
            DB.Execute("sproc_tblSupply_FilterBySupplier_Id");
            if (DB.Count == 1)
            {
                //copy the data from the databse to the private data members
                mSupplier_Id = Convert.ToInt32(DB.DataTable.Rows[0]["Supplier_Id"]);
                mSupplier_Name = Convert.ToString(DB.DataTable.Rows[0]["Supplier_Name"]);
                mSupplier_Phone_Number = Convert.ToString(DB.DataTable.Rows[0]["Supplier_Phone_Number"]);
                mSupplier_Address = Convert.ToString(DB.DataTable.Rows[0]["Supplier_Address"]);
                mSupplier_Email = Convert.ToString(DB.DataTable.Rows[0]["Supplier_Email"]);
                mSupplier_Country = Convert.ToString(DB.DataTable.Rows[0]["Supplier_Country"]);
                mSupplier_Export = Convert.ToBoolean(DB.DataTable.Rows[0]["Supplier_Export"]);
                mSupplier_Trade_Restrictions = Convert.ToBoolean(DB.DataTable.Rows[0]["Supplier_Trade_Restrictions"]);
                //return that everything worked successfully
                return true;
            }
            //if no record was found 
            else
            {

                //return false indicating there is a problem
                return false;
            }
        }

        public string Valid(string supplier_Name, string supplier_Phone_Number, string supplier_Address, string supplier_Email, string supplier_Country)
        {
            //create a string variable to store the error
            String Error = "";
            
            


            //if the supplier first name is blank
            if (supplier_Name.Length == 0)
            {
                //records the error 
                Error = Error + "The Supplier Name may not be blank : ";
            }

            //if the supplier first name is greater than 50 character
            if (supplier_Name.Length > 50)
            {
                //record the error
                Error = Error + "The Supplier Name must be less than 50 Character : ";
            }

            //if the phone Number 
            if (supplier_Phone_Number.Length == 0)
            {
                Error = Error + "The Supplier Phone may not be blank : ";
            }

            //if the phone number 
            if (supplier_Phone_Number.Length > 20)
            {
                //record the error
                Error = Error + "The PhoneNumber must be less than 20 Character : ";
            }

            if (supplier_Phone_Number.Length < 11)
            {
                Error = Error + "Phone number must be greater than 11";
            }


            

            if (supplier_Address.Length == 0)
            {
                //records the error 
                Error = Error + "The Address may not be blank : ";
            }

            //if the Customer password is greater than 20 character
            if (supplier_Address.Length > 50)
            {
                //record the error
                Error = Error + "The Address must be less than 50 Character : ";
            }


            if (supplier_Email.Length == 0)
            {
                //records the error 
                Error = Error + "The Address may not be blank : ";
            }

            //if the Customer password is greater than 20 character
            if (supplier_Email.Length > 30)
            {
                //record the error
                Error = Error + "The Email must be less than 30 Character : ";
            }
   



            if (supplier_Country.Length == 0)
            {
                //records the error 
                Error = Error + "The supplier Country may not be blank : ";
            }

            //if the Customer password is greater than 20 character
            if (supplier_Country.Length > 20)
            {
                //record the error
                Error = Error + "The supplier must be less than 50 Character : ";
            }

            //return any error messages
            return Error;
        }
    }
}