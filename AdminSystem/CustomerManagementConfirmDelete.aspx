<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerManagementConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delete Confirmation</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.6/dist/css/bootstrap.min.css" rel="stylesheet">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.6/dist/js/bootstrap.bundle.min.js"></script>
    <style type="text/css">
        /* Center the form on the page */
        body, html {
            height: 100%;
            margin: 0;
        }
        .full-height {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100%;
        }
        #form1 {
            max-width: 500px;
            padding: 24px;
            background: #fff;
            border-radius: 8px;
            box-shadow: 0 2px 8px rgba(0, 0, 0, 0.05);
        }
        .confirmation-message {
            font-size: 16px;
            margin-bottom: 24px;
        }
        .confirmation-buttons button {
            width: 100%;
        }
    </style>
</head>
<body>
    <div class="full-height">
        <form id="form1" runat="server" class="container">
            <div class="confirmation-message">
                <asp:Label ID="Label1" runat="server" Text="Are you sure you want to delete this record?" CssClass="h5"></asp:Label>
            </div>

            <div class="d-flex gap-2">
                <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" CssClass="btn btn-success flex-grow-1" Text="Yes" />
                <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" CssClass="btn btn-danger flex-grow-1" Text="No" />
            </div>
        </form>
    </div>
</body>
</html>
