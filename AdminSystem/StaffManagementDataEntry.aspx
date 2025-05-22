<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffManagementDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 39px">
    <h1>This is the Staff Management Data Entry</h1>
    <form id="form1" runat="server">
        

        
            <!-- This is the Staff Management Data Entry form -->
            <!-- The form is used to add or edit staff information -->
            <!-- The form contains the following fields: -->


            <!-- Staff ID field-->
            <asp:Label ID="lblStaffID" runat="server" style="z-index: 1; left: 10px; top: 87px; position: absolute; height: 20px; width: 124px; " Text="Staff ID"></asp:Label>
            <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; top: 85px; position: absolute; left: 153px;" width="128px"></asp:TextBox>
        
            <!-- Order ID field-->
            <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 153px; top: 115px; position: absolute" width="128px"></asp:TextBox>
            <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; left: 10px; top: 118px; position: absolute; height: 24px;" Text="Order ID" width="124px"></asp:Label>
        
            <!-- Staff Name field-->
            <asp:Label ID="lblFullName" runat="server" style="z-index: 1; left: 10px; position: absolute; height: 19px; top: 148px;" Text="FullName" width="124px"></asp:Label>
            <asp:TextBox ID="txtFullName" runat="server" style="z-index: 1; left: 153px; top: 147px; position: absolute" width="128px"></asp:TextBox>
      
            <!-- Password field-->
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 10px; top: 184px; position: absolute; height: 19px;" Text="Password" width="124px"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 153px; top: 182px; position: absolute" width="128px"></asp:TextBox>
        
            <!-- Email field-->
            <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 10px; top: 222px; position: absolute; width: 124px;" Text="Email"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 153px; top: 221px; position: absolute" width="128px"></asp:TextBox>
        
            <!-- Date of Employment field-->
            <asp:Label ID="lblDateOfEmployment" runat="server" style="z-index: 1; left: 10px; top: 260px; position: absolute; right: 557px;" Text="DateOfEmployment"></asp:Label>
            <asp:TextBox ID="txtDateOfEmployment" runat="server" style="z-index: 1; left: 153px; top: 259px; position: absolute; width: 136px;"></asp:TextBox>
        
            <!-- IsWorking field-->
            <asp:CheckBox ID="chkIsWorking" runat="server" style="z-index: 1; top: 299px; position: absolute; left: 8px" Text="IsWorking" />
        
            <!-- Error Label-->
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 14px; top: 335px; position: absolute" Text="[lblError]"></asp:Label>

            <!-- Buttons for OK, Cancel and Find-->
            <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 12px; top: 377px; position: absolute;" Text="OK" OnClick="btnOK_Click" />
            
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 58px; top: 377px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
            
                         
            <asp:Button ID="btnFind" runat="server" Text="Find" style="z-index: 1; left: 319px; top: 88px; position: absolute; width: 59px; height: 29px;" OnClick="btnFind_Click"/>
            
   
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 131px; top: 377px; position: absolute" Text="Clear" />
            
   
    </form>
</body>
</html>
