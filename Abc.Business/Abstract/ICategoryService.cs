
using Abc.Northwind.Entities.Concreate;
using System.Collections.Generic;

namespace Abc.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
