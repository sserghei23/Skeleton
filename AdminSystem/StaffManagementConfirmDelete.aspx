<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffManagementConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href = "Content/bootstrap.min.css" rel = "stylesheet" />
    <script src = "Scripts/bootstrap.bundle.min.js"></script>
    <script src = "Scripts/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
    <style>
        body {
            background-color: rgb(225, 225, 225);
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 780.5px; top: 250px; position: absolute; font-weight: bold; font-size: larger;" CssClass ="mb-4 text-center text-warning" Text="Are you sure you want to delete record?"></asp:Label>
        
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 890.5px; top: 310px; position: absolute" CssClass = "btn btn-danger" Text="Yes" />

        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Style="z-index: 1; left: 970.5px; top: 310px; position: absolute" CssClass = "btn btn-primary" Text="No" />
    </form>
</body>
</html>
