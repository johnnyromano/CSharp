using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// author: Johnny Romano
// date:   25-Nov-2016
// ver:    1.0
// name:   frmViewPersonnel.aspx.cs
// desc:   Display all Employee information from dsPersonnel
public partial class frmEditPersonnel : System.Web.UI.Page
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


    }
}