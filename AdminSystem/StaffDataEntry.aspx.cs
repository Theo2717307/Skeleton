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

    protected void txtStaff_ID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //capture the Firstname
        string FirstName = txtFirstName.Text;
        //capture the lastnamw
        string LastName = txtLastName.Text;
        //capture the position
        string Position = txtPosition.Text;
        //capture Department
        string Department = txtDepartment.Text;
        //capture start Start date
        string StartDate = txtStartDate.Text;
        //capture is manager check box
        string IsManager = chkIsManager.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnStaff.Valid(FirstName, LastName, Position, Department, StartDate);
        if (Error == "")
        {
            //capture the first name
            AnStaff.FirstName = FirstName;
            //capture the last name
            AnStaff.LastName = LastName;
            //capture the position
            AnStaff.Position = Position;
            //capture the department
            AnStaff.Department = Department;
            //capture the start date
            AnStaff.StartDate = Convert.ToDateTime(StartDate);
            //store the staff in session object
            Session["AnStaff"] = AnStaff;
            //navigate to the view page
            Response.Redirect("StaffViewer.aspx");
        }
        else
        {
            //display the error msg
            lblError.Text = Error;
        }
    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the staff class
        clsStaff AnStaff = new clsStaff();
        //create a variable to store the primary key
        Int32 Staff_ID;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        Staff_ID = Convert.ToInt32(txtStaff_ID.Text);
        //find the record
        Found = AnStaff.Find(Staff_ID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form

            txtFirstName.Text = AnStaff.FirstName;
            txtLastName.Text = AnStaff.LastName;
            txtPosition.Text = AnStaff.Position;
            txtDepartment.Text = AnStaff.Department;
            txtStartDate.Text = AnStaff.StartDate.ToString();
            chkIsManager.Checked = AnStaff.IsManager;
        }
    }
}