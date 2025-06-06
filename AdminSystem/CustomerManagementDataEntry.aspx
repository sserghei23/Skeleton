<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerManagementDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

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
    </style>
</head>
<body>
    <form id="form1" runat="server" class="container mt-5">
        <!-- Header Section -->
        <div class="container-fluid p-4 bg-primary text-white text-center">
            <h1><i class="bi bi-person-fill"></i> Customer Management</h1>
        </div>

        <div class="form-container">
            <!-- Customer ID -->
            <div class="mb-3">
                <label for="txtCustomerId" class="form-label">Customer ID</label>
                <asp:TextBox ID="txtCustomerId" runat="server" CssClass="form-control" />
            </div>

            <!-- Full Name -->
            <div class="mb-3">
                <label for="txtFullName" class="form-label">Full Name</label>
                <asp:TextBox ID="txtFullName" runat="server" CssClass="form-control" />
            </div>

            <!-- Email -->
            <div class="mb-3">
                <label for="txtEmail" class="form-label">Email</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" />
            </div>

            <!-- Phone Number -->
            <div class="mb-3">
                <label for="txtPhoneNumber" class="form-label">Phone Number</label>
                <asp:TextBox ID="txtPhoneNumber" runat="server" CssClass="form-control" />
            </div>

            <!-- Post Code -->
            <div class="mb-3">
                <label for="txtPostCode" class="form-label">Post Code</label>
                <asp:TextBox ID="txtPostCode" runat="server" CssClass="form-control" />
            </div>

            <!-- Date Registered -->
            <div class="mb-3">
                <label for="txtDateRegistered" class="form-label">Date Registered</label>
                <asp:TextBox ID="txtDateRegistered" runat="server" CssClass="form-control" />
            </div>

            <!-- Active Checkbox -->
            <div class="mb-3 form-check">
                <asp:CheckBox ID="chkIsActive" runat="server" Text="Active" class="form-check-input" />
            </div>

            <!-- Find Button -->
            <div class="mb-3">
                <asp:Button ID="btnFind" runat="server" CssClass="btn btn-primary w-100" OnClick="btnFind_Click" Text="Find" />
            </div>

            <!-- Error Message -->
            <div class="mb-3">
                <asp:Label ID="lblError" runat="server" CssClass="text-danger" />
            </div>

            <!-- OK Button -->
            <div class="mb-3">
                <asp:Button ID="btnOK" runat="server" CssClass="btn btn-secondary w-100" OnClick="btnOK_Click" Text="OK" />
            </div>

            <!-- Cancel Button -->
            <div class="mb-3">
                <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-secondary w-100" OnClick="btnCancel_Click" Text="Cancel" />
            </div>

           <!-- Back to Main Menu Button -->
<div class="mb-3">
    <asp:Button ID="btnReturntoMM" runat="server" CssClass="btn btn-link w-100" OnClick="btnReturntoMM_Click" Text="Back to Main Menu" />
</div>

        </div>
    </form>
</body>
</html>
