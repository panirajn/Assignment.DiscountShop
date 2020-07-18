using System;
using System.Collections.Generic;
using System.Text;
using Assignment.DiscountShop.Contracts;
using Assignment.DiscountShop.Models;

namespace Assignment.DiscountShop.DiscountService
{
    public class CustomerService:ICustomerService
    {
        List<Customer> customers = new List<Customer>();

        public int CreateCustomer(string name)
        {
            throw new NotImplementedException();
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
