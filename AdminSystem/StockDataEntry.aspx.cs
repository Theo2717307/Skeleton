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
    Int32 product_id;

	protected void Page_Load(object sender, EventArgs e)
	{
        // get the number of the stock to be processed
        product_id = Convert.ToInt32(Session["product_id"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (product_id != -1)
            {
                //display the current data for the record
                DisplayStocks();
            }

        }

	}

         void DisplayStocks()
         {
        //create instance of the stock book
        clsStockCollection StockBook = new clsStockCollection();
        //find the record to update
        StockBook.ThisStock.Find(product_id);
        //display the data for the record
        txtProductID.Text = StockBook.ThisStock.product_id.ToString();
        txtStockName.Text = StockBook.ThisStock.stockName.ToString();
        txtStockDetails.Text = StockBook.ThisStock.stockDetails.ToString();
        txtquantity.Text = StockBook.ThisStock.quantity.ToString();
        txtunitprice.Text = StockBook.ThisStock.unit_price.ToString();
        txtLastRestock.Text = StockBook.ThisStock.last_restock_date.ToString();
        chkDiscontinued.Text = StockBook.ThisStock.discontinued.ToString();


       }


       protected void btnOK_Click1(object sender, EventArgs e)
       {

        // create new instance of clsStock
        clsStock AnStock = new clsStock();
        string product_id = txtProductID.Text;
        string stockName = txtStockName.Text;
        string stockDetails = txtStockDetails.Text;
        string unit_price = txtunitprice.Text;
        string quantity = txtquantity.Text;
        string last_restock_date = txtLastRestock.Text;
        string discontinued = chkDiscontinued.Text;
        string Error = "";
        
        Error = AnStock.Valid( stockName, stockDetails, quantity, unit_price, last_restock_date);
        //variable to store any error messages
        if (Error == "")


        {
            AnStock.product_id = Convert.ToInt32(product_id);
            AnStock.stockName = stockName;
            AnStock.stockDetails = stockDetails;
            AnStock.unit_price = unit_price;
            AnStock.quantity = quantity;
            AnStock.last_restock_date = Convert.ToDateTime(last_restock_date);
            AnStock.discontinued = chkDiscontinued.Checked;

            //create a new instance of stock collection
            clsStockCollection StockList = new clsStockCollection();

            //set ThisStock property
            StockList.ThisStock = AnStock;
            //Add the new record
            StockList.Add();

            //redirect back to list page
            Response.Redirect("StockList.aspx");

        }

        //other wise it must be an update
        else
        {
            lblError.Text = Error;
        }



    }
}




