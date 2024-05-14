using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsSupply
        clsSupply Supplier1 = new clsSupply();
        //get the data from the session object
        Supplier1 = (clsSupply)Session["Supplier1"];
        //display the name of the supplier
        Response.Write(Supplier1.Supplier_Name);
        Response.Write("<br>");
        Response.Write(Supplier1.Supplier_Phone_Number);
        Response.Write("<br>");
        Response.Write(Supplier1.Supplier_Address);
        Response.Write("<br>");
        Response.Write(Supplier1.Supplier_Email);
        Response.Write("<br>");
        Response.Write(Supplier1.Supplier_Country);
        Response.Write("<br>");
        Response.Write(Supplier1.Supplier_Export);
        Response.Write("<br>");
        Response.Write(Supplier1.Supplier_Trade_Restrictions);
    }
}