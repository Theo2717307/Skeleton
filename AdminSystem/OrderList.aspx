﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrderBox" runat="server" style="z-index: 1; position: initial; height: 414px; width: 414px; right: 1065px;"></asp:ListBox>
        </div>
        <div>
            <asp:Button ID="btnADD" runat="server" style="z-index: 1; padding-inline: 25px; margin-inline: 2em;" Text="ADD" OnClick="btnADD_Click" />
            <asp:Button ID="btnEDIT" runat="server" style="z-index: 1; padding-inline: 25px; margin-inline: 2em;" Text="EDIT" OnClick="btnEDIT_Click" />
            <asp:Button ID="btnDELETE" runat="server" style="z-index: 1; padding-inline: 25px; margin-inline: 2em;" Text="DELETE" OnClick="btnDELETE_Click" />
        </div>
        <div>
            <asp:Label ID="lblError" runat="server" style="z-index: 1;"></asp:Label>
        </div>
        <div>
            <asp:Label ID="FromDate" runat="server" Text="From: "></asp:Label>
            <asp:Button ID="btnFrom" runat="server" Text="select a date" OnClick="btnFrom_Click"></asp:Button>
            <asp:Calendar ID="CalendarFrom" runat="server" Visible="False" OnSelectionChanged="selection_changedFrom" ></asp:Calendar>

            <asp:Label ID="ToDate" runat="server" Text="To: "></asp:Label>
            <asp:Button ID="btnTo" runat="server" Text="select a date" OnClick="btnTo_Click"></asp:Button>
            <asp:Calendar ID="CalendarTo" runat="server" Visible="False" OnSelectionChanged="selection_changedTo"></asp:Calendar>
        </div>

    </form>
</body>
</html>
