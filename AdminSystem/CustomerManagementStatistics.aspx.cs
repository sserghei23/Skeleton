using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class CustomerManagementStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer clsCustomer = new clsCustomer();

        //retrieve data from theDatabase
        DataTable dT = clsCustomer.StatisticsGroupedByFullName();

        //Retrieve dT into GridView
        GridViewStGroupByFullName.DataSource = dT;
        GridViewStGroupByFullName.DataBind();

        //change the header of the first column
        GridViewStGroupByFullName.HeaderRow.Cells[0].Text = "Total";

        //Retrieve the data from the database
        dT = clsCustomer.StatisticsGroupedDateRegistered();

        //Upload dT into gridView
        GridViewStGroupByDateRegistered.DataSource = dT;
        GridViewStGroupByDateRegistered.DataBind();

        //change the header of the first column
        GridViewStGroupByDateRegistered.HeaderRow.Cells[0].Text = "Total";
    }
}