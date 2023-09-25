<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="KpopZtation.View.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblname" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="txtname" runat="server"></asp:TextBox> 
            <br />
            <asp:Label ID="lblemail" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="txtemail" runat="server"></asp:TextBox> 
            <br />
            <asp:Label ID="lblgen" runat="server" Text="Gender"></asp:Label> 
            <asp:RadioButton ID="RadioButton1" Text="Male" runat="server" />
            <asp:RadioButton ID="RadioButton2" Text="Female" runat="server" />
            <br />
            <asp:Label ID="lbladd" runat="server" Text="Address"></asp:Label> <br />
            <asp:TextBox ID="txtadd" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblpass" runat="server" Text="Password"></asp:Label> <br />
            <asp:TextBox ID="txtpass" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnregis" runat="server" Text="Register" onclick="btnregis_Click"/>
            <br />
            <asp:Label ID="lblerror" runat="server" Text=""></asp:Label>
        
        </div>
    </form>
</body>
</html>
