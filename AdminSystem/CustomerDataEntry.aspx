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
            <asp:Label ID="lblPostCode_Id" runat="server" height="19px" style="z-index: 1; left: 11px; top: 334px; position: absolute" Text="Post Code" width="105px"></asp:Label>
            <asp:TextBox ID="txtCustomer_PostCode" runat="server" height="22px" style="z-index: 1; left: 136px; top: 333px; position: absolute" width="128px"></asp:TextBox>
            <asp:Label ID="lblRegistrationId" runat="server" style="z-index: 1; left: 10px; top: 374px; position: absolute" Text="Registration Date"></asp:Label>
            <asp:TextBox ID="txtRegistration" runat="server" height="22px" style="z-index: 1; left: 136px; top: 372px; position: absolute" width="128px"></asp:TextBox>
        </div>
        <asp:Label ID="lblCustomer_Id" runat="server" style="z-index: 1; left: 9px; top: 43px; position: absolute" Text="Customer_Id" width="105px"></asp:Label>        <asp:TextBox ID="txtCustomer_Id" runat="server" style="z-index: 1; left: 141px; top: 38px; position: absolute; bottom: 584px; right: 1274px;" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 9px; top: 81px; position: absolute" Text="FirstName" width="105px" height="19px"></asp:Label>
        <asp:TextBox ID="txtCustomer_FirstName" runat="server" style="z-index: 1; left: 140px; top: 77px; position: absolute; right: 1275px;" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 11px; top: 122px; position: absolute" Text="LastName" width="105px" height="19px"></asp:Label>
        <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 11px; top: 166px; position: absolute" Text="Phone Number" width="105px" height="19px"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 10px; top: 209px; position: absolute" Text="Email Address" width="105px" height="19px"></asp:Label>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 11px; top: 295px; position: absolute" Text="Address" width="105px" height="19px"></asp:Label>
        <asp:TextBox ID="txtCustomer_LastName" runat="server" OnTextChanged="TextBox3_TextChanged" style="z-index: 1; left: 139px; top: 118px; position: absolute; right: 1276px;" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtCustomer_PhoneNumber" runat="server" style="z-index: 1; left: 138px; top: 161px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtCustomer_Email" runat="server" OnTextChanged="TextBox5_TextChanged" style="z-index: 1; left: 137px; top: 204px; position: absolute; right: 1278px;" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtCustomer_Password" runat="server" style="z-index: 1; left: 136px; top: 247px; position: absolute; bottom: 375px; right: 1279px;" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="lblCreatePassword" runat="server" style="z-index: 1; left: 9px; top: 251px; position: absolute" Text="Create Password" height="19px" width="105px"></asp:Label>
        <asp:TextBox ID="txtCustomer_Address" runat="server" style="z-index: 1; left: 136px; top: 290px; position: absolute; height: 22px;" width="128px"></asp:TextBox>
        <asp:Label ID="chkActive" runat="server" style="z-index: 1; left: 70px; top: 427px; position: absolute; right: 1028px;" Text="Active"></asp:Label>
        <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" style="z-index: 1; left: 118px; top: 425px; position: absolute; height: 21px; width: 109px;" />
        <asp:Label ID="lblErrorId" runat="server" style="z-index: 1; left: 12px; top: 453px; position: absolute"></asp:Label>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 13px; top: 493px; position: absolute; right: 1184px;" Text="OK" height="26px" width="60px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 91px; top: 492px; position: absolute; height: 28px; width: 64px" Text="Cancel" />
    </form>
</body></html>
