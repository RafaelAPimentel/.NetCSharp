<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidationGroups.aspx.cs" Inherits="ValidatorCtrls.ValidationGroups" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <asp:Panel ID="Panel1" runat="server" Height="83px" Width="296px">
                <asp:TextBox ID="txtRequiredField" runat="server" ValidationGroup="FirstGroup"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Required field!" ControlToValidate="txtRequiredField" ValidationGroup="FirstGroup"></asp:RequiredFieldValidator>
                <br />
                <asp:Button ID="btnValidateRequired" runat="server" Text="Validate" ValidationGroup="FirstGroup" OnClick="btnValidateRequired_Click" />
            </asp:Panel>

            <asp:Panel ID="Panel2" runat="server" Height="119px" Width="295px">
                <asp:TextBox ID="txtSSN" runat="server" ValidationGroup="SecondGroup"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="*Need SSN" ControlToValidate="txtSSN" ValidationExpression="\d{3}-\d{2}-\d{4}" ValidationGroup="SecondGroup"></asp:RegularExpressionValidator>
                &nbsp
                <br />
                <asp:Button ID="btnValidateSSN" runat="server" Text="Validate" OnClick="btnValidateSSN_Click" ValidationGroup="SecondGroup" />
            </asp:Panel>
    </form>
</body>
</html>
