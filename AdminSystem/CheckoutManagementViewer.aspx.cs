using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
   
    public object Cartid { get; private set; }
    public object Customerid { get; private set; }
    public object TotalCartValue { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        //create an instance of cls Checkout
        clsCheckout AnCheckout = new clsCheckout();
        //Stores in session
        AnCheckout = (clsCheckout)Session["AnCheckout"]; 
        //Display the Total Cart Value 
        Response.Write(AnCheckout.TotalCartValue);
        //Display
        Response.Write(AnCheckout.CartId);
        //Display
        Response.Write(AnCheckout.CustomerId);
        //Display
        Response.Write(AnCheckout.WatchId);
        //Display
        Response.Write(AnCheckout.DateAdded);
        //Display
        //Response.Write(AnCheckout.CheckedOut);
    }
}