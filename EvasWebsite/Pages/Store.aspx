<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Store.aspx.cs"
    Inherits="EvasWebsite.Pages.Store" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="../CSS/main.css"/>
    <title>Store</title>
    <!-- add a script here
        that takes people's emails
        and signs them up for a news letter
        same thing for when they pay
    -->
    <script>
        alert("Sign up now!");
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Literal 
                runat = "server"
                id    = "mainStore">
            </asp:Literal>
        </div>
    </form>
</body>
</html>
