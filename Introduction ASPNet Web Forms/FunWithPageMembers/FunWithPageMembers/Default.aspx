<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FunWithPageMembers.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 338px">
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="BtnGetBrowserStats" runat="server" OnClick="BtnGetBrowserStats_Click" Text="Get Stats" />
        </div>
        <asp:Label ID="lblOutput" runat="server" Text="label"></asp:Label>
        <p>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <asp:Button ID="btnGetFormData" runat="server" OnClick="btnGetFormData_Click" Text="Get First Name" />
        </p>
        <br />
        <asp:Button runat="server" ID="btnHttpResponse"
            OnClick="btnHttpResponse_Click" Text="Get First Name" />
        <asp:Button runat="server" ID="btnWasteTime"
            OnClick="btnWasteTime_Click" Text="Go to Facebook" />
    </form>
</body>
</html>
