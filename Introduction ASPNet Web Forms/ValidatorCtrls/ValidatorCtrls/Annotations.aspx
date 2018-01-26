<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Annotations.aspx.cs" Inherits="ValidatorCtrls.Annotations" %>
<!DOCTYPE html>
<%@import Namespace="ValidatorCtrls.App_Code" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:FormView ID="fvDataBinding" runat="server" DefaultMode="Insert" InsertMethod="SaveCar" ItemType="Inventory" SelectMethod="GetCar" UpdateMethod="UpdateCar">
            <ItemTemplate>

                <table style="width: 100%">
                    <tr>
                        <td>
                            <asp:Label runat="server" AssociatedControlID="make">Make:</asp:Label>
                        </td>
                        <td>
                            <asp:Label runat="server" ID="make" Text='<%# Item.Make %>' /></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" AssociatedControlID="color">Color:</asp:Label></td>
                        <td>
                            <asp:Label runat="server" ID="color" Text='<%#: Item.Color %>' /></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" AssociatedControlID="petname">Pet Name:</asp:Label></td>
                        <td>
                            <asp:Label runat="server" ID="petname" Text='<%#: Item.PetName %>' /></td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />&nbsp;
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
            <EditItemTemplate>
                <table style="width: 100%">
                    <tr>
                        <td>
                            <asp:Label runat="server" AssociatedControlID="make">Make: </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="make" Text='<%# BindItem.Make %>' />
                            <asp:ModelErrorMessage ModelStateKey="make" runat="server" ForeColor="Red" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" AssociatedControlID="color">Color: </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="color" Text='<%#: BindItem.Color %>' />
                            <asp:ModelErrorMessage ModelStateKey="color" runat="server" ForeColor="Red" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" AssociatedControlID="petname">Pet Name: </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="petname" runat="server" Text='<%#: BindItem.PetName %>' />
                            <asp:ModelErrorMessage ModelStateKey="petname" runat="server" ForeColor="Red" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Button runat="server" CommandName="Update" Text="Save" />
                            <asp:Button runat="server" CommandName="Cancel" Text="Cancel" CausesValidation="false" />
                        </td>
                    </tr>
                </table>
            </EditItemTemplate>
            <InsertItemTemplate>
                <table style="width: 100%">
                    <tr>
                        <td>
                            <asp:Label runat="server" AssociatedControlID="make">Make: </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="make" Text='<%#: BindItem.Make %>' />
                            <asp:ModelErrorMessage ModelStateKey="make" runat="server" ForeColor="Red" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" AssociatedControlID="color">Color: </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="color" Text='<%#: BindItem.Color %>' />
                            <asp:ModelErrorMessage ModelStateKey="color" runat="server" ForeColor="Red" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label runat="server" AssociatedControlID="petname">Pet Name: </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="petname" runat="server" Text='<%#: BindItem.PetName %>' />
                            <asp:ModelErrorMessage ModelStateKey="petname" runat="server" ForeColor="Red" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Button runat="server" CommandName="Insert" Text="Save" />
                        </td>
                    </tr>
                </table>
            </InsertItemTemplate>
        </asp:FormView>
        <asp:ValidationSummary runat="server" ShowModelStateErrors="true" ForeColor="Red" HeaderText="Please check the following errors:" />
    </form>
</body>
</html>
