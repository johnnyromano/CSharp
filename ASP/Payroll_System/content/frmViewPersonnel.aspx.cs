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
public partial class frmViewPersonnel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // write url to log
        string path = HttpContext.Current.Request.Url.AbsolutePath;
        clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.accdb"), path);


        if (!Page.IsPostBack)
        {
            // Declares the DataSet
            dsPersonnel myDataSet = new dsPersonnel();

            string strSearch = Request["txtSearch"];

            // Fill the dataset with what is returned from the function
            myDataSet = clsDataLayer.GetPersonnel(Server.MapPath("PayrollSystem_DB.accdb"), strSearch);

            // Sets the DataGrid to the DataSource based on the table
            grdViewPersonnel.DataSource = myDataSet.Tables["tblPersonnel"];

            // Binds the DataGrid
            grdViewPersonnel.DataBind();
        }
    }
}