using DataAccess.Concrete.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Tests
{
    [TestClass]
    public class EfCategoryDalTests
    {
        [TestMethod]
        public void TestGetAll()
        {
            EfCategoryDal efCategoryDal = new EfCategoryDal();
            Assert.IsTrue(efCategoryDal.GetList().Any());
            Assert.AreEqual(8, efCategoryDal.GetList().Count);
        }

    }
}
