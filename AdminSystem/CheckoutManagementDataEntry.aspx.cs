using System;
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

     void DisplayCheckout()
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
        //Capture Cartid
         string cartId = txtCartId.Text;
        //Capture Watchid
        string watchId = txtWatchId.Text;      
        //capture Customerid
        string customerId = txtCustomerId.Text;        
        //Capture DateAdded
        string dateAdded = txtDateAdded.Text;
        //Capture CheckedOut
        string checkedOut = txtCheckedOut.Text;
        //capture the TotalCartValue
        string totalCartValue = txtTotalCartValue.Text;
        // to store any error message
        string Error = "";
        //validate data
        Error = AnCheckout.Valid(cartId, watchId, customerId, totalCartValue, dateAdded);
        if (Error == "")
        {   
            AnCheckout.CartId = CartId;
            AnCheckout.CheckedOut = txtCheckedOut.Checked;
            AnCheckout.TotalCartValue = totalCartValue;
            AnCheckout.WatchId = Convert.ToInt32(watchId);
            AnCheckout.CustomerId = Convert.ToInt32(customerId);
            AnCheckout.DateAdded = Convert.ToDateTime(dateAdded);  
            //create an instance
            clsCheckoutCollection CheckoutList = new clsCheckoutCollection();           
         
            if (CartId == -1)
            {
                CheckoutList.ThisCheckout = AnCheckout;
                CheckoutList.Add();               
            }      
            
            else
            {
                CheckoutList.ThisCheckout.Find(CartId);
                CheckoutList.ThisCheckout = AnCheckout;
                CheckoutList.Update();               
            }

            // navigate to the viewer page
            Response.Redirect("CheckoutManagementList.aspx");
        }

            else
            {
            //write errorS
            lblError.Text = "There was a problem:" + Error;           
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



    protected void btnCancel0_Click(object sender, EventArgs e)
    {

    }
}