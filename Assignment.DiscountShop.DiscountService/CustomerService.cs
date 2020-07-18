using System;
using System.Collections.Generic;
using System.Linq;
using Assignment.DiscountShop.Contracts;
using Assignment.DiscountShop.Models;

namespace Assignment.DiscountShop.DiscountShopService
{
    public class CustomerService:ICustomerService
    {
        readonly List<Customer> customers = new List<Customer>();

        public int CreateCustomer(string name)
        {
            int maxId = customers.Select(c => c.Id)
                .DefaultIfEmpty(0).Max();
            customers.Add(new Customer(++maxId, name));
            return maxId;
        }
        public ShoppingCart CreateShoppingCart(int customerId)
        {
            throw new NotImplementedException();
        }

        public ShoppingCart Checkout()
        {
            throw new NotImplementedException();
        }

        public ShoppingCart ComputeBill()
        {
            throw new NotImplementedException();
        }
    }
}
