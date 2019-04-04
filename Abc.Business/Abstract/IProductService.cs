
using Abc.Northwind.Entities.Concreate;
using System.Collections.Generic;

namespace Abc.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GelAll();
        List<Product> GetByCategory(int categoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(int productId);
    }
}
