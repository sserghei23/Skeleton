<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckoutManagementDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 355px; width: 496px">
    <form id="form1" runat="server">
        <asp:Label ID="lblCartId" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; bottom: 605px;" Text="CartId" width="93px"></asp:Label>
        <p>
            <asp:TextBox ID="txtCartId" runat="server" style="z-index: 1; left: 148px; top: 34px; position: absolute; width: 98px;" Width="98px"></asp:TextBox>
        </p>
        <asp:Label ID="lblTotalCartValue" runat="server" style="z-index: 1; left: 12px; top: 325px; position: absolute" Text="TotalCartValue"></asp:Label>
        <asp:Label ID="lblWatchId" runat="server" style="z-index: 1; left: 12px; top: 140px; position: absolute" Text="WatchId" width="93px"></asp:Label>
        <asp:Label ID="lblCheckedOut" runat="server" style="z-index: 1; left: 14px; top: 258px; position: absolute" Text="CheckedOut" width="93px"></asp:Label>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 10px; top: 91px; position: absolute; right: 286px;" Text="CustomerId" width="93px"></asp:Label>
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 12px; top: 190px; position: absolute" Text="DateAdded" width="93px"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 158px; top: 83px; position: absolute; width: 98px;"></asp:TextBox>
        <asp:TextBox ID="txtWatchId" runat="server" style="z-index: 1; left: 157px; top: 142px; position: absolute; width: 98px;"></asp:TextBox>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 149px; top: 186px; position: absolute; width: 98px;"></asp:TextBox>
        <asp:CheckBox ID="txtCheckedOut" runat="server" style="z-index: 1; left: 140px; top: 258px; position: absolute; height: 22px; width: 98px;" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 88px; top: 380px; position: absolute"></asp:Label>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 42px; top: 457px; position: absolute; height: 26px;" Text="Ok" />
        <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 335px; top: 33px; position: absolute" Text="Find" OnClick="btnFind_Click" />
        <p>
        <asp:TextBox ID="txtTotalCartValue" runat="server" style="z-index: 1; left: 146px; top: 330px; position: absolute; width: 98px;"></asp:TextBox>
        <asp:Button ID="btnCancel0" runat="server" style="z-index: 1; left: 152px; top: 459px; position: absolute" Text="Cancel" />
        </p>
    </form>
</body>
</html>
