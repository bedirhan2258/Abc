
using Abc.Core.DataAccess;
using Abc.Northwind.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcNorthwind.DataAccess.Abstract
{
    interface IProductDal : IEntityRepository<Product>
    {

    }
}
