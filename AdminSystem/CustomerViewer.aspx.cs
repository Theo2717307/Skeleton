using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();

        //get the data from the session object
        AnCustomer = (clsCustomer)Session["AnCustomer"];

        //display the Customer first name for this entry
        Response.Write(AnCustomer.CustomerFirstName + " ");
        Response.Write(AnCustomer.CustomerLastName + "<br>");
        Response.Write(AnCustomer.CustomerEmail + "<br>");
        Response.Write(AnCustomer.CustomerAddress + "<br>");
        Response.Write(AnCustomer.CustomerPassword + "<br>");
        Response.Write(AnCustomer.Active);

    }
}