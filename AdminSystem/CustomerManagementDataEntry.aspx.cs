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
        txtDateRegistered.Text = CustomerBook.ThisCustomer.DateRegistered.ToString();
        chkIsActive.Checked = CustomerBook.ThisCustomer.IsActive;

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //Capture the Postcode
        string postCode = txtPostCode.Text;
        //Capture the Date registered
        string dateRegistered = txtDateRegistered.Text;
        //Capture the Is Active
        string isActive = chkIsActive.Text;
        //Capture the Phonenumber
        string phoneNumber = txtPhoneNumber.Text;
        //Capture the Email Address
        string email = txtEmail.Text;
        //Capture the Full Name
        string fullName = txtFullName.Text;
        //Variable to store any error messages
        //string password = txtPassword.Text;
        string Error = "";

        Error = AnCustomer.Valid(dateRegistered, postCode, phoneNumber, email, fullName);
        if (Error == "")
        {
            //Capture the Customer ID
            AnCustomer.CustomerId = CustomerId;
            //Capture the PostCode
            AnCustomer.PostCode = postCode;
            //Capture the DateRegistered
            AnCustomer.DateRegistered = Convert.ToDateTime(dateRegistered);
            //Capture the Phone Number
            AnCustomer.PhoneNumber = phoneNumber;
            //Capture the Email
            AnCustomer.Email = email;
            //Capture the Full Name
            AnCustomer.FullName = fullName;
            //Capture the Password
            //AnCustomer.Password = password;
            //Capture Active
            AnCustomer.IsActive = chkIsActive.Checked;
            //Create a new instance of the address collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            //If this is a new record i.e Customer ID = -1 then add the data
            if (CustomerId == -1)
            {
                //set the ThisCustomer property
                CustomerList.ThisCustomer = AnCustomer;
                //Add the new record
                CustomerList.Add();

            }
            //Otherwise it must be an update

            else
            {
                //Find the record to Update
                CustomerList.ThisCustomer.Find(CustomerId);
                //set the ThisCustomer property
                CustomerList.ThisCustomer = AnCustomer;
                //Update the record
                CustomerList.Update();
            }
            //redirect back to the List Page
            Response.Redirect("CustomerManagementList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = "There was a problem: " + Error;
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
}
