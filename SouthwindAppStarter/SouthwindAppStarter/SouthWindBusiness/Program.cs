using SouthwindApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouthWindBusiness
{
   public class Program
    {
        static CRUDManager _crudManager;

        static void Main(string[] args)
        {
            //var c = new CRUDManager();

            //foreach (var item in c.RetrieveAllCustomers())
            //{
            //    Console.WriteLine($"{item.ContactName}");
            //}

            using (var db = new SouthwindContext())
            {

               // _crudManager = new CRUDManager();
               // _crudManager.CreateCustomer("Manda", "Nish Mandal","Birmingham","UK","BE6 9HF", "Nish","Password" );

                //Console.WriteLine(AuthenticationManager.AuthIsCorrect("Nish","Password"));



            }

        }
    }
}
