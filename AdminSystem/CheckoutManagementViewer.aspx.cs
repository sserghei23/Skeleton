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
        //create an instance of cls Checkout
        clsCheckout AnCheckout = new clsCheckout();
        //Stores in session
        AnCheckout = (clsCheckout)Session["AnCheckout"]; 
        //Display the Total Cart Value 

        Response.Write(AnCheckout.TotalCartValue);
        Response.Write("<br />");
        Response.Write(AnCheckout.CartId);
        Response.Write("<br />");
        Response.Write(AnCheckout.CustomerId);
        Response.Write("<br />");
        Response.Write(AnCheckout.WatchId);
        Response.Write("<br />");
        Response.Write(AnCheckout.DateAdded);
        Response.Write("<br />");
        Response.Write("CheckedOut?: " + AnCheckout.CheckedOut);

    }
}