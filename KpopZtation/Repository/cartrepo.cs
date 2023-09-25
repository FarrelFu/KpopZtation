using KpopZtation.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class cartrepo
    {
        static localDBEntities db = new localDBEntities();
        public static string addQuantity(int quantity, int id_album, int id_customer)
        {
            Cart cart = cartfact.createCart(quantity, id_album, id_customer);
            db.Carts.Add(cart);
            db.SaveChanges();

            return "Item berhasil dimasukkan ke dalam cart";
        }

        public static List<Cart> getCart()
        {
            return (from i in db.Carts select i).ToList();
        }

        public static Album getAlbumByID(int id)
        {
            Album albumc = (from i in db.Albums where i.AlbumID == id select i).FirstOrDefault();
            return albumc;
        }
        public static Cart getCartbyID(int albumid)
        {
            return db.Carts.Find(albumid);
        }
        public static bool deleteCart(int albumid)
        {
            Cart cart = getCartbyID(albumid);

            if (cart != null)
            {
                db.Carts.Remove(cart);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}