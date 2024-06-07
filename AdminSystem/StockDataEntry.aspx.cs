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
        int vehicle_id;
        //get the number of the address to be processed
        vehicle_id = Convert.ToInt32(Session["vehicle_id"]);
        //If this is the first Time the page is displayed
        if (IsPostBack == false)
        {
            if (vehicle_id != -1)
            {
                //update the list box
                DisplayStock(vehicle_id);
            }

        }

    }

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {

    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsStock AnStock = new clsStock();

        int vehicle_id = int.Parse(txtVehicleID.Text);
        string stockName = txtStockName.Text;
        string stockDetails = txtStockDetails.Text;
        string unit_price = txtunitprice.Text;
        string quantity = txtquantity.Text;
        string last_restock_date = txtLastRestock.Text;
        string discontinued = chkDiscontinued.Text;

        //variable to store any error messages
        string Error = "";

        //validation the data
        Error = AnStock.Valid(stockName, stockDetails, quantity, unit_price, last_restock_date);
        //variable to store any error messages
        if (Error == "")

        {
            //Capture the addressId
            AnStock.vehicle_id = vehicle_id;

            //capture the firstname
            AnStock.stockName = stockName;

            //Capture the lastname
            AnStock.stockDetails = stockDetails;

            //Capture the PhoneNumber
            AnStock.unit_price = unit_price;

            //Capture the Email
            AnStock.quantity = quantity;

            //Capture the postcode
            AnStock.last_restock_date = Convert.ToDateTime(last_restock_date);

            //Capture the registration
            AnStock.discontinued = chkDiscontinued.Checked;


            //Create a new instance of the address collection
            clsStockCollection StockList = new clsStockCollection();

            //if this is a new record i.e. Customer_Id = -1 then add the data
            if (vehicle_id == -1)
            {
                //set the thiscustomer property
                StockList.ThisStock = AnStock;
                //add the new record
                StockList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                StockList.ThisStock.Find(vehicle_id);
                //set the ThisCustomer property
                StockList.ThisStock = AnStock;
                //update the record
                StockList.Update();
            }


            //navigate to the view page
            Response.Redirect("StockList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;


        }


    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class 
        clsStock anStock = new clsStock();
        //create a variable to store the primary key
        int vehicle_id;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        vehicle_id = int.Parse(txtVehicleID.Text);
        //Find the record
        Found = anStock.Find(vehicle_id);
        //if found 
        if (Found == true)
        {

            txtStockName.Text = anStock.stockName;
            txtStockDetails.Text = anStock.stockDetails;
            txtquantity.Text = anStock.quantity;
            txtunitprice.Text = anStock.unit_price;
            txtLastRestock.Text = anStock.last_restock_date.ToString();
            chkDiscontinued.Checked = anStock.discontinued;
        }



    }

    void DisplayStock(int vehicle_id)
    {
        //create an instance of the address book
        clsStockCollection StockBook = new clsStockCollection();
        //find the record to update
        StockBook.ThisStock.Find(vehicle_id);
        //display the data for the record
        txtStockName.Text = StockBook.ThisStock.stockName.ToString();
        txtStockDetails.Text = StockBook.ThisStock.stockDetails.ToString();
        txtquantity.Text = StockBook.ThisStock.quantity.ToString();
        txtunitprice.Text = StockBook.ThisStock.unit_price.ToString();
        txtLastRestock.Text = StockBook.ThisStock.last_restock_date.ToString();
        chkDiscontinued.Checked = StockBook.ThisStock.discontinued;
    }




}


