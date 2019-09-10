using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EvasWebsite.Data;

namespace EvasWebsite.Tests
{
    [TestClass]
    public class DatabaseTests
    {
        [TestMethod]
        public void addProductTest()
        {
            Assert.IsTrue(Data_Layer.AddProduct("test", "test", 2, 2, "test"));
        }

        [TestMethod]
        public void addUserTest()
        {
            Assert.IsTrue(Data_Layer.AddUser("test", "test", 0));
        }
    }
}