using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //get the data from the session object
        AnOrder = (clsOrder)Session["AnOrder"];
        //display the status for this entry
        
        Response.Write(AnOrder.OrderId);
        Response.Write("<br />");
        Response.Write(AnOrder.CustomerId);
        Response.Write("<br />");
        Response.Write(AnOrder.StaffId);
        Response.Write("<br />");
        Response.Write(AnOrder.Status);
        Response.Write("<br />");
        Response.Write(AnOrder.TotalAmount);
        Response.Write("<br />");
        Response.Write(AnOrder.OrderDate);
        Response.Write("<br />");
        Response.Write("Completed?: "+ AnOrder.Completed);
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        //store the order in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to the viewer page
        Response.Redirect("OrderManagementDataEntry.aspx");
    }
}