<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderManagementList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstOrderList" runat="server" Height="354px" Width="338px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 18px; top: 416px; position: absolute; height: 32px; width: 58px;" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; top: 416px; position: absolute; height: 32px; width: 58px; left: 96px" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 21px; top: 465px; position: absolute"></asp:Label>
    </form>
</body>
</html>
