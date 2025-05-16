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
        string TotalCartValue = (txtTotalCartValue.Text);

        //capture Customerid
        string CustomerId = (txtCustomerId.Text);

        //Capture Cartid
        string CartId = (txtCartId.Text);

        //Capture DateAdded
        string DateAdded = txtDateAdded.Text;

        //Capture CheckedOut
        string CheckedOut = txtCheckedOut.Text;

        //Capture Watchid
        string WatchId = (txtWatchId.Text);

        //
        string Error = "";

        //validate data
        Error = AnCheckout.Valid(CartId, TotalCartValue, DateAdded, CustomerId, WatchId);
        if (Error == "")
        {
            AnCheckout.CartId = Convert.ToInt32(CartId);

            AnCheckout.TotalCartValue = TotalCartValue;

            AnCheckout.DateAdded = Convert.ToDateTime(DateAdded);

            AnCheckout.CustomerId = Convert.ToInt32(CustomerId);

            AnCheckout.WatchId = Convert.ToInt32(WatchId);

            AnCheckout.CheckedOut = Convert.ToBoolean(CheckedOut);

            //Stores in session
            Session["AnCheckout"] = AnCheckout;
            //navigate to the viewer page 
            Response.Redirect("CheckoutManagementViewer.aspx");
        }

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCheckout AnCheckout = new clsCheckout();
        //Create test data to assign to the proprty
        Int32 CartId;
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
            txtTotalCartValue.Text = AnCheckout.TotalCartValue;
            txtWatchId.Text = AnCheckout.WatchId.ToString();
            txtCustomerId.Text = AnCheckout.CustomerId.ToString();
        }
        else
        {
            lblError.Text = "Not Found";
        }
    
    }
}