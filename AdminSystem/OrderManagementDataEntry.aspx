<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderManagementDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 14px; top: 48px; position: absolute; width: 117px;" Text="Order ID" height="19px"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 178px; top: 93px; position: absolute; height: 20px;" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtOrderId" runat="server" style="z-index: 1; left: 178px; top: 47px; position: absolute; height: 20px;" width="128px"></asp:TextBox>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 14px; top: 93px; position: absolute; width: 112px;" Text="Customer ID" height="19px"></asp:Label>
        <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 14px; top: 140px; position: absolute; width: 122px;" Text="Staff ID" height="19px"></asp:Label>
        <asp:Label ID="lblStatus" runat="server" style="z-index: 1; left: 14px; top: 185px; position: absolute; width: 114px; height: 23px;" Text="Status"></asp:Label>
        <asp:Label ID="lblTotalAmount" runat="server" style="z-index: 1; left: 14px; top: 229px; position: absolute; width: 117px;" Text="Total Amount" height="19px"></asp:Label>
        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 14px; top: 275px; position: absolute; width: 130px;" Text="Order Date" height="19px"></asp:Label>
        <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 178px; top: 138px; position: absolute" height="20px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtStatus" runat="server" style="z-index: 1; left: 178px; top: 184px; position: absolute" height="20px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtTotalAmount" runat="server" style="z-index: 1; left: 178px; top: 229px; position: absolute" width="128px" height="20px"></asp:TextBox>
        <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 178px; top: 275px; position: absolute" height="20px" width="128px"></asp:TextBox>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 162px; top: 342px; position: absolute; height: 29px; width: 76px;" Text="Cancel"  />
        <asp:Button ID="btnOk" runat="server" style="z-index: 1; left: 41px; top: 342px; position: absolute; height: 29px; width: 76px;" Text="OK" OnClick="btnOk_Click" />
        <asp:CheckBox ID="chkCompleted" runat="server" style="z-index: 1; left: 180px; top: 310px; position: absolute" Text="Completed" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 386px; position: absolute"></asp:Label>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 343px; top: 45px; position: absolute; width: 76px" Text="Find" />

    </form>
</body>
</html>
