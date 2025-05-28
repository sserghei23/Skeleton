<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderManagementList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstOrderList" runat="server" Height="261px" Width="339px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 36px; top: 345px; position: absolute; height: 32px; width: 58px;" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; top: 345px; position: absolute; height: 32px; width: 58px; left: 119px; right: 990px;" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 313px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 204px; top: 345px; position: absolute; height: 32px; width: 58px" Text="Delete" />
        <asp:Label ID="lblStatusBox" runat="server" style="z-index: 1; left: 26px; top: 399px; position: absolute" Text="Enter a Status"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 124px; top: 399px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 33px; top: 448px; position: absolute; height: 34px; width: 104px; right: 1497px;" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 161px; top: 448px; position: absolute; height: 34px; width: 104px; right: 1366px;" Text="Clear Filter" />
        <asp:Button ID="btnStat" runat="server" OnClick="btnStat_Click" style="z-index: 1; left: 352px; top: 365px; position: absolute; height: 34px; width: 128px" Text="Go to Statistics" />

        <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" style="z-index: 1; left: 352px; top: 414px; position: absolute; height: 34px; width: 128px" Text="Main Menu" />

    </form>
</body>
</html>
