<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 398px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 522px">
            <asp:Button ID="btnFind" runat="server" height="26px" OnClick="btnFind_Click" style="z-index: 1; left: 353px; top: 39px; position: absolute" Text="Find" width="60px" />
        </div>
        <asp:Label ID="lblCustomer_Id" runat="server" style="z-index: 1; left: 9px; top: 43px; position: absolute" Text="Customer_Id" width="105px"></asp:Label>        <asp:TextBox ID="txtCustomer_Id" runat="server" style="z-index: 1; left: 135px; top: 38px; position: absolute; bottom: 358px; right: 1280px;" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 9px; top: 81px; position: absolute" Text="FirstName" width="105px"></asp:Label>
        <asp:TextBox ID="txtCustomer_FirstName" runat="server" style="z-index: 1; left: 134px; top: 77px; position: absolute; right: 867px;" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 11px; top: 122px; position: absolute" Text="LastName" width="105px"></asp:Label>
        <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 11px; top: 166px; position: absolute" Text="Phone Number" width="105px"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 10px; top: 209px; position: absolute" Text="Email Address" width="105px"></asp:Label>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 11px; top: 295px; position: absolute" Text="Address" width="105px"></asp:Label>
        <asp:TextBox ID="txtCustomer_LastName" runat="server" OnTextChanged="TextBox3_TextChanged" style="z-index: 1; left: 133px; top: 118px; position: absolute; right: 868px;" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtCustomer_PhoneNumber" runat="server" style="z-index: 1; left: 132px; top: 161px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtCustomer_Email" runat="server" OnTextChanged="TextBox5_TextChanged" style="z-index: 1; left: 131px; top: 204px; position: absolute; right: 870px;" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtCustomer_Password" runat="server" style="z-index: 1; left: 130px; top: 247px; position: absolute; bottom: 149px; right: 871px;" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="lblCreatePassword" runat="server" style="z-index: 1; left: 9px; top: 251px; position: absolute" Text="Create Password"></asp:Label>
        <asp:TextBox ID="txtCustomer_Address" runat="server" style="z-index: 1; left: 129px; top: 290px; position: absolute; height: 55px;" width="128px"></asp:TextBox>
        <asp:Label ID="chkActive" runat="server" style="z-index: 1; left: 70px; top: 386px; position: absolute; right: 1028px;" Text="Active"></asp:Label>
        <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" style="z-index: 1; left: 118px; top: 383px; position: absolute; height: 21px; width: 109px;" />
        <asp:Label ID="lblErrorId" runat="server" style="z-index: 1; left: 12px; top: 418px; position: absolute"></asp:Label>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 13px; top: 452px; position: absolute; right: 1064px;" Text="OK" height="26px" width="60px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 91px; top: 451px; position: absolute; height: 28px; width: 64px" Text="Cancel" />
    </form>
</body></html>
