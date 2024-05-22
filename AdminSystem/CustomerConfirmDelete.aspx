<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 130px; top: 174px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnYesId" runat="server" height="26px" OnClick="btnYesId_Click" style="z-index: 1; left: 156px; top: 225px; position: absolute; width: 69px" Text="Yes" />
        </p>
        <asp:Button ID="btnNoId" runat="server" style="z-index: 1; left: 275px; top: 225px; position: absolute; width: 69px" Text="No" OnClick="btnNoId_Click" />
    </form>
</body>
</html>
