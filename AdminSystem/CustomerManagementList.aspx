<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerManagementList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Management</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>

    <style>
        body {
            background-color: #f8f9fa;
        }
        .form-container {
            position: relative;
            padding: 20px;
        }
        .form-control, .form-check {
            margin-bottom: 10px;
        }
        .list-container {
            max-height: 350px;
            overflow-y: auto;
        }
        .btn-custom {
            width: 100%;
        }
        .btn-position {
            position: relative;
            margin-top: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="container mt-5">
        <!-- Header Section -->
        <div class="container-fluid p-4 bg-primary text-white text-center">
            <h1><i class="bi bi-person-fill"></i> Customer Management</h1>
        </div>

        <div class="form-container">
            <!-- Customer List Box -->
            <div class="mb-3">
                <label for="lstCustomerList" class="form-label">Customer List</label>
                <asp:ListBox ID="lstCustomerList" runat="server" CssClass="form-control list-container"></asp:ListBox>
            </div>

            <!-- Buttons for Actions -->
            <div class="d-grid gap-2">
                <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" CssClass="btn btn-success btn-custom" Text="Add" />
                <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" CssClass="btn btn-warning btn-custom" Text="Edit" />
                <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" CssClass="btn btn-danger btn-custom" Text="Delete" />
            </div>

            <!-- Post Code Filter Section -->
            <div class="mb-3">
                <label for="TxtPostCode" class="form-label">Post Code</label>
                <asp:TextBox ID="TxtPostCode" runat="server" CssClass="form-control" />
            </div>

            <!-- Filter Buttons -->
            <div class="d-grid gap-2">
                <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" CssClass="btn btn-primary btn-custom" Text="Apply Filter" />
                <asp:Button ID="btnClearFilter" runat="server" CssClass="btn btn-secondary btn-custom" Text="Clear Filter" OnClick="btnClearFilter_Click1" />
            </div>

            <!-- Statistics Page & Main Menu Buttons -->
            <div class="d-flex justify-content-between mt-3">
                <asp:Button ID="btnStatisticsPage" runat="server" OnClick="btnStatisticsPage_Click" CssClass="btn btn-info" Text="Statistics Page" />
                <asp:Button ID="btnReturntoMM" runat="server" OnClick="btnReturntoMM_Click" CssClass="btn btn-link" Text="Return to Main Menu" />
            </div>

            <!-- Error Message Section -->
            <div class="mt-3">
                <asp:Label ID="lblError" runat="server" CssClass="text-danger" />
            </div>
        </div>
    </form>
</body>
</html>
