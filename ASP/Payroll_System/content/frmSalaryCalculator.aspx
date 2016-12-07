<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmSalaryCalculator.aspx.cs" Inherits="frmSalaryCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/CIS407A_iLab_ACITLogo.jpg" PostBackUrl="~/content/frmMain.aspx" />
        <br />
        <asp:Panel ID="Panel1" runat="server" DefaultButton="btnCalculateSalary">
            <asp:Label ID="lblAnnualHours" runat="server" Text="Annual Hours" Width="95px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtAnnualHours" runat="server" ToolTip="Annual Hours"></asp:TextBox>
            <br />
            <asp:Label ID="lblPayRate" runat="server" Text="Pay Rate" width="95px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtPayRate" runat="server" ToolTip="Hourly Pay Rate">$0.00</asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnCalculateSalary" runat="server" OnClick="btnCalculateSalary_Click" Text="Calculate Salary" />
            <br />
            <asp:Label ID="lblAnnualSalary" runat="server" Text="Annual Salary: $"></asp:Label>
        </asp:Panel>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
