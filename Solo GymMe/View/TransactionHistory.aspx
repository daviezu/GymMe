<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master/Template.Master" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="Solo_GymMe.View.TransactionHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Transaction History</h1>
    <asp:GridView ID="TransactionHistoryGV" runat="server" AutoGenerateColumns="False" DataKeyNames="TransactionID">
        <Columns>
            <asp:BoundField DataField="TransactionID" HeaderText="TransactionID" SortExpression="TransactionID" />
            <asp:BoundField DataField="UserID" HeaderText="UserID" SortExpression="UserID" />
            <asp:BoundField DataField="TransactionDate" HeaderText="TransactionDate" SortExpression="TransactionDate" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="btnDetail" Text="Detail" runat="server" OnClick="btnDetail_Click"/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
