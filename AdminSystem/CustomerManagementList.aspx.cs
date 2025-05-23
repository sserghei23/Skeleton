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
        if (IsPostBack == false)
        {
            //update the List Box
            DisplayCustomer();
        }
    }
    void DisplayCustomer()
    {
        //Create an instance of the address collection
        clsCustomerCollection Customer = new clsCustomerCollection();
        //set the data source to list of customer in the collection
        lstCustomerList.DataSource = Customer.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "CustomerNo";
        //set the data field to display
        lstCustomerList.DataTextField = "PostCode";
        //blind the data to the list
        lstCustomerList.DataBind();



    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 intp the session object to indicate this is a new record
        Session["CustomerId"] = -1;
        //redirect to the data entry page
        Response.Redirect("CustomerManagementDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 CustomerId;
        //if a record has beem slected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            CustomerId = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["CustomerId"] = CustomerId;
            //redirect to the edit page
            Response.Redirect("CustomerManagementDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to Edit";
        }
    }

}