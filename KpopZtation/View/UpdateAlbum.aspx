<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateAlbum.aspx.cs" Inherits="KpopZtation.View.UpdateAlbum" %>

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
            <asp:Label ID="lbldes" runat="server" Text="Description"></asp:Label>
            <asp:TextBox ID="txtdes" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblprice" runat="server" Text="Price"></asp:Label>
            <asp:TextBox ID="txtprice" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblstock" runat="server" Text="Stock"></asp:Label>
            <asp:TextBox ID="txtstock" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblimage" runat="server" Text="Image"></asp:Label>
            <asp:TextBox ID="txtimage" runat="server"></asp:TextBox>
            <asp:FileUpload ID="flArtistImage" runat="server" />
            <asp:Button ID="sbmtpht" runat="server" Text="choose" onclick="sbmtpht_Click"/>
            <br />

            <asp:Button ID="btnup" runat="server" Text="Update" onclick="btnup_Click"/>
            <asp:Button ID="btnback" runat="server" Text="Back" onclick="btnback_Click"/>

            <asp:Label ID="message" runat="server" Text=""></asp:Label>


        </div>
    </form>
</body>
</html>
