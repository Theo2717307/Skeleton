using System;

namespace ClassLibrary
{
    public class clsSupply
    {
        private String mSupplier_Name;

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
        public Int64 Supplier_Phone_Number { get; set; }
        public string Supplier_Address { get; set; }
        public string Supplier_Email { get; set; }
        public string Supplier_Country { get; set; }
        public bool Supplier_Export { get; set; }
        public bool Supplier_Trade_Restrictions { get; set; }

        public bool Find(string supplier70)
        {
            mSupplier_Name = "John";
            return true;
        }

        public bool Find(long pNumber)
        {
            throw new NotImplementedException();
        }
    }
}