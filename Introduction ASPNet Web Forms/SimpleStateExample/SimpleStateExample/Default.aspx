<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Sime State Example"></asp:Label>
        <hr />
        <asp:Button ID="BtnSetCar" runat="server" OnClick="BtnSetCar_Click" Text="Set Favorite Car" />
        <asp:TextBox ID="txtFavCar" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnGetCar" runat="server" OnClick="btnGetCar_Click" Text="Get Favorite Car" />
        <asp:Label ID="lblFavCar" runat="server"></asp:Label>
    </form>
</body>
</html>
