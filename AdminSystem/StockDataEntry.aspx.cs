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
       
        //Capturing user input
        string stockName = txtStockName.Text;
        string stockDetails = txtStockDetails.Text;
        string unit_price = txtUnitPrice.Text;
        string quantity = txtQuantity.Text;
        string last_restock_date = txtLastRestock.Text;
        string discontinued = chkDiscontinued.Text;
        //variable to store any error messages
        string Error = "";

        //validation the data
        Error = AnStock.Valid(stockName, stockDetails, unit_price, quantity, last_restock_date);
        if (Error == "")

        //capture the stock name
        AnStock.stockName = stockName;

        //Capture the stock detials
        AnStock.stockDetails = stockDetails;

      

        //Capture the last restock date
        AnStock.last_restock_date = Convert.ToDateTime(last_restock_date);



        //store stock in the session object
        Session["AnStock"] = AnStock;
        //navigate to view page
        Response.Redirect("StockViewer.aspx");




    }
}




