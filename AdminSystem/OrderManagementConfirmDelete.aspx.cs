using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{

    //variable to store the primary key value of the record to be deleted
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order to be deleted from the session object
        OrderId = Convert.ToInt32(Session["OrderId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the order collection class
        clsOrderCollection Orders = new clsOrderCollection();
        //find the record to delete
        Orders.ThisOrder.Find(OrderId);
        //delete the record
        Orders.Delete();
        //redirect back to the order list page
        Response.Redirect("OrderManagementList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("OrderManagementList.aspx");
    }
}