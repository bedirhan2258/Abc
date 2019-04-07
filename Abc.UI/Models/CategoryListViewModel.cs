using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abc.Northwind.Entities.Concreate;

namespace Abc.UI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; internal set; }
    }
}
