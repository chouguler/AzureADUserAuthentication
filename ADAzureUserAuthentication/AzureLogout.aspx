<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AzureLogout.aspx.cs" Inherits="ADAzureUserAuthentication.AzureLogout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="LabelMsg" runat="server" Text="You have been successfully logged out!"></asp:Label>       
    </div>
        <br />
        <br />     
        <asp:Button ID="btnLogin" runat="server" Text="Log In" SkinID="_buttonDefault" CausesValidation="False" OnClick="btnLogin_Click" />
    </form>
</body>
</html>
