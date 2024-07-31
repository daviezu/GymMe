<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master/Template.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Solo_GymMe.View.Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1>Profile Page</h1>
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
            <asp:Label ID="lblDOB" Text="Date of birth" runat="server" />
            <asp:Calendar ID="calDOB" runat="server" OnSelectionChanged="calDOB_SelectionChanged"></asp:Calendar>
            <asp:TextBox ID="txtDOB" runat="server" ReadOnly="true" />
        </div>
        <div>
            <asp:Button ID="btnUpdateProfile" Text="Update Profile" runat="server" OnClick="btnUpdateProfile_Click" />
        </div>
    </div>
    <div>
        <div>
            <asp:Label ID="lblOldPassword" Text="Password" runat="server" />
            <asp:TextBox ID="txtOldPassword" runat="server" />
        </div>
        <div>
            <asp:Label ID="lblNewPassword" Text="Confirm Password" runat="server" />
            <asp:TextBox ID="txtNewPassword" runat="server" />
        </div>
        <div>
            <asp:Button ID="btnUpdatePassword" Text="Update Password" runat="server" OnClick="btnUpdatePassword_Click" />
        </div>
    </div>
</asp:Content>
