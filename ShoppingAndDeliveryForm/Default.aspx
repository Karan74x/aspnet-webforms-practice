<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ShoppingAndDeliveryForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="Label1" runat="server" Text="Product"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple">
        <asp:ListItem>Mouse</asp:ListItem>
        <asp:ListItem>Speaker</asp:ListItem>
        <asp:ListItem>Laptop</asp:ListItem>
        <asp:ListItem>CPU</asp:ListItem>
    </asp:ListBox>
    <br />
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Quantity"></asp:Label>
&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Delivery Options"></asp:Label>
&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem>Deliver To Door</asp:ListItem>
        <asp:ListItem>Deliver To Security</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Payment Options"></asp:Label>
    <br />
    <br />
    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
        <asp:ListItem>UPI</asp:ListItem>
        <asp:ListItem>COD</asp:ListItem>
    </asp:RadioButtonList>
    <br />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label5" runat="server"></asp:Label>
    <br />
    <br />

</asp:Content>
