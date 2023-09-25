using KpopZtation.Handler;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Controller
{
    public class artistcont
    {
        public static List<Artist> getAllArtist()
        {
            return artisthand.getAllArtist();
        }

        public static Artist getArtistbyID(int id)
        {
            return artisthand.getArtistbyID(id);
        }

        public static bool updateArtist(int id, string name, string image, int size, string extend)
        {
            if (name.Equals("") || image.Equals(""))
            {
                return false;
            }
            else if (artistrepo.uniqueArtist(name) == false)
            {
                return false;
            }
            else if (size > 2000000)
            {
                return false;
            }
            else if (extend != ".png" && extend!= ".jpg" && extend != ".jpeg" && extend != ".jfif")
            {
                return false;
            }
            return artisthand.updateArtist(id,name,image);
        }

        public static bool deleteArtist(int id)
        {
            return artisthand.deleteArtist(id);
        }

        public static bool addArtist(string name, string img, int size, string extend)
        {
            if (name.Equals("") || img.Equals(""))
            {
                return false;
            }
            else if (artistrepo.uniqueArtist(name) == false)
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
            return artisthand.addArtist(name, img);
        }
    }
}