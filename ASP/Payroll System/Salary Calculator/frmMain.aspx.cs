using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// author: Johnny Romano
// date:   06-Nov-2016
// ver:    1.0
// name:   frmMain.aspx.cs
// desc:   Primary View for Accounting Tools
public partial class Salary_Calculator_frmMain : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // write url to log
        string path = HttpContext.Current.Request.Url.AbsolutePath;
        clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.accdb"), path);
    }
}