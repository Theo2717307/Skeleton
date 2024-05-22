<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 380px">
    <form id="Form1" runat="server">
    This is the Order Data Entry Page
        <div>
            <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; " Text="Order ID" width="107px"></asp:Label>
            <asp:TextBox ID="txtOrderId" runat="server" style="z-index: 1; "></asp:TextBox>
            &nbsp;<p></p>
        </div>
        <div>
            <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; " Text="Customer ID" width="107px"></asp:Label>
            <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; "></asp:TextBox>
            &nbsp;<p></p>
        </div>
        <div> 
            <asp:Label ID="order_timestampID" runat="server" style="z-index: 1; " Text="Order Timestamp"></asp:Label>
            <asp:TextBox ID="txtOrderTimestamp" runat="server" style="z-index: 1; "></asp:TextBox>
            &nbsp;<p></p>
        </div>
        <div>
            <asp:Label ID="lblOrderProcessed" runat="server" style="z-index: 1; " Text="Order Processed" width="107px"></asp:Label>
            <asp:CheckBox ID="chkOrderProcessed" runat="server" style="z-index: 1; " />
            &nbsp;<p></p>
        </div>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; "></asp:Label>
        </p>
        <asp:Button ID="btnFind" runat="server" style="z-index: 1; padding-inline: 25px; margin-inline: 2em;" Text="Find" OnClick="btnFind_Click" />
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; padding-inline: 25px; margin-inline: 2em;" Text="OK" OnClick="btnOK_Click1" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; padding-inline: 25px; margin-inline: 2em;" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
