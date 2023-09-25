using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    
    public partial class Login : System.Web.UI.Page
    {
        public localDBEntities db;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                db = new localDBEntities();
                Customer customer = new Customer();
                ContentPlaceHolder NavBarGuest = (ContentPlaceHolder)Master.FindControl("NavbarGuest");
                NavBarGuest.Visible = true;
            }
        }
        protected void HomeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            localDBEntities db = new localDBEntities();
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            bool isRemember = cbRemember.Checked;

            Customer user = db.Customers.FirstOrDefault(x => x.CustomerEmail.Equals(email) && x.CustomerPassword.Equals(password));

            if (user != null)
            {
                Session["user"] = user;
                if (isRemember)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = user.CustomerID.ToString();

                    cookie.Expires = DateTime.Now.AddHours(3);
                    Response.Cookies.Add(cookie);
                }

                Response.Redirect("Home.aspx");
            }
            else
            {
                lblError.Text = "Invalid email and password";
            }
        }
    }
}