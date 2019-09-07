﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Store.aspx.cs"
    Inherits="EvasWebsite.Pages.Store" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet"
        href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"
        integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"
        crossorigin="anonymous" />

    <title>Store</title>
    <script src="../../Scripts/jquery/jquery.js"></script>

    <!-- add a script here
        that takes people's emails
        and signs them up for a news letter
        same thing for when they pay
    -->
</head>
<body>
    <form id="frmStore" runat="server">
        <div class="cotainer" id="product_holder">
            <div class="container">
                <asp:Literal
                    runat="server"
                    ID="mainStore">
                </asp:Literal>
            </div>
        </div>
        <div class="container">
            <asp:Label
                runat="server"
                ID="lblError"
                class="alert alert-danger" />
        </div>
    </form>
</body>
</html>
