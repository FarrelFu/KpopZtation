using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class customerhand
    {
        public static Customer getCustomerbyID(int id)
        {
            return customerepo.getCustomerbyID(id);
        }
        public static bool addCustomer(string nama, string email, string pass, string gen, string add)
        {
            return customerepo.addCustomer(nama, email, pass, gen, add);

            return true;
        }

        public static bool updateProfile(int id, string name, string email, string gender, string ad, string pass)
        {
            return customerepo.updateProfile(id, name, email, gender, ad, pass);
        }
    }
}