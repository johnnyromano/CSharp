using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// author: Johnny Romano
// date:   06-Nov-2016
// ver:    1.0
// name:   frmSalaryCalculator.aspx.cs
// desc:   Calculate Annual Salary based on Annual Hours and Rate

public partial class frmSalaryCalculator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // write url to log
        string path = HttpContext.Current.Request.Url.AbsolutePath;
        clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.accdb"), path);
    }

    protected void btnCalculateSalary_Click(object sender, EventArgs e)
    {

        Double hours = 0;
        Double rate = 0;
        Double salary = 0;

        hours = Double.Parse(txtAnnualHours.Text);
        rate = Double.Parse(txtPayRate.Text);
        salary = hours * rate;

        lblAnnualSalary.Text = "Annual Salary: " + salary.ToString("C");


    }
}