using KpopZtation.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class albumrepo
    {
        static localDBEntities db = new localDBEntities();

        public static List<Album> getAllAlbum()
        {
            return db.Albums.ToList();
        }

        public static Album getAlbumbyID(int id)
        {
            return db.Albums.Find(id);
        }

        public static bool updateAlbum(int id, string name, string des, int price, int stock, string image)
        {
            Album album = getAlbumbyID(id);

            album.AlbumName = name;
            album.AlbumDescription = des;
            album.AlbumPrice = price;
            album.AlbumStock = stock;
            album.AlbumImage = image;

            db.SaveChanges();
            return true;

        }

        public static bool deleteAlbum(int id)
        {
            Album album = getAlbumbyID(id);

            if (album != null)
            {
                db.Albums.Remove(album);
                db.SaveChanges();

                return true;
            }
            return false;
        }

        public static Album loadalbum(int id)
        {
            return (from i in db.Albums where i.AlbumID == id select i).FirstOrDefault();
        }

        public static bool addAlbum(int id, string name, string description, int price, int stock, string image)
        {
            Album album = albumfact.createAlbum(id, name, description, price, stock, image);
            db.Albums.Add(album);
            db.SaveChanges();

            return true;
        }
    }
}