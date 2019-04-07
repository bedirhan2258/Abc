
using System.Collections.Generic;
using Abc.Northwind.Entities.Concreate;

namespace Abc.UI.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; internal set; }
        public int PageCount { get; internal set; }
        public int PageSize { get; internal set; }
        public int CurrentCategory { get; internal set; }
        public int CurrentPage { get; internal set; }
    }
}
