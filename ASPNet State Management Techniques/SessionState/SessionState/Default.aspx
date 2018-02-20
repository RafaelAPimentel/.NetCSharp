<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Fun with Session State" Font-Bold="True" Font-Size="X-Large"></asp:Label>
        <hr />
        <asp:Label ID="Label2" runat="server" Text="Which color?"></asp:Label>
        <asp:TextBox ID="txtCarColor" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Which make?"></asp:Label>
        <asp:TextBox ID="txtCarMake" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Down Payment?"></asp:Label>
        <asp:TextBox ID="txtDownPayment" runat="server"></asp:TextBox>



        <br />
        <asp:CheckBox ID="chkIsLeasing" runat="server" Text="Lease?" />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Delivery Date:"></asp:Label>
        <asp:Calendar ID="myCalendar" runat="server"></asp:Calendar>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        <br />
        <br />
        <asp:Label ID="lblUserInfo" runat="server"></asp:Label>
    </form>
</body>
</html>
