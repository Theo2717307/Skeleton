﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStockList" runat="server" Height="272px" Width="272px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="Button1_Click" Text="Add" />
        </p>
        <p>
            <asp:Button ID="btnEdit" runat="server" Height="23px" OnClick="btnEdit_Click" Text="Edit" />
        </p>
        <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
    </form>
</body>
</html>
