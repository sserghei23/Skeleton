<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Menu</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>

    <style>
        body {
            background-color: #f8f9fa;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid p-5 bg-primary text-white text-center">
            <h1><i class="bi bi-house-fill me-2"></i>Web Watch Main Menu</h1>
        </div>
        <div class="container mt-5">
            <div class="row justify-content-center g-3">
                <div class="col-auto">
                    <button id="btnStaff" runat="server" class="btn btn-secondary px-4 py-2" onserverclick = "btnStaff_Click">
                        <i class="bi bi-people-fill me-2"></i>Staff
                    </button>
                </div>
                <div class="col-auto">
                    <button id="btnOrders" runat="server" class="btn btn-secondary px-4 py-2" onserverclick="btnOrders_Click">
                        <i class="bi bi-bag-fill me-2"></i>Orders
                    </button>
                </div>
                <div class="col-auto">
                    <button id="Button3" runat="server" class="btn btn-secondary px-4 py-2">
                        <i class="bi bi-box-seam me-2"></i>Inventory
                    </button>
                </div>
                <div class="col-auto">
                    <button id="Button4" runat="server" class="btn btn-secondary px-4 py-2">
                        <i class="bi bi-person-fill me-2"></i>Customer
                    </button>
                </div>
                <div class="col-auto">
                    <button id="Button5" runat="server" class="btn btn-secondary px-4 py-2" onserverclick="Button5_Click">
                        <i class="bi bi-cart-fill me-2"></i>Checkout
                    </button>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
