﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (IsPostBack == false ) 
        {
            //update the list box
            DisplayStaffs();
        }

    }
    void DisplayStaffs()
    {

        //create an instance of the staff collection
        clsStaffCollection Staffs = new clsStaffCollection();
        //set th data source to list of addresses in the collection
        lstStaffList.DataSource = Staffs.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "Staff_ID";
        //set the data field to display
        lstStaffList.DataTextField = "FirstName";
        //bind the data to the list
        lstStaffList.DataBind();
    }
}