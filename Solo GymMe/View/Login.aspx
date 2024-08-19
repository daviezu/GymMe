<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Solo_GymMe.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Login Page</h1>
        <asp:Label ID="lblMessage" runat="server" Forecolor="Red"/>
        <div>
            <asp:Label ID="lblUsername" Text="Username" runat="server" />
            <asp:TextBox ID="txtUsername" runat="server" />
        </div>
        <div>
            <asp:Label ID="lblPassword" Text="Password" runat="server" />
            <asp:TextBox ID="txtPassword" runat="server" />
        </div>
        <div>
            <asp:CheckBox ID="chkRememberMe" Text="Remember Me" runat="server" />
        </div>
        <div>
            <asp:Button ID="btnLogin" Text="Login" runat="server" OnClick="btnLogin_Click" />
        </div>
        <div>
            <asp:HyperLink NavigateUrl="~/View/Register.aspx" runat="server">Don't have an account yet? Register Here </asp:HyperLink> 
        </div>
    </form>
</body>
</html>
