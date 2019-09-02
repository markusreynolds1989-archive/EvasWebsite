<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User_Management.aspx.cs" Inherits="EvasWebsite.Pages.User_Management" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css" />
    <link rel="stylesheet" type="text/css" href="../CSS/main.css" />
    <title>User Management</title>
    <script src="../Scripts/jQuery.js"></script>
</head>
<body>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <form id="frmMenu" runat="server">

        <div class="w3-display-container" style="width:780px;height:500px;">
            <div class="w3-center w3-display-left">
            <h2 class ="">Add User</h2>
            <asp:ImageButton
                runat="server"
                class =""
                imageurl="~/Pictures/placeHolderPerson.png"
                width="100px"
                height="100px" 
                PostBackUrl="~/Pages/UserManagement/Add_User.aspx"/>
            </div>

            <div class="w3-center w3-display-middle">
            <h2 class="">Modify User</h2>
            <asp:ImageButton
                runat="server"
                class="" 
                imageurl="~/Pictures/placeHolderModifyPerson.png"
                width="100px"
                height="100px"/>
            </div>

            <div class="w3-center w3-display-right">
            <h2 class="">Remove User</h2>
            <asp:ImageButton
                runat="server"
                class=""
                imageurl="~/Pictures/placeHolderRemovePerson.png"
                width="100px"
                height="100px"/>
            </div>

        </div>
    </form>
</body>
</html>
