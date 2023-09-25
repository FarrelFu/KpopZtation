<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="KpopZtation.View.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="NavbarGuest" runat="server">
    <asp:Button ID="HomeBtn" runat="server" Text="Home" OnClick="HomeBtn_Click" />
    <asp:Button ID="RegisterBtn" runat="server" Text="Register" OnClick="RegisterBtn_Click" />
    <asp:Button ID="Button1" runat="server" Text="Login" OnClick="LoginBtn_Click" />
</asp:Content>

<asp:Content ID="Content5" ContentPlaceHolderID="WebsiteContent" runat="server">
    <div>
        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <br />
    </div>
    <div>
        <asp:CheckBox ID="cbRemember" runat="server" Text="Remember Me" />
    </div>
    <div>
        <asp:Button ID="loginBtn" runat="server" Text="Login" Onclick="loginBtn_Click"/>
    </div>

    <div>
        <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>
    </div>
</asp:Content>
