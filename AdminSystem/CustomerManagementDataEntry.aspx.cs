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

    protected void bttnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //Capture the Postcode
        AnCustomer.PostCode = txtPostCode.Text;
        //store the Post Code in the session object
        Session["AnCustomer"] = AnCustomer;
        //Navigate to the view page
        Response.Redirect("CustomerManagementViewer.aspx");

    }
}