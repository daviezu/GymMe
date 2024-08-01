<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertSupplement.aspx.cs" Inherits="Solo_GymMe.View.InsertSupplement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Insert Supplement Page</h1>
        <div>
            <asp:Label ID="lblMessage" Text="" runat="server" ForeColor ="Red"/>
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
    </form>
</body>
</html>
