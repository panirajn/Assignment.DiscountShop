using System;
using System.Collections.Generic;
using Assignment.DiscountShop.Contracts;
using Assignment.DiscountShop.Models;

namespace Assignment.DiscountShop.DiscountService
{
    public class DiscountService : IDiscountService
    {
        List<Discount> discount = new List<Discount>();
        List<DiscountCombinationItems> discountCombinationItems = new List<DiscountCombinationItems>();
        public IEnumerable<Discount> GetAll()
        {
            throw new NotImplementedException();
        }

        public Discount Get(int id)
        {
            throw new NotImplementedException();
        }

        Discount IDiscountService.CreateDiscount(Discount discount)
        {
            throw new NotImplementedException();
        }

        DiscountCombinationItems IDiscountService.CreateDiscountCombinationItems()
        {
            throw new NotImplementedException();
        }

        public Discount UpdateDiscountCombinationItems(DiscountCombinationItems discountCombinationItems)
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