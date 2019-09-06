<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDashboard.aspx.cs" Inherits="EvasWebsite.Pages.Login.AdminDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous" />

    <link rel="stylesheet" type="text/css" href="../CSS/main.css" />
    <title>Add Product</title>
    <script src="../Scripts/jQuery.js"></script>
</head>
<body>
    <meta name="viewport" content="width=device-width, initial-scale=1.0,shrink-to-fit=no" />
    <form id="frmDash" runat="server">
        <div class="">
            <div class="container">
                <h2 class="">User Management</h2>
                <asp:ImageButton
                    runat="server"
                    class=""
                    ImageUrl="~/Pictures/bow.jpg"
                    Height="100px"
                    Width="100px" PostBackUrl="~/Pages/UserManagement/User_Management.aspx" />
            </div>
            <div class="container">
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
