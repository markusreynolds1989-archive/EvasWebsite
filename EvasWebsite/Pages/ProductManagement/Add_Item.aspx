<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add_Item.aspx.cs" Inherits="EvasWebsite.Pages.Add_Item" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css" />
    <link rel="stylesheet" type="text/css" href="../CSS/main.css" />
    <title>Add Product</title>
    <script src="../Scripts/jQuery.js"></script>
    <script>
        /* Validation Functions, we could also use C# */
        /* TODO: Finish validation */
        /* string => string => int => int => string => boolean */
        let Title = $('#txtTitle').val();
        let Description = $('#txtQuantity').val();

        const validation = (title
            , description
            , quantity
            , cost
            , picturePath) => {
            if (1 == 1) {
                return true;
            } else {
                return false;
            }
        }
    </script>
</head>
<body>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <form id="frmAddItem" runat="server">
        <div class="w3-container w3-center">
            <h1>Add Item</h1>
            <p>
                <asp:TextBox
                    class="w3-input"
                    ID="txtTitle"
                    placeholder="Title"
                    runat="server" />
            </p>
            <p>
                <asp:TextBox
                    class="w3-input"
                    ID="txtDescription"
                    multiline="true"
                    TextMode="MultiLine"
                    placeholder="Description"
                    runat="server" />
            </p>
            <p>
                <asp:TextBox
                    class="w3-input"
                    ID="txtQuantity"
                    multiline="true"
                    placeholder="Quantity"
                    runat="server" />
            </p>
            <p>
                <asp:TextBox
                    class="w3-input"
                    ID="txtCost"
                    placeholder="Cost"
                    runat="server" />
            </p>
            <p>
                <asp:Label
                    ID="lblUp"
                    Text="Upload picture"
                    runat="server" />

                <asp:FileUpload
                    class="w3-input"
                    ID="upPicture"
                    runat="server" />
            </p>
            <div class="w3-container w3-card-4 w3-margin w3-white">
                <h2>Preview</h2>
                <h3>
                    <asp:Label
                        ID="lblTitlePre"
                        Text=""
                        runat="server" />
                </h3>
                <p>
                    <asp:Image
                        class="w3-image"
                        ID="imgPicturePreview"
                        runat="server"
                        height="200"
                        widht="200"/>
                </p>
                <p>
                    <asp:Label
                        ID="lblDescriptionPre"
                        Text=""
                        runat="server" />
                </p>
                <p>
                    <asp:Label
                        ID="lblQuantityPre"
                        Text=""
                        runat="server" />
                </p>
                <p>
                    <asp:Label
                        ID="lblCostPre"
                        runat="server" />
                </p>
            </div>
            <p>
                <asp:Button
                    class="w3-btn w3-blue w3-round"
                    ID="btnPreview"
                    Text="Preview"
                    runat="server"
                    OnClick="btnPreview_Click" />
            </p>
            <p>
                <asp:Button
                    class="w3-btn w3-green w3-round"
                    ID="btnAdd"
                    Text="Add"
                    runat="server"
                    OnClick="btnAdd_Click" />
            </p>
            <p>
                <asp:HyperLink
                    class="w3-button w3-grey w3-round"
                    runat="server"
                    NavigateUrl="~/Pages/Store.aspx">
                    Go to Store
                </asp:HyperLink>
            </p>
            <asp:Label
                class="w3-panel w3-red"
                ID="lblError"
                Text=""
                runat="server" 
                visible ="false"/>
        </div>
    </form>
</body>
</html>
