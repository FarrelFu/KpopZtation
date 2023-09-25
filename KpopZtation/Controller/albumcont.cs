using KpopZtation.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Controller
{
    public class albumcont
    {
        public static List<Album> getAllAlbum()
        {
            return albumhand.getAllAlbum();
        }

        public static Album getAlbumbyID(int id)
        {
            return albumhand.getAlbumbyID(id);
        }

        public static bool updateAlbum(int id, string name, string des, int price, int stock, string image, int size, string extend)
        {
            if(name.Equals("") || des.Equals("") || price.Equals("") || stock.Equals("") || image.Equals("")){
                return false;
            } 
            else if(name.Length > 50)
            {
                return false;
            } 
            else if(des.Length > 255)
            {
                return false;
            }
            else if(price < 100000 || price > 1000000)
            {
                return false;
            }
            else if (stock < 1)
            {
                return false;
            }
            else if (size > 2000000)
            {
                return false;
            }
            else if (extend != ".png" && extend != ".jpg" && extend != ".jpeg" && extend != ".jfif")
            {
                return false;
            }
            return albumhand.updateAlbum(id, name, des, price, stock, image);

        }

        public static bool deleteAlbum(int id)
        {
            return artisthand.deleteArtist(id);
        }

        public static bool InsertAlbum(int id, string name, string description, int price, int stock, string image, string extension, int fileSize)
        {
            if (name.Equals("") || description.Equals("") || price.Equals(null) || stock.Equals(null))
            {
                return false;
            }

            if (name.Length >= 50)
            {
                return false;
            }

            if (description.Length >= 255)
            {
                return false;
            }

            if (price <= 100000 && price >= 1000000)
            {
                return false;
            }

            if (stock <= 0 && stock < 0)
            {
                return false;
            }

            if (extension != ".png" && extension != ".jpg" && extension != ".jpeg" && extension != ".jfif")
            {
                return false;
            }

            return albumhand.addAlbum(id, name, description, price, stock, image);
        }
    }
}