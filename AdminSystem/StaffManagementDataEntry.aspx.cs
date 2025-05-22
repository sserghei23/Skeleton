using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffID = Convert.ToInt32(Session["StaffID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (StaffID != -1)
            {
                //display the current data for the record
                DisplayStaff();
            }
        }
    }

    //To enable the user to edit existing records, this function below 
    //will display the current data for the record in the text boxes.
    void DisplayStaff()
    {
        //create an instance of the staff collection
        clsStaffCollection Staffs = new clsStaffCollection();
        //find the record to update
        Staffs.ThisStaff.Find(StaffID);
        //display the current data for the record
        txtStaffID.Text = Staffs.ThisStaff.StaffID.ToString();
        txtOrderID.Text = Staffs.ThisStaff.OrderID.ToString();
        txtFullName.Text = Staffs.ThisStaff.FullName.ToString();
        txtPassword.Text = Staffs.ThisStaff.Password.ToString();
        txtEmail.Text = Staffs.ThisStaff.Email.ToString();
        txtDateOfEmployment.Text = Staffs.ThisStaff.DateOfEmployment.ToString();
        chkIsWorking.Checked = Staffs.ThisStaff.IsWorking;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create an instance of clsStaff
        clsStaff AStaff = new clsStaff();

        //AStaff.StaffID = Convert.ToInt32(txtStaffID.Text);
        //AStaff.IsWorking = chkIsWorking.Checked;


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
            //IMPORTANT: necessary to capture StaffID for the update procedure
            AStaff.StaffID = Convert.ToInt32(StaffID);

            //capture attributes that you have inserted into the text boxes.
            AStaff.OrderID = Convert.ToInt32(OrderID);
            AStaff.FullName = FullName;
            AStaff.Password = Password;
            AStaff.Email = Email;
            AStaff.DateOfEmployment = Convert.ToDateTime(DateOfEmployment);
            AStaff.IsWorking = chkIsWorking.Checked;
            //create an instance of the staff collection
            clsStaffCollection StaffList = new clsStaffCollection();

            if (StaffID == -1)
            {
                //set ThisStaff to the test data
                StaffList.ThisStaff = AStaff;
                //add the record
                StaffList.Add();
            }
            else
            {
                //find the record to update
                StaffList.ThisStaff.Find(StaffID);
                //set ThisStaff to the test data
                StaffList.ThisStaff = AStaff;
                //update the record
                StaffList.Update();
            }

            //create an instance of the staff collection
            //clsStaffCollection StaffList = new clsStaffCollection();
            //StaffList.ThisStaff = AStaff;
            //StaffList.Add();
            Response.Redirect("StaffManagementList.aspx");


        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }


    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the list page
        Response.Redirect("StaffManagementList.aspx");
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

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //clear the text boxes
        txtStaffID.Text = "";
        txtOrderID.Text = "";
        txtFullName.Text = "";
        txtPassword.Text = "";
        txtEmail.Text = "";
        txtDateOfEmployment.Text = "";
        chkIsWorking.Checked = false;
    }
}