<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderManagementDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 14px; top: 49px; position: absolute; width: 87px;" Text="Order ID" height="19px"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 120px; top: 80px; position: absolute; height: 20px;" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtOrderId" runat="server" style="z-index: 1; left: 120px; top: 46px; position: absolute; height: 20px;" width="128px"></asp:TextBox>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 14px; top: 82px; position: absolute; width: 87px;" Text="Customer ID" height="19px"></asp:Label>
        <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 14px; top: 116px; position: absolute; width: 87px;" Text="Staff ID" height="19px"></asp:Label>
        <asp:Label ID="lblStatus" runat="server" style="z-index: 1; left: 14px; top: 149px; position: absolute; width: 87px; height: 23px;" Text="Status"></asp:Label>
        <asp:Label ID="lblTotalAmount" runat="server" style="z-index: 1; left: 14px; top: 182px; position: absolute; width: 100px;" Text="Total Amount" height="19px"></asp:Label>
        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 14px; top: 215px; position: absolute; width: 87px;" Text="Order Date" height="19px"></asp:Label>
        <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 120px; top: 112px; position: absolute" height="20px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtStatus" runat="server" style="z-index: 1; left: 120px; top: 147px; position: absolute" height="20px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtTotalAmount" runat="server" style="z-index: 1; left: 120px; top: 183px; position: absolute" width="128px" height="20px"></asp:TextBox>
        <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 120px; top: 212px; position: absolute" height="20px" width="128px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 17px; top: 279px; position: absolute" height="26px" width="60px"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 105px; top: 317px; position: absolute" Text="Cancel" />
        <asp:Button ID="btnOk" runat="server" style="z-index: 1; left: 22px; top: 317px; position: absolute" Text="OK" OnClick="btnOk_Click" height="26px" width="60px" />
        <asp:CheckBox ID="chkCompleted" runat="server" style="z-index: 1; left: 120px; top: 250px; position: absolute" Text="Completed" />
    </form>
</body>
</html>
