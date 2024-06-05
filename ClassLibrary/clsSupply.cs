using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ClassLibrary
{
    public class clsSupply
    {
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
        public bool Supplier_Export { get 
            {
                return mSupplier_Export;
            } set 
            {
                mSupplier_Export = value;
            } 
        }
        public bool Supplier_Trade_Restrictions { get 
            {
                return mSupplier_Trade_Restrictions;
            } set 
            {
                mSupplier_Trade_Restrictions = value;
            } 
        }

        // FIND METHOD //
        public bool Find(string Supplier_Name)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the supplier name to search for
            DB.AddParameter("@Supplier_Name", Supplier_Name);
            //execute the stored procedure
            DB.Execute("sproc_tblSupply_FilterBySupplier_Name");
            if (DB.Count == 1)
            {
                //copy the data from the databse to the private data members
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

       /* public bool Find(long pNumber)
        {
            throw new NotImplementedException();
        }

        public bool Find(bool sExport)
        {
            throw new NotImplementedException();
        }*/

        public string Valid(string supplier_Phone_Number, string supplier_Address, string supplier_Email, string supplier_Country)
        {
            //create a string variable to store the error
            String Error = "";
            //if the Supplier Phone Number is blank
            if (supplier_Phone_Number.Length == 0)
            {
                //record the error
                Error = Error + "The Supplier Phone Number may not be blank : ";
            }
            //if the Supplier Phone Number is less than 11 characters
            if (supplier_Phone_Number.Length < 11)
            {
                //record the error
                Error = Error + "The Supplier Phone Number may not be less than 11 characters : ";
            }
            //if the Supplier Phone Number is greater than 500 characters
            if (supplier_Phone_Number.Length >= 50)
            {
                //record the error
                Error = Error + "The Supplier Phone Number may not be greater than 11 characters : ";
            }


            //if the Supplier Address is blank
            if (supplier_Address.Length == 0)
            {
                //record the error
                Error = Error + "The Supplier Address may not be blank : ";
            }

            //if the Supplier Phone Number is less than 11 characters
            if (supplier_Address.Length < 6)
            {
                //record the error
                Error = Error + "The Supplier Phone Number may not be less than 6 characters : ";
            }

            //if the Supplier Phone Number is greater than 500 characters
            if (supplier_Address.Length >= 50)
            {
                //record the error
                Error = Error + "The Supplier Address may not be greater than 50 characters : ";
            }


            //if the Supplier email is blank
            if (supplier_Email.Length == 0)
            {
                //record the error
                Error = Error + "The Supplier Address may not be blank : ";
            }

            //if the Suppliere email less than 3
            if (supplier_Email.Length < 3)
            {
                //record the error
                Error = Error + "The Supplier Phone Number may not be less than 3 characters : ";
            }

            //if the Supplier Phone Number is greater than 500 characters
            if (supplier_Email.Length >= 30)
            {
                //record the error
                Error = Error + "The Supplier Address may not be greater than 30 characters : ";
            }

            //if the Supplier email is blank
            if (supplier_Country.Length == 0)
            {
                //record the error
                Error = Error + "The Supplier Address may not be blank : ";
            }

            //if the Suppliere email less than 3
            if (supplier_Country.Length < 4)
            {
                //record the error
                Error = Error + "The Supplier Phone Number may not be less than 3 characters : ";
            }

            //if the Supplier Phone Number is greater than 500 characters
            if (supplier_Country.Length >= 20)
            {
                //record the error
                Error = Error + "The Supplier Address may not be greater than 30 characters : ";
            }
            //return any error messages
            return Error;
        }
    }
}