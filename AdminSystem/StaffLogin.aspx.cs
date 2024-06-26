﻿using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an instance of class
        clsStaffUser anUser = new clsStaffUser();
        //create the variable to stor ethe username and password
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;
        //create a variable to store teh result of the find user operation
        Boolean Found = false;
        //get the username entered by the user
        UserName = Convert.ToString(txtUserName.Text);
        //get the password entered by the user
        Password = Convert.ToString(txtPassword.Text);
        //Add a session to capture the username
        Session["AnUser"] = anUser;
        //find the record
        Found = anUser.FindUser(UserName, Password);
        //if username and/or password is empty
        if (txtUserName.Text == "")
        {
            lblError.Text = "Enter a username: ";

        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Enter a password: ";
        }
        else if (Found == true)
        {
            //redirec to the list page
            Response.Redirect("StaffList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Login details are incorrect! Please try again ";
        }
    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main menu page
        Response.Redirect("TeamMainMenu.aspx");
    }
}