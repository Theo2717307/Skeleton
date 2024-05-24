<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
    </style>
</head>
<body style="height: 401px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStaff_ID" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Staff ID" width="48px"></asp:Label>
            <asp:TextBox ID="txtStaff_ID" runat="server" height="22px" style="z-index: 1; left: 115px; top: 13px; position: absolute" width="128px"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 297px; top: 28px; position: absolute" Text="Find" />
            <p class="auto-style1" style="height: 33px; margin-top: 0px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; STAFF DATA ENTRY PAGE</p>
        </div>
        <p>
            <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 10px; top: 53px; position: absolute; width: 92px;" Text="First Name"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server" height="22px" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 115px; top: 50px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 10px; top: 91px; position: absolute; width: 75px;" Text="Last Name"></asp:Label>
        </p>
        <asp:TextBox ID="txtLastName" runat="server" height="22px" style="z-index: 1; left: 115px; top: 89px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblPosition" runat="server" style="z-index: 1; left: 9px; top: 130px; position: absolute" Text="Position" width="48px"></asp:Label>
        <asp:TextBox ID="txtPosition" runat="server" height="22px" style="z-index: 1; left: 115px; top: 127px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblDepartment" runat="server" style="z-index: 1; left: 12px; top: 170px; position: absolute" Text="Department" width="48px"></asp:Label>
        <asp:TextBox ID="txtDepartment" runat="server" height="22px" style="z-index: 1; left: 115px; top: 168px; position: absolute" width="128px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblStartDate" runat="server" style="z-index: 1; left: 10px; top: 220px; position: absolute" Text="Start Date" width="48px"></asp:Label>
        <asp:TextBox ID="txtStartDate" runat="server" height="22px" style="z-index: 1; left: 115px; top: 217px; position: absolute" width="128px"></asp:TextBox>
        <asp:CheckBox ID="chkIsManager" runat="server" height="22px" style="z-index: 1; left: 123px; top: 264px; position: absolute" Text="Manager?" width="128px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 309px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 66px; top: 332px; position: absolute" Text="OK" width="128px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 257px; top: 331px; position: absolute; right: 239px" Text="Cancel" width="128px" />
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
