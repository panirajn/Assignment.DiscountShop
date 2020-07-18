using System;
using System.Collections.Generic;
using Assignment.DiscountShop.Contracts;
using Assignment.DiscountShop.Models;

namespace Assignment.DiscountShop.DiscountShopService
{
    public class ShoppingCartService: IShoppingCartService
    {
        List<ShoppingCart> shoppingCarts = new List<ShoppingCart>();
        public void AddItem(ShoppingCart shoppingCart, Product product, int count)
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(ShoppingCart shoppingCart, Product product, int count)
        {
            throw new NotImplementedException();
        }

        public ShoppingCart ComputeBill(ShoppingCart shoppingCart)
        {
            throw new NotImplementedException();
        }

        public ShoppingCart Checkout(ShoppingCart shoppingCart)
        {
            throw new NotImplementedException();
        }
    }
}
