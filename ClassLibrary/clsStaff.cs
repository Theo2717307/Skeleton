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
                mStaff_ID = value;
            }


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

        public string Valid(string FirstName, string LastName, string Position, string Department, string StartDate)
        {
            // Create a string variable to store the error
            string Error = "";

            DateTime DateTemp;

            // If the FirstName is blank
            if (FirstName.Length == 0)
            {
                // Record the error
                Error = "The first name may not be blank. ";
            }
            // If the FirstName is greater than 50 characters
            if (FirstName.Length > 50)
            {
                // Record the error
                Error += "The first name must be less than or equal to 50 characters. ";
            }

            try
            {//copy the dateAdded value to the DateTemp variable 
                DateTemp = Convert.ToDateTime(StartDate);
                if (DateTemp < DateTime.Now.Date)
                { //record the error
                    Error = Error + "The date cannot be in the past : ";
                }

                //check to see if the date is greater than today's date 

                if (DateTemp > DateTime.Now.Date)
                { //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date: ";
            }
            // Check if the LastName is blank
            if (LastName.Length == 0)
            {
                // Record the error
                Error += "The last name may not be blank. ";
            }

            // If the LastName is too long
            if (LastName.Length > 50)
            {
                // Record the error
                Error += "The last name must be less than 50 characters. ";
            }

            // Check if the Position is blank
            if (Position.Length == 0)
            {
                // Record the error
                Error += "The position may not be blank. ";
            }

            // If the Position is too long
            if (Position.Length > 50)
            {
                // Record the error
                Error += "The position must be less than 50 characters. ";
            }

            // Check if the Department is blank
            if (Department.Length == 0)
            {
                // Record the error
                Error += "The department may not be blank. ";
            }

            // If the Department is too long
            if (Department.Length > 50)
            {
                // Record the error
                Error += "The department must be less than 50 characters. ";
            }

            // Return any error messages
            return Error;
            }
        }
    }
