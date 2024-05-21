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

        clsStock AnStock = new clsStock();
        //capture the stock name
        AnStock = (clsStock)Session["AnStock"];
        //store stock in the session object
        Session["AnStock"] = AnStock;
        //navigate to the view page
        Response.Write("AnStock.stockName");

    }
}