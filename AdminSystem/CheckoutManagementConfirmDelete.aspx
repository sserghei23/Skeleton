<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckoutManagementConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.6/dist/css/bootstrap.min.css" rel="stylesheet">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.6/dist/js/bootstrap.bundle.min.js"></script>
</head>
<body>
    <form id="form1" runat="server" class="container py-5">
        <div class="row justify-content-center">
            <div class="col-md-6 col-lg-5">
                <div class="card shadow-sm">
                    <div class="card-body text-center">
                        <asp:Label ID="lblDelete" runat="server" CssClass="h5 mb-4 d-block" Text="Are you sure you want to delete this record?"></asp:Label>
                        <div class="d-flex justify-content-center gap-3">
                            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" CssClass="btn btn-danger px-4" />
                            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" CssClass="btn btn-secondary px-4" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
