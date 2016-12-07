using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// author: Johnny Romano
// date:   25-Nov-2016
// ver:    1.0
// name:   frmPersonnelVerified.aspx.cs
// desc:   Display information from New Employee submitted from frmPersonnel.aspx

public partial class frmPersonnelVerified : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // write url to log
        string path = HttpContext.Current.Request.Url.AbsolutePath;
        clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.accdb"), path);

        // SecurityLevel flag_controls
        if (Session["SecurityLevel"] != "A")
        {
            Response.Redirect("frmLogin.aspx");
        }

        // Get the data from the previous form.

        String employee = Session["txtFirstName"].ToString() +
            "\n" + Session["txtLastName"].ToString() +
            "\n" + Session["txtPayRate"].ToString() +
            "\n" + Session["txtStartDate"].ToString() +
            "\n" + Session["txtEndDate"].ToString();

        txtVerifiedInfo.Text = employee;

        // Set employee out to data source
        // concat new line verified message
        if (clsDataLayer.SavePersonnel(Server.MapPath("PayrollSystem_DB.accdb"),
            Session["txtFirstName"].ToString(),
            Session["txtLastName"].ToString(),
            Session["txtPayRate"].ToString(),
            Session["txtStartDate"].ToString(),
            Session["txtEndDate"].ToString()))
        {
            txtVerifiedInfo.Text = txtVerifiedInfo.Text +
                "\nThe information was successfully saved!";
        }
        else
        {
            txtVerifiedInfo.Text = txtVerifiedInfo.Text +
                "\nThe information was NOT saved!";
        }
    }
}