using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public class cartfact
    {
        public static Cart createCart(int quantity, int id_album, int id_customer)
        {
            Cart cart = new Cart();
            cart.AlbumID = id_album;
            cart.CustomerID = id_customer;
            cart.Qty = quantity;

            return cart;
        }
    }
}