using KpopZtation.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{

    
    public class customerepo
    {
        static localDBEntities db = new localDBEntities();

        public static Customer getCustomerbyID(int id)
        {
            return db.Customers.Find(id);
        }

        public static bool addCustomer(string nama, string email, string pass, string gen, string add)
        {
            Customer customer = customerfact.createCustomer(nama, email, pass, gen, add);
            db.Customers.Add(customer);
            db.SaveChanges();

            return true;
        }

        public static bool uniqueCustomert(string email)
        {
            if (!(db.Customers == null))
            {
                foreach (var y in db.Customers)
                {
                    if (email.Equals(y.CustomerEmail))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool updateProfile(int id, string name, string email, string gender, string ad, string pass)
        {
            Customer customer = getCustomerbyID(id);
            customer.CustomerName = name;
            customer.CustomerEmail = email;
            customer.CustomerGender = gender;
            customer.CustomerAddress = ad;
            customer.CustomerPassword = pass;
            
            db.SaveChanges();
            return true;
        }
    }
}