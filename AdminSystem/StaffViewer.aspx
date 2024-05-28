​<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffViewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Viewer</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Enter Staff ID to View Details</h2>
            <asp:Label ID="lblStaffID" runat="server" Text="Staff ID: "></asp:Label>
            <asp:TextBox ID="txtStaffID" runat="server"></asp:TextBox>
            <asp:Button ID="btnViewStaff" runat="server" Text="View Staff" OnClick="btnViewStaff_Click" />
            <br /><br />
            <asp:Literal ID="ltlStaffDetails" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>