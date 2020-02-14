<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AzureLogin.aspx.cs" Inherits="ADAzureUserAuthentication.AzureLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabelMsg" runat="server" Text="Label" ForeColor="#003399"></asp:Label>
        </div>
        <br />
        <div>
            <asp:Button ID="btnLogin" runat="server" Text="Log In" SkinID="_buttonDefault" CausesValidation="False" OnClick="btnLogin_Click" />
        </div>
    </form>
</body>
</html>
