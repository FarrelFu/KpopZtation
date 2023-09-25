using KpopZtation.Handler;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Controller
{
    public class customercont
    {
        public static Customer getCustomerbyID(int id)
        {
            return customerhand.getCustomerbyID(id);
        }
        public static bool addCustomer(string nama, string email, string pass, string gen, string add)
        {
            if (nama.Equals("") || email.Equals("") || pass.Equals("") || gen.Equals("") || add.Equals(""))
            {
                return false;
            }
            else if(nama.Length < 5 || nama.Length > 50)
            {
                return false;
            }
            else if(customerepo.uniqueCustomert(email) == false)
            {
                return false;
            }
            else if (!(pass.Any(char.IsDigit) && pass.Any(char.IsLetter))){
                return false;
            }
            else if (!add.EndsWith("Street"))
            {
                return false;
            }
            return customerhand.addCustomer(nama, email, pass, gen, add);
        }

        public static bool updateProfile(int id, string name, string email, string gender, string ad, string pass)
        {
            if (name.Equals("") || email.Equals("") || pass.Equals("") || gender.Equals("") || ad.Equals(""))
            {
                return false;
            }
            else if (name.Length < 5 || name.Length > 50)
            {
                return false;
            }
            else if (customerepo.uniqueCustomert(email) == false)
            {
                return false;
            }
            else if (!(pass.Any(char.IsDigit) && pass.Any(char.IsLetter)))
            {
                return false;
            }
            else if (!ad.EndsWith("Street"))
            {
                return false;
            }
            return customerhand.updateProfile(id, name, email, gender, ad, pass);
        }
    }
}