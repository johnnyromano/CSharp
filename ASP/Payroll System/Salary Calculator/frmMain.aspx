<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmMain.aspx.cs" Inherits="Salary_Calculator_frmMain" %>

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
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/calculator.jpg" PostBackUrl="~/Salary Calculator/frmSalaryCalculator.aspx" />
            &nbsp;<asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Salary Calculator/frmSalaryCalculator.aspx">Annual Salary Calculator</asp:LinkButton>
            <br />
            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/img/newemployee1.jpg" PostBackUrl="~/Salary Calculator/frmPersonnel.aspx" />
            &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/Salary Calculator/frmPersonnel.aspx">Add New Employee</asp:LinkButton>
            <br />
            <asp:ImageButton ID="ImageButton3" runat="server" Height="150px" ImageUrl="~/img/useractivity.jpg" Width="175px" />
            &nbsp;<asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/Salary Calculator/frmUserActivity.aspx">User Activity</asp:LinkButton>
            <br />
            <br />
            <asp:ImageButton ID="ImageButton5" runat="server" Height="150px" ImageUrl="~/img/employees.jpg" PostBackUrl="~/Salary Calculator/frmViewPersonnel.aspx" Width="175px" />
            &nbsp;<asp:LinkButton ID="lnkBtnViewPersonnel" runat="server" PostBackUrl="~/Salary Calculator/frmViewPersonnel.aspx">View Personnel</asp:LinkButton>
            <br />
            <asp:ImageButton ID="ImageButton6" runat="server" Height="150px" ImageUrl="~/img/search.jpg" PostBackUrl="~/Salary Calculator/frmSearchPersonnel.aspx" Width="175px" />
            &nbsp;<asp:LinkButton ID="lnkbtnSearch" runat="server" PostBackUrl="~/Salary Calculator/frmSearchPersonnel.aspx">Search Personnel</asp:LinkButton>
            <br />
            <asp:ImageButton ID="ImageButton7" runat="server" Height="150px" ImageUrl="~/img/editemployees.jpg" PostBackUrl="~/Salary Calculator/frmEditPersonnel.aspx" Width="175px" />
            &nbsp;<asp:LinkButton ID="lnkbtnEditPersonnel" runat="server" PostBackUrl="~/Salary Calculator/frmEditPersonnel.aspx">Edit Personnel</asp:LinkButton>
            <br />
        </asp:Panel>
    </form>
</body>
</html>
