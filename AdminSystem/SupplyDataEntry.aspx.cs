using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of cls Supply
        clsSupply Supplier1 = new clsSupply();
        //capture the supplier name
        Supplier1.Supplier_Name = txtSupplier_Name.Text;
        //capture the supplier number
        Supplier1.Supplier_Phone_Number = txtSupplier_Phone_Number.Text;
        //capture the supplier address
        Supplier1.Supplier_Address = txtSupplier_Address.Text;
        //capture the supplier email
        Supplier1.Supplier_Email = txtSupplier_Email.Text;
        //capture the supplier country
        Supplier1.Supplier_Country = txtSupplier_Country.Text;
        //capture the supplier export check box
        Supplier1.Supplier_Export = Supplier1.Supplier_Export = chkYes.Checked;
        //capture the supplier trade restrictions check box
        Supplier1.Supplier_Trade_Restrictions = Supplier1.Supplier_Trade_Restrictions = chkYes2.Checked;

        //store the name in the session object
        Session["Supplier1"] = Supplier1;
        //navigate to the view page
        Response.Redirect("SupplyViewer.aspx");


    }

    protected void txtSupplier_Name_TextChanged(object sender, EventArgs e)
    {

    }
}