using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// author: Johnny Romano
// date:   30-Nov-2016
// ver:    1.0
// name:   frmUserActivity.aspx.cs
// desc:   Tracks what pages are being accessed
public partial class frmUserActivity : System.Web.UI.Page
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

        if (!Page.IsPostBack)
        {
            // Declares the DataSet
            dsUserActivity myDataSet = new dsUserActivity();
            
            // Fill the dataset with what is returned from the function
            myDataSet = clsDataLayer.GetUserActivity(Server.MapPath("PayrollSystem_DB.accdb"));
            
            // Sets the DataGrid to the DataSource based on the table
            grdUserActivity.DataSource = myDataSet.Tables["tblUserActivity"];
            
            // Binds the DataGrid
            grdUserActivity.DataBind();
        }
    }

}