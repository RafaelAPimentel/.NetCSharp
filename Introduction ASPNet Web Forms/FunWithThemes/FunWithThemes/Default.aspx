<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Button3" runat="server" Text="No Theme" OnClick="Button3_Click"  />
&nbsp;<asp:Button ID="Button5" runat="server" Text="Green Theme" OnClick="Button5_Click" />
&nbsp;<asp:Button ID="Button4" runat="server"  SkinID="BigFontButton" Text="Orange Theme" OnClick="Button4_Click" />
        <br />
        <br />
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button2" SkinID="BigFontButton" Text="Big Font" runat="server" />
    </form>
</body>
</html>
