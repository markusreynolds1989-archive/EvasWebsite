<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="EvasWebsite.Pages.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="frmMain" runat="server">
        <div>
            <asp:Label runat="server" 
                ID ="label" />

            <asp:Button runat="server" 
                ID ="test" 
                Text ="Hello World" 
                OnClick="test_Click"/>
        </div>
    </form>
</body>
</html>
