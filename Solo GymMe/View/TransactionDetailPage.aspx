<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master/Template.Master" AutoEventWireup="true" CodeBehind="TransactionDetailPage.aspx.cs" Inherits="Solo_GymMe.View.TransactionDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Transaction Detail</h1>
    <asp:GridView ID="TransactionDetailGV" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="TransactionID" HeaderText="TransactionID" SortExpression="TransactionID" />
        <asp:BoundField DataField="SupplementID" HeaderText="SupplementID" SortExpression="SupplementID" />
        <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
    </Columns>
</asp:GridView>
</asp:Content>
