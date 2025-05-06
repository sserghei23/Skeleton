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
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();

        //capture the order status
        AnOrder.Status = txtStatus.Text;

        //capture the order id
        AnOrder.OrderId = Convert.ToInt32(txtOrderId.Text);

        //capture the customer id
        AnOrder.CustomerId = Convert.ToInt32(txtCustomerId.Text);

        //capture the staff id
        AnOrder.StaffId = Convert.ToInt32(txtStaffId.Text);

        //capture the total amount
        AnOrder.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);

        //capture the order date
        AnOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);

        //capture the active status
        AnOrder.Active = chkCompleted.Checked;

        //store the status in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to the view page
        Response.Redirect("OrderManagementViewer.aspx");
    }
}