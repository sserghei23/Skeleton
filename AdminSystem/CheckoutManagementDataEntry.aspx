<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckoutManagementDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 522px;
            width: 552px;
        }
    </style>
</head>
<body style="height: 2px; width: 54px">
    <form id="form1" runat="server">
        <asp:Label ID="lblCartId" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; bottom: 589px; width: 44px;" Text="CartId"></asp:Label>
        <p>
            <asp:TextBox ID="txtCartId" runat="server" style="z-index: 1; left: 148px; top: 34px; position: absolute; width: 98px;" Width="98px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <div style="width: 550px; margin-left: 80px">
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 28px; top: 413px; position: absolute; height: 26px; width: 43px; right: 1506px;" Text="Ok" />
        </div>
        <asp:Label ID="lblTotalCartValue" runat="server" style="z-index: 1; left: 0px; top: 333px; position: absolute" Text="TotalCartValue"></asp:Label>
        <asp:Label ID="lblWatchId" runat="server" style="z-index: 1; left: 12px; top: 140px; position: absolute" Text="WatchId" width="93px"></asp:Label>
        <asp:Label ID="lblCheckedOut" runat="server" style="z-index: 1; left: 14px; top: 258px; position: absolute" Text="CheckedOut" width="93px"></asp:Label>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 10px; top: 91px; position: absolute; right: 286px;" Text="CustomerId" width="93px"></asp:Label>
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 12px; top: 190px; position: absolute" Text="DateAdded" width="93px"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 158px; top: 83px; position: absolute; width: 98px;"></asp:TextBox>
        <asp:TextBox ID="txtWatchId" runat="server" style="z-index: 1; left: 157px; top: 142px; position: absolute; width: 98px;"></asp:TextBox>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 149px; top: 186px; position: absolute; width: 98px;"></asp:TextBox>
        <asp:CheckBox ID="txtCheckedOut" runat="server" style="z-index: 1; left: 140px; top: 258px; position: absolute; height: 22px; width: 98px;" />
        <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 335px; top: 33px; position: absolute" Text="Find" OnClick="btnFind_Click" />
        <p style="margin-left: 120px; width: 1px;">
        <asp:TextBox ID="txtTotalCartValue" runat="server" style="z-index: 1; left: 146px; top: 330px; position: absolute; width: 98px;"></asp:TextBox>
        </p>
        <p style="width: 0px; margin-left: 120px">
            &nbsp;</p>
        <p style="width: 0px; margin-left: 120px">
            &nbsp;</p>
        <p style="width: 0px; margin-left: 120px">
            &nbsp;</p>
        <p style="width: 0px; margin-left: 120px">
            &nbsp;</p>
        <p style="width: 0px; margin-left: 120px">
            &nbsp;</p>
        <p style="width: 0px; margin-left: 120px">
            &nbsp;</p>
        <p style="width: 125px; margin-left: 200px">
            &nbsp;</p>
        <p style="width: 0px; margin-left: 120px">
            &nbsp;</p>
        <p style="width: 0px; margin-left: 120px">
            &nbsp;</p>
        <p style="width: 0px; margin-left: 120px">
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p style="margin-left: 2px; height: 52px;">
        <asp:Button ID="btnCancel0" runat="server" style="z-index: 1; left: 116px; top: 416px; position: absolute; height: 26px; width: 62px;" Text="Cancel" OnClick="btnCancel0_Click" />
            &nbsp;<asp:Label ID="lblError" runat="server" style="z-index: 1; left: 171px; top: 361px; position: absolute"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ReturnToMM" runat="server" OnClick="ReturnToMM_Click" Text="ReturnToMainMenu" />
&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    </form>
</body>
</html>
