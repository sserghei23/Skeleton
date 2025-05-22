using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            // Update the list box
            DisplayCheckouts();
        }
    }

    private void DisplayCheckouts()
    {
        clsCheckoutCollection Checkouts = new clsCheckoutCollection();
        lstCheckoutList.DataSource = Checkouts.CheckoutList;
        lstCheckoutList.DataValueField = "CartId";
        lstCheckoutList.DataTextField = "TotalCartValue";
        lstCheckoutList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {

    }
}