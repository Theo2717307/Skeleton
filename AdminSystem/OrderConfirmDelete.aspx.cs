using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 order_id;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of orders to be deleted from the session object
        order_id = Convert.ToInt32(Session["order_id"]);
    }
    protected void btnYES_Click(object sender, EventArgs e)
    {
        //create a new instance of the order collection class
        clsOrderCollection all_orders = new clsOrderCollection();
        //find the record to delete
        all_orders.ThisOrder.Find(order_id);
        all_orders.Delete();
        //redirect back to the main page
        Response.Redirect("OrderList.aspx");
    }
    protected void btnNO_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("OrderList.aspx");
    }
}