<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product_Management.aspx.cs" Inherits="EvasWebsite.Pages.ProductManagement.Product_Management" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous" />

    <link rel="stylesheet" type="text/css" href="../CSS/main.css" />
    <title>User Management</title>
    <script src="../Scripts/jQuery.js"></script>
</head>
<body>
    <meta name="viewport" content="width=device-width, initial-scale=1.0,shrink-to-fit = no"/>

    <form id="frmMenu" runat="server">

        <div class="container">
            <div class="container btn">
            <h2 class ="">Add Product</h2>
            <asp:ImageButton
                runat="server"
                class =""
                imageurl="~/Pictures/placeHolderPerson.png"
                width="100px"
                height="100px" 
                PostBackUrl="~/Pages/ProductManagement/Add_Product.aspx"/>
            </div>

            <div class="container btn">
            <h2 class="">Modify Product</h2>
            <asp:ImageButton
                runat="server"
                class="" 
                imageurl="~/Pictures/placeHolderModifyPerson.png"
                width="100px"
                height="100px"/>
            </div>

            <div class="container btn">
            <h2 class="">Remove Product</h2>
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
