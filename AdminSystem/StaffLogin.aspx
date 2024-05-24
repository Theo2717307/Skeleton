<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffLogin.aspx.cs" Inherits="StaffLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 119px; top: 158px; position: absolute; width: 70px" Text="UserName:"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 203px; top: 204px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblUserName0" runat="server" style="z-index: 1; left: 119px; top: 158px; position: absolute; width: 70px" Text="UserName:"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 204px; top: 158px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 120px; top: 203px; position: absolute" Text="Password:"></asp:Label>
        <p>
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 143px; top: 246px; position: absolute" Text="Login" />
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 210px; top: 245px; position: absolute" Text="Cancel" />
        <p>
            <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 415px; top: 195px; position: absolute"></asp:Label>
        </p>
    </form>
</body>
</html>
