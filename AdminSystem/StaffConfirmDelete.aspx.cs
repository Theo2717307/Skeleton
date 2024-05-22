﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 Staff_ID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the staff to be deleted from the session object
        Staff_ID = Convert.ToInt32(Session["Staff_ID"]);
    }



    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the saff book collection class
        clsStaffCollection StaffBook = new clsStaffCollection();
        //find the record to delete
        StaffBook.ThisStaff.Find(Staff_ID);
        StaffBook.Delete();
        //redirect back to the main page
        Response.Redirect("StaffList.aspx");

    }



    protected void btnNo_Click(object sender, EventArgs e)
    {

        //redirect back to the main page
        Response.Redirect("StaffList.aspx");

    }
}