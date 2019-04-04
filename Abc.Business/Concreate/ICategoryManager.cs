
using System.Collections.Generic;
using Abc.Business.Abstract;
using Abc.DataAccess.Abstract;
using Abc.Northwind.Entities.Concreate;

namespace Abc.Business.Concreate
{
    public class ICategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public ICategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
