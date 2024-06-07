<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 380px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="vehicle_id" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Vehicle ID"></asp:Label>
            <asp:TextBox ID="txtVehicleID" runat="server" style="z-index: 1; left: 97px; top: 31px; position: absolute; margin-bottom: 5px"></asp:TextBox>
            
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 11px; top: 92px; position: absolute; height: 19px; bottom: 565px; width: 68px;" Text="Stock Name"></asp:Label>
            <asp:TextBox ID="txtStockName" runat="server" style="z-index: 1; left: 97px; top: 90px; position: absolute"></asp:TextBox>
            
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 10px; top: 143px; position: absolute; height: 19px; width: 68px;" Text="Stock Details"></asp:Label>
            <asp:TextBox ID="txtStockDetails" runat="server" style="z-index: 1; left: 97px; top: 140px; position: absolute"></asp:TextBox>
            
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 10px; top: 185px; position: absolute" Text="Quantity" height="19px" width="68px"></asp:Label>
            <asp:TextBox ID="txtquantity" runat="server" style="z-index: 1; left: 97px; top: 183px; position: absolute"></asp:TextBox>
            
            <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 12px; top: 232px; position: absolute" Text="Unit Price" height="19px" width="68px"></asp:Label>
            <asp:TextBox ID="txtunitprice" runat="server" style="z-index: 1; left: 97px; top: 227px; position: absolute"></asp:TextBox>
            
            <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 10px; top: 272px; position: absolute; width: 68px;" Text="Last Restock " height="19px"></asp:Label>
            <asp:TextBox ID="txtLastRestock" runat="server" style="z-index: 1; left: 97px; top: 272px; position: absolute"></asp:TextBox>
            
            <asp:CheckBox ID="chkDiscontinued" runat="server" style="z-index: 1; left: 123px; top: 310px; position: absolute" Text="Discontinued" />
            
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 340px; position: absolute"></asp:Label>
            
            <asp:Button ID="btnOk" runat="server" style="z-index: 1; left: 90px; top: 370px; position: absolute; margin-bottom: 3px" Text="OK" OnClick="btnOk_Click" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 286px; top: 370px; position: absolute; right: 1791px" Text="Cancel" margin-bottom="3px" />
        </div>
    </form>
</body>
</html>
