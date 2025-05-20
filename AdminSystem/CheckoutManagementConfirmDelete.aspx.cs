using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 CartId;
    protected void Page_Load(object sender, EventArgs e)
    {
        CartId = Convert.ToInt32(Session["CartId"]);
    }



    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsCheckoutCollection CheckoutBook = new clsCheckoutCollection();
        CheckoutBook.ThisCheckout.Find(CartId);
        //
        CheckoutBook.Delete();
        //
        Response.Redirect("CheckoutManagementList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("CheckoutManagementList.aspx");
    }
}