<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDashboard.aspx.cs" Inherits="EvasWebsite.Pages.Login.AdminDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css" />
    <link rel="stylesheet" type="text/css" href="../CSS/main.css" />
    <title>Add Product</title>
    <script src="../Scripts/jQuery.js"></script>
</head>
<body>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <form id="frmDash" runat="server">
        <div class="w3-display-container" style="height: 500px; width: 1000px;">
            <div class="w3-display-left w3-center">
                <h2 class="">User Management</h2>
                <asp:ImageButton
                    runat="server"
                    class=""
                    ImageUrl="~/Pictures/bow.jpg"
                    Height="100px"
                    Width="100px" PostBackUrl="~/Pages/UserManagement/User_Management.aspx" />
            </div>
            <div class="w3-display-middle w3-center">
                <h2 class="">Product Management</h2>
                <asp:ImageButton
                    runat="server"
                    class=""
                    ImageUrl="~/Pictures/placeHolderPerson.png"
                    Height="100px"
                    Width="100px" PostBackUrl="~/Pages/ProductManagement/Product_Management.aspx" />
            </div>
        </div>
    </form>
</body>
</html>
