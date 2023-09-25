using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public class albumfact
    {
        public static Album createAlbum(int artistid, string name, string description, int price, int stock, string image)
        {
            Album album = new Album();
            album.ArtistID = artistid;
            album.AlbumName = name;
            album.AlbumDescription = description;
            album.AlbumPrice = price;
            album.AlbumStock = stock;
            album.AlbumImage = image;

            return album;
        }
    }
}