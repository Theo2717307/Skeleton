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
    Int32 vehicleIdVariable;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        vehicleIdVariable = Convert.ToInt32(Session["vehicle_id"]);
        //If this is the first Time the page is displayed
        if (IsPostBack == false)
        {
            if (vehicleIdVariable != -1)
            {
                //update the list box
                DisplayStock();
            }

        }


    }


    private void DisplayStock()
    {
        //create instance of the stock book
        clsStockCollection StockBook = new clsStockCollection();
        //find the record to updat
        StockBook.ThisStock.Find(vehicleIdVariable);
        //dispaly the data for the record
        txtVehicleID.Text = StockBook.ThisStock.vehicle_id.ToString();
        txtStockName.Text = StockBook.ThisStock.stockName.ToString();
        txtStockDetails.Text = StockBook.ThisStock.stockDetails.ToString();
        txtquantity.Text = StockBook.ThisStock.quantity.ToString();
        txtunitprice.Text = StockBook.ThisStock.unit_price.ToString();
        txtLastRestock.Text = StockBook.ThisStock.last_restock_date.ToString();
        chkDiscontinued.Text = StockBook.ThisStock.discontinued.ToString();
    }
    protected void btnClearFilter_Click(object sender, EventArgs e){
    
    }
    protected void btnReturn_Click(object sender, EventArgs e)
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
        
        Error = AnStock.Valid( stockName, stockDetails, quantity, unit_price, last_restock_date);
        //variable to store any error messages
        if (Error == "")


        {
            AnStock.vehicle_id = vehicleIdVariable;
            AnStock.stockName = stockName;
            AnStock.stockDetails = stockDetails;
            AnStock.unit_price = unit_price;
            AnStock.quantity = quantity;
            AnStock.last_restock_date = Convert.ToDateTime(last_restock_date);
            AnStock.discontinued = chkDiscontinued.Checked;

            //create a new instance of stock collection
            clsStockCollection StockList = new clsStockCollection();

            if (vehicleIdVariable == -1)
            {
                // Add the new record
                StockList.ThisStock = AnStock;
                StockList.Add();
            }
            else
            {
                // Update the existing record
                StockList.ThisStock.Find(vehicleIdVariable);
                StockList.ThisStock = AnStock;
                StockList.Update();
            }

            // redirect back to list page
            Response.Redirect("StockList.aspx");
        }
        else
        {
            // display errors
            lblError.Text = Error;
        }



    }
}




