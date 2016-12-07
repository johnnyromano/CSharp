﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmPersonnelVerified.aspx.cs" Inherits="frmPersonnelVerified" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/CIS407A_iLab_ACITLogo.jpg" PostBackUrl="~/content/frmMain.aspx" />
    
    </div>
        <asp:Panel ID="Panel1" runat="server" Height="250px" Width="650px">
            <asp:Label ID="lblInformationtoSubmit" runat="server" Text="Information to Submit"></asp:Label>
            &nbsp;<asp:TextBox ID="txtVerifiedInfo" runat="server" Height="80px" TextMode="MultiLine" Width="400px"></asp:TextBox>
            <br />
            <asp:Button ID="btnViewPersonnel" runat="server" PostBackUrl="~/content/frmViewPersonnel.aspx" Text="View Personnel" />
        </asp:Panel>
    </form>
</body>
</html>
