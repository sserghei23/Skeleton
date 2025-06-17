<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerManagementStatistics.aspx.cs" Inherits="CustomerManagementStatistics" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Management Statistics</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
        }
        
        #form1 {
            width: 80%;
            margin: 30px auto;
            padding: 20px;
            background-color: #fff;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
        }

        h1 {
            color: #333;
            text-align: center;
            margin-bottom: 20px;
        }

        .grid-container {
            display: flex;
            justify-content: space-between;
            gap: 20px;
            margin-bottom: 30px;
        }

        .grid-view {
            width: 48%;
            border: 1px solid #ccc;
            border-radius: 5px;
            box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
            overflow: hidden;
            background-color: #fff;
        }

        .grid-view th, .grid-view td {
            padding: 10px;
            text-align: left;
        }

        .grid-view th {
            background-color: #006699;
            color: white;
        }

        .grid-view td {
            background-color: #f9f9f9;
        }

        .grid-view tr:nth-child(even) {
            background-color: #f1f1f1;
        }

        .grid-view tr:hover {
            background-color: #e2e2e2;
        }

        .button-container {
            text-align: center;
            margin-top: 30px;
        }

        .btn {
            background-color: #007bff;
            color: white;
            padding: 10px 20px;
            font-size: 16px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            transition: background-color 0.3s;
        }

        .btn:hover {
            background-color: #0056b3;
        }

        .btn:focus {
            outline: none;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Customer Management Statistics</h1>

        <div class="grid-container">
            <div class="grid-view">
                <asp:GridView ID="GridViewStGroupByFullName" runat="server">
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    <RowStyle ForeColor="#000066" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#00547E" />
                </asp:GridView>
            </div>

            <div class="grid-view">
                <asp:GridView ID="GridViewStGroupByDateRegistered" runat="server">
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    <RowStyle ForeColor="#000066" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#00547E" />
                </asp:GridView>
            </div>
        </div>

        <div class="button-container">
            <asp:Button ID="btnBTPP" runat="server" OnClick="btnBTPP_Click" CssClass="btn" Text="Back To Previous Page" />
        </div>
    </form>
</body>
</html>
