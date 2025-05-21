using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class OrderManagementStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder clsOrder = new clsOrder();

        //retrieve data from the database
        DataTable dT = clsOrder.StatisticsGroupedByStatus();

        //upload dT into GridView
        GridViewStGroupByStatus.DataSource = dT;
        GridViewStGroupByStatus.DataBind();

        //change the header of the first column
        GridViewStGroupByStatus.HeaderRow.Cells[0].Text = "Total";

        //retrieve data from the database
        dT = clsOrder.StatisticsGroupedByOrderDate();

        //upload dT into GridView
        GridViewStGroupByOrderDate.DataSource = dT;
        GridViewStGroupByOrderDate.DataBind();

        //change the header of the first column
        GridViewStGroupByOrderDate.HeaderRow.Cells[0].Text = "Total";


    }

    protected void btnGoBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderManagementList.aspx");
    }
}