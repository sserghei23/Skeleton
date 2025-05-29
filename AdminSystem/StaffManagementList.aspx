<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffManagementList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstStaffList" runat="server" Height="400px" Width="400px"></asp:ListBox>
     
        <asp:Button ID="btnAdd" runat="server" style = "position: absolute; top: 434px; left: 10px;" Text="Add" OnClick="btnAdd_Click" height="26px" />

        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 63px; top: 434px; position: absolute;" Text="Edit" OnClick="btnEdit_Click" height="26px"/>
        
        <asp:Button ID="btnDelete" runat="server" Style="z-index: 1; left: 111px; top: 434px; position: absolute" Text="Delete" OnClick="btnDelete_Click" height="26px" />
      
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 18px; top: 608px; position: absolute"></asp:Label>
      
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 16px; top: 502px; position: absolute" Text="Enter Full Name:"></asp:Label>

        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 130px; top: 501px; position: absolute"></asp:TextBox>

        <asp:Button ID="btnApplyFilter" runat="server" style="z-index: 1; left: 18px; top: 547px; position: absolute" Text="Apply Filter" OnClick="btnApplyFilter_Click" />

        <asp:Button ID="btnClearFilter" runat="server" style="z-index: 1; left: 138px; top: 547px; position: absolute" Text="Clear Filter" OnClick="btnClearFilter_Click" />
      
        <asp:Button ID="btnStatistics" runat="server" OnClick="btnStatistics_Click" style="z-index: 1; left: 253px; top: 547px; position: absolute" Text="Statistics Page" />
      
    </form>
</body>
</html>
