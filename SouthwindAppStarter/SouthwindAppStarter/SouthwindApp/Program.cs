using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
namespace SouthwindApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SouthwindContext())
            {
                //Create customer
                //Console.WriteLine("Creating 2 Customers");
                //db.Add(new Customer {
                //    CustomerId = "MANDA",
                //    City = "Birmingham", 
                //    ContactName = "Nish mandal", 
                //    Country = "UK",
                //    PostalCode = "B74BB" });

                //db.Add(new Customer {
                //    CustomerId = "FRENC",
                //    City = "Birmingham", 
                //    ContactName = "Cathy French",
                //    Country = "UK", 
                //    PostalCode = "B74Bs" });
                //db.SaveChanges();

                //Read 
                //Console.WriteLine("Querying for a customer");

                //var customerQuery = db.Customers.OrderBy(c => c.ContactName);

                //var customer = customerQuery.Where(c => c.ContactName.Contains("Cath")).FirstOrDefault();

                //Console.WriteLine($"Customer Details: {customer.ContactName} lives in {customer.City}");

                //update customer

                //var nish1 = db.Customers.Find("MANDA");
                //nish1.City = "London";
                //db.SaveChanges();

                //Find a customer and create an order for them

                //var nish2 = db.Customers.Find("MANDA");
                //nish1.Orders.Add(new Order { CustomerId = "MANDA", OrderDate = DateTime.Now, ShipCountry = "Brazil" });
                //db.SaveChanges();

                //Create an order amd associate ot with a customer
                //var nish3 = db.Customers.Find("MANDA");
                //var order1 = new Order { OrderDate = DateTime.Now, ShipCountry = "India", Customer = nish3 };
                //db.SaveChanges();

                //Add some order details to a list and associate it to an order

                //var order = db.Orders.Find(1);

                //var orderDetails1 = new OrderDetail { UnitPrice = 30.00m, Discount = 0.5F, Quantity = 2 };
                //var orderDetails2 = new OrderDetail { UnitPrice = 30.00m, Discount = 0.25F, Quantity = 1 };

                //var orderDetailsList = new List<OrderDetail>();
                //orderDetailsList.Add(orderDetails1);
                //orderDetailsList.Add(orderDetails2);

                //order.OrderDetails = orderDetailsList;

                //db.SaveChanges();

                //Include the list of orders when a customer is retrieved

                //var custQuery = db.Customers.OrderBy(c => c.ContactName);

                //foreach (var c in custQuery.Include(c => c.Orders))
                //{
                //    Console.WriteLine($"{c.ContactName} lives in {c.City}");
                //    if (c.Orders.Count > 0)
                //    {
                //        foreach (var item in c.Orders)
                //        {
                //            Console.WriteLine($"\tOrder {item.OrderId} by {item.Customer.ContactName}"
                //                + $" was made on {item.OrderDate.Value.Date}");
                //        }
                //    }
                //}

                //Another query but using methon syntax and THEN INCLUDe

                //var orderDetails = db.OrderDetails.Include(od => od.Order).ThenInclude(c => c.Customer);
                //orderDetails.ToList().ForEach(od => Console.WriteLine($"{od.Order.Customer.ContactName} made an order" +
                //    $" with id {od.Order.OrderId} with the unit proce of {od.UnitPrice} without discount"));



            }
        }
    }
}
