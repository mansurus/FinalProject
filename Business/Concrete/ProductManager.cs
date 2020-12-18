using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            if (product.ProductName.Length < 2)
            {
                return new ErrorResult("Ürün ismi minimum 2 karakterden oluşmalıdır.");
            }

            _productDal.Add(product);
            return new SuccessResult("Ürün eklendi.");
        }

        public IResult Delete(Product product)
        {
            if (product.ProductId < 10)
            {
                return new ErrorResult("İlk 10 üründen herhangi biri silinemez.");
            }
            _productDal.Delete(product);
            return new SuccessResult("Ürün silindi.");
        }

        public IDataResult<List<Product>> GetAll()
        {

            return new SuccessDataResult<List<Product>>(_productDal.GetList());
        }

        public IDataResult<List<Product>> GetProductsByCategoryId(int categoryId)
        {

            return new SuccessDataResult<List<Product>>(_productDal.GetList(p => p.CategoryId == categoryId));
        }

        public IDataResult<List<ProductWithCategoryDto>> GetProductsByCategoryName(string categoryName)
        {

            return new SuccessDataResult<List<ProductWithCategoryDto>>(_productDal.GetProductsWithCategoryName(categoryName));
        }

        public IDataResult<List<Product>> GetProductsByUnitPrice(decimal min, decimal max)
        {

            return new SuccessDataResult<List<Product>>(_productDal.GetList(p => p.UnitPrice >= min && p.UnitPrice <= max));
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult("Ürün güncellendi.");
        }
    }
}
