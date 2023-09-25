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
    public partial class InsertAlbum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void insertBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            string name = txtAlbumName.Text;
            string description = txtAlbumDescription.Text;
            int price = int.Parse(txtAlbumPrice.Text);
            int stock = int.Parse(txtAlbumStock.Text);
            string image = flAlbumImage.FileName;
            int size = flAlbumImage.PostedFile.ContentLength;
            string extension = Path.GetExtension(flAlbumImage.FileName);

            if (albumcont.InsertAlbum(id, name, description, price, stock, image, extension, size)){
                lblMsgInsertAlbum.Text = "insert success";
                txtAlbumName.Text = "";
                txtAlbumDescription.Text = "";
                txtAlbumPrice.Text = "";
                txtAlbumStock.Text = "";
            }
        }

        protected void backbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ArtistDetail.aspx");
        }
    }
}