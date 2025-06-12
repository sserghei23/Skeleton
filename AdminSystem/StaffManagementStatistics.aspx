<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffManagementStatistics.aspx.cs" Inherits="StaffManagementStatistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href = "Content/bootstrap.min.css" rel = "stylesheet" />
    <script src = "Scripts/bootstrap.bundle.min.js"></script>
    <script src = "Scripts/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
    <style>
        body {
            background-color: rgb(245, 245, 245);
        }
    </style>

</head>
<body>
    <h2 class ="mb-4 text-center"> Staff Statistics Page</h2>
    <form id="form1" runat="server">
    
    <div style="height: 240px auto; overflow: auto;">
        <!-- GridView which displays statistics grouped by Full Name -->
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 8px; top: 54px; position: absolute; height: 24px; width: 340px; margin-top: 0px; font-size: 20px;" Text="Statistics - Grouped by Full Name"></asp:Label>
        <asp:GridView ID="GridViewStGroupByFullName" runat="server" style="z-index: 1; left: 28px; top: 91px; position: absolute; height: 140px; width: 190px" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridViewStGroupByFullName_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>

        <!-- GridView which displays statistics grouped by Date of Employment -->
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 548px; top: 54px; position: absolute; height: 24px; margin-top: 0px; font-size: 20px;" Text = "Statistics - Grouped by Date of Employment"></asp:Label>
        <asp:GridView ID="GridViewStGroupByDateOfEmployment" runat="server" style="z-index: 1; left: 568px; top: 90px; position: absolute; height: 140px; width: 190px" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView> 
    </div>
   
    <!-- Button to return to the previous page -->
    <div style="height: 50px auto; place-self:auto; overflow:auto; top:auto;">
         <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" CssClass = "btn btn-primary" style="z-index: 1; left: 15px; top: 1100px;" Text="Return Page" />
    </div>

    </form>
</body>
</html>
