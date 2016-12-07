<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmMain.aspx.cs" Inherits="frmMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" ImageUrl="~/img/CIS407A_iLab_ACITLogo.jpg" />
    
    </div>
        <asp:Panel ID="Panel1" runat="server" Height="100%" Width="500px">
            <asp:LinkButton ID="linkbtnSignOut" runat="server" PostBackUrl="~/content/frmLogin.aspx">Sign out</asp:LinkButton>
            <br />
            <asp:ImageButton ID="imgbtnCalculator" runat="server" ImageUrl="~/img/calculator.jpg" PostBackUrl="~/content/frmSalaryCalculator.aspx" />
            &nbsp;<asp:LinkButton ID="linkbtnCalculator" runat="server" PostBackUrl="~/content/frmSalaryCalculator.aspx">Annual Salary Calculator</asp:LinkButton>
            <br />
            <asp:ImageButton ID="imgbtnNewEmployee" runat="server" ImageUrl="~/img/newemployee1.jpg" PostBackUrl="~/content/frmPersonnel.aspx" />
            &nbsp;<asp:LinkButton ID="linkbtnNewEmployee" runat="server" PostBackUrl="~/content/frmPersonnel.aspx">Add New Employee</asp:LinkButton>
            <br />
            <asp:ImageButton ID="imgbtnViewUserActivity" runat="server" Height="150px" ImageUrl="~/img/useractivity.jpg" Width="175px" />
            &nbsp;<asp:LinkButton ID="linkbtnViewUserActivity" runat="server" PostBackUrl="~/content/frmUserActivity.aspx">User Activity</asp:LinkButton>
            <br />
            <br />
            <asp:ImageButton ID="imgbtnViewPersonnel" runat="server" Height="150px" ImageUrl="~/img/employees.jpg" PostBackUrl="~/content/frmViewPersonnel.aspx" Width="175px" />
            &nbsp;<asp:LinkButton ID="linkbtnViewPersonnel" runat="server" PostBackUrl="~/content/frmViewPersonnel.aspx">View Personnel</asp:LinkButton>
            <br />
            <asp:ImageButton ID="imgbtnSearch" runat="server" Height="150px" ImageUrl="~/img/search.jpg" PostBackUrl="~/content/frmSearchPersonnel.aspx" Width="175px" />
            &nbsp;<asp:LinkButton ID="linkbtnSearch" runat="server" PostBackUrl="~/content/frmSearchPersonnel.aspx">Search Personnel</asp:LinkButton>
            <br />
            <asp:ImageButton ID="imgbtnEditEmployees" runat="server" Height="150px" ImageUrl="~/img/editemployees.jpg" PostBackUrl="~/content/frmEditPersonnel.aspx" Width="175px" />
            &nbsp;<asp:LinkButton ID="linkbtnEditEmployees" runat="server" PostBackUrl="~/content/frmEditPersonnel.aspx">Edit Employees</asp:LinkButton>
            <br />
            <asp:ImageButton ID="imgbtnManageUsers" runat="server" Height="150px" ImageUrl="~/img/manageusers.jpg" PostBackUrl="~/content/frmManageUsers.aspx" Width="175px" />
            &nbsp;<asp:LinkButton ID="linkbtnManageUsers" runat="server" PostBackUrl="~/content/frmManageUsers.aspx">Manage Users</asp:LinkButton>
            <br />
        </asp:Panel>
    </form>
</body>
</html>
