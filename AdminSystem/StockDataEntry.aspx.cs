using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page

{
	protected void Page_Load(object sender, EventArgs e)
	{

	}

	protected void btnOK_Click(object sender, EventArgs e)
	{
		//creates new instance of clsStock
		clsStock AnStock = new clsStock();
		//capture stock name
		AnStock.stockName = txtStockName.Text;
		// store stock in the session object
		Session["AnStock"] = AnStock;
        //navigate to view page
        Response.Redirect("StockViewer.aspx");
	}
}




