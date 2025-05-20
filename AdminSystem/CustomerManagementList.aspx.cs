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
}