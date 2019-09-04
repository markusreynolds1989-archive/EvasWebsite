<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login_Admin.aspx.cs" Inherits="EvasWebsite.Pages.Login_Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="../CSS/main.css" />
    <script src="../Scripts/jQuery.js"></script>

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous" />

    <title>Login</title>
</head>
<body>
    <meta name="viewport" content="width=device-width, initial-scale=1.0,shrink-to-fit = no"/>
    <form id="frmLogin" runat="server">
        <div class ="container">
            <asp:Login
                class =""
                id ="AdminLogin"
                runat ="server" 
                OnAuthenticate="AdminLogin_Authenticate" DestinationPageUrl="~/Pages/Login/AdminDashboard.aspx"
                />
        </div>
    </form>
</body>
</html>
