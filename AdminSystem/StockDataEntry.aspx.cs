using ClassLibrary;
using System;
using System.Activities.Expressions;
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

        string stockName = txtStockName.Text;
        string stockDetails = txtStockDetails.Text;
        string unit_price = txtunitprice.Text;
        string quantity = txtquantity.Text;
        string last_restock_date = txtLastRestock.Text;
        string discontinued = chkDiscontinued.Text;
        string Error = "";
        Error = AnStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
        //variable to store any error messages
        if (Error == "")


        {
            AnStock.stockName = stockName;
            AnStock.stockDetails = stockDetails;
            AnStock.unit_price = unit_price;
            AnStock.quantity = quantity;
            AnStock.last_restock_date = Convert.ToDateTime(last_restock_date);
            Session["AnStock"] = AnStock;
            //navigate to view page
            Response.Redirect("StockViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }



    }
}




