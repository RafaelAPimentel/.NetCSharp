<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Fun with Cookies"></asp:Label>
        <hr />
        <asp:Label ID="Label2" runat="server" Text="Cookie Name:"></asp:Label>
        <asp:TextBox ID="txtCookieName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Cookie Value:"></asp:Label>
        <asp:TextBox ID="txtCookieValue" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnCookie" runat="server" Text="Write this Cookie" OnClick="btnCookie_Click" />
        <hr />
        <br />
        <asp:Button ID="btnShowCookie" runat="server" Text="Show Cookie Data" OnClick="btnShowCookie_Click" />
        <br />
        <asp:Label ID="lblCookieData" runat="server"></asp:Label>
    </form>
</body>
</html>
