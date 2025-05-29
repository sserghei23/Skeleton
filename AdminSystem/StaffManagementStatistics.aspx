<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffManagementStatistics.aspx.cs" Inherits="StaffManagementStatistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 39px">
    <h2>Staff Statistics Page</h2>
    <form id="form1" runat="server">
    
    <div style="height: 791px">
        <h3>Statistics - Grouped by Full Name</h3>
        <asp:GridView ID="GridViewStGroupByFullName" runat="server" style="z-index: 1; left: 28px; top: 91px; position: absolute; height: 133px; width: 187px" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridViewStGroupByFullName_SelectedIndexChanged">
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
   
    <div style="height: 600px">
        <h3>Statistics - Grouped by Date Of Employment</h3>
        <asp:GridView ID="GridViewStGroupByDateOfEmployment" runat="server" style="z-index: 1; left: 34px; top: 921px; position: absolute; height: 133px; width: 187px" CellPadding="4" ForeColor="#333333" GridLines="None">
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

    <div>
        <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" style="z-index: 1; left: 22px; top: 1376px; position: absolute" Text="Return Page" />
    </div>

    </form>
</body>
</html>
