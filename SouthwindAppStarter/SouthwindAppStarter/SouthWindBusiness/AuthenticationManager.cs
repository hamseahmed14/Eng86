using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SouthwindApp;

namespace SouthWindBusiness
{
    public class AuthenticationManager
    {
        public string AuthIsCorrect(string username, string password)
        {
            using (var db = new SouthwindContext())
            {
                var selectedCustomer = db.Customers.Where(c => c.Username == username && c.Password == password).ToList();
                if(selectedCustomer.Count != 0)
                {
                    foreach (var cus in selectedCustomer)
                    {
                        return cus.CustomerId;
                    }
                    
                }
                return "Incorrect Credentials";
            }
        }


        public char GetRole(string cred)
        {
            using (var db = new SouthwindContext())
            {
                var role = db.Customers.Where(c => c.CustomerId == cred).ToList();

                foreach (var item in role)
                {
                    return item.Role;
                }

                return ' ';
            }
        }
    }
}
