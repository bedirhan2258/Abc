using Abc.Core.DataAccess;
using Abc.Northwind.Entities.Concreate;

namespace Abc.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}
