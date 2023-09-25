﻿<%@ Page Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="KpopZtation.View.Home" enableEventValidation="false"%>


  <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
    <asp:Content ID="Content2" ContentPlaceHolderID="NavbarGuest" runat="server">
        <asp:Button ID="HomeBtn" runat="server" Text="Home" OnClick="HomeBtn_Click" />
        <asp:Button ID="RegisterBtn" runat="server" Text="Register" OnClick="RegisterBtn_Click" />
        <asp:Button ID="LoginBtn" runat="server" Text="Login" OnClick="LoginBtn_Click" />
    </asp:Content>

    <asp:Content ID="Content3" ContentPlaceHolderID="NavbarCustomer" runat="server">
        <asp:Button ID="HomeBtn2" runat="server" Text="Home" OnClick="HomeBtn2_Click" />
        <asp:Button ID="CartBtn" runat="server" Text="Cart" OnClick="CartBtn_Click" />
        <asp:Button ID="TransactionBtn" runat="server" Text="Transaction" OnClick="TransactionBtn_Click" />
        <asp:Button ID="UpdateProfileBtn" runat="server" Text="Update Profile" OnClick="UpdateProfileBtn_Click" />
        <asp:Button ID="LogOutBtn" runat="server" Text="Log Out" OnClick="LogOutBtn_Click" />
    </asp:Content>

    <asp:Content ID="Content4" ContentPlaceHolderID="NavbarAdmin" runat="server">
        <asp:Button ID="HomeBtn3" runat="server" Text="Home" OnClick="HomeBtn3_Click" />
        <asp:Button ID="TransactionBtn2" runat="server" Text="Transaction" OnClick="TransactionBtn2_Click" />
        <asp:Button ID="UpdateProfileBtn2" runat="server" Text="Update Profile" OnClick="UpdateProfileBtn2_Click" />
        <asp:Button ID="LogOutBtn2" runat="server" Text="Log Out" OnClick="LogOutBtn2_Click" />
    </asp:Content>
    <asp:Content ID="Content5" ContentPlaceHolderID="WebsiteContent" runat="server">
        <asp:GridView ID="artistGV" runat="server" AutoGenerateEditButton="false" AutoGenerateDeleteButton="true"  onRowEditing="artistGV_RowEditing1" onRowdeleting="artistGV_RowDeleting" >
            <Columns>
        
        <asp:CommandField ButtonType="Button" ShowEditButton="true" EditText="Update"/>
                  <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btncard" runat="server" Text="CARD" onclick="btncard_Click"/>
                     </ItemTemplate>
                    </asp:TemplateField>

            </Columns>
        </asp:GridView>
        <asp:Button ID="Button2" runat="server" Text="Insert Artist" onclick="Button1_Click1"/>
    </asp:Content>