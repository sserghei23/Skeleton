using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Create a new Instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //Get the data from the session Object
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        //Capture the Date Added
       
        //Display the Postcode for this Entry
        Response.Write(AnCustomer.PostCode);
        //Display the Full Name for this Entry
        Response.Write(AnCustomer.FullName);
        //Display the Customer ID for this Entry
        Response.Write(AnCustomer.CustomerId);
        //Display the Date Registered for this Entry
        Response.Write(AnCustomer.DateRegistered);
        //Display the Phone Number for this Entry   
        Response.Write(AnCustomer.PhoneNumber);
        //Display the Email for this Entry
        Response.Write(AnCustomer.Email);
        //Display the Entry for this Entry
        //Response.Write(AnCustomer.Password);



    }


    protected void btnBack_Click(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = new clsCustomer();
        //store the order in the session object
        Session["Anustomer"] = AnCustomer;
        //navigate to the viewer page
        Response.Redirect("CustomerManagementDataEntry.aspx");
    }
}