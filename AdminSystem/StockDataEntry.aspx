<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="product_id" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Product ID"></asp:Label>
        <p>
            <asp:TextBox ID="txtStockName" runat="server" style="z-index: 1; left: 100px; top: 90px; position: absolute"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtProductID" runat="server" style="z-index: 1; left: 97px; top: 31px; position: absolute; margin-bottom: 5px"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 11px; top: 92px; position: absolute; height: 21px" Text="Stock Name"></asp:Label>
        </p>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 10px; top: 143px; position: absolute; height: 22px" Text="Stock Details"></asp:Label>
        <asp:TextBox ID="txtStockDetails" runat="server" style="z-index: 1; left: 109px; top: 140px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 10px; top: 185px; position: absolute" Text="Quantity"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 86px; top: 183px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 13px; top: 229px; position: absolute" Text="Unit Price"></asp:Label>
        <asp:TextBox ID="txtUnitPrice" runat="server" style="z-index: 1; left: 91px; top: 227px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 10px; top: 272px; position: absolute" Text="Last Restock "></asp:Label>
        <asp:TextBox ID="txtLastRestock" runat="server" style="z-index: 1; left: 109px; top: 272px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 14px; top: 312px; position: absolute" Text="Discontinued"></asp:Label>
        <asp:TextBox ID="txtDiscontinued" runat="server" style="z-index: 1; left: 120px; top: 312px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
