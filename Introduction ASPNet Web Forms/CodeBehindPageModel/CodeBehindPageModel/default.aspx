﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="CodeBehindPageModel._default" trace="true"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="CarGridView" runat="server" SelectMethod="GetData">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
