﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Modify_Product.aspx.cs" Inherits="EvasWebsite.Pages.ProductManagement.Modify_Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <link rel="stylesheet"
        href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"
        integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"
        crossorigin="anonymous" />

    <title>Modify Products</title>
    <script src="../../Scripts/jquery/jquery.js"></script>

    <!-- add a script here
        that takes people's emails
        and signs them up for a news letter
        same thing for when they pay
    -->
</head> 
<body>    
    <meta name="viewport" content="width=device-width, initial-scale=1.0,shrink-to-fit=no" />
    <form id="frmModify" 
          runat="server">
        <div class = "container">
            <table class ="table">
                <asp:Literal
                    id="productTable"
                    runat="server" />
            </table>
        </div>
        <div class ="container">
            <asp:TextBox
                class ="form-control-inline"
                placeholder ="ID"
                id ="txtID"
                type="number"
                runat="server" OnTextChanged="txtID_TextChanged" AutoPostBack="True" />
            <asp:TextBox
                class ="form-control-inline"
                placeholder ="Title"
                id ="txtTitle"
                type="text"
                runat="server" />
            <asp:TextBox
                class ="form-control-inline"
                placeholder ="Description"
                id ="txtDesc"
                type="text"
                runat="server" />
            <asp:TextBox
                class ="form-control-inline"
                placeholder ="Quantity"
                id ="txtQuan"
                type="number"
                runat="server" />
            <asp:TextBox
                class ="form-control-inline"
                placeholder ="Cost"
                id ="txtCost"
                type="number"
                runat="server" />
            <asp:FileUpload
                class ="form-control-file"
                id ="upPicture"
                type="number"
                runat="server" />
            </div>
            <div class ="container">
            <asp:Button
                class ="btn btn-primary"
                id ="btnModify"
                text ="Modify"
                OnClick ="btnModify_Click"
                runat="server" />
            <asp:Button
                class ="btn btn-danger"
                id ="btnDelete"
                text ="Delete"
                OnClick ="btnDelete_Click"
                runat="server" />
                </div>
        </form>
</body>
</html>
