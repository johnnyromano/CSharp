using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// author: Johnny Romano
// date:   30-Nov-2016
// ver:    1.0
// name:   frmLogin.aspx.cs
// desc:   Login page
public partial class Salary_Calculator_frmLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // write url to log
        string path = HttpContext.Current.Request.Url.AbsolutePath;
        clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.accdb"), path);
    }

    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        
        dsUser dsUserLogin = clsDataLayer.VerifyUser(Server.MapPath("PayrollSystem_DB.accdb"),
        Login1.UserName, Login1.Password);
        
        string SecurityLevel;
        
        // if user not valid
        if (dsUserLogin.tblUserLogin.Count < 1)
        {
            e.Authenticated = false;
            return;
        }
        
        SecurityLevel = dsUserLogin.tblUserLogin[0].SecurityLevel.ToString();
        
        // set authenticate against user level
        switch (SecurityLevel)
        {
            case "A":
                e.Authenticated = true;
                Session["SecurityLevel"] = "A";
                break;
            case "U":
                e.Authenticated = true;
                Session["SecurityLevel"] = "U";
                break;
            default:
                e.Authenticated = false;
                break;
        }
    }
}