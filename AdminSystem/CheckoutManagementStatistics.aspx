<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckoutManagementStatistics.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.6/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.6/dist/js/bootstrap.bundle.min.js"></script>
    <!-- Add Bootstrap Icons CDN -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.10.5/font/bootstrap-icons.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server" class="container py-5">
        <div class="row justify-content-center">
            <div class="col-lg-8">
                <h2 class="mb-4 text-center auto-style1">Statistics Page</h2>

                <div class="mb-5">
                    <h5 class="mb-3">CheckoutList - Group By TotalCartValue</h5>
                    <asp:GridView ID="GridViewStGroupByTotalCartValue" runat="server"
                        CssClass="table table-striped table-bordered"
                        CellPadding="4" ForeColor="#333333" GridLines="None" Height="161px"
                        OnSelectedIndexChanged="GridViewStGroupByTotalCartValue_SelectedIndexChanged" Width="100%">
                        <AlternatingRowStyle BackColor="White" />
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                    </asp:GridView>
                </div>

                <div class="mb-5">
                    <h5 class="mb-3">CheckoutList - Group By DateAdded</h5>
                    <asp:GridView ID="GridViewStGroupByDateAdded" runat="server"
                        CssClass="table table-striped table-bordered"
                        CellPadding="4" ForeColor="#333333" GridLines="None"
                        OnSelectedIndexChanged="GridViewStGroupByDateAdded_SelectedIndexChanged" Width="100%">
                        <AlternatingRowStyle BackColor="White" />
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                    </asp:GridView>
                </div>

                <div class="d-flex justify-content-center mb-3">
                    <asp:Button ID="btnBTPP" runat="server" Text=" Back To Previous Page" CssClass="btn btn-primary" OnClick="btnBTPP_Click" />

                </div>
            </div>
        </div>
    </form>
</body>
</html>
