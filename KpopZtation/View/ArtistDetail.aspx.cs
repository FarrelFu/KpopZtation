using KpopZtation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class ArtistDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            albumGV.DataSource = albumcont.getAllAlbum();
            albumGV.DataBind();

            if (!IsPostBack)
            {
                int id = int.Parse(Request.QueryString["id"]);
                Artist artist = artistcont.getArtistbyID(id);

                dname.Text = artist.ArtistName;
                dimage.Text = artist.ArtistImage;
            }
        }

        protected void albumGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = albumGV.Rows[e.NewEditIndex];

            int id = int.Parse(row.Cells[3].Text);
            Response.Redirect("~/View/UpdateAlbum.aspx?id=" + id);
        }

        protected void albumGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = albumGV.Rows[e.RowIndex];
            int id = int.Parse(row.Cells[3].Text);
            albumcont.deleteAlbum(id);
            albumGV.DataSource = albumcont.getAllAlbum();
            albumGV.DataBind();
        }

        protected void btncard_Click(object sender, EventArgs e)
        {
            Button btncrd = (Button)sender;
            GridViewRow row = (GridViewRow)btncrd.NamingContainer;
            int id = int.Parse(row.Cells[3].Text);
            Response.Redirect("~/View/AlbumDetail.aspx?id=" + id);
        }

        protected void btninsert_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            Response.Redirect("~/View/InsertAlbum.aspx?id=" + id);
        }
    }
}