using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public class customerfact
    {
        public static Customer createCustomer(string name, string email, string pass, string gen, string add)
        {
            Customer customer = new Customer();
            customer.CustomerName = name;
            customer.CustomerEmail = email;
            customer.CustomerPassword = pass;
            customer.CustomerGender = gen;
            customer.CustomerAddress = add;
            customer.CustomerRole = "User";

            return customer;
        }
    }
}