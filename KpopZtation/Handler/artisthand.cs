using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class artisthand
    {
       
            public static List<Artist> getAllArtist()
            {
                return artistrepo.getAllArtist();
            }

            public static Artist getArtistbyID(int id)
            {
                return artistrepo.getArtistbyID(id);
            }

            public static bool updateArtist(int id, string name, string image)
            {
                return artistrepo.updateArtist(id, name, image);
            }
            public static bool deleteArtist(int id)
            {
                return artistrepo.deleteArtist(id);
            }
            public static bool addArtist(string name, string img)
            {
            return artistrepo.addArtist(name, img);
            }
    }
    
}