<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="KpopZtation.View.UpdateProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Profile Update</h1>
        <div>
            <asp:Label ID="lblProfile_Name" runat="server" Text="Name: "></asp:Label>
            <asp:TextBox ID="txtProfile_Name" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblProfile_Email" runat="server" Text="Email: "></asp:Label>
            <asp:TextBox ID="txtProfile_Email" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblProfile_Gender" runat="server" Text="Gender: "></asp:Label>
            <asp:RadioButton ID="Male" runat="server" GroupName="GenderGroup"/>Male &nbsp; <asp:RadioButton ID="Female" runat="server" GroupName="GenderGroup"/>Female
        </div>
        <div>
            <asp:Label ID="lblProfile_Address" runat="server" Text="Address: "></asp:Label>
            <asp:TextBox ID="txtProfile_Address" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblProfile_Password" runat="server" Text="Password: "></asp:Label>
            <asp:TextBox ID="txtProfile_Password" runat="server"></asp:TextBox>
        </div>
        <br/>
            <asp:Button ID="BtnProfile_Update" runat="server" Text="Udpdate" onclick="BtnProfile_Update_Click"/>
            <asp:Button ID="btnback" runat="server" Text="Back" onclick="btnback_Click"/>
        <br/>
        <asp:Label ID="lblProfile_Msg" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
