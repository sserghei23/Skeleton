<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderManagementStatistics.aspx.cs" Inherits="OrderManagementStatistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <style>
    body, html {
        margin: 0;
        padding: 0;
        height: 100%;
    }

    #form1 > div {
        display: flex;
        flex-direction: column;
        align-items: center;
    }

    h1, h3 {
        text-align: center;
    }
</style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div> <h1>Order Management Statistics</h1> </div>

             <div>
                <h3>Order List - Grouped by Status</h3>


                 <div style="display: flex; justify-content: center; margin-bottom: 40px;">
                <asp:GridView ID="GridViewStGroupByStatus" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" style="position: relative">
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
             </div>


             <div>
                <h3>Order List - Grouped by Order Date</h3>
                     <div style="display: flex; justify-content: center; margin-bottom: 40px;">
                        <asp:GridView ID="GridViewStGroupByOrderDate" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
             </div> 


        </div>    
        <div style="display: flex; justify-content: center; margin-bottom: 40px;">
        <asp:Button ID="btnGoBack" runat="server" Text="Back To Prvious Page" Height="36px" OnClick="btnGoBack_Click" Width="160px" />
            </div>
    </form>
</body>
</html>
