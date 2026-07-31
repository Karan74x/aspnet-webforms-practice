<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ListBoxExample._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        <asp:Label ID="Label1" runat="server" Text="Hobbies"></asp:Label>
        <br />
&nbsp;&nbsp;
    </p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" SelectionMode="Multiple">
            <asp:ListItem>Meditation</asp:ListItem>
            <asp:ListItem>Reading</asp:ListItem>
            <asp:ListItem>Walk in Nature</asp:ListItem>
            <asp:ListItem>Exercise</asp:ListItem>
        </asp:ListBox>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="CLiCK" OnClick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server"></asp:Label>
    </p>

</asp:Content>
