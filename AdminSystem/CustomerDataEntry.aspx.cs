using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    int Customer_Id;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        Customer_Id = Convert.ToInt32(Session["Customer_Id"]);
        //If this is the first Time the page is displayed
        if (IsPostBack == false)
        {
            if (Customer_Id != -1)
            {
                //update the list box
                DisplayCustomers();
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
        clsCustomer AnCustomer = new clsCustomer();

        /*//capture CustomerId
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

        //capture PostCode
        AnCustomer.Customer_PostCode = txtCustomer_PostCode.Text;  

        //Capture registration date
        AnCustomer.Registration = Convert.ToDateTime(txtRegistration.Text);

        //capture password
        AnCustomer.Customer_Password = txtCustomer_Password.Text;

        //capture active box
        AnCustomer.Active = CheckBox1.Checked;*/

        //Capturing user input
        string Customer_FirstName = txtCustomer_FirstName.Text;
        string Customer_LastName = txtCustomer_LastName.Text;
        string Customer_PhoneNumber = txtCustomer_PhoneNumber.Text; 
        string Customer_Email = txtCustomer_Email.Text;
        string Customer_Password = txtCustomer_Password.Text; 
        string Customer_Address = txtCustomer_Address.Text;
        string Customer_PostCode = txtCustomer_PostCode.Text;
        string Registration = txtRegistration.Text;

        //variable to store any error messages
        string Error = "";

        //validation the data
        Error = AnCustomer.Valid(Customer_FirstName, Customer_LastName, Customer_PhoneNumber, Customer_Email, Customer_Password, Customer_Address, Customer_PostCode, Registration);
        if(Error == "")
        {
            //Capture the addressId
            AnCustomer.Customer_Id = Customer_Id; 

            //capture the firstname
            AnCustomer.Customer_FirstName = Customer_FirstName;

            //Capture the lastname
            AnCustomer.Customer_LastName = Customer_LastName;

            //Capture the PhoneNumber
            AnCustomer.Customer_PhoneNumber = Customer_PhoneNumber;

            //Capture the Email
            AnCustomer.Customer_Email= Customer_Email;

            //Capture the Password
            AnCustomer.Customer_Password= Customer_Password;   

            //Capture the Address
            AnCustomer.Customer_Address = Customer_Address;

            //Capture the postcode
            AnCustomer.Customer_PostCode = Customer_PostCode;

            //Capture the registration
            AnCustomer.Registration = Convert.ToDateTime(Registration);

            //Capture active
            AnCustomer.Active = CheckBox1.Checked;

            //Create a new instance of the address collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            //if this is a new record i.e. Customer_Id = -1 then add the data
            if (Customer_Id == -1) 
            {
                //set the thiscustomer property
                CustomerList.ThisCustomer = AnCustomer;
                //add the new record
                CustomerList.Add();
            }
            //otherwise it must be an update
            else 
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(Customer_Id);
                //set the ThisCustomer property
                CustomerList.ThisCustomer= AnCustomer;
                //update the record
                CustomerList.Update();
            }
          

            //navigate to the view page
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            //display the error message
            lblErrorId.Text = Error;


        }

        
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
            txtCustomer_PostCode.Text = anCustomer.Customer_PostCode;
            txtRegistration.Text = anCustomer.Registration.ToString();
            CheckBox1.Checked = anCustomer.Active;
        }

        

    }

    void DisplayCustomers() 
    {
        //create an instance of the address book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to update
        CustomerBook.ThisCustomer.Find(Customer_Id);
        //display the data for the record
        txtCustomer_FirstName.Text = CustomerBook.ThisCustomer.Customer_FirstName.ToString();
        txtCustomer_LastName.Text = CustomerBook.ThisCustomer.Customer_LastName.ToString();
        txtCustomer_PhoneNumber.Text = CustomerBook.ThisCustomer.Customer_PhoneNumber.ToString();
        txtCustomer_Email.Text = CustomerBook.ThisCustomer.Customer_Email.ToString();
        txtCustomer_Password.Text = CustomerBook.ThisCustomer.Customer_Password.ToString();
        txtCustomer_Address.Text = CustomerBook.ThisCustomer.Customer_Address.ToString();
        txtCustomer_PostCode.Text = CustomerBook.ThisCustomer.Customer_PostCode.ToString();
        txtRegistration.Text = CustomerBook.ThisCustomer.Registration.ToString();
        CheckBox1.Checked = CustomerBook.ThisCustomer.Active;
    }
}