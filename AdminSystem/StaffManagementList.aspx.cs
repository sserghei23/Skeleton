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
        //if this is the first time the page has been displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
        //create an instance of the staff collection
        clsStaffCollection Staffs = new clsStaffCollection();
        //set the data source to the list of staff in the collection
        lstStaffList.DataSource = Staffs.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffID";
        //set the data field to display and bind the data to the list
        lstStaffList.DataTextField = "FullName";
        lstStaffList.DataBind();
    }
}