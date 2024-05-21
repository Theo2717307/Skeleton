<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstCustomerList" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 360px; width: 473px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAddId" runat="server" OnClick="btnAddId_Click" style="z-index: 1; left: 12px; top: 393px; position: absolute" Text="Add" />
    </form>
</body>
</html>
