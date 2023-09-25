using KpopZtation.Controller;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class UpdateAlbum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request.QueryString["id"]);
                Album album = albumcont.getAlbumbyID(id);

                txtname.Text = album.AlbumName;
                txtdes.Text = album.AlbumDescription;
                txtprice.Text = album.AlbumPrice.ToString();
                txtstock.Text = album.AlbumStock.ToString();
                txtimage.Text = album.AlbumImage;
            }
        }

        protected void sbmtpht_Click(object sender, EventArgs e)
        {
            txtimage.Text = flArtistImage.FileName;
        }

        protected void btnup_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            string name = txtname.Text;
            string des = txtdes.Text;
            int price = int.Parse(txtprice.Text);
            int stock = int.Parse(txtstock.Text);
            int size = flArtistImage.PostedFile.ContentLength;
            string extension = Path.GetExtension(txtimage.Text);

            if(albumcont.updateAlbum(id, name, des, price, stock, txtimage.Text, size, extension))
            {
                message.Text = "Update success";
            }
            else
            {
                message.Text = "Update failed, check your input!";

            }
        }

        protected void btnback_Click(object sender, EventArgs e)
        {
            Response.Redirect("ArtistDetail.aspx");
        }
    }
}