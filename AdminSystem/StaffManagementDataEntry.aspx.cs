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

        AStaff.StaffID = Convert.ToInt32(txtStaffID.Text);
        AStaff.IsWorking = chkIsWorking.Checked;


        //capture the five attributes inserted into the fields: OrderID, FullName, Password, Email, DateOfEmployment for validation
        string OrderID = txtOrderID.Text;
        string FullName = txtFullName.Text;
        string Password = txtPassword.Text;
        string Email = txtEmail.Text;
        string DateOfEmployment = txtDateOfEmployment.Text;
        //create variable to store error message and validated data
        string Error = "";
        Error = AStaff.Valid(OrderID, FullName, Password, Email, DateOfEmployment);
        if (Error == "")
        {
            //capture attributes that you have inserted into the text boxes.
            AStaff.OrderID = Convert.ToInt32(OrderID);
            AStaff.FullName = txtFullName.Text;
            AStaff.Password = txtPassword.Text;
            AStaff.Email = txtEmail.Text;
            AStaff.DateOfEmployment = Convert.ToDateTime(DateOfEmployment);
            //store staff in the session object
            Session["AStaff"] = AStaff;
            //navigate to the viewer page
            Response.Redirect("StaffManagementViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

            //capture attributes that you have inserted into the text boxes.
            //AStaff.StaffID = Convert.ToInt32(txtStaffID.Text);

            //AStaff.OrderID = Convert.ToInt32(txtOrderID.Text);

            //AStaff.FullName = txtFullName.Text;

            //AStaff.Password = txtPassword.Text;

            //AStaff.Email = txtEmail.Text;

            //AStaff.DateOfEmployment = Convert.ToDateTime(txtDateOfEmployment.Text);

            //AStaff.IsWorking = chkIsWorking.Checked;

            //store staff in the session object
            //Session["AStaff"] = AStaff;

            //navigate to the viewer page
            //Response.Redirect("StaffManagementViewer.aspx");
        }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //variable to store the primary key
        Int32 StaffID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffID = Convert.ToInt32(txtStaffID.Text);
        //find the record
        Found = AStaff.Find(StaffID);
        //if found, display the values in the entry form
        if (Found == true)
        {
            txtOrderID.Text = AStaff.OrderID.ToString();
            txtFullName.Text = AStaff.FullName;
            txtPassword.Text = AStaff.Password;
            txtEmail.Text = AStaff.Email;
            txtDateOfEmployment.Text = AStaff.DateOfEmployment.ToString();
            chkIsWorking.Checked = AStaff.IsWorking;
        }

        else
        {
            //display an error message
            lblError.Text = "Staff ID not found";
        }
    }
}