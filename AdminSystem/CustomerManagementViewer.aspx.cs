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
        AnCustomer.DateRegistered = Convert.ToDateTime(DateTime.Now);
        //Capture Active Check Box
        AnCustomer.IsActive = chkActive.Checked;

        //Displat the Postcode for this Entry
        Response.Write(AnCustomer.PostCode);
        Response.Write(AnCustomer.FullName);
        Response.Write(AnCustomer.CustomerId);
        Response.Write(AnCustomer.DateRegistered);
        Response.Write(AnCustomer.PhoneNumber);
        Response.Write(AnCustomer.Email);
        Response.Write(AnCustomer.Password);



    }
    
}