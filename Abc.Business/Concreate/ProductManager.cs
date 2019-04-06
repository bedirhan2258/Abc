
using System.Collections.Generic;
using Abc.Business.Abstract;
using Abc.Northwind.Entities.Concreate;
using AbcNorthwind.DataAccess.Abstract;

namespace Abc.Business.Concreate
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(int productId)
        {
            _productDal.Delete(new Product { ProductId = productId });
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }

        public List<Product> GelAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetList(x => x.CategoryId == categoryId);
        }
    }
}
