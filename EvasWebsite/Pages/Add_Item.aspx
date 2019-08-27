<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add_Item.aspx.cs" Inherits="EvasWebsite.Pages.Add_Item" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link rel="stylesheet" type="text/css" href="../CSS/main.css"/>
    <title>Add Product</title>
</head>
<body>
    <form id="frmAddItem" runat="server">
        <div class ="topForm">
            <h1>Add Item</h1>
            <p>
            <asp:Label
                class = "Labels"
                id    = "lblTitle"
                text  = "Title:"
                runat = "server" />

            <asp:TextBox
                class = "Inputs"
                id    = "txtTitle"
                runat = "server"/>
            </p>
            <p>
            <asp:Label
                class = "Labels"
                id    = "lblDescription"
                text  = "Description:"
                runat = "server" />

            <asp:TextBox
                class     = "Inputs"
                id        = "txtDescription"
                multiline = "true"
                textMode  = "MultiLine"
                runat     = "server" />
            </p>
            <p>
            <asp:Label
                class = "Labels"
                id    = "lblCost"
                text  = "Cost:"
                runat = "server" />
            <asp:TextBox
                class = "Inputs"
                id    = "txtCost"
                runat = "server" />
            </p>
            <p>
            <asp:Label
                class = "Labels"
                id    = "lblUp"
                text  = "Upload picture" 
                runat = "server" />

            <asp:FileUpload
                class = "Inputs"
                id    = "upPicture"
                runat = "server" />
            </p>
            <h2>Preview</h2>
            <p>
            <asp:Label
                class  = "Labels"
                id     = "lblPicPre"
                text   = "Title"
                runat  = "server" />
            <asp:Label
                class  = "Inputs"
                id     = "lblTitlePre"
                text   = ""
                runat  = "server" />
            </p>
            <p>
            <asp:Label
                class  = "Labels"
                id     = "lblDescriptionPre"
                text   = "Description"
                runat  = "server" />
            <asp:Label
                class  = "Inputs"
                id     = "lblDescriptionPost"
                text   = ""
                runat  = "server" />
            </p>
            <p>
            <asp:Label
                class = "Labels"
                id    = "lblQuantity1"
                text  = "Quantity"
                runat = "server" />

            <asp:Label
                class  = "Inputs"
                id     = "lblQuantityPre"
                text   = ""
                runat  = "server" />  
            </p>
            <p>
            <asp:Label
                class  = "Labels"
                id     = "lblCost1"
                text   = "Cost"
                runat  = "server" />
            <asp:Label
                class  = "Inputs"
                id     = "lblCostPre"
                runat  = "server"  />
            </p>
            <p>
            <asp:Image
                class  = "Images"
                id     = "imgPicturePreview"
                src    = ""
                runat  = "server" />
            </p>
            <p>
            <asp:Button 
                class   = "Buttons"
                id      = "btnAdd"
                text    = "Add"
                runat   = "server" 
                OnClick = "btnAdd_Click" />
            </p>
                        
            <asp:Label
                id    = "lblError"
                text  = "" 
                runat = "server" />

        </div>
    </form>
</body>
</html>
