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

    protected void btnOk_Click(object sender, EventArgs e)
    {
            //create an instance of cls Checkout
            clsCheckout AnCheckout = new clsCheckout();
        //capture the TotalCartValue
        AnCheckout.TotalCartValue = (txtTotalCartValue.Text);
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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCheckout AnCheckout = new clsCheckout();
        //Create test data to assign to the proprty
        Int32 CartId = 6;
        //Create a Boolean variable to store the results of the validation
        Boolean Found = false;
       //get primary key entered by user
       CartId = Convert.ToInt32(txtCartId.Text);    
        //Assign Data to the proprty
        Found = AnCheckout.Find(CartId);
        //check the date added property
        if (Found == true)
        {
            //display#
            txtCheckedOut.Checked = AnCheckout.CheckedOut;
            txtDateAdded.Text = AnCheckout.DateAdded.ToString();
            txtDateAdded.Text = AnCheckout.DateAdded.ToString();
            txtTotalCartValue.Text = AnCheckout.TotalCartValue;
            txtWatchId.Text = AnCheckout.WatchId.ToString();
            txtCustomerId.Text = AnCheckout.CustomerId.ToString();            
        }
    }
}