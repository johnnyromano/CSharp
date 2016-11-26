using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// author: Johnny Romano
// date:   25-Nov-2016
// ver:    1.0
// name:   frmSearchPersonnel.aspx.cs
// desc:   Display Employee query information from dsPersonnel
public partial class Salary_Calculator_frmSearchPersonnel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // write url to log
        string path = HttpContext.Current.Request.Url.AbsolutePath;
        clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.accdb"), path);

    }
}