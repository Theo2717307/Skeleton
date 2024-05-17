using System;
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
        //If this is the first Time the page is displayed
        if (IsPostBack == false) 
        {
            //update the list box
            DisplayCustomers();
        }
    }

    void DisplayCustomers()
    {
        //Create an instance of Customer Collection
        clsCustomerCollection customer = new clsCustomerCollection();
        //set the data source to list of address in the collection
        lstCustomerList.DataSource = customer.CustomerList;
        //set the name of the primary key

        lstCustomerList.DataValueField = "Customer_Id";
        //set the data field to display
        lstCustomerList.DataTextField = "Customer_PostCode";
        //Bind the data to the list
        lstCustomerList.DataBind();
    }
}