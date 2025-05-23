﻿using System;
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

    protected void btnAdd_Click(object sender, EventArgs eventArgs)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StaffID"] = -1;
        //redirect to the data entry page
        Response.Redirect("StaffManagementDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    { 
        //variable to store primary key
        Int32 StaffID;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key of the record to edit
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffId"] = StaffID;
            Response.Redirect("StaffManagementDataEntry.aspx");
        }
        //if no record has been selected.
        else
        {
            //display an error message
            lblError.Text = "Please select a record to edit from the list";
        }
    }
}