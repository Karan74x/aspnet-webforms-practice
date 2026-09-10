<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ValidatorsExample._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Label ID="Label2" runat="server" BackColor="#000066" BorderColor="#333333" BorderStyle="Solid" BorderWidth="2px" ForeColor="White" Height="43px" Text="STUDENT REGISTERATION " Font-Size="Large" Width="292px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<br />
<br />
<br />
<asp:Label ID="Label1" runat="server" Text="STUDENT Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="TextBox1" runat="server" Width="193px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RequiredFieldValidator 
        ID="RequiredFieldValidator1" 
        runat="server"
        ErrorMessage=" Student Name is required"
        ControlToValidate=TextBox1 ForeColor="Red"></asp:RequiredFieldValidator>
<br />
<br />
<br />
<asp:Label ID="Label3" runat="server" Text="STUDENT AGE"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="TextBox2" runat="server" Width="193px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RangeValidator ID="RangeValidator1" 
        runat="server" 
        ErrorMessage="Age must be  in between 0 and 90"
        ControlToValidate=TextBox2
        MinimumValue="0" MaximumValue="90" ForeColor="Red"></asp:RangeValidator>
    &nbsp;&nbsp;
<br />
<br />
<br />
<asp:Label ID="Label4" runat="server" Text="STUDENT ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="TextBox3" runat="server" Width="193px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RequiredFieldValidator 
        ID="RequiredFieldValidator2" 
        runat="server" 
        ErrorMessage="Student ID is Required" ControlToValidate="TextBox3"  ForeColor="Red"></asp:RequiredFieldValidator>
    
    <br />
    
    <br />
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
    <asp:CustomValidator ID="CustomValidator1" 
        runat="server"
        ErrorMessage="Student ID must start with ST"
        ControlToValidate="TextBox3"
        OnServerValidate="CustomValidator1_ServerValidate"
        ForeColor="Red"></asp:CustomValidator>

&nbsp;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="Button1" runat="server" Height="57px" Text="Register" Font-Size="Large" Width="192px" BackColor="#33CC33" ForeColor="Black" BorderColor="Black" BorderStyle="Solid" BorderWidth="3px" OnClick="Button1_Click" />
    <br />
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Label ID="Label5" runat="server"></asp:Label>
    <br />
<br />
<br />
<br />
<asp:ValidationSummary ID="ValidationSummary1" runat="server" Height="80px" />
<br />
<br />
&nbsp;

</asp:Content>
