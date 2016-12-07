using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// author: Johnny Romano
// date:   30-Nov-2016
// ver:    1.0
// name:   frmManageUsers.aspx.cs
// desc:   User management page
public partial class frmManageUsers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string path = HttpContext.Current.Request.Url.AbsolutePath;
        clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.accdb"), path);

        // SecurityLevel flag_controls
        if (Session["SecurityLevel"] != "A")
        {
            Response.Redirect("frmLogin.aspx");
        }
    }

    protected void btnAddUser_Click(object sender, EventArgs e)
    {
        if (clsDataLayer.SaveUser(Server.MapPath("PayrollSystem_DB.accdb"),
        txtUserName.Text, txtPassword.Text, ddlSecurityLevel.SelectedValue))
        {
            lblError.Text = "The user was successfully added!";
            grdUsers.DataBind();
        }
        else
        {
            lblError.Text = "The user was not added.";
        }
    }
}