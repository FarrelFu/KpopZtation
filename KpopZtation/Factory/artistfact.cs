using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public class artistfact
    {
        public static Artist createArtist(string name, string image)
        {
            Artist artist = new Artist();
            artist.ArtistName = name;
            artist.ArtistImage = image;

            return artist;
        }
    }
}