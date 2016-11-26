<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmSearchPersonnel.aspx.cs" Inherits="Salary_Calculator_frmSearchPersonnel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/CIS407A_iLab_ACITLogo.jpg" PostBackUrl="~/Salary Calculator/frmMain.aspx" />
        <br />
        <asp:Panel ID="Panel1" runat="server">
            <asp:Label ID="lblSearch" runat="server" Text="Search for employee by last name:"></asp:Label>
            &nbsp;<asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnSearch" runat="server" PostBackUrl="~/Salary Calculator/frmViewPersonnel.aspx" Text="Search" />
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
