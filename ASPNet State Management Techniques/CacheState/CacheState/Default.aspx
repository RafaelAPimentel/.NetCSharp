<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="The Add New Car Page"></asp:Label>
        <hr />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Make"></asp:Label>
        <asp:TextBox ID="txtCarMake" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Color"></asp:Label>
        <asp:TextBox ID="txtCarColor" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Pet Name"></asp:Label>
        <asp:TextBox ID="txtCarPetName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnAddCar" runat="server" OnClick="btnAddCar_Click" Text="Add This Car" />
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Enter Id of car"></asp:Label>
        <asp:TextBox ID="txtCarToDelete" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Delete Car" OnClick="Button1_Click" />
        <br />
        <br />
        <hr />
        <br />
        <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Current Inventory"></asp:Label>
        <br />
        <asp:GridView ID="carsGridView" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
