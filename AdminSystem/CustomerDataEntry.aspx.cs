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
        clsCustomer AnCustomer = new clsCustomer();

        //capture CustomerId
        AnCustomer.Customer_Id = Convert.ToInt32(txtCustomer_Id.Text);

        //capture firstName 
        AnCustomer.Customer_FirstName = txtCustomer_FirstName.Text;

        //caputre lastname
        AnCustomer.Customer_LastName = txtCustomer_LastName.Text;

        //capture phonenumber
        AnCustomer.Customer_PhoneNumber = txtCustomer_PhoneNumber.Text;

        //capture email
        AnCustomer.Customer_Email = txtCustomer_Email.Text;

        //capture address
        AnCustomer.Customer_Address = txtCustomer_Address.Text;

        //capture password
        AnCustomer.Customer_Password = txtCustomer_Password.Text;

        //capture active box
        AnCustomer.Active = CheckBox1.Checked;

        //store the address in the sessoin object
        Session["AnCustomer"] = AnCustomer;

        //navigate to the view page
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class 
        clsCustomer anCustomer = new clsCustomer();
        //create a variable to store the primary key
        Int32 Customer_Id;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        Customer_Id = Convert.ToInt32(txtCustomer_Id.Text);
        //Find the record
        Found = anCustomer.Find(Customer_Id);  
        //if found 
        if (Found == true) 
        {
            //diaply the values of the propeties in the form 
            txtCustomer_FirstName.Text = anCustomer.Customer_FirstName;
            txtCustomer_LastName.Text = anCustomer.Customer_LastName;
            txtCustomer_PhoneNumber.Text = anCustomer.Customer_PhoneNumber;
            txtCustomer_Email.Text = anCustomer.Customer_Email;
            txtCustomer_Password.Text = anCustomer.Customer_Password;  
            txtCustomer_Address.Text = anCustomer.Customer_Address;
            CheckBox1.Checked = anCustomer.Active;
        }


    }
}