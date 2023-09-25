using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class albumhand
    {
        public static List<Album> getAllAlbum()
        {
            return albumrepo.getAllAlbum();
        }

        public static Album getAlbumbyID(int id)
        {
            return albumrepo.getAlbumbyID(id);
        }

        public static bool updateAlbum(int id, string name, string des, int price, int stock, string image)
        {
            return albumrepo.updateAlbum(id, name, des, price, stock, image);

        }

        public static bool deleteAlbum(int id)
        {
            return albumrepo.deleteAlbum(id);
        }
        public static bool addAlbum(int id, string name, string description, int price, int stock, string image)
        {
            return albumrepo.addAlbum(id, name, description, price, stock, image);

            return true;
        }
    }
}