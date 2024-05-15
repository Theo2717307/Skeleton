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
        //if this order is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayOrders();
        }
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
}