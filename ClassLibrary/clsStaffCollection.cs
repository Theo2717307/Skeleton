using System.Collections.Generic;
using System; // Import the System namespace


namespace ClassLibrary
{
    public class clsStaffCollection
    {
        // Private data member for the list
        private List<clsStaff> mStaffList = new List<clsStaff>();

        // Private member data for thisStaff
        private clsStaff mThisStaff = new clsStaff();

        // Public property for the staff list
        public List<clsStaff> StaffList
        {
            get
            {
                // Return the private data
                return mStaffList;
            }
            set
            {
                // Set the private data
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
            {
                // No need for setter, included for consistency
            }
        }

        public clsStaff ThisStaff
        {
            get
            {
                // Return the private data
                return mThisStaff;
            }
            set
            {
                // Set the private data
                mThisStaff = value;
            }
        }

        // Constructor for the class
        public clsStaffCollection()
        {
            // Object for the data connection
            clsDataConnection DB = new clsDataConnection();
            // Execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            // Populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            // Adds a record to the database based on the values of mThisStaff
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@Position", mThisStaff.Position);
            DB.AddParameter("@Department", mThisStaff.Department);
            DB.AddParameter("@StartDate", mThisStaff.StartDate);
            DB.AddParameter("@IsManager", mThisStaff.IsManager);
            // Execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Delete()
        {
            // Deletes the record pointed to by mThisStaff
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure
            DB.AddParameter("@Staff_ID", mThisStaff.Staff_ID);
            // Execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void Update()
        {
            // Updates the record pointed to by mThisStaff
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure
            DB.AddParameter("@Staff_ID", mThisStaff.Staff_ID);
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@Position", mThisStaff.Position);
            DB.AddParameter("@Department", mThisStaff.Department);
            DB.AddParameter("@StartDate", mThisStaff.StartDate);
            DB.AddParameter("@IsManager", mThisStaff.IsManager);
            // Execute the query
            DB.Execute("sproc_tblStaff_Update");
        }

        public void ReportByPosition(string Position)
        {
            // Filters the records based on a full or partial position
            clsDataConnection DB = new clsDataConnection();
            // Send the Position parameter to the database
            DB.AddParameter("@Position", Position);
            // Execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByPosition");
            // Populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            // Populate the array list based on the data table in the parameter DB
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mStaffList = new List<clsStaff>();
            while (Index < RecordCount)
            {
                clsStaff AnStaff = new clsStaff();
                AnStaff.Staff_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Staff_ID"]);
                AnStaff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AnStaff.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AnStaff.Position = Convert.ToString(DB.DataTable.Rows[Index]["Position"]);
                AnStaff.Department = Convert.ToString(DB.DataTable.Rows[Index]["Department"]);
                AnStaff.StartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StartDate"]);
                AnStaff.IsManager = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsManager"]);
                mStaffList.Add(AnStaff);
                Index++;
            }
        }
    }
}