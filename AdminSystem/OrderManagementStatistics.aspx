<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderManagementStatistics.aspx.cs" Inherits="OrderManagementStatistics" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Management - Statistics</title>

    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>

    <style>
        body {
            background-color: #f8f9fa;
        }
        h1, h3 {
            text-align: center;
        }
        .table thead {
            background-color: #0d6efd;
            color: white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="container py-5">
        <h1 class="mb-5 text-primary"><i class="bi bi-bar-chart-line-fill me-2"></i>Order Management Statistics</h1>

        <div class="mb-5">
            <h3 class="mb-3">Order List - Grouped by Status</h3>
            <div class="table-responsive">
                <asp:GridView ID="GridViewStGroupByStatus" runat="server"
                    CssClass="table table-bordered table-striped text-center"
                    AutoGenerateColumns="true">
                </asp:GridView>
            </div>
        </div>

        <div class="mb-5">
            <h3 class="mb-3">Order List - Grouped by Order Date</h3>
            <div class="table-responsive">
                <asp:GridView ID="GridViewStGroupByOrderDate" runat="server"
                    CssClass="table table-bordered table-striped text-center"
                    AutoGenerateColumns="true">
                </asp:GridView>
            </div>
        </div>

        <div class="d-flex justify-content-center">
            <button id="btnGoBack" runat="server" class="btn btn-outline-primary px-4 py-2" onserverclick="btnGoBack_Click">
                <i class="bi bi-arrow-left me-2"></i>Back to Previous Page
            </button>
        </div>
    </form>
</body>
</html>
