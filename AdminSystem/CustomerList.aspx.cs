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
        //create a new instacne of user
        clsCustomerUser AnUser = new clsCustomerUser();
        //get data from the session object
        AnUser = (clsCustomerUser)Session["AnUser"];
        //display the user name
        Response.Write("Logged in as: " + AnUser.UserName);
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
        lstCustomerList.DataTextField = "Customer_FirstName";
        //Bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void btnAddId_Click(object sender, EventArgs e)
    {
        //store -1 into the session obecjt to indicate this a new record
        Session["Customer_Id"] = -1;
        //redirect to the data entry page
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEditId_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 Customer_Id;
        //if a record has been selected from the list
        if(lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            Customer_Id = Convert.ToInt32(lstCustomerList.SelectedValue);
            //Store the data in the sesssion object
            Session["Customer_Id"] = Customer_Id;
            //redirect to the edite page
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";

        }
    }

    protected void btnDeleteId_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 Customer_Id;
        //if a record has been selected from the list 
        if (lstCustomerList.SelectedIndex != -1) 
        {
            //get the primary key value of the record delete
            Customer_Id = Convert.ToInt32(lstCustomerList.SelectedValue);
            //Store the data in the session object
            Session["Customer_Id"] = Customer_Id;
            //redirect to the delete page
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        else 
        {
            //display an error message
            lblError.Text = "Please select a record form the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the address object
        clsCustomerCollection anCustomer = new clsCustomerCollection();
        //retrieve the values of post code from the presentation layer
        anCustomer.ReportByPostCode(txtPostCode.Text);
        //set the data source to the list of addresses in the collection
        lstCustomerList.DataSource = anCustomer.CustomerList;
        //set the name of hte primary key 
        lstCustomerList.DataValueField = "Customer_Id";
        //set the name of the field to display
        lstCustomerList.DataTextField = "Customer_FirstName";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the address object
        clsCustomerCollection anCustomer = new clsCustomerCollection();
        //Set an empty string
        anCustomer.ReportByPostCode("");
        //clear any existing filter to tidy up the interface
        txtPostCode.Text = "";
        lstCustomerList.DataSource = anCustomer.CustomerList;
        //set the name of hte primary key 
        lstCustomerList.DataValueField = "Customer_Id";
        //set the name of the field to display
        lstCustomerList.DataTextField = "Customer_FirstName";
        //bind the data to the list
        lstCustomerList.DataBind();

    }



    
    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");

    }
}