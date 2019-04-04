
using Abc.Core.EntityFramework;
using Abc.Northwind.Entities.Concreate;
using AbcNorthwind.DataAccess.Abstract;

namespace Abc.DataAccess.Concreate.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        
    }
}
