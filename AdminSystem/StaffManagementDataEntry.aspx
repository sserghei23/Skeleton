<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffManagementDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Management Data Entry</title>

    <link href = "Content/bootstrap.min.css" rel = "stylesheet" />
    <script src = "Scripts/bootstrap.bundle.min.js"></script>
    <script src = "Scripts/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css"/>
    <style>
        body {
            background-color: rgb(225 225 225);

        }
    </style>
</head>
<body>
    <h2 class ="mb4 text-center">This is the Staff Management Data Entry</h2>
    <form id="form1" runat="server" class ="row justify-content-center">
        <div class="row justify-content-center">
            <div class="col-md-8 col-lg-6">
            <!-- This is the Staff Management Data Entry form -->
            <!-- The form is used to add or edit staff information -->
            <!-- The form contains the following fields: -->

            <!-- Staff ID field-->
            <div class = "mb-3">
                <asp:Label ID="lblStaffID" runat="server" Text="Staff ID: "></asp:Label>
                <asp:TextBox ID="txtStaffID" runat="server" CssClass = "form-control" placeholder = "Enter StaffID"></asp:TextBox>
            </div>

            <!-- Order ID field-->
            <div class = "mb-3">
                <asp:Label ID="lblOrderID" runat="server" Text="Order ID: " ></asp:Label>
                <asp:TextBox ID="txtOrderID" runat="server" CssClass = "form-control" placeholder = "Enter OrderID"></asp:TextBox>
            </div>

            <!-- Staff Name field-->
            <div class = "mb-3">
                <asp:Label ID="lblFullName" runat="server" Text="FullName: " ></asp:Label>
                <asp:TextBox ID="txtFullName" runat="server" CssClass = "form-control" placeholder = "Enter Staff Name" ></asp:TextBox>
            </div>
            
            <!-- Password field-->
            <div class ="mb-3">
                <asp:Label ID="Label1" runat="server" Text="Password: " ></asp:Label>
                <asp:TextBox ID="txtPassword" runat="server" CssClass = "form-control" placeholder = "Enter Password" ></asp:TextBox>
            </div>

            <!-- Email field-->
            <div class ="mb-3">
                <asp:Label ID="lblEmail" runat="server" Text="Email: "></asp:Label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass = "form-control" placeholder = "Enter Email" ></asp:TextBox>
            </div>
           
            <!-- Date of Employment field-->
            <div class ="mb-3">
                <asp:Label ID="lblDateOfEmployment" runat="server" Text="DateOfEmployment: "></asp:Label>
                <asp:TextBox ID="txtDateOfEmployment" runat="server" CssClass = "form-control" placeholder = "Enter Date" ></asp:TextBox>
            </div>

            <!-- IsWorking field-->
            <asp:CheckBox ID="chkIsWorking" runat="server" CssClass = "form-check-label"  Text="IsWorking"/>
        
            <!-- Error Label-->
            <div class = "mb-3">
                <asp:Label ID="lblError" runat="server"  CssClass = "text-danger"></asp:Label>
            </div>

            <!-- Buttons for OK, Cancel, Clear, Find-->
            <div class = "mb-3">
                <asp:Button ID="btnOK" runat="server" style ="z-index: 1; left: 605px; top: 640px; margin-right: 10px; " OnClick="btnOK_Click" CssClass ="btn btn-primary" Text = "OK" />
            
                <asp:Button ID="btnCancel" runat="server" style ="z-index: 1; left: 650px; top: 640px; margin-left: 10px; margin-right: 10px;" OnClick="btnCancel_Click" CssClass ="btn btn-secondary" Text = "Cancel"/>
                      
                <asp:Button ID="btnClear" runat="server" style ="z-index: 1; left: 720px; top: 640px; margin-left: 20px; margin-right: 10px;"  OnClick="btnClear_Click" CssClass ="btn btn-danger" Text = "Clear" />
            </div>

            <asp:Button ID="btnFind" runat="server" style = "z-index: 1; left: 1600px; top: 84px; " OnClick="btnFind_Click" CssClass ="btn btn-secondary" Text = "Find"/>
            </div>
        </div>
    </form>
</body>
</html>
