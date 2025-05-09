using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //creates a new instance of clsStaff
        clsStaff AStaff = new clsStaff();

        //gets the data from the session object
        AStaff = (clsStaff)Session["AStaff"];

        //display what was inputed into the text fields for this entry
        Response.Write(AStaff.StaffID);
        Response.Write("<br>");

        Response.Write(AStaff.OrderID);
        Response.Write("<br>");

        Response.Write(AStaff.FullName);
        Response.Write("<br>");

        Response.Write(AStaff.Password);
        Response.Write("<br>");

        Response.Write(AStaff.Email);
        Response.Write("<br>");

        Response.Write(AStaff.DateOfEmployment);
        Response.Write("<br>");

        Response.Write(AStaff.IsWorking);
        Response.Write("<br>");

    }
}