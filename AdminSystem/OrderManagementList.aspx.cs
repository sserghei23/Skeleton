using System;
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
        //if this is the first time the page is being displayed
        if (IsPostBack == false)
        {
            //update the list
            DisplayOrders();
        }
    }
        void DisplayOrders()
        {
            //create an instance of the order collection
            clsOrderCollection Orders = new clsOrderCollection();
            //set the data source to the list of orders in the collection
            lstOrderList.DataSource = Orders.OrderList;
            //set the name of the primary key
            lstOrderList.DataValueField = "OrderId";
            //set the data field to display
            lstOrderList.DataTextField = "Status";
            //bind the data to the list
            lstOrderList.DataBind();
        }
    

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 in the session object to indicate this is a new record
        Session["OrderId"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrderManagementDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 OrderId;
        //if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record to be edited
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderId"] = OrderId;
            //redirect to the data entry page
            Response.Redirect("OrderManagementDataEntry.aspx");
        }
        else
        {
            //display an error message
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 OrderId;
        //if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record to be deleted
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderId"] = OrderId;
            //redirect to the delete page
            Response.Redirect("OrderManagementConfirmDelete.aspx");
        }
        else
        {
            //display an error message
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the order collection
        clsOrderCollection AnOrder = new clsOrderCollection();
        //retreive the value of status from the presentation layer
        AnOrder.ReportByStatus(txtFilter.Text);
        //set the data source to the filtered list of orders in the collection
        lstOrderList.DataSource = AnOrder.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderId";
        //set the data field to display
        lstOrderList.DataTextField = "Status";
        //bind the data to the list
        lstOrderList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the order collection
        clsOrderCollection AnOrder = new clsOrderCollection();
        //set an empty string
        txtFilter.Text = "";
        //set the data source to the filtered list of orders in the collection
        lstOrderList.DataSource = AnOrder.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderId";
        //set the data field to display
        lstOrderList.DataTextField = "Status";
        //bind the data to the list
        lstOrderList.DataBind();
    }


    protected void btnStat_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderManagementStatistics.aspx");
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}