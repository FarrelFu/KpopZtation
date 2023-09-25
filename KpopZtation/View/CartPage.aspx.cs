using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class CartPage : System.Web.UI.Page
    {
        public List<Cart> albumList = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            albumList = cartrepo.getCart();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Response.Redirect("homeNonAdmin.aspx");
        }

        protected void btnCheckOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("TransactionHistory.aspx");
        }
    }
}