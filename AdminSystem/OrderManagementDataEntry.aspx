<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderManagementDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Management - Data Entry</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>

    <style>
        body {
            background-color: #f8f9fa;
        }
        .form-label {
            font-weight: 500;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="container py-5">
        <h2 class="mb-4 text-primary"><i class="bi bi-pencil-square"></i> Order Management</h2>

        <div class="row mb-3">
            <div class="col-md-6">
                <label for="txtOrderId" class="form-label">Order ID</label>
                <asp:TextBox ID="txtOrderId" runat="server" CssClass="form-control" />
            </div>
            <div class="col-md-6 d-flex align-items-end">
                <button id="btnFind" runat="server" class="btn btn-outline-success w-100" onserverclick="btnFind_Click">
                    <i class="bi bi-search me-2"></i>Find
                </button>
            </div>
        </div>

        <div class="row mb-3">
            <div class="col-md-6">
                <label for="txtCustomerId" class="form-label">Customer ID</label>
                <asp:TextBox ID="txtCustomerId" runat="server" CssClass="form-control" />
            </div>
            <div class="col-md-6">
                <label for="txtStaffId" class="form-label">Staff ID</label>
                <asp:TextBox ID="txtStaffId" runat="server" CssClass="form-control" />
            </div>
        </div>

        <div class="row mb-3">
            <div class="col-md-6">
                <label for="txtStatus" class="form-label">Status</label>
                <asp:TextBox ID="txtStatus" runat="server" CssClass="form-control" />
            </div>
            <div class="col-md-6">
                <label for="txtTotalAmount" class="form-label">Total Amount</label>
                <asp:TextBox ID="txtTotalAmount" runat="server" CssClass="form-control" />
            </div>
        </div>

        <div class="row mb-3">
            <div class="col-md-6">
                <label for="txtOrderDate" class="form-label">Order Date</label>
                <asp:TextBox ID="txtOrderDate" runat="server" CssClass="form-control" />
            </div>
            <div class="col-md-6 d-flex align-items-end">
                <div class="form-check">
                    <asp:CheckBox ID="chkCompleted" runat="server" CssClass="form-check-input" />
                    <label class="form-check-label" for="chkCompleted">Completed</label>
                </div>
            </div>
        </div>

        <div class="row mt-4">
            <div class="col-md-4">
                <button id="btnOk" runat="server" class="btn btn-primary w-100" onserverclick="btnOk_Click">
                    <i class="bi bi-check-circle me-2"></i>OK
                </button>
            </div>
            <div class="col-md-4">
                <button id="btnCancel" runat="server" class="btn btn-secondary w-100" onserverclick="btnCancel_Click">
                    <i class="bi bi-x-circle me-2"></i>Cancel
                </button>
            </div>
            <div class="col-md-4">
                <button id="btnReturn" runat="server" class="btn btn-outline-primary w-100" onserverclick="Button1_Click">
                     <i class="bi bi-box-arrow-left me-2"></i>Main Menu
                </button>
            </div>
        </div>

        <div class="mt-4">
            <asp:Label ID="lblError" runat="server" CssClass="text-danger" />
        </div>
    </form>
</body>
</html>
