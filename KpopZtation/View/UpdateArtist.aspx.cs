using KpopZtation.Controller;
using System;
using System.IO;

namespace KpopZtation.View
{
    public partial class UpdateArtist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { 
                int id = int.Parse(Request.QueryString["id"]);
            Artist artist = artistcont.getArtistbyID(id);

                txtname.Text = artist.ArtistName;
                txtimage.Text = artist.ArtistImage;
                 }
            
        }

        protected void btnup_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            int size = flArtistImage.PostedFile.ContentLength;
            string extension = Path.GetExtension(txtimage.Text);

            if (artistcont.updateArtist(id, txtname.Text, txtimage.Text, size, extension))
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
            Response.Redirect("Home.aspx");
        }

        protected void sbmtpht_Click(object sender, EventArgs e)
        {
            txtimage.Text = flArtistImage.FileName;
        }
    }
}