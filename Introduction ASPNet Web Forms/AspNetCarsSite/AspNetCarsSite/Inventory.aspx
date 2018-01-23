<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Inventory.aspx.cs" Inherits="AspNetCarsSite.WebForm2" Async="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DropDownList ID="cboMake" runat="server" AppendDataBoundItems="True" AutoPostBack="True" DataTextField="Make" DataValueField="Make" SelectMethod="GetMake"><asp:ListItem Value="" Text="(All)" />
    </asp:DropDownList>
    <asp:GridView ID="GridView1" runat="server" CellPadding="3" AutoGenerateColumns="False" ItemType="AutoLotDAL.Models.Inventory" SelectMethod="GetData" EmptyDataText="There are no data records to display" GridLines="None" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellSpacing="1" Width="400px" DataKeyNames="CarId" DeleteMethod="Delete" UpdateMethod="Update" AllowPaging="True" AllowSorting="True" PageSize="8">
        <Columns>
            <asp:BoundField DataField="CarID" HeaderText="CarID" ReadOnly="true" SortExpression="CarID" />
            <asp:BoundField DataField="Make" HeaderText="Make" SortExpression="Make" />
            <asp:BoundField DataField="Color" HeaderText="Color" SortExpression="Color" />
            <asp:BoundField DataField="PetName" HeaderText="PetName" SortExpression="PetName" />
            <asp:CommandField ShowEditButton="True" />
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
        <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
        <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#594B9C" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#33276A" />
    </asp:GridView>
</asp:Content>
