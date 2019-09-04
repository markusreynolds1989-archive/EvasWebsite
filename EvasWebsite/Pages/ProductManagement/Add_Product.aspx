<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add_Product.aspx.cs" Inherits="EvasWebsite.Pages.Add_Item" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous" />

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
            /*use a regex to deteremine if they contain numbers/letters/symbols*/
            if (title.compare(title, REGEXNUM));
            if (description == null) {
                return false;
            }
            if (quantity == null || quantity == string) {
                return false;
            }
            if (cost == null || cost == string) {
            }
            if (picturePath == null) {
                return false;
            } else {
                return true;
            }
        }
    </script>
</head>
<body>
    <meta name="viewport" content="width=device-width, initial-scale=1.0,shrink-to-fit=no" />
    <form id="frmAddItem" runat="server">
        <div class="form-group">
            <div class="container">
                <h1>Add Item</h1>
                <asp:TextBox
                    class="form-control"
                    ID="txtTitle"
                    placeholder="Title"
                    runat="server" />
            </div>
            <div class="container">
                <asp:TextBox
                    class="form-control"
                    ID="txtDescription"
                    multiline="true"
                    TextMode="MultiLine"
                    placeholder="Description"
                    runat="server" />
            </div>
            <div class="container">
                <asp:TextBox
                    class="form-control"
                    ID="txtQuantity"
                    multiline="true"
                    placeholder="Quantity"
                    runat="server" />
            </div>
            <div class="container">
                <asp:TextBox
                    class="form-control"
                    ID="txtCost"
                    placeholder="Cost"
                    runat="server" />
            </div>
            <div class="container">
                <label for="upPicture">Please upload a picture:</label>
                <asp:FileUpload
                    class="form-control-file"
                    ID="upPicture"
                    runat="server"
                    type="file" />
            </div>
        </div>
        <div class="container ">
            <h2>Preview</h2>
            <div class="card">
                <asp:Image
                    class="card-img-top"
                    ID="imgPicturePreview"
                    runat="server"
                    alt="preview image"
                    Height="300"
                    widht="100" />
                <div class="card-title">
                    <h5>
                        <asp:Label
                            ID="lblTitlePre"
                            Text=""
                            runat="server" />
                    </h5>
                    <div class="card-body">
                        <p>
                            <asp:Label
                                ID="lblDescriptionPre"
                                Text=""
                                runat="server" />
                        </p>
                        <p>
                            <label>Quantity: </label>
                            <asp:Label
                                ID="lblQuantityPre"
                                Text=""
                                runat="server" />
                        </p>
                        <p>
                            <label>Cost: </label>
                            <asp:Label
                                ID="lblCostPre"
                                runat="server" />
                        </p>
                    </div>
                </div>
            </div>
            <div class="container">
                <asp:Button
                    class="btn btn-primary"
                    ID="btnPreview"
                    Text="Preview"
                    runat="server"
                    OnClick="btnPreview_Click" />
                <asp:Button
                    class="btn btn-danger"
                    ID="btnClear"
                    Text="Clear"
                    runat="server"
                    OnClick="btnClear_Click" />
                <asp:Button
                    class="btn btn-success"
                    ID="btnAdd"
                    Text="Add"
                    runat="server"
                    OnClick="btnAdd_Click" />
                <asp:HyperLink
                    class="btn btn-link"
                    runat="server"
                    NavigateUrl="~/Pages/Store.aspx">
                    Go to Store
                </asp:HyperLink>
            </div>
            <br />
            <div class="container">
                <asp:Label
                    class="alert alert-danger"
                    role="alert"
                    ID="lblError"
                    Text=""
                    runat="server" />
            </div>
        </div>
    </form>
</body>
</html>
