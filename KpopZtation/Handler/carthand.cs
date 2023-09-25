using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class carthand
    {
        public static string addQuantity(int quantity, int id_album, int id_customer)
        {
            return cartrepo.addQuantity(quantity, id_album, id_customer);
        }

        public static bool deleteCart(int albumid)
        {
            return cartrepo.deleteCart(albumid);
        }
    }
}