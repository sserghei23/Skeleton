<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffManagementList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 58px; top: 434px; position: absolute" Text="Edit" OnClick="btnEdit_Click" />
        
        <asp:ListBox ID="lstStaffList" runat="server" Height="400px" Width="400px"></asp:ListBox>
     
        <asp:Button ID="btnAdd" runat="server" style = "position: absolute; top: 434px; left: 10px;" Text="Add" OnClick="btnAdd_Click" />
        
  
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 12px; top: 479px; position: absolute"></asp:Label>
        
  
    </form>
</body>
</html>
