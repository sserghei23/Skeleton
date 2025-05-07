using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    public object txtWatchId { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
            //create an instance of cls Checkout
            clsCheckout AnCheckout = new clsCheckout();
            //capture the TotalCartValue
            AnCheckout.TotalCartValue = txtTotalCartValue.Text;
            //capture Customerid
            AnCheckout.CustomerId = Convert.ToInt32(txtCustomerId.Text);
             //Capture Cartid
             AnCheckout.CartId = Convert.ToInt32(txtCartId.Text);
            //Capture DateAdded
            AnCheckout.DateAdded = Convert.ToDateTime(DateTime.Now);
            //Capture CheckedOut
            AnCheckout.CheckedOut = txtCheckedOut.Checked;
            //Capture Watchid
            AnCheckout.WatchId = Convert.ToInt32(txtWatchId.Text);
            //Stores in session
            Session["AnCheckout"] = AnCheckout;
            //navigate to the viewer page 
            Response.Redirect("CheckoutManagementViewer.aspx");
    }
}