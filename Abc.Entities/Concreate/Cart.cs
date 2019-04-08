using System.Collections.Generic;
using System.Linq;

namespace Abc.Entities.Concreate
{
    public class Cart
    {
        public Cart()
        {
            CartLines = new List<CartLine>();   
        }
        public List<CartLine> CartLines { get; set; }

        public decimal Total { get { return CartLines.Sum(x => x.Product.UnitPrice * x.Quantity); } }
    }
}
