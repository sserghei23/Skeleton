<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerManagementDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 303px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerId" runat="server" ClientIDMode="Predictable" style="z-index: 1; left: 10px; top: 34px; position: absolute; bottom: 578px;" Text="Customer ID" width="79px"></asp:Label>
        <div>
        </div>
        <p>
            <asp:Label ID="lblFullName" runat="server" style="z-index: 1; left: 12px; top: 70px; position: absolute; width: 79px" Text="Full Name"></asp:Label>
        </p>
        <asp:TextBox ID="txtCustomerId" runat="server" OnTextChanged="TextBox2_TextChanged" style="z-index: 1; left: 119px; top: 33px; position: absolute; margin-bottom: 0px; bottom: 511px;"></asp:TextBox>
       <asp:TextBox ID="txtFullName" runat="server" style="z-index: 1; left: 119px; top: 70px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 13px; top: 105px; position: absolute" Text="Email" width="79px"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 119px; top: 103px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 13px; top: 143px; position: absolute" Text="Password" width="79px"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 119px; top: 139px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 119px; top: 182px; position: absolute; bottom: 651px" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtPhoneNumber" runat="server" style="z-index: 1; left: 120px; top: 219px; position: absolute; right: 443px" height="22px" width="128px"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 295px; top: 31px; position: absolute; width: 57px; height: 26px;" Text="Find" />
        <p>
            &nbsp;</p>
        <asp:Label ID="lblDateRegistered" runat="server" style="z-index: 1; left: 12px; top: 257px; position: absolute" Text="Date Registered" width="79px"></asp:Label>
        <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 13px; top: 221px; position: absolute" Text="Phone Number" width="79px"></asp:Label>
        <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 13px; top: 184px; position: absolute; right: 622px;" Text="Post Code" width="79px"></asp:Label>
        <asp:CheckBox ID="chkIsActive" runat="server" style="z-index: 1; left: 120px; top: 297px; position: absolute" Text="Active" />
        <p>
            <asp:TextBox ID="txtDateRegistered" runat="server" style="z-index: 1; left: 121px; top: 255px; position: absolute" height="22px" width="128px"></asp:TextBox>
        </p>
       <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 46px; top: 356px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 125px; top: 357px; position: absolute; width: 62px;" Text="Cancel" height="26px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 325px; position: absolute"></asp:Label>
    </form>
</body>
</html>
