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
        lstSupplierList.DataValueField = "Supplier_Id";
        //set teh dataa field to display
        lstSupplierList.DataTextField = "Supplier_Email";
        //blind the data to the list
        lstSupplierList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["Supplier_Id"] = -1;
        Response.Redirect("SupplyDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 Supplier_Id;
        if(lstSupplierList.SelectedIndex != -1) 
        {
            Supplier_Id= Convert.ToInt32(lstSupplierList.SelectedValue);
            Session["Supplier_Id"] = Supplier_Id;
            Response.Redirect("SupplyDataEntry.aspx");
        }
        else 
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }
}