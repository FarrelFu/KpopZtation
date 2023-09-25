<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertArtist.aspx.cs" Inherits="KpopZtation.View.InsertArtist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblArtistName" runat="server" Text="Artist name : "></asp:Label>
            <asp:TextBox ID="txtArtistName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblArtistImg" runat="server" Text="Artist image : "></asp:Label>
            
            <asp:FileUpload ID="flArtistImage" runat="server" />
            <br />
            <asp:Button ID="btnInsert" runat="server" Text="Insert" onclick="btnInsert_Click" />
            <asp:Button ID="btnback" runat="server" Text="Back" onclick="btnback_Click"/>
            <br />
            <asp:Label ID="lblMsgInsertArtist" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
