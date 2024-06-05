using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_List : System.Web.UI.Page
{
    Int32 product_id;
    protected void Page_Load(object sender, EventArgs e)
    {

        // if this is the first time the page is displayed
        product_id = Convert.ToInt32(Session["product_id"]);
    if (IsPostBack == false)
        {
            if (product_id != -1)
            {

                //update the list box
                DisplayStock();

            }
      
        }
    }

    void DisplayStock()
    {
        //create an instance of the stock collection
        clsStockCollection Stock = new clsStockCollection();
        //set the data source to list of stock in the collection
         
            
        lstStockList.DataSource = Stock.StockList;
        // set the name of the primary key
        lstStockList.DataValueField = "stockName";
        //set the data field to display
        lstStockList.DataTextField = "stockDetails";
        //bind the data to the list
        lstStockList.DataBind();


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //store -1 into the session object t indicate this is a new record
        Session["product_id"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 product_id;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            product_id = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["product_id"] = product_id;
            //redirect to the edit page
            Response.Redirect("StockDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }
}