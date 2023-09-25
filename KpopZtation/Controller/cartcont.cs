using KpopZtation.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Controller
{
    public class cartcont
    {
        public static string addQuantity(string quantity, int stock, int id_album, int id_customer)
        {
            if (quantity.Equals(""))
            {
                return "Tolong isi kuantitas album";
            }

            else if (int.Parse(quantity) > stock)
            {
                return "Stok barang tidak cukup";
            }


            return carthand.addQuantity(int.Parse(quantity), id_album, id_customer);
        }

        public static bool deleteCart(int albumid)
        {
            return carthand.deleteCart(albumid);
        }
    }
}