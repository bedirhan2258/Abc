﻿
using Abc.Entities.Concreate;
using Abc.Northwind.Entities.Concreate;
using System.Collections.Generic;

namespace Abc.Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart, Product product);
        void RemoveFromCart(Cart cart, int productId);
        List<CartLine> List(Cart cart);
    }
}