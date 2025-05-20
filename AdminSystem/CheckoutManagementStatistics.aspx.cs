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

        GridViewStGroupByDateAdded.DataSource = dT;
        GridViewStGroupByDateAdded.DataBind();

        GridViewStGroupByDateAdded.HeaderRow.Cells[0].Text = " Total ";

    }

    
}