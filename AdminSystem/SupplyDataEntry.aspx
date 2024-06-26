﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplyDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 378px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblSupplier_Name" runat="server" height="24px" style="z-index: 1; left: 16px; top: 75px; position: absolute" Text="Name:" width="73px"></asp:Label>
            <asp:TextBox ID="txtSupplier_Name" runat="server" height="17px" OnTextChanged="txtSupplier_Name_TextChanged" style="z-index: 1; top: 71px; position: absolute; width: 128px; left: 103px;"></asp:TextBox>
        </div>
        <asp:Label ID="lblSupplier_Phone_Number" runat="server" height="24px" style="z-index: 1; left: 15px; top: 113px; position: absolute" Text="Number:" width="73px"></asp:Label>
        <asp:TextBox ID="txtSupplier_Phone_Number" runat="server" height="17px" style="z-index: 1; left: 104px; top: 110px; position: absolute; width: 128px"></asp:TextBox>
        <asp:Label ID="Supplier_Id" runat="server" style="z-index: 1; left: 10px; top: 36px; position: absolute" Text="Supplier Id:"></asp:Label>
        <asp:TextBox ID="txtSupplier_Id" runat="server" height="17px" style="z-index: 1; left: 104px; top: 33px; position: absolute" width="128px"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtSupplier_Address" runat="server" style="z-index: 1; left: 104px; top: 145px; position: absolute; height: 17px" width="128px"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 280px; top: 8px; position: absolute; right: 1133px" Text="Find" Width="100px" OnClick="btnFind_Click1" />
        </p>
        <p>
            <asp:Label ID="lblSupplier_Address" runat="server" height="24px" style="z-index: 1; left: 16px; top: 148px; position: absolute; width: 73px" Text="Address:"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtSupplier_Email" runat="server" height="17px" style="z-index: 1; left: 104px; top: 183px; position: absolute; width: 128px"></asp:TextBox>
            <asp:TextBox ID="txtSupplier_Country" runat="server" style="z-index: 1; top: 220px; position: absolute; height: 17px; width: 128px; left: 104px; bottom: 227px"></asp:TextBox>
            <asp:Label ID="lblSupplier_Email" runat="server" height="24px" style="z-index: 1; top: 186px; position: absolute; bottom: 260px; left: 16px" Text="Email:" width="73px"></asp:Label>
        </p>
        <asp:Label ID="lblSupplier_Country" runat="server" height="24px" style="z-index: 1; left: 16px; position: absolute; top: 224px; width: 73px" Text="Country:"></asp:Label>
        <p>
            <asp:Label ID="lblSupplier_Export" runat="server" style="z-index: 1; left: 16px; top: 261px; position: absolute; height: 19px" Text="Export:"></asp:Label>
            <asp:Label ID="lblInformation" runat="server" Font-Bold="True" style="z-index: 1; left: 161px; top: 257px; position: absolute" Text="(If no export is needed, leave blank!)"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblInformation2" runat="server" Font-Bold="True" style="z-index: 1; left: 161px; top: 291px; position: absolute; margin-bottom: 2px" Text="(If no trade restrictions, leave blank!)"></asp:Label>
            <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 16px; top: 324px; position: absolute"></asp:Label>
            <asp:Button ID="btnOK" runat="server" height="26px" OnClick="btnOK_Click" style="z-index: 1; left: 14px; top: 377px; position: absolute; right: 1088px" Text="OK" width="60px" />
            <asp:Label ID="lblSupplier_Trade_Restrictions" runat="server" style="z-index: 1; left: 16px; top: 293px; position: absolute; height: 24px" Text="Restrictions:"></asp:Label>
            <asp:CheckBox ID="chkYes" runat="server" style="z-index: 1; top: 259px; position: absolute; left: 104px" Text="Yes" />
        </p>
        <asp:Button ID="btnCancel" runat="server" height="26px" style="z-index: 1; left: 89px; top: 376px; position: absolute;" Text="Cancel" Width="60px" />
        <p>
            <asp:CheckBox ID="chkYes2" runat="server" style="z-index: 1; left: 105px; position: absolute; top: 292px" Text="Yes" />
        </p>
    </form>
</body>
</html>
