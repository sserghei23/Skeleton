<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderManagementList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order List</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>

    <style>
        body {
            background-color: #f8f9fa;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container py-5">
            <h2 class="mb-4 text-primary"><i class="bi bi-list-ul me-2"></i>Order List</h2>

            <div class="mb-4">
                <asp:ListBox ID="lstOrderList" runat="server" CssClass="form-select" Height="261px" Width="100%" />
            </div>

            <div class="row mb-3 g-2">
                <div class="col-auto">
                    <button id="btnAdd" runat="server" class="btn btn-primary" onserverclick="btnAdd_Click">
                        <i class="bi bi-plus-circle me-2"></i>Add
                    </button>
                </div>
                <div class="col-auto">
                    <button id="btnEdit" runat="server" class="btn btn-primary" onserverclick="btnEdit_Click">
                        <i class="bi bi-pencil-square me-2"></i>Edit
                    </button>
                </div>
                <div class="col-auto">
                    <button id="btnDelete" runat="server" class="btn btn-danger" onserverclick="btnDelete_Click">
                        <i class="bi bi-trash me-2"></i>Delete
                    </button>
                </div>
            </div>

            <div class="row mb-4 align-items-end">
                <div class="col-auto">
                    <asp:Label ID="lblStatusBox" runat="server" Text="Enter a Status:" CssClass="form-label fw-medium" />
                </div>
                <div class="col-auto">
                    <asp:TextBox ID="txtFilter" runat="server" CssClass="form-control" />
                </div>
                <div class="col-auto">
                    <button id="btnApplyFilter" runat="server" class="btn btn-outline-success" onserverclick="btnApplyFilter_Click">
                        <i class="bi bi-filter-circle me-2"></i>Apply Filter
                    </button>
                </div>
                <div class="col-auto">
                    <button id="btnClearFilter" runat="server" class="btn btn-outline-secondary" onserverclick="btnClearFilter_Click">
                        <i class="bi bi-x-circle me-2"></i>Clear Filter
                    </button>
                </div>
            </div>

            <div class="row mb-3">
                <div class="col-auto">
                    <button id="btnStat" runat="server" class="btn btn-primary" onserverclick="btnStat_Click">
                        <i class="bi bi-bar-chart-line me-2"></i>Go to Statistics
                    </button>
                </div>
                <div class="col-auto">
                    <button id="btnReturn" runat="server" class="btn btn-primary" onserverclick="btnReturn_Click">
                        <i class="bi bi-box-arrow-left me-2"></i>Main Menu
                    </button>
                </div>
            </div>

            <div class="mt-3">
                <asp:Label ID="lblError" runat="server" CssClass="text-danger fw-bold" />
            </div>
        </div>
    </form>
</body>
</html>
