using DataAccess.Concrete.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Tests
{
    [TestClass]
    public class EfProductDalTests
    {
        [TestMethod]
        public void TestGetAll()
        {
            EfProductDal efProductDal = new EfProductDal();
            Assert.IsTrue(efProductDal.GetList().Any());
            Assert.AreEqual(79, efProductDal.GetList().Count);
        }
    }
}
