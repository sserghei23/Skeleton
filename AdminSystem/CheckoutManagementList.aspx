<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckoutManagementList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.6/dist/css/bootstrap.min.css" rel="stylesheet">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.10.5/font/bootstrap-icons.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.6/dist/js/bootstrap.bundle.min.js"></script>
    <style type="text/css">
        #form1 {
            max-width: 800px;
            margin: 40px auto;
            padding: 24px;
            background: #fff;
            border-radius: 8px;
            box-shadow: 0 2px 8px rgba(0,0,0,0.05);
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="container">
        <div class="mb-3">
            <asp:ListBox ID="lstCheckoutList" runat="server" CssClass="form-select mb-3" Height="349px" Width="100%"></asp:ListBox>
        </div>
        <div class="mb-3">
            <asp:Label ID="lblError" runat="server" CssClass="text-danger"></asp:Label>
        </div>
        <div class="row mb-3">
            <div class="col-md-4">
                <asp:Label ID="lblTotalCartValueBox" runat="server" Text="Enter a TotalCartValue" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtFilter" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-8 d-flex align-items-end gap-2">
                <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" CssClass="btn btn-primary" Text="Apply Filter" />
                <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" CssClass="btn btn-primary" Text="Clear Filter" />
            </div>
        </div>
       <div class="mb-3 d-flex gap-2">
    <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" CssClass="btn btn-primary" Text=" Edit" />
    <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" CssClass="btn btn-primary" Text=" Delete" />
    <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" CssClass="btn btn-primary" Text=" Add" />
       </div>
        <div class="mb-3 d-flex gap-2">
    <asp:Button ID="ReturnToMM" runat="server" OnClick="ReturnToMM_Click" CssClass="btn btn-outline-dark flex-grow-1" Text="Return To Main Menu" Width="278px" />
    <asp:Button ID="btnStat" runat="server" OnClick="btnStat_Click" CssClass="btn btn-primary" Text=" Go to Statistics" />
       </div>

    </form>
</body>
</html>
