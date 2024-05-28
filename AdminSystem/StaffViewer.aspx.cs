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
        if (!IsPostBack && Request.QueryString["StaffID"] != null)
        {
            int staffID;
            if (int.TryParse(Request.QueryString["StaffID"], out staffID))
            {
                DisplayStaffDetails(staffID);
            }
            else
            {
                ltlStaffDetails.Text = "Invalid Staff ID.";
            }
        }
    }

    protected void btnViewStaff_Click(object sender, EventArgs e)
    {
        int staffID;
        if (int.TryParse(txtStaffID.Text, out staffID))
        {
            // Redirect to the same page with the staff ID as a query parameter
            Response.Redirect("StaffViewer.aspx?StaffID=" + staffID.ToString());
        }
        else
        {
            ltlStaffDetails.Text = "Please enter a valid Staff ID.";
        }
    }

    private void DisplayStaffDetails(int staffID)
    {
        // Create an instance of the staff collection
        clsStaffCollection staffCollection = new clsStaffCollection();
        // Find the staff member with the given ID
        clsStaff selectedStaff = staffCollection.Find(staffID);

        if (selectedStaff != null)
        {
            // Display all staff details
            ltlStaffDetails.Text = string.Format("First Name: {0}<br>Last Name: {1}<br>Position: {2}<br>Department: {3}<br>Start Date: {4}<br>Is Manager: {5}<br>",
                selectedStaff.FirstName,
                selectedStaff.LastName,
                selectedStaff.Position,
                selectedStaff.Department,
                selectedStaff.StartDate.ToShortDateString(),
                selectedStaff.IsManager
            );
            // Add other properties as needed
        }
        else
        {
            ltlStaffDetails.Text = "Staff member not found.";
        }
    }
}