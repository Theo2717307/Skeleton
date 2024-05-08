<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 283px">
        </div>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 10px; top: 42px; position: absolute; bottom: 589px;" Text="Customer ID" width="105px"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 124px; top: 41px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 11px; top: 75px; position: absolute" Text="FirstName" width="105px"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 124px; top: 71px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 11px; top: 107px; position: absolute" Text="LastName" width="105px"></asp:Label>
        <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 11px; top: 138px; position: absolute" Text="Phone Number" width="105px"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 12px; top: 167px; position: absolute" Text="Email Address" width="105px"></asp:Label>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 11px; top: 196px; position: absolute" Text="Address" width="105px"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" OnTextChanged="TextBox3_TextChanged" style="z-index: 1; left: 124px; top: 104px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPhoneNumber" runat="server" style="z-index: 1; left: 124px; top: 134px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" OnTextChanged="TextBox5_TextChanged" style="z-index: 1; left: 124px; top: 161px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 124px; top: 193px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCreatePassword" runat="server" style="z-index: 1; left: 9px; top: 227px; position: absolute" Text="Create Password"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 124px; top: 226px; position: absolute"></asp:TextBox>
        <asp:Label ID="chkActive" runat="server" style="z-index: 1; left: 70px; top: 258px; position: absolute" Text="Active"></asp:Label>
        <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" style="z-index: 1; left: 124px; top: 256px; position: absolute" />
        <asp:Label ID="lblErrorId" runat="server" style="z-index: 1; left: 12px; top: 303px; position: absolute"></asp:Label>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 13px; top: 329px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 63px; top: 328px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
