using KpopZtation.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class artistrepo
    {
        static localDBEntities db = new localDBEntities();

        public static List<Artist> getAllArtist()
        {
            return db.Artists.ToList();
        }

        public static Artist getArtistbyID(int id)
        {
            return db.Artists.Find(id);
        }

        public static bool updateArtist(int id, string name, string image)
        {
            Artist artist = getArtistbyID(id);

            artist.ArtistName = name;
            artist.ArtistImage = image;

            db.SaveChanges();
            return true;
        }

        public static bool uniqueArtist(string name)
        {
            foreach (var y in db.Artists)
            {
                if (name.Equals(y.ArtistName))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool deleteArtist(int id)
        {
            Artist artist = getArtistbyID(id);

            if (artist != null)
            {
                db.Artists.Remove(artist);
                db.SaveChanges();

                return true;
            }
            return false;
        }

        public static bool addArtist(string name, string img)
        {
            Artist artist = artistfact.createArtist(name, img);
            db.Artists.Add(artist);
            db.SaveChanges();

            return true;
        }

    }
}