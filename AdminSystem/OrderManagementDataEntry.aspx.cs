using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order to be processed
        OrderId = Convert.ToInt32(Session["OrderId"]);
        if (IsPostBack == false)
        {
            if (OrderId != -1)
            {
                //display teh current data for the record
                DisplayOrder();
            }
        }
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the customer id
        string customerId = txtCustomerId.Text;
        //capture the staff id
        string staffId = txtStaffId.Text;
        //capture the order status
        string status = txtStatus.Text;
        //capture the total amount
        string totalAmount = txtTotalAmount.Text;
        //capture the order date
        string orderDate = txtOrderDate.Text;
        //capture the active status
        string completed = chkCompleted.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data on the web form
        Error = AnOrder.Valid(customerId, staffId, status, totalAmount, orderDate);
        if (Error == "")
        {
            //capture the order id
            AnOrder.OrderId = OrderId;
            //capture the customer id
            AnOrder.CustomerId = Convert.ToInt32(customerId);
            //capture the staff id
            AnOrder.StaffId = Convert.ToInt32(staffId);
            //capture the order status
            AnOrder.Status = status;
            //capture the total amount
            AnOrder.TotalAmount = Convert.ToDecimal(totalAmount);
            //capture the order date
            AnOrder.OrderDate = Convert.ToDateTime(orderDate);
            //capture the active status
            AnOrder.Completed = chkCompleted.Checked;    
            //create a new instance of the order collection
            clsOrderCollection OrderList = new clsOrderCollection();

            if(OrderId == -1)
            {
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //add the new record
                OrderList.Add();
            }

            else
            {
                //find the record to update
                OrderList.ThisOrder.Find(OrderId);
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //update the record
                OrderList.Update();
            }
                
            //navigate to the viewer page
            Response.Redirect("OrderManagementList.aspx");
        }

        else
        {
            //display the error message
            lblError.Text = "There was a problem: " + Error;
        }

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
            //empty the text boxes
            txtOrderId.Text = string.Empty;
            txtCustomerId.Text = string.Empty;
            txtCustomerId.Text = string.Empty;
            txtStaffId.Text = string.Empty;
            txtStatus.Text = string.Empty;
            txtTotalAmount.Text = string.Empty;
            txtOrderDate.Text = string.Empty;
            chkCompleted.Checked = false;
        }
    }
    void DisplayOrder()
    {
        //create an instance of the order
        clsOrderCollection Order = new clsOrderCollection();
        //find the record to update
        Order.ThisOrder.Find(OrderId);
        //display the customer id
        txtOrderId.Text = Order.ThisOrder.OrderId.ToString();
        txtCustomerId.Text = Order.ThisOrder.CustomerId.ToString();
        txtStaffId.Text = Order.ThisOrder.StaffId.ToString();
        txtStatus.Text = Order.ThisOrder.Status;
        txtTotalAmount.Text = Order.ThisOrder.TotalAmount.ToString();
        txtOrderDate.Text = Order.ThisOrder.OrderDate.ToString();
        chkCompleted.Checked = Order.ThisOrder.Completed;
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderManagementList.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}