<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login_Admin.aspx.cs" Inherits="EvasWebsite.Pages.Login_Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="../CSS/main.css" />
    <script src="../Scripts/jQuery.js"></script>
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css"/>
    <title>Login</title>
</head>
<body class="w3-display-container" style ="height:500px; width: 850px;">
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <form id="frmLogin" runat="server">
        <div class ="w3-display-middle">
            <asp:Login
                class ="w3-card-4"
                id ="AdminLogin"
                runat ="server" 
                OnAuthenticate="AdminLogin_Authenticate" DestinationPageUrl="~/Pages/UserManagement/User_Management.aspx"
                />
        </div>
    </form>
</body>
</html>
