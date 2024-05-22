using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key value of the record to be deleted
    Int32 Customer_Id;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session object
        Customer_Id = Convert.ToInt32(Session["Customer_Id"]);

    }

    protected void btnYesId_Click(object sender, EventArgs e)
    {
        //Create a new instance of the customer collection class
        clsCustomerCollection customerCollection = new clsCustomerCollection();
        //find the record to delete
        customerCollection.ThisCustomer.Find(Customer_Id);
        //Find the record to delete
        customerCollection.Delete();
        //rediret back to the main page
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnNoId_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("CustomerList.aspx");

    }
}