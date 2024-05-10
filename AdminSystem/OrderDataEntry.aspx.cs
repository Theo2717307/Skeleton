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


    protected void btnOK_Click1(object sender, EventArgs e)
    {
        //create a new instance of class Order
        clsOrder AnOrder = new clsOrder();
        //capture the order id
        AnOrder.Order_id = Convert.ToInt32(txtOrderId.Text);
        //capture the customer id
        AnOrder.Customer_id= Convert.ToInt32(txtCustomerId.Text);
        //capture the order timestamp
        AnOrder.Order_timestamp = Convert.ToDateTime(txtOrderTimestamp.Text);
        //capture the order processed
        AnOrder.Order_processed = chkOrderProcessed.Checked;
        //store the order id in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to the view page
        Response.Redirect("OrderViewer.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create and instance of the order class
        clsOrder AnOrder = new clsOrder();
        //create a variable to store the primary key
        Int32 OrderID;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderID = Convert.ToInt32(txtOrderId.Text);
        //find the record
        Found = AnOrder.Find(OrderID);
        //if found
        if( Found == true)
        {
            //display the values of the properties in the form
            txtOrderId.Text = AnOrder.Order_id.ToString();
            //txtCustomerId = AnOrder.Customer_id.ToString();
            //txtOrderTimestamp = AnOrder.Order_timestamp.ToString();
            //chkOrderProcessed = AnOrder.Order_processed.ToBoolean();


        }
    }
}