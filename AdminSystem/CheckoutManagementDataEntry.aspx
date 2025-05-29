<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckoutManagementDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

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
            <div class="col-md-8 col-lg-6">
                <h2 class="mb-4 text-center">Checkout Data Entry</h2>
                <div class="mb-3">
                    <asp:Label ID="lblCartId" runat="server" AssociatedControlID="txtCartId" CssClass="form-label" Text="CartId"></asp:Label>
                    <div class="input-group">
                        <asp:TextBox ID="txtCartId" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:Button ID="btnFind" runat="server" CssClass="btn btn-outline-secondary" Text="Find" OnClick="btnFind_Click" />
                    </div>
                </div>
                <div class="mb-3">
                    <asp:Label ID="lblCustomerId" runat="server" AssociatedControlID="txtCustomerId" CssClass="form-label" Text="CustomerId"></asp:Label>
                    <asp:TextBox ID="txtCustomerId" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <asp:Label ID="lblWatchId" runat="server" AssociatedControlID="txtWatchId" CssClass="form-label" Text="WatchId"></asp:Label>
                    <asp:TextBox ID="txtWatchId" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <asp:Label ID="lblDateAdded" runat="server" AssociatedControlID="txtDateAdded" CssClass="form-label" Text="DateAdded"></asp:Label>
                    <asp:TextBox ID="txtDateAdded" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3 form-check">
                    <asp:CheckBox ID="txtCheckedOut" runat="server" CssClass="form-check-input" />
                    <asp:Label ID="lblCheckedOut" runat="server" AssociatedControlID="txtCheckedOut" CssClass="form-check-label ms-2" Text="CheckedOut" Width="190px"></asp:Label>
                </div>
                <div class="mb-3">
                    <asp:Label ID="lblTotalCartValue" runat="server" AssociatedControlID="txtTotalCartValue" CssClass="form-label" Text="TotalCartValue"></asp:Label>
                    <asp:TextBox ID="txtTotalCartValue" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <asp:Label ID="lblError" runat="server" CssClass="text-danger"></asp:Label>
                </div>
                <div class="d-flex flex-wrap gap-2 justify-content-between mb-3">
                    <asp:Button ID="btnOk" runat="server" CssClass="btn btn-primary" Text="Ok" OnClick="btnOk_Click" />
                    <asp:Button ID="btnCancel0" runat="server" CssClass="btn btn-secondary" Text="Cancel" OnClick="btnCancel0_Click" />
                    <asp:Button ID="ReturnToMM" runat="server" CssClass="btn btn-outline-dark flex-grow-1" Text="ReturnToMainMenu" OnClick="ReturnToMM_Click" Width="220px" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
