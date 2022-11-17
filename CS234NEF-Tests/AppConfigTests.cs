using CS234NEntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CS234NEF_Tests
{
    public class AppConfigTests
    {
        BitsContext dbContext;
        AppConfig? a;
        List<AppConfig>? appConfigs;

        [SetUp]
        public void Setup()
        {

            dbContext = new BitsContext();

            a = new AppConfig();
            a.DefaultUnits = "metric";
            a.BreweryName = "NewBrew";
            a.HomePageText = "Lorem Ipsum";
            a.BreweryLogo = "Logo.png";
            a.HomePageBackgroundImage = "BGImage.png";
            a.Color1 = "red";
            a.Color2 = "green";
            a.Color3 = "blue";
            a.ColorWhite = "white";
            a.ColorBlack = "black";
        }

        [Test]
        public void GetAllTest()
        {
            // Get all customers
            appConfigs = dbContext.AppConfigs.OrderBy<AppConfig, int>(a => a.BreweryId).ToList();

            Assert.IsNotNull(appConfigs);
            Assert.IsNotEmpty(appConfigs);
            Assert.That(appConfigs[0].DefaultUnits, Is.EqualTo(a.DefaultUnits));
            Assert.That(appConfigs[0].BreweryName, Is.EqualTo(a.BreweryName));
            Assert.That(appConfigs[0].HomePageText, Is.EqualTo(a.HomePageText));
            Assert.That(appConfigs[0].BreweryLogo, Is.EqualTo(a.BreweryLogo));
            Assert.That(appConfigs[0].HomePageBackgroundImage, Is.EqualTo(a.HomePageBackgroundImage));
            Assert.That(appConfigs[0].Color1, Is.EqualTo(a.Color1));
            Assert.That(appConfigs[0].Color2, Is.EqualTo(a.Color2));
            Assert.That(appConfigs[0].Color3, Is.EqualTo(a.Color3));
            Assert.That(appConfigs[0].ColorWhite, Is.EqualTo(a.ColorWhite));
            Assert.That(appConfigs[0].ColorBlack, Is.EqualTo(a.ColorBlack));
        }
        [Test]
        public void CreateTest()
        {
            dbContext.AppConfigs.Add(a);
            dbContext.SaveChanges();

            AppConfig? a2 = dbContext.AppConfigs.FirstOrDefault(n => n.BreweryName == "NewBrew");
            Assert.IsNotNull(a2);
            Assert.That(a2.DefaultUnits, Is.EqualTo(a.DefaultUnits));
            Assert.That(a2.BreweryName, Is.EqualTo(a.BreweryName));
            Assert.That(a2.HomePageText, Is.EqualTo(a.HomePageText));
            Assert.That(a2.BreweryLogo, Is.EqualTo(a.BreweryLogo));
            Assert.That(a2.HomePageBackgroundImage, Is.EqualTo(a.HomePageBackgroundImage));
            Assert.That(a2.Color1, Is.EqualTo(a.Color1));
            Assert.That(a2.Color2, Is.EqualTo(a.Color2));
            Assert.That(a2.Color3, Is.EqualTo(a.Color3));
            Assert.That(a2.ColorWhite, Is.EqualTo(a.ColorWhite));
            Assert.That(a2.ColorBlack, Is.EqualTo(a.ColorBlack));
        }

        [Test]
        public void DeleteTest()
        {

            appConfigs = dbContext.AppConfigs.OrderBy<AppConfig, int>(a => a.BreweryId).ToList();
            int index = appConfigs[appConfigs.Count - 1].BreweryId;

            a = dbContext.AppConfigs.Find(index);
            dbContext.AppConfigs.Remove(a);
            dbContext.SaveChanges();
            Assert.IsNull(dbContext.AppConfigs.Find(index));
        }

        [Test]
        public void UpdateTest()
        {
            appConfigs = dbContext.AppConfigs.OrderBy<AppConfig, int>(a => a.BreweryId).ToList();
            int index = appConfigs[appConfigs.Count - 1].BreweryId;

            a = dbContext.AppConfigs.Find(index);
            a.DefaultUnits = "imperial";
            a.BreweryName = "NewNewBrew";
            a.HomePageText = "Ipsum Lorem";
            a.BreweryLogo = "Logo.jpg";
            a.HomePageBackgroundImage = "BGImage.jpg";
            a.Color1 = "orange";
            a.Color2 = "teal";
            a.Color3 = "purple";
            a.ColorWhite = "black";
            a.ColorBlack = "white";
            dbContext.SaveChanges();

            AppConfig a2 = dbContext.AppConfigs.Find(index);
            Assert.That(a2.DefaultUnits, Is.EqualTo(a.DefaultUnits));
            Assert.That(a2.BreweryName, Is.EqualTo(a.BreweryName));
            Assert.That(a2.HomePageText, Is.EqualTo(a.HomePageText));
            Assert.That(a2.BreweryLogo, Is.EqualTo(a.BreweryLogo));
            Assert.That(a2.HomePageBackgroundImage, Is.EqualTo(a.HomePageBackgroundImage));
            Assert.That(a2.Color1, Is.EqualTo(a.Color1));
            Assert.That(a2.Color2, Is.EqualTo(a.Color2));
            Assert.That(a2.Color3, Is.EqualTo(a.Color3));
            Assert.That(a2.ColorWhite, Is.EqualTo(a.ColorWhite));
            Assert.That(a2.ColorBlack, Is.EqualTo(a.ColorBlack));
        }
    }
}
