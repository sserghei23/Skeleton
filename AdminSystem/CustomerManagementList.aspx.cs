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
        lstCustomerList.DataValueField = "CustomerId";
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


    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 CustomerId;
        if (lstCustomerList.SelectedIndex != -1)
        {
            //Get the Primary Key value of the record Delete
            CustomerId = Convert.ToInt32(lstCustomerList.SelectedValue);
            //Store the Data in the session object
            Session["CustomerId"] = CustomerId;
            //Redirect to the delete page
            Response.Redirect("CustomerManagementConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //Display an error message
            lblError.Text = "Please select a record from the list to delete";

        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        // Get the value from the PostCode textbox
        string postCode = TxtPostCode.Text.Trim();  // Remove leading/trailing spaces

        if (!string.IsNullOrEmpty(postCode))
        {
            // Create an instance of the customer collection
            clsCustomerCollection AnCustomer = new clsCustomerCollection();

            // Apply the filter by the PostCode, including partial matches
            AnCustomer.ReportByPostCode(postCode);

            // Set the data source to the filtered list of customers
            lstCustomerList.DataSource = AnCustomer.CustomerList;

            // Set the name of the primary key and the field to display
            lstCustomerList.DataValueField = "CustomerId";
            lstCustomerList.DataTextField = "PostCode";

            // Bind the filtered data to the list box
            lstCustomerList.DataBind();
        }
        else
        {
            // If no filter is applied, show an error message
            lblError.Text = "Please enter a PostCode to filter.";
        }
    }

    protected void btnStatisticsPage_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerManagementStatistics.aspx");
    }


    protected void btnReturntoMM_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnClearFilter_Click1(object sender, EventArgs e)
    {
        // Create an instance of the customer collection
        clsCustomerCollection AnCustomer = new clsCustomerCollection();

        // Clear the filter input
        TxtPostCode.Text = "";


        // Set the data source to the unfiltered list
        lstCustomerList.DataSource = AnCustomer.CustomerList;

        // Set the name of the primary key and the field to display
        lstCustomerList.DataValueField = "CustomerId";
        lstCustomerList.DataTextField = "PostCode";

        // Bind the data to the list
        lstCustomerList.DataBind();

        // Optionally, clear any error messages
        lblError.Text = "";
    }
}