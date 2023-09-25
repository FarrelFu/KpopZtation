<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AlbumDetail.aspx.cs" Inherits="KpopZtation.View.AlbumDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Album Detail</h1>

          
         

            <br />
            <br />


            <asp:Label ID="Label1" runat="server" Text="Album Name = "></asp:Label>
            <asp:Label ID="lblAlbumName" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Description = "></asp:Label>
            <asp:Label ID="lblAlbumDescription" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Price = "></asp:Label>
            <asp:Label ID="lblAlbumPrice" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Stock = "></asp:Label>
            <asp:Label ID="lblAlbumStock" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Quantity to add : "></asp:Label>
            <asp:TextBox ID="txtAlbumQuantity" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnAddToCart" runat="server" Text="Add to cart" onclick="btnAddToCart_Click"/>
            <br />
            <br />
            <asp:Label ID="lblInfoText" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
