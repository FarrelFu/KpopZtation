using KpopZtation.Controller;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class AlbumDetail : System.Web.UI.Page
    {
        
        int id_customer = 2;
        protected void Page_Load(object sender, EventArgs e)
        {

            int id = int.Parse(Request.QueryString["id"]);

            Album album = albumrepo.loadalbum(id);


            string album_name = album.AlbumName;
            string album_description = album.AlbumDescription;
            int album_price = album.AlbumPrice;
            int album_stock = album.AlbumStock;

            lblAlbumName.Text = album_name;
            lblAlbumDescription.Text = album_description;
            lblAlbumPrice.Text = album_price.ToString();
            lblAlbumStock.Text = album_stock.ToString();
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            string album_quantity = txtAlbumQuantity.Text;
            int album_stock = int.Parse(lblAlbumStock.Text);
            int id = int.Parse(Request.QueryString["id"]);

            string Msg_Info = cartcont.addQuantity(album_quantity, album_stock, id, id_customer);

            lblInfoText.Text = Msg_Info;
        }
    }
}