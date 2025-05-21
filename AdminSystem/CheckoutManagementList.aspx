<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckoutManagementList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 567px;
        }
    </style>
</head>
<body style="height: 21px; width: 479px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCheckoutList" runat="server" Height="301px" Width="422px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="margin-left: 27px" Text="Edit" Width="44px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" Height="25px" OnClick="btnDelete_Click" Text="Delete" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Enter a TotalCartValue"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtFilter" runat="server" Height="16px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnApplyFilter" runat="server" Text="ApplyFilter" OnClick="btnApplyFilter_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnClearFilter" runat="server" Text="ClearFilter" OnClick="btnClearFilter_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnStatistics" runat="server" OnClick="btnStatistics_Click" Text="Statistics Page" />
        &nbsp;&nbsp;
            <asp:Button ID="btnReturnToMM" runat="server" OnClick="btnReturnToMM_Click" Text="ReturnToMainMenu" />
&nbsp;&nbsp;
        </p>
        <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
    </form>
</body>
</html>
