using System.Collections.Generic;
using System.Linq;

using Assignment.DiscountShop.Contracts;
using Assignment.DiscountShop.Models;

namespace Assignment.DiscountShop.DiscountShopService
{
    public class DiscountService : IDiscountService
    {
        private readonly List<DiscountCombinationItems> discountCombinationItems = new List<DiscountCombinationItems>();
        private readonly List<Discount> discounts = new List<Discount>();

        public IEnumerable<Discount> GetAll()
        {
            return discounts;
        }

        public Discount Get(int id)
        {
            return discounts[id];
        }

        public Discount CreateDiscount(string name, string description)
        {
            var maxId = discounts.Select(c => c.Id)
                .DefaultIfEmpty(0).Max();

            discounts.Add(new Discount(++maxId, name, description));
            return discounts[maxId];
        }

        public DiscountCombinationItems CreateDiscountCombinationItems(int discountId,
            DiscountCombinationItems dci)
        {
            discounts[discountId].UpdateDiscountCombinationItems(dci);
            return dci;
        }

        public Discount UpdateDiscountCombinationItems(int discountId,
            DiscountCombinationItems discountCombinationItems)
        {
            discounts[discountId].UpdateDiscountCombinationItems(discountCombinationItems);
            return discounts[discountId];
        }


        public void DeactivateDiscount(Discount discount)
        {
            discounts[discount.Id].DeactivateProduct();
        }

        public void ActivateDiscount(Discount discount)
        {
            discounts[discount.Id].ActivateProduct();
        }
    }
}