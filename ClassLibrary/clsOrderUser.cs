using System;

namespace ClassLibrary
{
    public class clsOrderUser
    {
        //private data members
        private Int32 mUserID;
        private String mUserName;
        private String mPassword;
        private String mDepartment;


        public clsOrderUser()
        {
        }
        public Int32 UserID 
        { 
            get {  return mUserID; }
            set { mUserID = value; }
        }
        public string Username 
        { 
            get { return mUserName; }
            set { mUserName = value; }
        }
        public string Password 
        { 
            get { return mPassword; } 
            set { mPassword = value; }
        }
        public string Department
        {
            get { return mDepartment; }
            set { mDepartment = value; }
        }

        public bool FindUser(string test_username, string test_password)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameters
            DB.AddParameter ("@UserName", test_username);
            DB.AddParameter ("@Password", test_password);
            //execute the stored procedure
            DB.Execute("sproc_tblUsers_FindUserNamePW");
            //if one record is found (should be 1 or None)
            if (DB.Count == 1)
            {
                //copy the data to private data members
                mUserID     = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUserName   = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword   = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //return true to confirm it worked
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}