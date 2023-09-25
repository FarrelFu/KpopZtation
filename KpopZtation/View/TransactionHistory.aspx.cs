using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class TransactionHistory : System.Web.UI.Page
    {
        public List<TransactionDetail> transactionList = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            transactionList = transactionrepo.getTransaction();
        }
    }
}