using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //get the data from the session object
        AnOrder = (clsOrder)Session["AnOrder"];
        //display the order id for this entry
        Response.Write(AnOrder.Order_id);
        Response.Write("<br/>");
        //display the customer id for this entry
        Response.Write(AnOrder.Customer_id);
        Response.Write("<br/>");
        //display the order timestamp for this entry
        Response.Write(AnOrder.Order_timestamp);
        Response.Write("<br/>");
        //display the order processed for this entry
        Response.Write(AnOrder.Order_processed)
    }
}