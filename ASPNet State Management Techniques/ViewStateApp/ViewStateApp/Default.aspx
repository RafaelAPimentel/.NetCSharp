<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" EnableViewState="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="myListBox" runat="server">
        </asp:ListBox>
        <br />
        <asp:Button ID="btnPostBack" runat="server" Text="Button" />
        <br />
        <br />
        <asp:Button ID="btnAddToVS" runat="server" OnClick="btnAddToVS_Click" Text="Button" />
        <asp:Label ID="lblVSValue" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
