using System;
using System.IO;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for the staff id property
        private Int32 mStaff_ID;

        public Int32 Staff_ID

        {
            get
            {
                //this line of code sends data out of the property
                return mStaff_ID;

            }
            set
            {

                //This line of code allows data into the property
                mStaff_ID = value; }


        }

        private string mFirstName;
        public string FirstName
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }

        private string mLastName;
        public string LastName
        {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
        }

        private string mPosition;
        public string Position
        {
            get
            {
                return mPosition;
            }
            set
            {
                mPosition = value;
            }
        }

        private string mDepartment;
        public string Department
        {
            get
            {
                return mDepartment;
            }
            set
            {
                mDepartment = value;
            }
        }

        private DateTime mStartDate;
        public DateTime StartDate
        {
            get
            {
                return mStartDate;
            }
            set
            {
                mStartDate = value;
            }
        }

        private bool mIsManager;
        public bool IsManager
        {
            get
            {
                return mIsManager;
            }
            set
            {
                mIsManager = value;
            }
        }


        //********** FIND METHOD****//

        public bool Find(int Staff_ID)
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            // Add the parameter for the Staff_ID to search for
            DB.AddParameter("@Staff_ID", Staff_ID);

            // Execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaff_ID");

            // If one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                // Copy the data from the database to the private data members
                mStaff_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Staff_ID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mPosition = Convert.ToString(DB.DataTable.Rows[0]["Position"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                mStartDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StartDate"]);
                mIsManager = Convert.ToBoolean(DB.DataTable.Rows[0]["IsManager"]);

                // Return that everything worked OK
                return true;
            }
            // If no record was found
            else
            {
                // Return false indicating there is a problem
                return false;
            }
        }


        //function for the public validation method
        
        public string Valid(string firstName, string lastName, string position, string department, string startDate)
        {
            // Create a string variable to store the error
            string Error = "";

            //create a temporary variable to store data values
            DateTime DateTemp;

            // If the FirstName is blank
            if (firstName.Length == 0)
            {
                // Record the error
                Error = "The first name may not be blank. ";
            }
            // If the FirstName is greater than 50 characters
            if (firstName.Length > 50)
            {
                // Record the error
                Error += "The first name must be less than or equal to 50 characters. ";
            }
            DateTemp = Convert.ToDateTime(StartDate);
            if (DateTemp < DateTime.Now.AddYears(-20))
            {
                Error += "The date cannot be more than 20 years in the past. ";
            }

            if (DateTemp > DateTime.Now.Date)
            {
                Error += "The date cannot be in the future: ";
            }

            // Return any error messages
            return Error;
        }
    }
}
