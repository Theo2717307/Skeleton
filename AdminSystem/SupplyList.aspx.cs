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
                //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplaySuppliers();
        }
    }

    void DisplaySuppliers()
    {
        //create an instance
        clsSupplyCollection Suppliers = new clsSupplyCollection();
        //set the data source to list of suppliers in the collection
        lstSupplierList.DataSource = Suppliers.SupplierList;
        //set the name of teh priumary key
        lstSupplierList.DataValueField = "Supplier_Name";
        //set teh dataa field to display
        lstSupplierList.DataTextField = "Supplier_Email";
        //blind the data to the list
        lstSupplierList.DataBind();
    }

}