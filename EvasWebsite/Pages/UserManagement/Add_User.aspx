<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add_User.aspx.cs" Inherits="EvasWebsite.Pages.UserManagement.Add_User" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Add User</title>
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css" />
    <link rel="stylesheet" type="text/css" href="../CSS/main.css" />
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
            <h1>Add User</h1>
            <p>
                <asp:TextBox
                    class="w3-input"
                    ID="txtUserName"
                    placeholder="Username"
                    runat="server" />
            </p>
            <p>
                <asp:TextBox
                    class="w3-input"
                    ID="txtPassword"
                    placeholder="Password"
                    runat="server" />
            </p>
            <p>
                <asp:TextBox
                    class="w3-input"
                    ID="txtSecurityLevel"
                    placeholder="Security Level"
                    runat="server" />
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
                    NavigateUrl="~/Pages/UserManagement/User_Management.aspx">
                    User Management
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
