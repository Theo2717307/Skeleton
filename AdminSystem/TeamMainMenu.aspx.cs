using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    /*******************CUSTOMER*******************/
    protected void btnCustomer_Click(object sender, EventArgs e)
    {

    }
    /*******************ORDER*******************/
    protected void btnOrder_Click(object sender, EventArgs e)
    {
        //Redirect user to login page for orders
        Response.Redirect("OrderLogin.aspx");
    }
    /*******************STAFF*******************/
    protected void btnStaff_Click(object sender, EventArgs e)
    {

    }
    /*******************STOCK*******************/
    protected void btnStock_Click(object sender, EventArgs e)
    {

    }
    /*******************SUPPLY*******************/
    protected void btnSupply_Click(object sender, EventArgs e)
    {

    }
}