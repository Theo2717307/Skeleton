using System;

namespace ClassLibrary
{
    public class clsCustomerUser
    {
        //private data member for field
        private Int32 mUserId;
        private String mUserName;
        private String mPassword;
        private String mDepartment;




        public int UserId {
            get 
            {
                return mUserId;
            } 
            set 
            {
                mUserId = value;
            } 
        }

        public string UserName {
            get 
            {
                return mUserName;
            }
            set 
            {
                mUserName = value;
            } 
        }

        public string Password {
            get 
            {
                return mPassword;
            }
            set 
            {
                mPassword = value;
            } 
        }

        public string Department {
            get 
            {
                return mDepartment;
            } set 
            {
                mDepartment = value;
            } 
        }

        public bool FindUser(string UserName, string Password)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add parameters for the username and password to search for
            DB.AddParameter("@UserName", UserName);
            DB.AddParameter("@Password", Password);
            //excute 
            DB.Execute("sproc_tblUsers_FindUserNamePw");
            //if one records 
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mUserId = Convert.ToInt32(DB.DataTable.Rows[0]["UserId"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //return true to confirm
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}