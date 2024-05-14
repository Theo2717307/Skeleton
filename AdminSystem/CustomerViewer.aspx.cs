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

        Response.Write(AnCustomer.Customer_Id + "<br>");
        Response.Write(AnCustomer.Customer_FirstName + " ");
        Response.Write(AnCustomer.Customer_LastName + "<br>");
        Response.Write(AnCustomer.Customer_Email + "<br>");
        Response.Write(AnCustomer.Customer_Address + "<br>");
        Response.Write(AnCustomer.Customer_Password + "<br>");
        Response.Write(AnCustomer.Active);

    }
}
