using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this order is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayOrders();
        }

        //create a new instance of clsOrderUser
        clsOrderUser a_user = new clsOrderUser();
        //get data from session object
        a_user = (clsOrderUser)Session["a_user"];
        //display the username
        Response.Write("Logged in as: " + a_user.Username);
    }

    void DisplayOrders()
    {
        //create an instance of the order collection
        clsOrderCollection orders = new clsOrderCollection();
        //set the data source to list of orders in collection
        lstOrderBox.DataSource = orders.OrderList;
        //set the name of the primary key
        lstOrderBox.DataValueField = "order_id";
        //set the data field to display
        lstOrderBox.DataTextField = "Order_timestamp";
        //bind the data to the list
        lstOrderBox.DataBind();
    }
    void DisplayOrderLine()
    {
        //create an instance of the order line collection
        clsOrderLineCollection order_lines = new clsOrderLineCollection();
        //set the data source to list of order lines in collection
        
    }
    protected void btnADD_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["order_id"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrderDataEntry.aspx");
    }
    protected void btnEDIT_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["order_id"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrderDataEntry.aspx");
    }
    protected void btnDELETE_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 order_id;
        //if a record has been selected from the list
        if (lstOrderBox.SelectedIndex != -1)
        {
            //get the primary key from of the record to be deleted
            order_id = Convert.ToInt32(lstOrderBox.SelectedValue);
            //store the data in the session object
            Session["order_id"] = order_id;
            //redirect to the delete page
            Response.Redirect("OrderConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }
    protected void btnFrom_Click(object sender, EventArgs e)
    {
        CalendarFrom.Visible = true;
    }

    protected void selection_changedFrom(object sender, EventArgs e)
    {
        btnFrom.Text = CalendarFrom.SelectedDate.ToString();
        CalendarFrom.Visible = false;
    }
    protected void btnTo_Click(object sender, EventArgs e)
    {
        CalendarTo.Visible = true;
    }

    protected void selection_changedTo(object sender, EventArgs e)
    {
        btnTo.Text = CalendarFrom.SelectedDate.ToString();
        CalendarTo.Visible = false;
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        //redirect to the main menu page
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //TODO
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //TODO
    }

    protected void lstOrderBox_MouseDoubleClick(object sender, EventArgs e)
    {
        int index = lstOrderBox.SelectedIndex;
        Console.WriteLine(index);
    }
}