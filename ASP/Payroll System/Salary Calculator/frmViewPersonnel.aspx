<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmViewPersonnel.aspx.cs" Inherits="Salary_Calculator_frmViewPersonnel" %>

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
            <asp:Label ID="lblPersonnel" runat="server" Text="View Personnel"></asp:Label>
            <asp:GridView ID="grdViewPersonnel" runat="server">
            </asp:GridView>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
