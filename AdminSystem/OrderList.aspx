<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstOrderBox" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 414px; width: 414px"></asp:ListBox>
        <asp:Button ID="btnADD" runat="server" style="z-index: 1;" Text="ADD" OnClick="btnADD_Click" />
    </form>
</body>
</html>
