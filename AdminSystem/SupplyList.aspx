﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplyList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <div>
           <asp:ListBox ID="lstSupplierList" runat="server" Style="z-index: 1; left: 10px; top: 54px; position: absolute; height: 360px; width: 473px" OnSelectedIndexChanged="lstSupplierList_SelectedIndexChanged1"></asp:ListBox>
    </div>
    </form>
</body>
</html>
