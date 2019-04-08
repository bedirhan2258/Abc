
using Abc.Northwind.Entities.Concreate;
using System.Linq;

namespace Abc.Entities.Concreate
{
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

    }
}
