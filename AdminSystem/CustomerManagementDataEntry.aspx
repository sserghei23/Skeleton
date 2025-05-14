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
        <asp:Label ID="lblCustomerId" runat="server" ClientIDMode="Predictable" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Customer ID"></asp:Label>
        <div>
        </div>
        <p>
            <asp:Label ID="lblFullName" runat="server" style="z-index: 1; left: 12px; top: 70px; position: absolute; width: 79px" Text="Full Name"></asp:Label>
        </p>
        <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" style="z-index: 1; left: 119px; top: 32px; position: absolute; margin-bottom: 0px"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 119px; top: 70px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 13px; top: 105px; position: absolute" Text="Email" width="79px"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 119px; top: 103px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 13px; top: 143px; position: absolute" Text="Password" width="79px"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 119px; top: 139px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPostCode" runat="server" OnTextChanged="TextBox6_TextChanged" style="z-index: 1; left: 119px; top: 182px; position: absolute; bottom: 651px"></asp:TextBox>
        <asp:TextBox ID="TextBox7" runat="server" style="z-index: 1; left: 120px; top: 219px; position: absolute; right: 443px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblDateRegistered" runat="server" style="z-index: 1; left: 12px; top: 257px; position: absolute" Text="Date Registered" width="79px"></asp:Label>
        <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 13px; top: 221px; position: absolute" Text="Phone Number" width="79px"></asp:Label>
        <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 13px; top: 184px; position: absolute" Text="Post Code" width="79px"></asp:Label>
        <asp:CheckBox ID="chkIsActive" runat="server" style="z-index: 1; left: 120px; top: 297px; position: absolute" Text="Active" />
        <p>
            <asp:TextBox ID="TextBox9" runat="server" style="z-index: 1; left: 121px; top: 255px; position: absolute"></asp:TextBox>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="bttnOK_Click" style="z-index: 1; left: 46px; top: 356px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 125px; top: 356px; position: absolute; width: 66px;" Text="Cancel" height="26px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 325px; position: absolute"></asp:Label>
    </form>
</body>
</html>
