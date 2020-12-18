using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;
using Business.Concrete;
using DataAccess.Abstract;
using System.Linq;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Core.Utilities;
using Core.Utilities.Results;

namespace Business.Tests
{
    [TestClass]
    public class ProductManagerTests
    {
        [TestMethod]
        public void AddTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var productToAdd = new Product
            {
                CategoryId = 2,
                ProductName = "Test Laptop",
                QuantityPerUnit = "16 GB RAM",
                UnitPrice = 10000,
                UnitsInStock = 4
            };

            IResult result1 = productManager.Add(productToAdd);
            Assert.AreEqual(true, result1.Success);

            productToAdd.ProductName = "a";
            IResult result2 = productManager.Add(productToAdd);
            Assert.AreEqual(false, result2.Success);



        }
    }
}