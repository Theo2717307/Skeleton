using System.Collections.Generic;
using System; // Import the System namespace


namespace ClassLibrary
{
    public class clsStaffCollection
    {
       
        //private data member for the list
        
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private member data for thisStaff
        clsStaff mThisStaff = new clsStaff();

        //public property for the staff list

        public List<clsStaff> StaffList
        {
            get
            {
                //set the private data
                return mStaffList;

            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }

        public int Count
        {
            get 
            { 
                return mStaffList.Count; 
            }

            set
            { ////later}

            }
        }
        public clsStaff ThisStaff
        {
            get
            {
                // return the private data
                return mThisStaff;
                ;


            }
            set
            {
                //set the private data
                mThisStaff = value;
                ;
            }
        }

        

        public clsStaffCollection()
        {
            //constructor for the class
            
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount ) 
            { 
                //create a blank staffmember
                clsStaff AnStaff = new clsStaff();
                AnStaff.IsManager = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsManager"]);
                AnStaff.Staff_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Staff_ID"]);
                AnStaff.StartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StartDate"]);
                AnStaff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AnStaff.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AnStaff.Position = Convert.ToString(DB.DataTable.Rows[Index]["Position"]);
                AnStaff.Department = Convert.ToString(DB.DataTable.Rows[Index]["Department"]);
                //add the record to the private data member
                mStaffList.Add( AnStaff );
                //point at the next record
                Index++;
            }
 
        }

        public int Add()
        {
            //adds a record to the database based on vals of mThisStaff
            //set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();
            //set the paremeters for the stored procedure
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@Position", mThisStaff.Position);
            DB.AddParameter("@Department", mThisStaff.Department);
            DB.AddParameter("@StartDate", mThisStaff.StartDate);
            DB.AddParameter("@IsManager", mThisStaff.IsManager);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
            
        }

      
    }
}
