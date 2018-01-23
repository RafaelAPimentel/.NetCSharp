<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="BuildCar.aspx.cs" Inherits="AspNetCarsSite.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" Text="Use this Wizard to build your Dream Car"></asp:Label>
    <asp:Wizard runat="server" ActiveStepIndex="3" BackColor="#EFF3FB" BorderColor="#B5C7DE" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" OnFinishButtonClick="Wizard1_FinishButtonClick" Width="320px">
        <HeaderStyle BackColor="#284E98" BorderColor="#EFF3FB" BorderStyle="Solid" BorderWidth="2px" Font-Bold="True" Font-Size="0.9em" ForeColor="White" HorizontalAlign="Center" />
        <NavigationButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" />
        <SideBarButtonStyle BackColor="#507CD1" Font-Names="Verdana" ForeColor="White" />
        <SideBarStyle BackColor="#507CD1" Font-Size="0.9em" VerticalAlign="Top" />
        <StepStyle Font-Size="0.8em" ForeColor="#333333" />
        <WizardSteps>
            <asp:WizardStep runat="server" title="Pick Your Model">
                <asp:TextBox ID="txtCarModel" runat="server"></asp:TextBox>
            </asp:WizardStep>
            <asp:WizardStep runat="server" title="Pick Your Color">
                <asp:ListBox ID="ListBoxColors" runat="server" Width="237px">
                    <asp:ListItem>Purple</asp:ListItem>
                    <asp:ListItem>Green</asp:ListItem>
                    <asp:ListItem>Red</asp:ListItem>
                    <asp:ListItem Value="Yellow">Yellow</asp:ListItem>
                    <asp:ListItem>Pea</asp:ListItem>
                    <asp:ListItem>Black</asp:ListItem>
                    <asp:ListItem>Lime</asp:ListItem>
                </asp:ListBox>
            </asp:WizardStep>
            <asp:WizardStep runat="server" Title="Name Your Car">
                <asp:TextBox ID="txtCarPetName" runat="server"></asp:TextBox>
            </asp:WizardStep>
            <asp:WizardStep runat="server" Title="Delivery Date">
                <asp:Calendar ID="carCalendar" runat="server"></asp:Calendar>
            </asp:WizardStep>
        </WizardSteps>
    </asp:Wizard>
    <asp:Label ID="lblOrder" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="X-Large" ForeColor="Black"></asp:Label>
</asp:Content>
