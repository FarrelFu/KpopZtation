<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="KpopZtation.View.CartPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h1>Shopping Cart</h1>
            <br />
            <br />

            
            <table border="1">

                <tr>
                    <th>Picture</th>
                    <th>Album Name</th>
                    <th>Quantity</th>
                    <th>Price</th>
                    <th>Delete</th>
                </tr>

                <% foreach (var i in albumList)
                    {%>

                <tr>
                    <td>
                        <%= i.Album.AlbumImage %>
                    </td>
                    <td>
                        <%= i.Album.AlbumName %>
                    </td>
                    <td>
                        <% Response.Write(i.Qty); %>
                    </td>
                    <td>
                        <%= i.Album.AlbumPrice %>
                    </td>
                    <td>
                        <asp:Button ID="btnDelete" runat="server" Text="Delete"  onclick="btnDelete_Click"/>
                    </td>
                </tr>

                <%} %>

            </table>

            <br />

            <asp:Button ID="btnCheckOut" runat="server" Text="Checkout" onclick="btnCheckOut_Click"/>


        </div>
    </form>
</body>
</html>
