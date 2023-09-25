<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="KpopZtation.View.TransactionHistory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <div>

            <h1> Transaction History </h1>
            <br />
            <br />

                <table border="1">

                <tr>
                    <th>Transaction ID</th>
                    <th>Date</th>
                    <th>Customer Name</th>
                    <th>Image</th>
                    <th>Album Name</th>
                    <th>Album Quantity</th>
                    <th>Album Price</th>
                </tr>

                <% foreach (var i in transactionList)
                    {%>

                <tr>
                    <td>
                        <% Response.Write(i.TransactionID); %>
                    </td>
                    <td>
                        <%= i.TransactionHeader.TransactionDate %>
                    </td>
                    <td>
                        <%= i.TransactionHeader.Customer.CustomerName %>
                    </td>
                    <td>
                        <%= i.Album.AlbumImage %>
                        
                    </td>
                    <td>
                        <%= i.Album.AlbumName %>
                    </td>
                    <td>
                        <%= i.Qty %>
                    </td>
                     <td>
                        <%= i.Album.AlbumPrice %>
                    </td>
                </tr>

                <%} %>

            </table>


        </div>
        </div>
    </form>
</body>
</html>
