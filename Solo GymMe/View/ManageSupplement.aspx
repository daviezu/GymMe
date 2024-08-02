<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master/Template.Master" AutoEventWireup="true" CodeBehind="ManageSupplement.aspx.cs" Inherits="Solo_GymMe.View.ManageSupplement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="ManageSuppGV" runat="server" AutoGenerateColumns="False" DataKeyNames="SupplementID" OnRowUpdating="ManageSuppGV_RowUpdating" OnRowDeleting="ManageSuppGV_RowDeleting">
        <Columns>
            <asp:BoundField DataField="SupplementName" HeaderText="Name" SortExpression="SupplementName" />
            <asp:BoundField DataField="SupplementExpiryDate" HeaderText="Expiry Date" SortExpression="SupplementExpiryDate" />
            <asp:BoundField DataField="SupplementPrice" HeaderText="Price" SortExpression="SupplementPrice" />
            <asp:BoundField DataField="SupplementTypeID" HeaderText="TypeID" SortExpression="SupplementTypeID" />
            <asp:ButtonField ButtonType="Button" CommandName="Delete" Text="Delete" />
            <asp:ButtonField ButtonType="Button" CommandName="Update" Text="Update" />
        </Columns>

    </asp:GridView>
    <asp:Button ID="btnInsert" Text="Insert a new supplement" runat="server" OnClick="btnInsert_Click" />
    <asp:Label ID="lblMessage" Text="" runat="server" ForeColor="Red" />
</asp:Content>
