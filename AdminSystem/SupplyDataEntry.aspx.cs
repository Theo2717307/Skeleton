using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 SupplierId;
    protected void Page_Load(object sender, EventArgs e)
    {
        SupplierId = Convert.ToInt32(Session["Supplier_Id"]);
        if (IsPostBack == false)
        {
            if (SupplierId != -1)
            {
                //update the list box
                DisplaySupplier();
            }

        }


    }
    void DisplaySupplier()
    {
        //create an instance of the supplyer 
        clsSupplyCollection Supplier1 = new clsSupplyCollection();
        //find the record
        Supplier1.ThisSupplier.Find(SupplierId);
        //display 
        txtSupplier_Id.Text = Supplier1.ThisSupplier.Supplier_Id.ToString();
        txtSupplier_Name.Text = Supplier1.ThisSupplier.Supplier_Name.ToString();    
        txtSupplier_Phone_Number.Text = Supplier1.ThisSupplier.Supplier_Phone_Number.ToString();
        txtSupplier_Address.Text = Supplier1.ThisSupplier.Supplier_Address.ToString();
        txtSupplier_Country.Text = Supplier1.ThisSupplier.Supplier_Country.ToString();
        chkYes.Checked = Supplier1.ThisSupplier.Supplier_Export;
        chkYes2.Checked = Supplier1.ThisSupplier.Supplier_Trade_Restrictions;

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of cls Supply
        clsSupply Supplier1 = new clsSupply();
        /*//capture the supplier Id
        Supplier1.Supplier_Id = Convert.ToInt32(txtSupplier_Id.Text); */
        //capture the supplier name
        string Supplier_Name = txtSupplier_Name.Text;
        //capture the supplier number
        string Supplier_Phone_Number = txtSupplier_Phone_Number.Text;
        //capture the supplier address
        string Supplier_Address = txtSupplier_Address.Text;
        //capture the supplier email
        string Supplier_Email = txtSupplier_Email.Text;
        //capture the supplier country
        string Supplier_Country = txtSupplier_Country.Text;
        //capture the supplier export check box
        string Supplier_Export = chkYes.Text; 
        //capture the supplier trade restrictions check box
        string Supplier_Trade_Restrictions = chkYes2.Text;
        //variable to store any error message
        string Error = "";
        //validation the data
        Error = Supplier1.Valid(Supplier_Name, Supplier_Phone_Number, Supplier_Address, Supplier_Email, Supplier_Country);
        if (Error == "")
        {
            Supplier1.Supplier_Id = SupplierId;
            Supplier1.Supplier_Name = Supplier_Name;
            Supplier1.Supplier_Phone_Number = Supplier_Phone_Number;
            Supplier1.Supplier_Address = Supplier_Address;
            Supplier1.Supplier_Email = Supplier_Email;
            Supplier1.Supplier_Country = Supplier_Country;
            Supplier1.Supplier_Export = chkYes.Checked;
            Supplier1.Supplier_Trade_Restrictions= chkYes2.Checked;

            clsSupplyCollection SupplierList = new clsSupplyCollection();

            if(SupplierId == -1) 
            {
                SupplierList.ThisSupplier = Supplier1;
                SupplierList.Add();
            }
            else 
            {
                SupplierList.ThisSupplier.Find(SupplierId);
                SupplierList.ThisSupplier = Supplier1;
                SupplierList.Update();
            }
            
            Response.Redirect("SupplyBookList.aspx");


            /*//store the name in the session object
            Session["Supplier1"] = Supplier1;
            //navigate to the view page
            Response.Redirect("SupplyViewer.aspx");*/
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }




    }

    protected void txtSupplier_Name_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the name class
        clsSupply Supplier_Name = new clsSupply();
        //create a variable to store the primary key
        Int32 Supplier_Id;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        Supplier_Id = Convert.ToInt32(txtSupplier_Id.Text);
        //find the record
        Found = Supplier_Name.Find(Supplier_Id);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtSupplier_Name.Text = Supplier_Name.Supplier_Name;
            txtSupplier_Phone_Number.Text = Supplier_Name.Supplier_Phone_Number;
            txtSupplier_Address.Text = Supplier_Name.Supplier_Address;
            txtSupplier_Email.Text = Supplier_Name.Supplier_Email;
            txtSupplier_Country.Text = Supplier_Name.Supplier_Country;
            chkYes.Checked = Supplier_Name.Supplier_Export;
            chkYes2.Checked = Supplier_Name.Supplier_Trade_Restrictions;
        }
        
    }

    protected void btnFind_Click1(object sender, EventArgs e)
    {
        //create an instance of the name class
        clsSupply Supplier = new clsSupply();
        //create a variable to store the primary key
        Int32 Supplier_Id;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        Supplier_Id = Convert.ToInt32(txtSupplier_Id.Text);
        //find the record
        Found = Supplier.Find(Supplier_Id);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtSupplier_Name.Text = Supplier.Supplier_Name;
            txtSupplier_Phone_Number.Text = Supplier.Supplier_Phone_Number;
            txtSupplier_Address.Text = Supplier.Supplier_Address;
            txtSupplier_Email.Text = Supplier.Supplier_Email;
            txtSupplier_Country.Text = Supplier.Supplier_Country;
            chkYes.Checked = Supplier.Supplier_Export;
            chkYes2.Checked = Supplier.Supplier_Trade_Restrictions;
        }

    }
}
