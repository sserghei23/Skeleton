using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCheckout clsCheckout = new clsCheckout();
        DataTable dT = clsCheckout.StatisticsGroupedByTotalCartValue();
        //
        GridViewStGroupByTotalCartValue.DataSource = dT;
        GridViewStGroupByTotalCartValue.DataBind();

        GridViewStGroupByTotalCartValue.HeaderRow.Cells[0].Text = " Total ";


        dT = clsCheckout.StatisticsGroupedByDateAdded();

        GridViewStGroupByDateAdded.DataSource = dT;
        GridViewStGroupByDateAdded.DataBind();

        GridViewStGroupByDateAdded.HeaderRow.Cells[0].Text = " Total ";
    }


    protected void btnBTPP_Click(object sender, EventArgs e)
    {
        Response.Redirect("CheckoutManagementList.aspx");
    }



    protected void GridViewStGroupByTotalCartValue_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void GridViewStGroupByDateAdded_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}