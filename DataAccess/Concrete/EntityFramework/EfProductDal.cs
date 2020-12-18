using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductWithCategoryDto> GetProductsWithCategoryName(string categoryName)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             where c.CategoryName.ToLower().Contains(categoryName.ToLower())
                             select new ProductWithCategoryDto
                             {
                                 CategoryId = c.CategoryId,
                                 CategoryName = c.CategoryName,
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 UnitPrice = p.UnitPrice
                             };

                return result.ToList();
            }
        }
    }
}
