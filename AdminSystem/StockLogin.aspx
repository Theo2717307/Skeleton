<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockLogin.aspx.cs" Inherits="_Default" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            stock log in
        </div>
        <div id="login-box" style="padding: 2em">
             <div id="login-fields">
                 <div id="username">
                    Username:
                    <asp:TextBox ID="text_username" runat="server" style="z-index: 1; margin-top:1em; margin-bottom:1em;"></asp:TextBox>
                 </div>
                 <div id="password">
                    Password:
                    <asp:TextBox ID="text_password" runat="server" style="z-index: 1; margin-top:1em; margin-bottom:1em;" TextMode="Password"></asp:TextBox>
                 </div>
            </div>
            <div id="login-errors">
                <asp:Label ID="lblError" runat="server" style="z-index: 1; "></asp:Label>
            </div>
            <div id="login-btns">
                <asp:Button ID="btnLogin" runat="server" style="z-index: 1; padding-inline: 25px; margin-inline: 2em;" Text="Login" OnClick="btnLogin_Click" />
                <asp:Button ID="btnCancel" runat="server" style="z-index: 1; padding-inline: 25px; margin-inline: 2em;" Text="Cancel" OnClick="btnCancel_Click" /> 
            </div>
        </div>
         
    </form>
</body>
</html>
