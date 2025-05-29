<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerManagementList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 371px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" Height="348px" Width="450px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 89px; top: 400px; position: absolute" Text="Delete" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        </p>
        <p>
            <asp:TextBox ID="TxtPostCode" runat="server" style="z-index: 1; left: 141px; top: 444px; position: absolute; width: 205px; height: 27px;"></asp:TextBox>
            <asp:Button ID="btnApplyFilter" runat="server" height="26px" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 14px; top: 487px; position: absolute; " Text="Apply Filter" width="133px" />
            <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 9px; top: 450px; position: absolute; right: 524px; height: 19px" Text="Enter a Post Code"></asp:Label>
        </p>
        <p style="margin-left: 280px">
            <asp:Button ID="btnStatisticsPage" runat="server" OnClick="btnStatisticsPage_Click" Text="Statistics Page" />
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnClearFilter" runat="server" style="z-index: 1; left: 146px; top: 486px; position: absolute" Text="Clear Filter" height="26px" width="133px" />
        <p>
            &nbsp;</p>
        <p>
        <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
