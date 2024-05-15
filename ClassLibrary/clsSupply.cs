using System;
using System.Runtime.CompilerServices;

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

        public bool Find(string supplier70)
        {
            mSupplier_Name = "John";
            mSupplier_Phone_Number = "07376106016";
            mSupplier_Address = "12 Darwin Close";
            mSupplier_Email = "jhigginson@gmail.com";
            mSupplier_Country = "England";
            mSupplier_Export = false;
            mSupplier_Trade_Restrictions = false;

            return true;
        }

        public bool Find(long pNumber)
        {
            throw new NotImplementedException();
        }

        public bool Find(bool sExport)
        {
            throw new NotImplementedException();
        }
    }
}