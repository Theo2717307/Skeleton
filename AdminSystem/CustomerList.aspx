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
        <asp:Button ID="btnAddId" runat="server" OnClick="btnAddId_Click" style="z-index: 1; left: 12px; top: 393px; position: absolute" Text="Add" height="26px" width="55px" />
        <asp:Button ID="btnEditId" runat="server" OnClick="btnEditId_Click" style="z-index: 1; left: 76px; top: 393px; position: absolute" Text="Edit" height="26px" width="55px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 17px; top: 577px; position: absolute; right: 835px;"></asp:Label>
        <asp:Button ID="btnDeleteId" runat="server" OnClick="btnDeleteId_Click" style="z-index: 1; left: 145px; top: 392px; position: absolute" Text="Delete" height="26px" Width="55px"/>
        <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 17px; top: 457px; position: absolute" Text="Enter a Post Code"></asp:Label>
        <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 142px; top: 450px; position: absolute; height: 24px"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 16px; top: 505px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 136px; top: 506px; position: absolute" Text="Clear Filter" />
    </form>
</body>
</html>
