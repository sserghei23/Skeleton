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
      .  clsOrder AnOrder = new clsOrder();

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
        AnOrder.Completed = chkCompleted.Checked;

        //store the status in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to the view page
        Response.Redirect("OrderManagementViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the order class
        clsOrder AnOrder = new clsOrder();
        //create a variable to store the primary key
        Int32 OrderId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderId = Convert.ToInt32(txtOrderId.Text);
        //find the record
        Found = AnOrder.Find(OrderId);
        //if the record is found
        if (Found == true)
        {
            //clear any previous error message
            lblError.Text = string.Empty;
            //display the values of the properties in the form
            txtCustomerId.Text = AnOrder.CustomerId.ToString();
            txtStaffId.Text = AnOrder.StaffId.ToString();
            txtStatus.Text = AnOrder.Status;
            txtTotalAmount.Text = AnOrder.TotalAmount.ToString();
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
            chkCompleted.Checked = AnOrder.Completed;
        }
        //if the record is not found
        else
        {
            //display an error message
            lblError.Text = "Order ID not found!!";
        }
    }
}