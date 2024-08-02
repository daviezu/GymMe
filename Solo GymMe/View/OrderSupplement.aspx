<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master/Template.Master" AutoEventWireup="true" CodeBehind="OrderSupplement.aspx.cs" Inherits="Solo_GymMe.View.OrderSupplement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Supplement List</h1>
    <asp:Label ID="lblMessage" Text="" runat="server" ForeColor="Red"/>
    <asp:GridView ID="OrderSuppGV" runat="server" AutoGenerateColumns="False" DataKeyNames="SupplementID">
        <Columns>
            <asp:BoundField DataField="SupplementName" HeaderText="Name" SortExpression="SupplementName" />
            <asp:BoundField DataField="SupplementExpiryDate" HeaderText="Expiry Date" SortExpression="SupplementExpiryDate" />
            <asp:BoundField DataField="SupplementPrice" HeaderText="Price" SortExpression="SupplementPrice" />
            <asp:BoundField DataField="SupplementTypeID" HeaderText="TypeID" SortExpression="SupplementTypeID" />
            <asp:TemplateField HeaderText="Quantity">
                <ItemTemplate>
                    <asp:TextBox ID="txtQuantity" runat="server" />
                    <asp:Button ID="btnOrder" Text="Order" runat="server" OnClick="btnOrder_Click" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        
    </asp:GridView>
    <div>
        <h1>Cart</h1>
        <asp:GridView ID="CartGV" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="CartID" HeaderText="CartID" SortExpression="CartID" />
                <asp:BoundField DataField="UserID" HeaderText="UserID" SortExpression="UserID" />
                <asp:BoundField DataField="SupplementID" HeaderText="SupplementID" SortExpression="SupplementID" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
            </Columns>

        </asp:GridView>
    </div>
</asp:Content>
