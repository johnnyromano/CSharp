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
public partial class frmMain : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // write url to log
        string path = HttpContext.Current.Request.Url.AbsolutePath;
        clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.accdb"), path);

        // SecurityLevel flag_controls
        if (Session["SecurityLevel"] == "A")
        {
            // link:SignOut
            linkbtnSignOut.Visible = true;
            // link:Calculator
            linkbtnCalculator.Visible = true;
            imgbtnCalculator.Visible = true;
            // link:ViewPersonnel
            linkbtnViewPersonnel.Visible = true;
            imgbtnViewPersonnel.Visible = true;
            // link:SearchEmployees
            linkbtnSearch.Visible = true;
            imgbtnSearch.Visible = true;
            // link:AddEmployee
            linkbtnNewEmployee.Visible = true;
            imgbtnNewEmployee.Visible = true;
            // link:ViewUserActivity
            linkbtnViewUserActivity.Visible = true;
            imgbtnViewUserActivity.Visible = true;
            // link:EditEmployees
            linkbtnEditEmployees.Visible = true;
            imgbtnEditEmployees.Visible = true;
            // link:ManageUsers
            linkbtnManageUsers.Visible = true;
            imgbtnManageUsers.Visible = true;
        }
        else
        {
            // link:SignOut
            linkbtnSignOut.Visible = true;
            // link:Calculator
            linkbtnCalculator.Visible = true;
            imgbtnCalculator.Visible = true;
            // link:ViewPersonnel
            linkbtnViewPersonnel.Visible = true;
            imgbtnViewPersonnel.Visible = true;
            // link:SearchEmployees
            linkbtnSearch.Visible = true;
            imgbtnSearch.Visible = true;
            // link:AddEmployee
            linkbtnNewEmployee.Visible = false;
            imgbtnNewEmployee.Visible = false;
            // link:ViewUserActivity
            linkbtnViewUserActivity.Visible = false;
            imgbtnViewUserActivity.Visible = false;
            // link:EditEmployees
            linkbtnEditEmployees.Visible = false;
            imgbtnEditEmployees.Visible = false;
            // link:ManageUsers
            linkbtnManageUsers.Visible = false;
            imgbtnManageUsers.Visible = false;
        }


    }
}