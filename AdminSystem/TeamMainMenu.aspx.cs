using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("CheckoutManagementList.aspx");
    }

    protected void btnOrders_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderManagementList.aspx");
    }
}