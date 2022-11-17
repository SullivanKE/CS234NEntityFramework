using CS234NEntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using NuGet.Frameworks;

namespace CS234NEF_Tests
{
    public class AccountTests
    {
        BitsContext dbContext;
        Account? a;
        List<Account>? accounts;
        [SetUp]
        public void Setup()
        {
            dbContext = new BitsContext();

            a = new Account();
            a.Name = "Fake Name";
            a.Address = "Fake Address";
            a.City = "Fake City";
            a.State = "OR";
            a.Zipcode = "12345";
            a.Phone = "1234567890";
            a.ContactName = "Test";
            a.SalesPersonName = "Test";

        }

        [Test]
        public void GetAllTest()
        {
            // Get all customers
            accounts = dbContext.Accounts.OrderBy<Account, string>(a => a.Name).ToList();

            Assert.IsNotNull(accounts);
            Assert.IsNotEmpty(accounts);
            Assert.That(accounts[0].Name, Is.EqualTo(a.Name));
            Assert.That(accounts[0].Address, Is.EqualTo(a.Address));
            Assert.That(accounts[0].City, Is.EqualTo(a.City));
            Assert.That(accounts[0].State, Is.EqualTo(a.State));
            Assert.That(accounts[0].Zipcode, Is.EqualTo(a.Zipcode));
            Assert.That(accounts[0].Phone, Is.EqualTo(a.Phone));
            Assert.That(accounts[0].ContactName, Is.EqualTo(a.ContactName));
            Assert.That(accounts[0].SalesPersonName, Is.EqualTo(a.SalesPersonName));
        }
        [Test]
        public void CreateTest()
        {
            dbContext.Accounts.Add(a);
            dbContext.SaveChanges();

            Account? a2 = dbContext.Accounts.FirstOrDefault(n => n.Name == "Not a Name");
            Assert.IsNotNull(a2);
            Assert.That(a2.Name, Is.EqualTo(a.Name));
            Assert.That(a2.Address, Is.EqualTo(a.Address));
            Assert.That(a2.City, Is.EqualTo(a.City));
            Assert.That(a2.State, Is.EqualTo(a.State));
            Assert.That(a2.Zipcode, Is.EqualTo(a.Zipcode));
            Assert.That(a2.Phone, Is.EqualTo(a.Phone));
            Assert.That(a2.ContactName, Is.EqualTo(a.ContactName));
            Assert.That(a2.SalesPersonName, Is.EqualTo(a.SalesPersonName));
        }

        [Test]
        public void DeleteTest()
        {
            
            accounts = dbContext.Accounts.OrderBy<Account, int>(a => a.AccountId).ToList();
            int index = accounts[accounts.Count - 1].AccountId;

            a = dbContext.Accounts.Find(index);
            dbContext.Accounts.Remove(a);
            dbContext.SaveChanges();
            Assert.IsNull(dbContext.Accounts.Find(index));
        }

        [Test]
        public void UpdateTest()
        {
            accounts = dbContext.Accounts.OrderBy<Account, int>(a => a.AccountId).ToList();
            int index = accounts[accounts.Count - 1].AccountId;

            a = dbContext.Accounts.Find(index);
            a.Name = "New Name";
            a.Address = "New Address";
            a.City = "New City";
            a.State = "OR";
            a.Zipcode = "54321";
            a.Phone = "0987654321";
            a.ContactName = "New Name";
            a.SalesPersonName = "Another new name";
            dbContext.SaveChanges();

            Account a2 = dbContext.Accounts.Find(index);
            Assert.IsNotNull(a2);
            Assert.That(a2.Name, Is.EqualTo(a.Name));
            Assert.That(a2.Address, Is.EqualTo(a.Address));
            Assert.That(a2.City, Is.EqualTo(a.City));
            Assert.That(a2.State, Is.EqualTo(a.State));
            Assert.That(a2.Zipcode, Is.EqualTo(a.Zipcode));
            Assert.That(a2.Phone, Is.EqualTo(a.Phone));
            Assert.That(a2.ContactName, Is.EqualTo(a.ContactName));
            Assert.That(a2.SalesPersonName, Is.EqualTo(a.SalesPersonName));
        }
    }
}