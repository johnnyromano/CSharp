<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmManageUsers.aspx.cs" Inherits="Salary_Calculator_frmManageUsers" %>

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
        <asp:Label ID="lblManageUsers" runat="server" Text="Manage Users"></asp:Label>
        <br />
        <asp:Label ID="lblUserName" runat="server" Text="User Name"></asp:Label>
&nbsp;<asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
&nbsp;<asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblSecurityLevel" runat="server" Text="Security Level"></asp:Label>
&nbsp;
        <asp:DropDownList ID="ddlSecurityLevel" runat="server">
            <asp:ListItem>A</asp:ListItem>
            <asp:ListItem>U</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="btnAddUser" runat="server" OnClick="btnAddUser_Click" Text="Add User" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblCurrentUsers" runat="server" Text="Current Users"></asp:Label>
        <asp:GridView ID="grdUsers" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="UserID" HeaderText="UserID" InsertVisible="False" SortExpression="UserID" />
                <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName" />
                <asp:BoundField DataField="UserPassword" HeaderText="UserPassword" SortExpression="UserPassword" />
                <asp:BoundField DataField="SecurityLevel" HeaderText="SecurityLevel" SortExpression="SecurityLevel" />
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [tblUserLogin] WHERE [UserID] = ?" InsertCommand="INSERT INTO [tblUserLogin] ([UserID], [UserName], [UserPassword], [SecurityLevel]) VALUES (?, ?, ?, ?)" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [tblUserLogin]" UpdateCommand="UPDATE [tblUserLogin] SET [UserName] = ?, [UserPassword] = ?, [SecurityLevel] = ? WHERE [UserID] = ?">
            <DeleteParameters>
                <asp:Parameter Name="UserID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="UserID" Type="Int32" />
                <asp:Parameter Name="UserName" Type="String" />
                <asp:Parameter Name="UserPassword" Type="String" />
                <asp:Parameter Name="SecurityLevel" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="UserName" Type="String" />
                <asp:Parameter Name="UserPassword" Type="String" />
                <asp:Parameter Name="SecurityLevel" Type="String" />
                <asp:Parameter Name="UserID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
