using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetProductsByCategoryId(int categoryId);
        IDataResult<List<ProductWithCategoryDto>> GetProductsByCategoryName(string categoryName);
        IDataResult<List<Product>> GetProductsByUnitPrice(decimal min, decimal max);
        IResult Add(Product product);
        IResult Delete(Product product);
        IResult Update(Product product);

    }
}
