<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmPersonnel.aspx.cs" Inherits="Salary_Calculator_frmPersonnel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 163px">
    <form id="form1" runat="server">
    <div>
    
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/CIS407A_iLab_ACITLogo.jpg" PostBackUrl="~/Salary Calculator/frmMain.aspx" />
    
    </div>
        <asp:Panel ID="Panel1" runat="server">
            
            <asp:Label ID="lblFirstName" runat="server" Text="First Name:" width="80px"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server" ToolTip="i.e. James"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" ControlToValidate="txtFirstName" ErrorMessage="First Name" Font-Bold="True" ForeColor="Red" SetFocusOnError="True">!!!</asp:RequiredFieldValidator>
            <br />
            
            <asp:Label ID="lblLastName" runat="server" Text="Last Name:" width="80px"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server" ToolTip="i.e. Smith"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvLastName" runat="server" ControlToValidate="txtLastName" ErrorMessage="Last Name." SetFocusOnError="True" Font-Bold="True" ForeColor="Red">!!!</asp:RequiredFieldValidator>
            <br />
            
            <asp:Label ID="lblPayRate" runat="server" Text="Pay Rate:" width="80px"></asp:Label>
            <asp:TextBox ID="txtPayRate" runat="server" ToolTip="Hourly">0.00</asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvPayRate" runat="server" ControlToValidate="txtPayRate" ErrorMessage="Pay Rate." SetFocusOnError="True" Font-Bold="True" ForeColor="Red" InitialValue="$0.00">!!!</asp:RequiredFieldValidator>
            <br />
            
            <asp:Label ID="lblStartDate" runat="server" Text="Start Date:" width="80px"></asp:Label>
            <asp:TextBox ID="txtStartDate" runat="server" TextMode="Date" ToolTip="Start Date">2016-01-01</asp:TextBox>
            <asp:CompareValidator ID="cvStartDate" runat="server" ControlToCompare="txtEndDate" ControlToValidate="txtStartDate" ErrorMessage="Start Date." Font-Bold="True" ForeColor="Red" Operator="LessThan" SetFocusOnError="True" ValueToCompare="1">!!! Must be before End Date.</asp:CompareValidator>
            <br />
            
            <asp:Label ID="lblEndDate" runat="server" Text="End Date:" width="80px"></asp:Label>
            <asp:TextBox ID="txtEndDate" runat="server" TextMode="Date" ToolTip="End Date">2016-01-01</asp:TextBox>
            <asp:CompareValidator ID="cvEndDate" runat="server" ControlToCompare="txtStartDate" ControlToValidate="txtEndDate" ErrorMessage="End Date." Font-Bold="True" ForeColor="Red" Operator="GreaterThan" SetFocusOnError="True" ValueToCompare="0">!!! Must be after Start Date.</asp:CompareValidator>
            <br />
            
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <br />
            <br />      
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Please correct these entries" Font-Bold="True" ForeColor="Red" />

            <br />

        </asp:Panel>
    </form>
</body>
</html>
