using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Salary_Calculator_frmTestDataValidation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string path = HttpContext.Current.Request.Url.AbsolutePath;
        // Add your comments here
        clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.accdb"), path);
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if(Page.IsValid)
        {
            Session["txtFirstName"] = txtFirstName.Text;
            Session["txtLastName"] = txtLastName.Text;
            Session["txtPayRate"] = txtPayRate.Text;
            Session["txtStartDate"] = txtStartDate.Text;
            Session["txtEndDate"] = txtEndDate.Text;

            Response.Redirect("frmPersonnelVerified.aspx");

        }


    }
    
}