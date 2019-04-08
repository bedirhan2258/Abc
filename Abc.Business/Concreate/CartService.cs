using System.Collections.Generic;
using System.Linq;
using Abc.Business.Abstract;
using Abc.Entities.Concreate;
using Abc.Northwind.Entities.Concreate;

namespace Abc.Business.Concreate
{
    class CartService : ICartService
    {
        public void AddToCart(Cart cart, Product product)
        {
            CartLine cartLine = cart.CartLines.FirstOrDefault(x => x.Product.ProductId == product.ProductId);
            if (cartLine != null)
            {
                cartLine.Quantity++;
                return;
            }
            cart.CartLines.Add(new CartLine { Product = product, Quantity = 1 });
        }   

        public List<CartLine> List(Cart cart)
        {
            return cart.CartLines.ToList();
        }

        public void RemoveFromCart(Cart cart, int productId)
        {
            cart.CartLines.Remove(cart.CartLines.FirstOrDefault(x => x.Product.ProductId == productId));
        }
    }
}
