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

        if (IsPostBack == false ) 
        {
            //update the list box
            DisplayStaffs();
        }
        //create a new instance of clsOrderUser
        clsStaffUser AnUser = new clsStaffUser();
        //get data from session object
        AnUser = (clsStaffUser)Session["AnUser"];
        //display the username
        Response.Write("Logged in as: " + AnUser.UserName);

    }
    void DisplayStaffs()
    {

        //create an instance of the staff collection
        clsStaffCollection Staffs = new clsStaffCollection();
        //set th data source to list of addresses in the collection
        lstStaffList.DataSource = Staffs.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "Staff_ID";
        //set the data field to display
        lstStaffList.DataTextField = "FirstName";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["Staff_ID"] = -1;
        //redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }

 
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 Staff_ID;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1) 
        {
            //get the primary key value of the record to edit
            Staff_ID = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the ession object
            Session["Staff_ID"] = Staff_ID;
            //redirect to the edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a rcord from the list to edit";
        }

    }



    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be dlted
        Int32 Staff_ID;
        //if a record has been selected fromthe list
        if ( lstStaffList.SelectedIndex != -1 ) 
        {
            //get th primary key value of the record delete
            Staff_ID = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["Staff_ID"] = Staff_ID;
            // redirect to the delete page
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error messgae
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the staff object
        clsStaffCollection AnStaff = new clsStaffCollection();
        //retrieve the value of positn from presentation layer
        AnStaff.ReportByPosition(txtFilter.Text);
        //set the data source to the list of staff  in th ecollection
        lstStaffList.DataSource = AnStaff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "Staff_ID";
        //set the name of the field to display
        lstStaffList.DataTextField = "Position";
        //bind the data to the list
        lstStaffList.DataBind();

    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the staff object
        clsStaffCollection AnStaff = new clsStaffCollection();
        //retrieve the value of positn from presentation layer
        AnStaff.ReportByPosition("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        //set the data source to the list of staff  in th ecollection
        lstStaffList.DataSource = AnStaff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "Staff_ID";
        //set the name of the field to display
        lstStaffList.DataTextField = "Position";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        //redirect to the main menu page
        Response.Redirect("TeamMainMenu.aspx");
    }
}