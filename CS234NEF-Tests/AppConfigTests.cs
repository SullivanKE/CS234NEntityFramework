using CS234NEntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS234NEF_Tests
{
    public class AppConfigTests
    {
        [SetUp]
        public void Setup()
        {

            dbContext = new BitsContext();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}
