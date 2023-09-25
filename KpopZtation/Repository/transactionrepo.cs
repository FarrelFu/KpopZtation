using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class transactionrepo
    {

        public static localDBEntities db = new localDBEntities();

        public static List<TransactionDetail> getTransaction()
        {
            return (from i in db.TransactionDetails select i).ToList();
        }
    }
}