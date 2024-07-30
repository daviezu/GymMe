<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Solo_GymMe.View.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Register Page</h1>
        <asp:Label ID="lblMessage" runat="server" ForeColor="Red" />
        <div>
            <asp:Label ID="lblUsername" Text="Username" runat="server" />
            <asp:TextBox ID="txtUsername" runat="server" />
        </div>
        <div>
            <asp:Label ID="lblEmail" Text="Email" runat="server" />
            <asp:TextBox ID="txtEmail" runat="server" />
        </div>
        <asp:Label Text="Gender" runat="server" />
        <asp:DropDownList ID="ddlGender" runat="server">
            <asp:ListItem Value="" Text="Select Gender"></asp:ListItem>
            <asp:ListItem Value="Male" Text="Male"></asp:ListItem>
            <asp:ListItem Value="Female" Text="Female"></asp:ListItem>
        </asp:DropDownList>
        <div>
            <asp:Label ID="lblPassword" Text="Password" runat="server" />
            <asp:TextBox ID="txtPassword" runat="server" />
        </div>
        <div>
            <asp:Label ID="lblConfirmPassword" Text="Confirm Password" runat="server" />
            <asp:TextBox ID="txtConfirmPassword" runat="server" />
        </div>
        <div>
            <asp:Label ID="lblDOB" Text="Date of birth" runat="server" />
            <asp:Calendar ID="calDOB" runat="server" OnSelectionChanged="calDOB_SelectionChanged"></asp:Calendar>
            <asp:TextBox ID="txtDOB" runat="server" ReadOnly="true" />
        </div>
        <div>
            <asp:Button ID="btnRegister" Text="Register" runat="server" OnClick="btnRegister_Click" />
        </div>
        <div>
            <asp:HyperLink NavigateUrl="~/View/Login.aspx" runat="server">Already have an account? Login here</asp:HyperLink>
        </div>
    </form>
</body>
</html>
