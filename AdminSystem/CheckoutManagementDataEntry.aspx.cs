using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{

    Int32 CartId;
    protected void Page_Load(object sender, EventArgs e)
    {
        CartId = Convert.ToInt32(Session["CartId"]);
        if (IsPostBack == false)
        {
            if (CartId != -1)
            {
                DisplayCheckout();
            }
        }
    }

    private void DisplayCheckout()
    {
        clsCheckoutCollection CheckoutBook = new clsCheckoutCollection();
        CheckoutBook.ThisCheckout.Find(CartId);
        //
        txtCartId.Text = CheckoutBook.ThisCheckout.CartId.ToString();
        txtWatchId.Text = CheckoutBook.ThisCheckout.WatchId.ToString();
        txtCustomerId.Text = CheckoutBook.ThisCheckout.CustomerId.ToString();
        txtDateAdded.Text = CheckoutBook.ThisCheckout.DateAdded.ToString();
        txtTotalCartValue.Text = CheckoutBook.ThisCheckout.TotalCartValue;
        txtCheckedOut.Text = CheckoutBook.ThisCheckout.CheckedOut.ToString();
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create an instance of cls Checkout
        clsCheckout AnCheckout = new clsCheckout();        
        //capture the TotalCartValue
        string TotalCartValue = txtTotalCartValue.Text;
        //capture Customerid
        string CustomerId = txtCustomerId.Text;
        //Capture Cartid
       // string CartId = txtCartId.Text;
        //Capture DateAdded
        string DateAdded = txtDateAdded.Text;
        //Capture CheckedOut
        string CheckedOut = txtCheckedOut.Text;
        //Capture Watchid
        string WatchId = txtWatchId.Text;
        //
        string Error = "";
        //validate data
        Error = AnCheckout.Valid(TotalCartValue, DateAdded);
        if (Error == "")
        {                    
            AnCheckout.TotalCartValue = TotalCartValue;
            AnCheckout.DateAdded = Convert.ToDateTime(DateAdded);           
            Session["AnCheckout"] = AnCheckout;
            clsCheckoutCollection CheckoutList = new clsCheckoutCollection();           
            //
            if (Convert.ToInt32(CartId) == -1)
            {
                CheckoutList.ThisCheckout = AnCheckout;
                CheckoutList.Add();               
            }           
            else
            {
                CheckoutList.ThisCheckout.Find(Convert.ToInt32(CartId));
                CheckoutList.ThisCheckout = AnCheckout;
                CheckoutList.Update();
                //navigate to the viewer page 
            }

            Response.Redirect("CheckoutManagementViewer.aspx");
        }
            else
            {
            lblError.Text = "There was a problem:" + Error;
            //Response.Redirect("CheckoutManagementList.aspx");
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
            lblError.Text =string.Empty;
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
            txtCartId.Text = string.Empty;
            txtCustomerId.Text = string.Empty;
            txtWatchId.Text = string.Empty;
            txtTotalCartValue.Text = string.Empty;
            txtDateAdded.Text = string.Empty;
            txtCheckedOut.Checked = false;
        }
    
    }

    

    protected void ReturnToMM_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

   
}