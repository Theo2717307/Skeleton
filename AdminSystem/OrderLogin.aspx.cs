using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an instance of the order user class
        clsOrderUser a_user = new clsOrderUser();
        //create the variables to store the username and password
        String username;
        String password;
        //create a var to store the result of find method
        Boolean found = false;
        //get the username entered by the user
        username = Convert.ToString(text_username.Text);
        //get the password entered by the user
        password = Convert.ToString(text_password.Text);
        //find the record
        found = a_user.FindUser(username, password);
        //if username or password is empty
        if (text_username.Text == "")
        {
            //record the error
            lblError.Text = "Please enter a username";
        }
        else if (text_password.Text == "")
        {
            //record the error
            lblError.Text = "Please enter a password";
        }
        else if (found == true)
        {
            //redirect to list page
            Response.Redirect("OrderList.aspx");
        }
        else if (found == false)
        {
            //record the error
            lblError.Text = "Login details are incorrect. Please try again.";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}