<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderManagementConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="z-index: 1; left: 0px; top: 0px; position: absolute; height: 19px; width: 936px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblConfirmation" runat="server" style="z-index: 1; left: 52px; top: 44px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 201px; top: 90px; position: absolute; height: 32px; width: 67px" Text="No" />
        <p>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 87px; top: 90px; position: absolute; height: 32px; width: 67px; right: 782px" Text="Yes" />
        </p>
    </form>
</body>
</html>
