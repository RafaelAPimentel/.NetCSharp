<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Fun with Application State"></asp:Label>
        <br />
        <hr />
        <br />
        <asp:Button ID="btnShowAppVariables" runat="server" OnClick="btnShowAppVariables_Click" Text="ShowAppVar" />
        <br />
        <br />
        <asp:Label ID="lblAppVariables" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="btnSetSalePerson" runat="server" Text="Set New Sales Person" OnClick="btnSetSalePerson_Click" />
        <asp:TextBox ID="txtSetSalesPerson" runat="server"></asp:TextBox>
    </form>
</body>
</html>
