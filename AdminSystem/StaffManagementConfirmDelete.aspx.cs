﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffID = Convert.ToInt32(Session["StaffID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staffs = new clsStaffCollection();
        //find the record to delete
        Staffs.ThisStaff.Find(StaffID);
        Staffs.Delete();
        Response.Redirect("StaffManagementList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect to the list page
        Response.Redirect("StaffManagementList.aspx");
    }
}