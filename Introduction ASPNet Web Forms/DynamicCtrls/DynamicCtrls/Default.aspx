<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DynamicCtrls.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 397px">
    <form id="form1" runat="server">
        <div>
            <hr />
            <h1>Dynamic Controls</h1>
            <asp:Label ID="lblTextBoxText" runat="server" Text="Label"></asp:Label>
        </div>
        <!--THE PANEL HAS THREE CONTAINED CONTOLS-->
            <asp:Panel ID="MyPanel" runat="server" width="200px"
                BorderColor="Black" BorderStyle="Solid">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Button" /><br />
                <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>
            </asp:Panel>
        <br />
        <br />
        <asp:Label ID="lblControlInfo" runat="server"></asp:Label>
    </form>
</body>
</html>
