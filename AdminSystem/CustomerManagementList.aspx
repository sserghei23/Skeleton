﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerManagementList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" Height="420px" Width="450px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 84px; top: 473px; position: absolute" Text="Delete" />
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
    </form>
</body>
</html>
