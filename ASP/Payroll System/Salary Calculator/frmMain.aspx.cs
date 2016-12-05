using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// author: Johnny Romano
// date:   30-Nov-2016
// ver:    1.1
// name:   frmMain.aspx.cs
// desc:   Primary View for Payroll Tools
public partial class Salary_Calculator_frmMain : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // write url to log
        string path = HttpContext.Current.Request.Url.AbsolutePath;
        clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.accdb"), path);

        // SecurityLevel flag_controls
        if (Session["SecurityLevel"] == "A")
        {
            linkbtnSignOut.Visible = true;


            linkbtnCalculator.Visible = true;
            imgbtnCalculator.Visible = true;

            linkbtnViewPersonnel.Visible = true;
            imgbtnViewPersonnel.Visible = true;

            linkbtnSearch.Visible = true;
            imgbtnSearch.Visible = true;


            //
            linkbtnNewEmployee.Visible = true;
            imgbtnNewEmployee.Visible = true;

            linkbtnViewUserActivity.Visible = true;
            imgbtnViewUserActivity.Visible = true;

            linkbtnEditEmployees.Visible = true;
            imgbtnEditEmployees.Visible = true;

            linkbtnManageUsers.Visible = true;
            imgbtnManageUsers.Visible = true;

        }
        else
        {
            linkbtnSignOut.Visible = true;

            linkbtnCalculator.Visible = true;
            imgbtnCalculator.Visible = true;

            linkbtnViewPersonnel.Visible = true;
            imgbtnViewPersonnel.Visible = true;

            linkbtnSearch.Visible = true;
            imgbtnSearch.Visible = true;
            
            //
            linkbtnNewEmployee.Visible = false;
            imgbtnNewEmployee.Visible = false;

            linkbtnViewUserActivity.Visible = false;
            imgbtnViewUserActivity.Visible = false;

            linkbtnEditEmployees.Visible = false;
            imgbtnEditEmployees.Visible = false;

            linkbtnManageUsers.Visible = false;
            imgbtnManageUsers.Visible = false;

        }


    }
}