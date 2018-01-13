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
            <asp:Panel ID="MyPanel" runat="server" width="506px"
                BorderColor="Black" BorderStyle="Solid" Height="182px">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Button ID="MoveNameToLabel" runat="server" OnClick="btnMoveNameToLabel_Click" Text="Button" />
                <br />
                <asp:Label ID="lblTextBoxText" runat="server" Text="Label"></asp:Label>
            </asp:Panel>
        </div>
        <!--THE PANEL HAS THREE CONTAINED CONTOLS-->
        <asp:Button ID="btnAddWidget" runat="server" Text="Add Widget" OnClick="btnAddWidget_Click" />
        <asp:Button ID="btnClearPanel" runat="server" Text="Clear Planel" OnClick="btnClearPanel_Click" />
        <asp:Button ID="btnGetTextData" runat="server" Text="Get Data" OnClick="btnGetTextData_Click"/><br />
        <asp:Label ID="lblControlInfo" runat="server"></asp:Label>
        <asp:Label ID="lblTextBoxData" runat="server"></asp:Label>
        <br />
        <br />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
