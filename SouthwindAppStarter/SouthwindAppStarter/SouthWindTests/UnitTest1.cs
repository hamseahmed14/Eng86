using NUnit.Framework;
using SouthwindApp;
using SouthWindBusiness;
using System.Linq;

namespace SouthWindTests
{
    public class Tests
    {
        CRUDManager _crudmanager;
        [SetUp]
        public void Setup()
        {
            _crudmanager = new CRUDManager();
            using (var db = new SouthwindContext())
            {
                var selectedCustomers =
                from c in db.Customers
                where c.CustomerId == "BLACK"
                select c;

                db.Customers.RemoveRange(selectedCustomers);
                db.SaveChanges();
            }
        }

        [Test]
        public void WhenANewCustomerIsAdded_TheNumberOfCustomersIncreasesBy1()
        {
            using (var db = new SouthwindContext())
            {
                var expected = _crudmanager.RetrieveAllCustomers().Count();
                _crudmanager.CreateCustomer("BLACK", "Tom Black", "Birmingham", "UK","BE9 0RT", "Tom", "password",'C') ;
                var actual = _crudmanager.RetrieveAllCustomers().Count();
                Assert.AreEqual(expected, actual - 1);

            }
        }

        [Test]
        public void WhenACustomersDetailsAreChanged_TheDatabaseIsUpdated()
        {
            using (var db = new SouthwindContext())
            {
                _crudmanager.CreateCustomer("BLACK", "Tom Black", "Birmingham", "UK", "BE9 0RT", "Tom", "password", 'C');

                _crudmanager.UpdateCustomer("BLACK", "Tim White", "Birmingham", "UK", "BA5 9KH");


                Assert.AreEqual(db.Customers.Find("BLACK").ContactName, "Tim White");
                Assert.AreEqual(db.Customers.Find("BLACK").PostalCode, "BA5 9KH");

            }
        }

        [Test]

        public void WhenACustomerIsRemoved_TheyAreNoLongerInTheDatabase()
        {
            using (var db = new SouthwindContext())
            {
                _crudmanager.CreateCustomer("BLACK", "Tom Black", "Birmingham", "UK", "BE9 0RT", "Tom", "password",'C');
                _crudmanager.DeleteCustomer("MANDA");
                var actual = db.Customers.Where(c => c.CustomerId == "Manda").Any();
                Assert.AreEqual(false, actual);
            }
        }

        [TearDown]
        public void TearDown()
        {
            using (var db = new SouthwindContext())
            {
                var selectedCustomers =
                from c in db.Customers
                where c.CustomerId == "BLACK"
                select c;

                db.Customers.RemoveRange(selectedCustomers);
                db.SaveChanges();
            }
        }
    }
}