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
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //Capture the Postcode
        string PostCode = txtPostCode.Text;
        //Capture the Date registered
        string DateRegistered = txtDateRegistered.Text;
        //Capture the Is Active
        string IsActive = chkIsActive.Text;
        //Capture the Phonenumber
        string PhoneNumber = txtPhoneNumber.Text;
        //Capture the Email Address
        string Email = txtEmail.Text;
        //Capture the Full Name
        string FullName = txtFullName.Text;
        //Variable to store any error messages
        string Password = txtPassword.Text;
        string Error = "";
        Error = AnCustomer.Valid(PostCode, DateRegistered, PostCode, PhoneNumber, Email, FullName);
        if (Error == "")
        {
            //Capture the PostCode
            AnCustomer.PostCode = PostCode;
            AnCustomer.DateRegistered = Convert.ToDateTime(DateRegistered);
            AnCustomer.PhoneNumber = PhoneNumber;
            AnCustomer.Email = Email;
            AnCustomer.FullName = FullName;
            AnCustomer.Password = Password;
            //store the Post Code in the session object
            Session["AnCustomer"] = AnCustomer;
            //Navigate to the view page
            Response.Redirect("CustomerManagementViewer.aspx");

        }
        else
        {
            //display the error message
            lblError.Text = Error;
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
            txtPassword.Text = AnCustomer.Password;
            chkIsActive.Checked = AnCustomer.IsActive;
            txtPostCode.Text = AnCustomer.PostCode;
            txtDateRegistered.Text = AnCustomer.DateRegistered.ToString();

        }
    }

    protected void btnOK_Click1(object sender, EventArgs e)
    {

    }
}