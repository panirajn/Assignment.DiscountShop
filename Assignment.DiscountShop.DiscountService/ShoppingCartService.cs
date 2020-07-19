using System;
using System.Collections.Generic;
using System.Linq;

using Assignment.DiscountShop.Contracts;
using Assignment.DiscountShop.Models;

namespace Assignment.DiscountShop.DiscountShopService
{
    public class ShoppingCartService: IShoppingCartService
    {
        readonly List<ShoppingCart> _shoppingCarts = new List<ShoppingCart>();
        public void AddItem(ShoppingCart shoppingCart, Product product, int count)
        {
            var item = shoppingCart.CartItems.First(ci => ci.Key.Id == product.Id);
            
            if (item.Equals(new KeyValuePair<Product, int>()))
                shoppingCart.CartItems.Add(new KeyValuePair<Product, int>(product, count));
            else
            {
                shoppingCart.CartItems.Remove(item);
                shoppingCart.CartItems.Add(new KeyValuePair<Product, int>(product, count));
            }
        }

        public void RemoveItem(ShoppingCart shoppingCart, Product product, int count)
        {
            var item = shoppingCart.CartItems.First(ci => ci.Key.Id == product.Id);
            
            if (!item.Equals(new KeyValuePair<Product, int>()))
                shoppingCart.CartItems.Remove(item);
        }

        public ShoppingCart ComputeBill(ShoppingCart shoppingCart)
        {
            throw new NotImplementedException();
        }

        public ShoppingCart Checkout(ShoppingCart shoppingCart)
        {
            throw new NotImplementedException();
        }

        public ShoppingCart CreateShoppingCart(int id, int customerId)
        {
            var customerShoppingCart = _shoppingCarts.Where(sc => sc.CustomerId == customerId).Select(sc => sc).Single();

            if (customerShoppingCart != null) 
                return customerShoppingCart;

            int maxId = _shoppingCarts.Select(sc => sc.Id)
                .DefaultIfEmpty(0).Max();
            
            _shoppingCarts.Add( new ShoppingCart(++maxId, customerId));
            return _shoppingCarts[maxId];
        }
    }
}
