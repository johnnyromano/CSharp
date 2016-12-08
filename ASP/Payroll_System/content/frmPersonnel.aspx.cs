using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// author: Johnny Romano
// date:   30-Nov-2016
// ver:    1.2
// name:   frmPersonnel.aspx.cs
// desc:   Enter New Employee information
public partial class frmPersonnel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // SecurityLevel flag_controls
        if (Session["SecurityLevel"] == "A")
        {
            btnSubmit.Visible = true;
        }
        else
        {
            btnSubmit.Visible = false;
        }

        // write url to log
        string path = HttpContext.Current.Request.Url.AbsolutePath;
        clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.accdb"), path);
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {

       if (Page.IsValid)
       {
            Session["txtFirstName"] = txtFirstName.Text;
            Session["txtLastName"] = txtLastName.Text;
            Session["txtPayRate"] = txtPayRate.Text;
            Session["txtStartDate"] = txtStartDate.Text;
            Session["txtEndDate"] = txtEndDate.Text;

            Response.Redirect("frmPersonnelVerified.aspx", false);
            Context.ApplicationInstance.CompleteRequest();
        }
    }   
}