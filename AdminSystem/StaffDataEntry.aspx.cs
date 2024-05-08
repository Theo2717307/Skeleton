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
        //create a new instance of clsSatff
        clsStaff AnStaff = new clsStaff();
        //capture the first name
        AnStaff.FirstName = txtFirstName.Text;
        //capture the last name
        AnStaff.LastName = txtLastName.Text;
        //capture the position
        AnStaff.Position = txtPosition.Text;
        //capture the department
        AnStaff.Department = txtDepartment.Text;
        //capture the start date
        AnStaff.StartDate = Convert.ToDateTime(DateTime.Now);
        //capture the Mananger access
        AnStaff.IsManager = chkIsManager.Checked;
        Session["AnStaff"] = AnStaff;
        //navigate to the view page
        Response.Redirect("StaffViewer.aspx");
    }
}