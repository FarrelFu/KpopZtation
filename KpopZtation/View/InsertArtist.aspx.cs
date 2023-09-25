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
    public partial class InsertArtist : System.Web.UI.Page
    {
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string artist_name = txtArtistName.Text;
            string artist_img = flArtistImage.FileName;
            int size = flArtistImage.PostedFile.ContentLength;
            string extension = Path.GetExtension(flArtistImage.FileName);

            if(artistcont.addArtist(artist_name, artist_img, size, extension))
            {
                lblMsgInsertArtist.Text = "insert success";
                txtArtistName.Text = null;
                

            }
        }

        protected void btnback_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }
}