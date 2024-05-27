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


    protected void btnOK_Click1(object sender, EventArgs e)
    {

        // create new instance of clsStock
        clsStock AnStock = new clsStock();
        //capture the stock name
        AnStock.stockName = txtStockName.Text;
        //other properties
        AnStock.stockDetails = txtStockDetails.Text;
        AnStock.unit_price = Convert.ToInt32(txtUnitPrice.Text);
        AnStock.quantity = Convert.ToInt32(txtQuantity.Text);
        AnStock.last_restock_date = Convert.ToDateTime(DateTime.Now);
        AnStock.discontinued = chkDiscontinued.Checked;



        //store stock in the session object
        Session["AnStock"] = AnStock;
        
        
      
        //navigate to view page
        Response.Redirect("StockViewer.aspx");
    }
}




