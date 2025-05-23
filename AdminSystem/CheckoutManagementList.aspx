<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckoutManagementList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 567px;
            height: 320px;
        }
    </style>
</head>
<body style="height: 21px; width: 479px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCheckoutList" runat="server" Height="349px" Width="422px"></asp:ListBox>
        <p>
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        <p>
            &nbsp;<p>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; top: 437px; position: absolute; height: 23px; width: 58px; left: 116px; right: 1100px;" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 231px; top: 437px; position: absolute; height: 23px; width: 58px; right: 985px;" Text="Delete" />
        <asp:Label ID="lblTotalCartValueBox" runat="server" style="z-index: 1; left: 39px; top: 474px; position: absolute" Text="Enter a TotalCartValue"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 230px; top: 473px; position: absolute; width: 71px;"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 18px; top: 520px; position: absolute; height: 22px; width: 107px; right: 1149px;" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 138px; top: 520px; position: absolute; height: 21px; width: 107px; right: 1029px;" Text="Clear Filter" />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ReturnToMM" runat="server" OnClick="ReturnToMM_Click" Text="ReturnToMainMenu" Width="206px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btnStat" runat="server" OnClick="btnStat_Click" style="z-index: 1; left: 257px; top: 518px; position: absolute; height: 22px; width: 107px; right: 910px;" Text="Go to Statistics" />

    </form>
</body>
</html>
