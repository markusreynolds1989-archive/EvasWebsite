<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login_Admin.aspx.cs" Inherits="EvasWebsite.Pages.Login_Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css"/>
    <title>Login</title>
</head>
<body>
    <form id="form1" class="w3-card-2" runat="server">
        <div>
            <asp:Login
                id ="AdminLogin"
                class ="Inputs"
                runat ="server"/>
        </div>
    </form>
</body>
</html>
