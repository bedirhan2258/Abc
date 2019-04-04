using Abc.Core.EntityFramework;
using Abc.DataAccess.Abstract;
using Abc.Northwind.Entities.Concreate;

namespace Abc.DataAccess.Concreate.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {

    }
}
