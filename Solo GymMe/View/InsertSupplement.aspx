<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master/Template.Master" AutoEventWireup="true" CodeBehind="InsertSupplement.aspx.cs" Inherits="Solo_GymMe.View.InsertSupplement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    <h1>Insert Supplement Page</h1>
    <div>
        <asp:Label ID="lblMessage" Text="" runat="server" ForeColor="Red" />
    </div>
    <div>
        <asp:Label ID="lblSupplementName" Text="Name" runat="server" />
        <asp:TextBox ID="txtSupplementName" runat="server" />
    </div>
    <div>
        <asp:Label ID="lblExpDate" Text="Expiry Date" runat="server" />
        <asp:Calendar ID="calDOB" runat="server" OnSelectionChanged="calDOB_SelectionChanged"></asp:Calendar>
        <asp:TextBox ID="txtExpDate" runat="server" />
    </div>
    <div>
        <asp:Label ID="lblSupplementPrice" Text="Price" runat="server" />
        <asp:TextBox ID="txtSupplementPrice" runat="server" />
    </div>
    <div>
        <asp:Label ID="lblTypeID" Text="Type ID" runat="server" />
        <asp:TextBox ID="txtTypeID" runat="server" />
    </div>
    <div>
        <asp:Button ID="btnInput" Text="Input" runat="server" OnClick="btnInput_Click" />
        <asp:Button ID="btnBack" Text="Back" runat="server" OnClick="btnBack_Click" />
    </div>
</div>
</asp:Content>
