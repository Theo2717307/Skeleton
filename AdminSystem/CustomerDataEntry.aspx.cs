using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {

    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();

        //capture firstName 
        AnCustomer.CustomerFirstName = txtFirstName.Text;

        //caputre lastname
        AnCustomer.CustomerLastName = txtLastName.Text;

        //capture phonenumber
        AnCustomer.CustomerPhoneNumber = txtPhoneNumber.Text;

        //capture email
        AnCustomer.CustomerEmail = txtEmail.Text;

        //capture address
        AnCustomer.CustomerAddress = txtAddress.Text;

        //capture password
        AnCustomer.CustomerPassword = txtPassword.Text;

        //capture active box
        AnCustomer.Active = CheckBox1.Checked;

        //store the address in the sessoin object
        Session["AnCustomer"] = AnCustomer;

        //navigate to the view page
        Response.Redirect("CustomerViewer.aspx");
    }
}