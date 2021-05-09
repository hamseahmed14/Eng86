using Microsoft.EntityFrameworkCore;
using SouthwindApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SouthWindBusiness
{
    public class CRUDManager
    {

        public Customer SelectedCustomer { get; set; }
        public Product SelectedProduct { get; set; }


        public void CreateCustomer (string customerID, string contactName,string city, string country, string postcode, string username, string password, char role)
        {
            var newCustomer = new Customer() {CustomerId = customerID, ContactName = contactName, City = city, Country = country,PostalCode = postcode, Username = username, Password = password, Role = role };
            using (var db = new SouthwindContext())
            {
                db.Customers.Add(newCustomer);
                db.SaveChanges();
            }
        }

        public void UpdateCustomer(string  customerID, string contactName, string city, string country, string postcode)
        {

            using (var db = new SouthwindContext())
            {
                SelectedCustomer = db.Customers.Find(customerID);
                SelectedCustomer.ContactName = contactName;
                SelectedCustomer.City = city;
                SelectedCustomer.Country = country;
                SelectedCustomer.PostalCode = postcode;

                db.SaveChanges();
            }
        }

        public void DeleteCustomer(string customerID)
        {
            using (var db = new SouthwindContext())
            {
                var selectedCustomer = db.Customers.Where(c => c.CustomerId == customerID);
                db.Customers.RemoveRange(selectedCustomer);
                db.SaveChanges();
            }  
        }

        public List<Customer> RetrieveAllCustomers()
        {
            using (var db = new SouthwindContext())
            {
                return db.Customers.ToList();
            }
        }

        public List<Product> RetrieveAllProducts()
        {
            using (var db = new SouthwindContext())
            {
               
                return db.Products.ToList();
            }
        }

        public void SetSelectedCustomer(object selectedItem)
        {
            SelectedCustomer = (Customer)selectedItem;
        }

        public void SetSelectedProduct(object selectedItem)
        {
            SelectedProduct = (Product)selectedItem;
        }

        public string CreateOrder(List<Product> productList, String cred)
        {
           
            using (var db = new SouthwindContext())
                {
                    var order = new Order() { CustomerId = cred, OrderDate = DateTime.Now, ShippedDate = DateTime.Now.AddDays(1), ShipCountry = "UK" }; 
                   // db.Orders.Add(order);
                    //db.SaveChanges();

                   // int orderid = db.Orders.Last().OrderId;

                    foreach (var product in productList)
                    {
                    var orderDetail = new OrderDetail() { ProductId = product.ProductID, Order = order, UnitPrice = Decimal.Parse(product.ProductPrice), Discount = 0, Quantity = 1 };
                    db.OrderDetails.Add(orderDetail);
                    db.SaveChanges();
                    }

                    return  GetReceipt(order);
                     

                 }
         }

        public string GetReceipt(Order order) 
        {
            using (var db = new SouthwindContext())
            {
                
                var orderList = db.OrderDetails.Include(o => o.Order).ThenInclude(c => c.Customer).Include(p => p.Product).Where(o => o.OrderId == order.OrderId).ToList();
                var message = $"OrderID :{order.OrderId}\n{orderList[0].Order.Customer.ContactName}\nOrder made on: {order.OrderDate}";
                var total = 0m;

                if(orderList != null)
                {
                    foreach (var item in orderList)
                    {
                         message += $"\n\t{item.Product.ProductName} - {item.UnitPrice.ToString("c")}";
                         total += item.UnitPrice;
                    }

                    message += $"\n -------------\n  Total Price: {total.ToString("c")}";
                    return message;
                }

                return "";
            }
        
        }

      
    }
}
