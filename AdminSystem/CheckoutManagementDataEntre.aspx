<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckoutManagementDataEntre.aspx.cs" Inherits="CheckoutManagementDataEntre" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 16px; top: 178px; position: absolute; right: 1468px;" Text="CustomerId" width="93px"></asp:Label>
        <asp:TextBox ID="txtCartId" runat="server" style="z-index: 1; left: 223px; top: 90px; position: absolute; width: 98px;"></asp:TextBox>
        <asp:TextBox ID="txtTotalCartValue" runat="server" style="z-index: 1; left: 219px; top: 252px; position: absolute; width: 98px;"></asp:TextBox>
        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 225px; top: 176px; position: absolute; width: 98px;"></asp:TextBox>
        <asp:TextBox ID="txtWatchId" runat="server" style="z-index: 1; left: 224px; top: 138px; position: absolute; width: 98px; bottom: 483px;"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
        <asp:Label ID="lblCheckedOut" runat="server" style="z-index: 1; left: 10px; top: 216px; position: absolute; " Text="CheckedOut" width="93px"></asp:Label>
        <asp:Label ID="lblWatchId" runat="server" style="z-index: 1; left: 16px; top: 142px; position: absolute; right: 1468px;" Text="WatchId" width="93px"></asp:Label>
        <asp:Label ID="lblCartId" runat="server" style="z-index: 1; left: 19px; top: 93px; position: absolute; right: 1465px;" Text="CartId" width="93px"></asp:Label>
        <asp:Label ID="lblTotalCartValue" runat="server" style="z-index: 1; left: 14px; top: 254px; position: absolute; " Text="TotalCartValue" width="93px"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnFind" runat="server" Height="25px" OnClick="btnFind_Click" Text="Find" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p style="margin-left: 200px">
            <asp:CheckBox ID="txtCheckedOut" runat="server" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblDateAdded" runat="server" Text="DateAdded"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDateAdded" runat="server" Height="16px"></asp:TextBox>
        </p>
        <p>
        <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOk" runat="server" Text="Ok" OnClick="btnApplyFilter_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnClearFilter_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;
            <asp:Button ID="btnReturnToMM" runat="server" OnClick="btnReturnToMM_Click" Text="ReturnToMainMenu" />
&nbsp;&nbsp;
        </p>
        <br />
        <br />
    </form>
</body>
</html>
