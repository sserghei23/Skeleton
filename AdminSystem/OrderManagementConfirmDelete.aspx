<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderManagementConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirm Delete</title>
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
    <form id="form1" runat="server" class="container py-5 d-flex flex-column align-items-center">
        <h2 class="mb-4 text-danger"><i class="bi bi-exclamation-triangle-fill me-2"></i>Confirm Deletion</h2>

        <div class="mb-4">
            <asp:Label ID="lblConfirmation" runat="server" Text="Are you sure you want to delete this record?" CssClass="h5 text-center text-dark fw-semibold" />
        </div>

        <div class="row w-100 justify-content-center">
            <div class="col-4 col-md-2">
                <button id="btnYes" runat="server" class="btn btn-danger w-100" onserverclick="btnYes_Click">
                    <i class="bi bi-check-circle me-2"></i>Yes
                </button>
            </div>
            <div class="col-4 col-md-2">
                <button id="btnNo" runat="server" class="btn btn-secondary w-100" onserverclick="btnNo_Click">
                    <i class="bi bi-x-circle me-2"></i>No
                </button>
            </div>
        </div>
    </form>
</body>
</html>
