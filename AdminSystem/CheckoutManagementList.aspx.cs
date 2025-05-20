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
        lstCheckoutList.DataValueField = "CustomerId";
        lstCheckoutList.DataTextField = "TotalCartValue";
        lstCheckoutList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["CartId"] = -1;
        Response.Redirect("CheckoutManagementDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 CartId;
        if (lstCheckoutList.SelectedIndex != -1)
        {
            CartId = Convert.ToInt32(lstCheckoutList.SelectedValue);
            Session["CartId"] = CartId;
            Response.Redirect("CheckoutManagementDataEntry.aspx");
        }
        else
        {
            lblError.Text = "please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 CartId;
        if (lstCheckoutList.SelectedIndex != -1)
        {
            CartId = Convert.ToInt32(lstCheckoutList.SelectedValue);
            Session["CartId"] = CartId;
            Response.Redirect("CheckoutManagementConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "please select a record from the list to delete";
        }

    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsCheckoutCollection AnCheckout = new clsCheckoutCollection();
        AnCheckout.ReportByTotalCartValue(txtFilter.Text);
        lstCheckoutList.DataSource = AnCheckout.CheckoutList;
        lstCheckoutList.DataValueField = "CartId";
        lstCheckoutList.DataTextField = "TotalCartValue";
        lstCheckoutList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsCheckoutCollection AnCheckout = new clsCheckoutCollection();
        AnCheckout.ReportByTotalCartValue("");
        txtFilter.Text = "";
        lstCheckoutList.DataSource = AnCheckout.CheckoutList;
        lstCheckoutList.DataValueField = "CartId";
        lstCheckoutList.DataTextField = "TotalCartValue";
        lstCheckoutList.DataBind();
    }


    protected void btnStatistics_Click(object sender, EventArgs e)
    {
        Response.Redirect("CheckoutManagementStatistics.aspx");
    }
}