using KpopZtation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class homeNonAdmin : System.Web.UI.Page
    {
        public localDBEntities db;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                db = new localDBEntities();
                ContentPlaceHolder NavBarGuest = (ContentPlaceHolder)Master.FindControl("NavbarGuest");
                ContentPlaceHolder NavBarUser = (ContentPlaceHolder)Master.FindControl("NavbarCustomer");
                ContentPlaceHolder NavBarAdmin = (ContentPlaceHolder)Master.FindControl("NavbarAdmin");
                if (Session["user"] != null && Session["user"] is Customer)
                {
                    Customer customer = (Customer)Session["user"];
                    if (customer.CustomerRole == "User")
                    {
                        NavBarUser.Visible = true;
                        NavBarAdmin.Visible = false;
                        NavBarGuest.Visible = false;
                    }
                    else if (customer.CustomerRole == "Admin")
                    {
                        NavBarUser.Visible = false;
                        NavBarAdmin.Visible = true;
                        NavBarGuest.Visible = false;
                    }
                }
                else
                {
                    NavBarUser.Visible = false;
                    NavBarAdmin.Visible = false;
                    NavBarGuest.Visible = true;
                }
            }

            artistGV.DataSource = artistcont.getAllArtist();
            artistGV.DataBind();
        }

        protected void btncard_Click(object sender, EventArgs e)
        {
            Button btncrd = (Button)sender;
            GridViewRow row = (GridViewRow)btncrd.NamingContainer;
            int id = int.Parse(row.Cells[3].Text);
            Response.Redirect("~/View/ArtistDetail.aspx?id=" + id);
        }


        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("InsertArtist.aspx");
        }


        protected void HomeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomeNonAdmin.aspx");
        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void HomeBtn2_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomeNonAdmin.aspx");
        }

        protected void CartBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("CartPage.aspx");
        }

        protected void TransactionBtn_Click(object sender, EventArgs e)
        {
            int id = 2;
            Response.Redirect("Transaction.aspx?id=" + id);
        }

        protected void UpdateProfileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProfile.aspx");
        }

        protected void LogOutBtn_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Home.aspx");
        }

        protected void HomeBtn3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void TransactionBtn2_Click(object sender, EventArgs e)
        {
            Response.Redirect("TransactionReport.aspx");
        }

        protected void UpdateProfileBtn2_Click(object sender, EventArgs e)
        {
            int id = 2;
            Response.Redirect("Transaction.aspx?id=" + id);
        }

        protected void LogOutBtn2_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Home.aspx");
        }
    }
}