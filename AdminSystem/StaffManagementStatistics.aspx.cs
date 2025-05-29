using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
using System.Data;


public partial class StaffManagementStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff Staff = new clsStaff();

        //retrieve the data from the database grouped by FullName
        DataTable dTable = Staff.StatisticsGroupedByFullName();

        //upload dt into the GridView
        GridViewStGroupByFullName.DataSource = dTable;
        GridViewStGroupByFullName.DataBind();

        //change the header of the first column
        GridViewStGroupByFullName.HeaderRow.Cells[0].Text = " Total ";

        //retrieve data from the database grouped by Date of Employment
        dTable = Staff.StatisticsGroupedByDateOfEmployment();

        //upload dt into the GridView to include date of employment
        GridViewStGroupByDateOfEmployment.DataSource = dTable;
        GridViewStGroupByDateOfEmployment.DataBind();

        //change the header of the first column
        GridViewStGroupByDateOfEmployment.HeaderRow.Cells[0].Text = " Total ";
    }

    protected void GridViewStGroupByFullName_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffManagementList.aspx");
    }
}