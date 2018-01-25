<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ValidatorCtrls.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 540px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 517px">
            <asp:Label ID="Label5" runat="server" Text="Fun with ASP.NET Validator" Font-Bold="True" Font-Size="X-Large"></asp:Label>
            <hr />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Required Field:" Font-Bold="True"></asp:Label>
            <br />
            <asp:TextBox ID="txtRequiredField" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtRequiredField" ErrorMessage="Ooops!Need to enter data."></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Range 0-100:" Font-Bold="True"></asp:Label>
            <br />
            <asp:TextBox ID="txtRange" runat="server" ></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtRange" ErrorMessage="Please enter valid value between 0 and 100" MaximumValue="100" MinimumValue="0" Type="Integer"></asp:RangeValidator>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Enter your US SSN:" Font-Bold="True"></asp:Label>
            <br />
            <asp:TextBox ID="txtRegExp" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtRegExp" ErrorMessage="Please enter valid US SSN." ValidationExpression="\d{3}-\d{2}-\d{4}"></asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Value &lt; 20:" Font-Bold="True"></asp:Label>
            <br />
            <asp:TextBox ID="txtComparison" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtComparison" ErrorMessage="Enter a value less than 20." Operator="LessThan" Type="Integer" ValueToCompare="20"></asp:CompareValidator>
            <br />
            <br />
            <asp:Button ID="btnPostBack" runat="server" OnClick="btnPostBack_Click" Text="PostBack" />
            <asp:Label ID="lblValidationComplete" runat="server"></asp:Label>
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Here are the things you must correct" />
        </div>
    </form>
</body>
</html>
