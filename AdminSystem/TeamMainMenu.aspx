<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Sahil Motors Main Menu</h1>
            <p>This is the menu page for the Sahil Motors Project.</p>
        </div>
        <div>
            <h3>Menu:</h3>
            <div>
                <table>
                    <tr>
                        <td><asp:Button ID="btnCustomer" runat="server" style="z-index: 1;  " Text="Customers" OnClick="btnCustomer_Click"/></td>
                        <td><asp:Button ID="btnOrder"   runat="server" style="z-index: 1; " Text="Orders" OnClick="btnOrder_Click"/></td>
                        <td><asp:Button ID="btnStaff"   runat="server" style="z-index: 1; " Text="Staff" OnClick="btnStaff_Click"/></td>
                        <td><asp:Button ID="btnStock"   runat="server" style="z-index: 1;  " Text="Stock" OnClick="btnStock_Click"/></td>
                        <td><asp:Button ID="btnSupply"  runat="server" style="z-index: 1;  " Text="Supply" OnClick="btnSupply_Click"/></td>
                    </tr>
                </table>
            </div>
        </div>
    </form>
</body>
</html>
