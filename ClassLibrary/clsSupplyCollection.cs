using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsSupplyCollection
    {
        //private data member for the list
        List<clsSupply> mSupplierList = new List<clsSupply>();
        clsSupply mThisSupplier = new clsSupply();


        //Constructor for the class
        public clsSupplyCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the records count
            Int32 RecordCount = 0;
            //onject for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the count 
            DB.Execute("sproc_tblSupply_SelectAll");
            //get the count of recrods
            RecordCount = DB.Count;
            //while there are records of process
            while (Index < RecordCount)
            {
                //create a blank addres 
                clsSupply AnSupplier = new clsSupply();
                //read in teh files for the currenct records
                //copy the data from the databse to the private data members
                AnSupplier.Supplier_Id = Convert.ToInt32(DB.DataTable.Rows[0]["Supplier_Id"]);
                AnSupplier.Supplier_Name = Convert.ToString(DB.DataTable.Rows[0]["Supplier_Name"]); 
                AnSupplier.Supplier_Phone_Number = Convert.ToString(DB.DataTable.Rows[0]["Supplier_Phone_Number"]);
                AnSupplier.Supplier_Address = Convert.ToString(DB.DataTable.Rows[0]["Supplier_Address"]);
                AnSupplier.Supplier_Email = Convert.ToString(DB.DataTable.Rows[0]["Supplier_Email"]);
                AnSupplier.Supplier_Country = Convert.ToString(DB.DataTable.Rows[0]["Supplier_Country"]);
                AnSupplier.Supplier_Export = Convert.ToBoolean(DB.DataTable.Rows[0]["Supplier_Export"]);
                AnSupplier.Supplier_Trade_Restrictions = Convert.ToBoolean(DB.DataTable.Rows[0]["Supplier_Trade_Restrictions"]);
                //add the records toe the private data member
                mSupplierList.Add(AnSupplier);
                
                //to next records
                Index++;
            }

        }



        public List<clsSupply> SupplierList
        {
            get
            {
                return mSupplierList;
            }
            set
            {
                mSupplierList = value;
            }
        }
        public int Count
        {
            get
            {
                return mSupplierList.Count;
            }
            set
            {
                //worry about this later
            }
        }
        public clsSupply ThisSupplier
        {
            get
            {
                return mThisSupplier;
            }
            set
            {
                //worry about this later
                mThisSupplier = value;  
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            //set the parameters of the stored procedure
            DB.AddParameter("@Supplier_Name", mThisSupplier.Supplier_Name);
            DB.AddParameter("@Supplier_Phone_Number", mThisSupplier.Supplier_Phone_Number);
            DB.AddParameter("@Supplier_Address", mThisSupplier.Supplier_Address);
            DB.AddParameter("@Supplier_Email", mThisSupplier.Supplier_Email);
            DB.AddParameter("@Supplier_Country", mThisSupplier.Supplier_Country);
            DB.AddParameter("@Supplier_Export", mThisSupplier.Supplier_Export);
            DB.AddParameter("@Supplier_Trade_Restrictions", mThisSupplier.Supplier_Trade_Restrictions);
          
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblSupply_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            //set the parameters of the stored procedure
            DB.AddParameter("@Supplier_Id", mThisSupplier.Supplier_Id);
            DB.AddParameter("@Supplier_Name", mThisSupplier.Supplier_Name);
            DB.AddParameter("@Supplier_Phone_Number", mThisSupplier.Supplier_Phone_Number);
            DB.AddParameter("@Supplier_Address", mThisSupplier.Supplier_Address);
            DB.AddParameter("@Supplier_Email", mThisSupplier.Supplier_Email);
            DB.AddParameter("@Supplier_Country", mThisSupplier.Supplier_Country);
            DB.AddParameter("@Supplier_Export", mThisSupplier.Supplier_Export);
            DB.AddParameter("@Supplier_Trade_Restrictions", mThisSupplier.Supplier_Trade_Restrictions);

            //execute the query returning the primary key value
            DB.Execute("sproc_tblSupply_Update");
        }
    }
}