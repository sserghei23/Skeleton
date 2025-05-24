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
        <div>
        <asp:TextBox ID="txtCustomerId" runat="server" OnTextChanged="TextBox2_TextChanged" style="margin-bottom: 0px; margin-left: 109px;" Height="22px" width="129px"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="lblFullName" runat="server" style="z-index: 1; left: 12px; top: 70px; position: absolute; width: 108px" Text="Full Name"></asp:Label>
        </p>
       <asp:TextBox ID="txtFullName" runat="server" style="z-index: 1; left: 119px; top: 70px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 13px; top: 105px; position: absolute" Text="Email" width="108px"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 119px; top: 103px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 13px; top: 143px; position: absolute" Text="Password" width="108px"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 119px; top: 139px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 119px; top: 182px; position: absolute; bottom: 651px" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtPhoneNumber" runat="server" style="z-index: 1; left: 120px; top: 219px; position: absolute; right: 443px" height="22px" width="128px"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 295px; top: 31px; position: absolute; width: 57px; height: 26px;" Text="Find" />
        <p>
            &nbsp;</p>
        <asp:Label ID="lblDateRegistered" runat="server" style="z-index: 1; left: 12px; top: 257px; position: absolute; width: 108px;" Text="Date Registered"></asp:Label>
        <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 13px; top: 221px; position: absolute" Text="Phone Number" width="108px"></asp:Label>
        <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 13px; top: 184px; position: absolute; right: 622px;" Text="Post Code" width="108px"></asp:Label>
        <asp:CheckBox ID="chkIsActive" runat="server" style="z-index: 1; left: 120px; top: 297px; position: absolute" Text="Active" />
        <p>
            <asp:TextBox ID="txtDateRegistered" runat="server" style="z-index: 1; left: 121px; top: 255px; position: absolute" height="22px" width="128px" OnTextChanged="txtDateRegistered_TextChanged"></asp:TextBox>
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 111px; top: 355px; position: absolute; width: 50px;" Text="Cancel" height="26px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 325px; position: absolute"></asp:Label>
        <p>
        <asp:Label ID="lblCustomerId" runat="server" ClientIDMode="Predictable" style="z-index: 1; left: 12px; top: 33px; position: absolute; bottom: 572px; width: 108px;" Text="Customer ID"></asp:Label>
        </p>
        <p>
       <asp:Button ID="btnOK" runat="server" style="z-index: 1; top: 355px; position: absolute; width: 50px;" Text="OK" OnClick="btnOK_Click" height="26px" />
        </p>
    </form>
</body>
</html>
