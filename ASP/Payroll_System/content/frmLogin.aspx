<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmLogin.aspx.cs" Inherits="frmLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
        }
        .auto-style2 {
        }
    </style>
</head>
<body style="text-align: center">
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <div class="auto-style2">
            <br />
        </div>
        <div class="auto-style2">
        </div>

        <asp:Panel ID="Panel1" runat="server" style="text-align: center" Width="100%">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/img/CIS407A_iLab_ACITLogo.jpg" style="text-align: right" />
            <br />
            <div style="width: 500px; margin-left: auto; margin-right: auto;">
            <asp:Login ID="Login1" runat="server" DestinationPageUrl="~/content/frmMain.aspx" TitleText="Please enter your UserName and Password in order to log in to the system." style="text-align: center" OnAuthenticate="Login1_Authenticate">
                
                <LoginButtonStyle Width="50%" />
                
            </asp:Login>
            </div>
        </asp:Panel>
        <br />
    
    </div>
    </form>
</body>
</html>
