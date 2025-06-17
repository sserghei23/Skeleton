<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffManagementList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href = "Content/bootstrap.min.css" rel = "stylesheet" />
    <script src = "Scripts/bootstrap.bundle.min.js"></script>
    <script src = "Scripts/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css"/>
    <style>
        body {
            background-color: rgb(225, 225, 225);
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <!-- Staff ListBox -->
        <asp:ListBox ID="lstStaffList" runat="server" Height="400px" Width="400px" CssClass ="form-select mb-3"></asp:ListBox>

        <div class = "mt-3">
            <!-- Add Button -->
            <asp:Button ID="btnAdd" runat="server" style = "z-index : 1;  top: 434px; left: 10px; position: absolute;" Text="Add" OnClick="btnAdd_Click" class = "btn btn-secondary"/>

            <!-- Edit Button -->
            <asp:Button ID="btnEdit" runat="server" style ="z-index: 1; left: 63px; top: 434px; position: absolute; margin-left: 10px" Text="Edit" OnClick="btnEdit_Click"  class = "btn btn-secondary"/>

            <!-- Delete Button-->
            <asp:Button ID="btnDelete" runat="server" Style="z-index: 1; left: 111px; top: 434px; position: absolute; margin-left: 23px" Text="Delete" OnClick="btnDelete_Click" class = "btn btn-danger"/>
        </div>

        <!-- Error Label -->
        <asp:Label ID="lblError" runat="server" style = "z-index: 1; left: 18px; top: 608px; position: absolute" CssClass ="text-danger"></asp:Label>

        <!-- Filter Section -->
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 16px; top: 502px; position: absolute" Text="Enter Full Name:"></asp:Label>

        <asp:TextBox ID="txtFilter" runat="server" class = "form-control" placeholder = "Enter a name" style="z-index: 1; left: 137px; top: 496px; position: absolute" Width="140px"></asp:TextBox>

        <asp:Button ID="btnApplyFilter" runat="server" style="z-index: 1; left: 18px; top: 547px; position: absolute" Text="Apply Filter" OnClick="btnApplyFilter_Click" class = "btn btn-secondary"/>

        <asp:Button ID="btnClearFilter" runat="server" style="z-index: 1; left: 138px; top: 547px; position: absolute" Text="Clear Filter" OnClick="btnClearFilter_Click" class = "btn btn-secondary"/>

        <!-- Navigation Buttons -->
        <asp:Button ID="btnStatistics" runat="server" style="z-index: 1; left: 253px; top: 547px; position: absolute" Text="Statistics Page" OnClick="btnStatistics_Click" class = "btn btn-secondary"/>

        <asp:Button ID="btnMainMenu" runat="server" style="z-index: 1; left: 397px; top: 547px; position: absolute" Text="Return to Menu"  OnClick="btnMainMenu_Click" class = "btn btn-primary"/>

    </form>
</body>
</html>
