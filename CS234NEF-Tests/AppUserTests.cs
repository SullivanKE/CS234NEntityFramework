using CS234NEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS234NEF_Tests
{
    public class AppUserTests
    {
        BitsContext dbContext;
        AppUser? u;
        List<AppUser>? appUsers;

        [SetUp]
        public void Setup()
        {

            dbContext = new BitsContext();

            u = new AppUser();
            u.Name = "New User";

        }

        [Test]
        public void GetAllTest()
        {
            // Get all customers
            appUsers = dbContext.AppUsers.OrderBy<AppUser, int>(a => a.AppUserId).ToList();

            Assert.IsNotNull(appUsers);
            Assert.IsNotEmpty(appUsers);
            Assert.That(appUsers[0].Name, Is.EqualTo(u.Name));

        }
        [Test]
        public void CreateTest()
        {
            dbContext.AppUsers.Add(u);
            dbContext.SaveChanges();

            AppUser? u2 = dbContext.AppUsers.FirstOrDefault(n => n.Name == "New User");
            Assert.IsNotNull(u2);
            Assert.That(u2.Name, Is.EqualTo(u.Name));

        }

        [Test]
        public void DeleteTest()
        {

            appUsers = dbContext.AppUsers.OrderBy<AppUser, int>(a => a.AppUserId).ToList();
            int index = appUsers[appUsers.Count - 1].AppUserId;

            u = dbContext.AppUsers.Find(index);
            dbContext.AppUsers.Remove(u);
            dbContext.SaveChanges();
            Assert.IsNull(dbContext.AppConfigs.Find(index));
        }

        [Test]
        public void UpdateTest()
        {
            appUsers = dbContext.AppUsers.OrderBy<AppUser, int>(a => a.AppUserId).ToList();
            int index = appUsers[appUsers.Count - 1].AppUserId;

            u = dbContext.AppUsers.Find(index);
            u.Name = "New New User";
            dbContext.SaveChanges();

            AppUser u2 = dbContext.AppUsers.Find(index);
            Assert.That(u2.Name, Is.EqualTo(u.Name));

        }
    }
}
