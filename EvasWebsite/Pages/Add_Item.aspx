<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add_Item.aspx.cs" Inherits="EvasWebsite.Pages.Add_Item" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link rel="stylesheet" type="text/css" href="CSS/main.css">
    <title>Add Product</title>
</head>
<body>
    <form id="frmAddItem" runat="server">
        <div>
            <asp:Label
                id    = "lblTitle"
                text  = "Title:"
                runat = "server" />

            <asp:TextBox
                id    = "txtTitle"
                runat = "server"/>

            <asp:Label
                id    = "lblDescription"
                text  = "Description:"
                runat = "server" />

            <asp:TextBox
                id    = "txtDescription"
                runat = "server"/>
            
            <asp:Label
                id    = "lblUp"
                text  = "Upload picture" 
                runat = "server" />

            <asp:FileUpload
                id    = "upPicture"
                runat = "server" />

            <asp:Button 
                id    = "btnAdd"
                text  = "Add"
                runat = "server" OnClick="btnAdd_Click" />

            <asp:Label
                id    = "lblError"
                text  = "" 
                runat = "server" />

        </div>
    </form>
</body>
</html>
