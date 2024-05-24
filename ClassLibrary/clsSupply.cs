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
        public bool Supplier_Export { get; set; }
        public bool Supplier_Trade_Restrictions { get; set; }

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

        public bool Find(long pNumber)
        {
            throw new NotImplementedException();
        }

        public bool Find(bool sExport)
        {
            throw new NotImplementedException();
        }

        public string Valid(string supplier_Phone_Number, string supplier_Address, string supplier_Email, string supplier_Country, bool supplier_Export, bool supplier_Trade_Restrictions)
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
            //return any error messages
            return Error;
        }
    }
}