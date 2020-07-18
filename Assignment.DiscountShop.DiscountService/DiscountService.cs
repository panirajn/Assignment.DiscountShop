using System;
using System.Collections.Generic;
using Assignment.DiscountShop.Contracts;
using Assignment.DiscountShop.Models;

namespace Assignment.DiscountShop.DiscountShopService
{
    public class DiscountService : IDiscountService
    {
        readonly List<Discount> discounts = new List<Discount>();
        readonly List<DiscountCombinationItems> discountCombinationItems = new List<DiscountCombinationItems>();
        public IEnumerable<Discount> GetAll()
        {
            throw new NotImplementedException();
        }

        public Discount Get(int id)
        {
            throw new NotImplementedException();
        }

        public Discount CreateDiscount(string name, string description)
        {
            throw new NotImplementedException();
        }

        public DiscountCombinationItems CreateDiscountCombinationItems(int discountId, 
            DiscountCombinationItems dci)
        {
            throw new NotImplementedException();
        }

        public Discount UpdateDiscountCombinationItems(int discountId, 
            DiscountCombinationItems discountCombinationItems)
        {
            throw new NotImplementedException();
        }

        public void CreateDiscount(Discount discount)
        {
            throw new NotImplementedException();
        }

        public void DeactivateDiscount(Discount discount)
        {
            throw new NotImplementedException();
        }

        public void ActivateDiscount(Discount discount)
        {
            throw new NotImplementedException();
        }

        public void CreateDiscountCombinationItems()
        {
            throw new NotImplementedException();
        }
    }
}