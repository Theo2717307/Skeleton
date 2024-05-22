<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                Are you sure you want to delete this record
            </p>
        </div>
        <div>
            <asp:Button ID="btnYES" runat="server" style="z-index: 1; padding-inline: 25px; margin-inline: 2em;" Text="OK" OnClick="btnYES_Click" />
            <asp:Button ID="btnNO" runat="server" style="z-index: 1; padding-inline: 25px; margin-inline: 2em;" Text="Cancel" OnClick="btnNO_Click" />
        </div>
    </form>
</body>
</html>
