<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmTestDataValidation.aspx.cs" Inherits="Salary_Calculator_frmTestDataValidation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server">
            <asp:Label ID="lblFirstName" runat="server" Text="First Name:" width="80px"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server" ToolTip="i.e. James"></asp:TextBox>

            <asp:CustomValidator ID="cvFirstName" runat="server" ControlToValidate="txtFirstName" ErrorMessage="!!! Letters only" Font-Bold="True" ForeColor="Red" SetFocusOnError="True"></asp:CustomValidator>
            <br />
            <asp:Label ID="lblLastName" runat="server" Text="Last Name:" width="80px"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server" ToolTip="i.e. Smith"></asp:TextBox>

            <asp:RequiredFieldValidator ID="rfvLastName" runat="server" ControlToValidate="txtLastName" ErrorMessage="Last name is required!" Font-Bold="True" ForeColor="Red" SetFocusOnError="True">!!!</asp:RequiredFieldValidator>

            <br />
            <asp:Label ID="lblPayRate" runat="server" Text="Pay Rate:" width="80px"></asp:Label>
            <asp:TextBox ID="txtPayRate" runat="server" ToolTip="Hourly">$0.00</asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvPayRate" runat="server" ControlToValidate="txtPayRate" ErrorMessage="Pay rate is required!" SetFocusOnError="True" Font-Bold="True" ForeColor="Red" InitialValue="$0.00">!!!</asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblStartDate" runat="server" Text="Start Date:" width="80px"></asp:Label>
            <asp:TextBox ID="txtStartDate" runat="server" TextMode="Date" ToolTip="Start Date">01-Jan-2016</asp:TextBox>
            <asp:CompareValidator ID="cvStartDate" runat="server" ControlToCompare="txtEndDate" ControlToValidate="txtStartDate" ErrorMessage="Start date required!" Font-Bold="True" ForeColor="Red" Operator="LessThan" SetFocusOnError="True" ValueToCompare=" ">!!!</asp:CompareValidator>
            <br />
            <asp:Label ID="lblEndDate" runat="server" Text="End Date:" width="80px"></asp:Label>
            <asp:TextBox ID="txtEndDate" runat="server" TextMode="Date" ToolTip="End Date">01-Jan-2016</asp:TextBox>
            <asp:CompareValidator ID="cvEndDate" runat="server" ControlToCompare="txtStartDate" ControlToValidate="txtEndDate" ErrorMessage="End date after start date required!" Font-Bold="True" ForeColor="Red" Operator="GreaterThan" SetFocusOnError="True">!!!</asp:CompareValidator>
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" PostBackUrl="~/Salary Calculator/frmMain.aspx" />
            <br />
            <br />
            
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Please correct these entries" Font-Bold="True" ForeColor="Red" />

        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
