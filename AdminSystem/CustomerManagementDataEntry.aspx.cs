using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the numeber of the address to be processed
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
        if (IsPostBack == false)
        {

            //if this is not a new record
            if (CustomerId != -1)
            {
                //display the current data for the record
                DisplayCustomer();
            }
        }
    }

    void DisplayCustomer()
    {
        //create an instance of the address book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to update
        CustomerBook.ThisCustomer.Find(CustomerId);
        //Display the data for the record
        txtCustomerId.Text = CustomerBook.ThisCustomer.CustomerId.ToString();
        txtFullName.Text = CustomerBook.ThisCustomer.FullName;
        txtEmail.Text = CustomerBook.ThisCustomer.Email;
        //txtPassword.Text = CustomerBook.ThisCustomer.Password;
        txtPhoneNumber.Text = CustomerBook.ThisCustomer.PhoneNumber;
        txtPostCode.Text = CustomerBook.ThisCustomer.PostCode;
        txtDateRegistered.Text = CustomerBook.ThisCustomer.DateRegistered.ToString("yyyy-MM-dd");
        chkIsActive.Checked = CustomerBook.ThisCustomer.IsActive;

    }

    
    protected void btnOK_Click(object sender, EventArgs e)
    {
        // Create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        // Capture the Postcode
        string postCode = txtPostCode.Text;
        // Capture the DateRegistered
        string dateRegistered = txtDateRegistered.Text;
        // Capture the Is Active
        bool isActive = chkIsActive.Checked;
        // Capture the PhoneNumber
        string phoneNumber = txtPhoneNumber.Text;
        // Capture the Email Address
        string email = txtEmail.Text;
        // Capture the Full Name
        string fullName = txtFullName.Text;

        // Variable to store any error messages
        string error = "";

        // Validate the input fields, including DateRegistered
        if (string.IsNullOrEmpty(dateRegistered))
        {
            error = "Date Registered cannot be empty.";
        }
        else
        {
            // Check if DateRegistered can be parsed into a valid DateTime
            DateTime parsedDate;
            if (!DateTime.TryParse(dateRegistered, out parsedDate))
            {
                error = "Invalid date format for Date Registered.";
            }
            else
            {
                // If no errors, continue with the process
                AnCustomer.DateRegistered = parsedDate;
            }
        }

        // Check if any validation errors occurred
        if (string.IsNullOrEmpty(error))
        {
            // Capture the Customer ID
            AnCustomer.CustomerId = CustomerId;
            // Capture other properties
            AnCustomer.PostCode = postCode;
            AnCustomer.PhoneNumber = phoneNumber;
            AnCustomer.Email = email;
            AnCustomer.FullName = fullName;
            AnCustomer.IsActive = isActive;

            // Proceed with adding or updating the customer
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            // If this is a new record (CustomerId == -1), add the data
            if (CustomerId == -1)
            {
                CustomerList.ThisCustomer = AnCustomer;
                CustomerList.Add();
            }
            else
            {
                // Otherwise, update the existing record
                CustomerList.ThisCustomer.Find(CustomerId);
                CustomerList.ThisCustomer = AnCustomer;
                CustomerList.Update();
            }

            // Redirect back to the List Page
            Response.Redirect("CustomerManagementList.aspx");
        }
        else
        {
            // Display the error message
            lblError.Text = error;
        }
    }



    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //Create an Instance of the Customer Class
        clsCustomer AnCustomer = new clsCustomer();
        //Create a Variable to Store the Primary Key
        Int32 CustomerId;
        //Create a Variable to store the result of the find operation
        Boolean Found = false;
        //Get the primary key entered by the user
        CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //Find The Record
        Found = AnCustomer.Find(CustomerId);
        //If Foound
        if (Found == true)
        {
            //Display the value of the properties in the form
            txtFullName.Text = AnCustomer.FullName;
            txtEmail.Text = AnCustomer.Email;
            txtPhoneNumber.Text = AnCustomer.PhoneNumber;
            //txtPassword.Text = AnCustomer.Password;
            chkIsActive.Checked = AnCustomer.IsActive;
            txtPostCode.Text = AnCustomer.PostCode;
            txtDateRegistered.Text = AnCustomer.DateRegistered.ToString();

        }
    }
    protected void txtDateRegistered_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnReturntoMM_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerManagementList.aspx");
    }
}
