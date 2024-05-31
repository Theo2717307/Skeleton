<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff List</title>
    <link rel="stylesheet" type="text/css" href="styles.css" />
    </style>
</head>
<body style="height: 380px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStaff_ID" runat="server" style="z-index: 1; left: 10px; top: 9px; position: absolute; width: 136px;" Text="Staff ID"></asp:Label>
            <asp:TextBox ID="txtStaff_ID" runat="server" height="22px" style="z-index: 1; left: 138px; top: 9px; position: absolute" width="128px"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 327px; top: 28px; position: absolute" Text="Find" />
            <p class="auto-style1" style="height: 33px; margin-top: 0px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; STAFF DATA ENTRY PAGE</p>
        </div>
        <p>
            <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 10px; top: 46px; position: absolute; width: 162px;" Text="First Name"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server" height="22px" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 138px; top: 46px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 10px; top: 89px; position: absolute; width: 153px;" Text="Last Name"></asp:Label>
        </p>
        <asp:TextBox ID="txtLastName" runat="server" height="22px" style="z-index: 1; left: 138px; top: 89px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblPosition" runat="server" style="z-index: 1; left: 10px; top: 130px; position: absolute; width: 124px; right: 2071px;" Text="Position"></asp:Label>
        <asp:TextBox ID="txtPosition" runat="server" height="22px" style="z-index: 1; left: 138px; top: 130px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblDepartment" runat="server" style="z-index: 1; left: 10px; top: 172px; position: absolute; width: 170px;" Text="Department"></asp:Label>
        <asp:TextBox ID="txtDepartment" runat="server" height="22px" style="z-index: 1; left: 138px; top: 172px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblStartDate" runat="server" style="z-index: 1; left: 10px; top: 220px; position: absolute; width: 162px;" Text="Start Date"></asp:Label>
        <asp:TextBox ID="txtStartDate" runat="server" height="22px" style="z-index: 1; left: 138px; top: 220px; position: absolute" width="128px"></asp:TextBox>
        <asp:CheckBox ID="chkIsManager" runat="server" height="22px" style="z-index: 1; left: 123px; top: 264px; position: absolute" Text="Manager?" width="128px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 309px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 90px; top: 332px; position: absolute" Text="OK" width="128px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 286px; top: 331px; position: absolute; right: 1791px" Text="Cancel" width="128px" />

        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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
            <asp:Button ID="btnReturn" runat="server" style="z-index: 1; padding-inline: 25px; margin-inline: 2em;" Text="Return to Main Menu" OnClick="btnReturn_Click" />

        </p>
    </form>
    </body>
</html>
