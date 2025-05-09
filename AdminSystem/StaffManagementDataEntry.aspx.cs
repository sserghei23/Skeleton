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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create an instance of clsStaff
        clsStaff AStaff = new clsStaff();

        //capture attributes that you have inserted into the text boxes.
        AStaff.StaffID = Convert.ToInt32(txtStaffID.Text);

        AStaff.OrderID = Convert.ToInt32(txtOrderID.Text);

        AStaff.FullName = txtFullName.Text;

        AStaff.Password = txtPassword.Text;

        AStaff.Email = txtEmail.Text;

        AStaff.DateOfEmployment = Convert.ToDateTime(txtDateOfEmployment.Text);

        AStaff.IsWorking = chkIsWorking.Checked;

        //store staff in the session object
        Session["AStaff"] = AStaff;

        //navigate to the viewer page
        Response.Redirect("StaffManagementViewer.aspx");
    }
}