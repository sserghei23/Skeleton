using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be deleted from the session object
        CustomerId = Convert.ToInt32(Session["CustomerId"]);

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //Create a new instance of the customerManagement Collection class
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to delete
        CustomerBook.ThisCustomer.Find(CustomerId);
        //delete the record
        CustomerBook.Delete();
        //redirect bacl to the main page
        Response.Redirect("CustomerManagementList.aspx");
    }


    protected void btnNo_Click(object sender, EventArgs e)
    {
        //Redirect back to the main Page
        Response.Redirect("CustomerManagementList.aspx");
    }
}