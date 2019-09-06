<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add_User.aspx.cs" Inherits="EvasWebsite.Pages.UserManagement.Add_User" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Add User</title>

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous" />

    <script type = "text/javascript" src ="../../Scripts/jquery/jquery.js"></script>

    <script>
        /* Validation Functions, we could also use C# */
        /* TODO: Finish validation */
        /* string => string => int => int => string => boolean */
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
    <meta name="viewport" content="width=device-width, initial-scale=1.0,shrink-to-fit = no" />
    <form id="frmAddItem" runat="server">
        <div class="form-group">
            <div class="container">
                <h1>Add User</h1>
                <asp:TextBox
                    class="form-control"
                    ID="txtUserName"
                    type ="text"
                    placeholder="Username"
                    runat="server" />
            </div>
            <div class="container">
                <asp:TextBox
                    class="form-control"
                    ID="txtPassword"
                    type="password"
                    placeholder="Password"
                    runat="server" />
            </div>
            <div class="container">
                <asp:TextBox
                    class="form-control"
                    ID="txtSecurityLevel"
                    type="number"
                    placeholder="Security Level"
                    runat="server" />
            </div>
            <div class="container">
                <asp:Button
                    class ="btn btn-success"
                    ID ="btnAdd"
                    Text ="Add"
                    runat="server"
                    OnClick="btnAdd_Click" />

                <input type     ="button"
                       class    ="btn btn-danger"
                       id       ="btnClear"
                       value    ="Clear"
                       onclick  ="btnClear_Click()"/>

                <asp:HyperLink
                    class="btn btn-link"
                    runat="server"
                    NavigateUrl="~/Pages/UserManagement/User_Management.aspx">
                    User Management
                </asp:HyperLink>
                </div>
            <br/>
            <div class="container">
                <asp:Label
                    class="alert alert-danger"
                    ID="lblError"
                    Text=""
                    runat="server"/>
            </div>
        </div>
    </form>

    <script>
        /* all the inputs are runat server, might need to think about that, turn them into post as a possibilty 
         otherwise onclick will be serverside clearing*/
        function btnClear_Click()
        {
            $("#txtUserName").attr("value", "");
            $("#txtPassword").attr("value", "");
            $("#txtSecurityLevel").attr("value", "");
        }
    </script>

</body>
</html>
