<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffManagementConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Are you sure you want to delete record?"></asp:Label>
      
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 10px; top: 125px; position: absolute" Text="Yes" />

        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Style="z-index: 1; left: 58px; top: 125px; position: absolute" Text="No" />
    </form>
</body>
</html>
