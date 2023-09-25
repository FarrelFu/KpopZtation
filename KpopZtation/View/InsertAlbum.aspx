<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertAlbum.aspx.cs" Inherits="KpopZtation.View.InsertAlbum" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Insert Album</h1>
        <div>
            <asp:Label ID="lblAlbumName" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="txtAlbumName" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblAlbumDescription" runat="server" Text="Description"></asp:Label>
            <asp:TextBox ID="txtAlbumDescription" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblAlbumPrice" runat="server" Text="Price"></asp:Label>
            <asp:TextBox ID="txtAlbumPrice" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblAlbumStock" runat="server" Text="Stock"></asp:Label>
            <asp:TextBox ID="txtAlbumStock" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblAlbumImage" runat="server" Text="Image"></asp:Label>
            <asp:FileUpload ID="flAlbumImage" runat="server"/>
        </div>
        <br/>
        <asp:Button ID="insertBtn" runat="server" Text="Insert" onclick="insertBtn_Click"/>
            <asp:Button ID="backbtn" runat="server" Text="Back" onclick="backbtn_Click"/>
        <br/>
        <asp:Label ID="lblMsgInsertAlbum" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
