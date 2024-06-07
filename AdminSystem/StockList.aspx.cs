using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_List : System.Web.UI.Page
{
 
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStocks();
        }
    }

    void DisplayStocks()
    {
        //create an instance of the stock collection
        clsStockCollection Stock = new clsStockCollection();
        //set the data source to list of stock in the collection
        lstStockList1.DataSource = Stock.StockList;
        // set the name of the primary key
        lstStockList1.DataValueField = "vehicle_id";
        //set the data field to display
        lstStockList1.DataTextField = "stockName";
        //bind the data to the list
        lstStockList1.DataBind();


    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object t indicate this is a new record
        Session["vehicle_id"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 vehicle_id;
        //if a record has been selected from the list
        if (lstStockList1.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            vehicle_id = Convert.ToInt32(lstStockList1.SelectedValue);
            //store the data in the session object
            Session["vehicle_id"] = vehicle_id;
            //redirect to the edit page
            Response.Redirect("StockDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be dlted
        Int32 vehicle_id;
        //if a record has been selected fromthe list
        if (lstStockList2.SelectedIndex != -1)
        {
            //get th primary key value of the record delete
            vehicle_id = Convert.ToInt32(lstStockList2.SelectedValue);
            //store the data in the session object
            Session["vehicle_id"] = vehicle_id;
            // redirect to the delete page
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error messgae
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the staff object
        clsStockCollection AnStock = new clsStockCollection();
        //retrieve the value of positn from presentation layer
        AnStock.ReportBystockDetails(txtFilter.Text);
        //set the data source to the list of staff  in th ecollection
        lstStockList2.DataSource = AnStock.StockList;
        //set the name of the primary key
        lstStockList2.DataValueField = "vehicle_id";
        //set the name of the field to display
        lstStockList2.DataTextField = "stockDetaills";
        //bind the data to the list
        lstStockList2.DataBind();

    }
}